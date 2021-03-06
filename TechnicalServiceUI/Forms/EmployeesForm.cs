using Business.Abstract;
using Business.DependencyResolvers.AutoFac;
using DevExpress.XtraEditors;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;   
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechnicalServiceUI.Forms
{
    public partial class EmployeesForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly IEmployeeService _employeeService;
        private readonly IDepartmentService _departmentService;
        public EmployeesForm()
        {
            InitializeComponent();
            _employeeService = InstanceFactory.GetInstance<IEmployeeService>();
            _departmentService = InstanceFactory.GetInstance<IDepartmentService>();
        }

        private void EmployeesForm_Load(object sender, EventArgs e)
        {
            gridViewEmployees.Appearance.Row.BackColor = Color.Silver;
            gridViewEmployees.Appearance.Row.BackColor2 = Color.FromArgb(224, 224, 224);

            GetAllDepartments();
            GetAllEmployeesDetailDto();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            var result = _employeeService.Add(new Employee
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Address = memoAddress.Text,
                DateOfBirth = Convert.ToDateTime(deDateOfBirth.Text),
                Email = txtEmailAddress.Text,
                IdentityNumber = txtIdentityNumber.Text,
                Phone = txtPhoneNumber.Text,
                Picture = File.ReadAllBytes(pictureEditEmployeePicture.GetLoadedImageLocation()),
                DepartmentId = Convert.ToInt32(lueDepartmentName.EditValue.ToString()),

            });

            if (result.Success)
            {
                XtraMessageBox.Show(result.Message,"Adding an Employee",MessageBoxButtons.OK,MessageBoxIcon.Information);
                GetAllEmployeesDetailDto();
            }
        }

        private void GetAllDepartments()
        {
            lueDepartmentName.Properties.DataSource = _departmentService.GetAll().Data;
            lueDepartmentName.Properties.DisplayMember = "DepartmentName";
            lueDepartmentName.Properties.ValueMember = "DepartmentId";
        }

        private void GetAllEmployeesDetailDto()
        {
            gridControlEmployees.DataSource = _employeeService.GetEmployeesDetailDto().Data;
        }

        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            var result = _employeeService.Update(new Employee
            {
                EmployeeId = Convert.ToInt32(txtEmployeeId.Text),
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Address = memoAddress.Text,
                DateOfBirth = Convert.ToDateTime(deDateOfBirth.Text),
                Email = txtEmailAddress.Text,
                IdentityNumber = txtIdentityNumber.Text,
                Phone = txtPhoneNumber.Text,
                Picture = File.ReadAllBytes(pictureEditEmployeePicture.GetLoadedImageLocation()),
                DepartmentId = Convert.ToInt32(lueDepartmentName.EditValue.ToString()),

            });

            if (result.Success)
            {
                XtraMessageBox.Show(result.Message, "Updating an Employee", MessageBoxButtons.OK, MessageBoxIcon.Question);
                GetAllEmployeesDetailDto();
            }
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            var result = _employeeService.Update(new Employee
            {
                EmployeeId = Convert.ToInt32(txtEmployeeId.Text)
            });

            if (result.Success)
            {
                XtraMessageBox.Show(result.Message, "Deleting an Employee", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                GetAllEmployeesDetailDto();
            }
        }

        private void gridViewEmployees_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtEmployeeId.Text = gridViewEmployees.GetFocusedRowCellValue("EmployeeId").ToString();
            txtFirstName.Text = gridViewEmployees.GetFocusedRowCellValue("FirstName").ToString();
            txtLastName.Text = gridViewEmployees.GetFocusedRowCellValue("LastName").ToString();
            txtEmailAddress.Text = gridViewEmployees.GetFocusedRowCellValue("Email").ToString();
            txtIdentityNumber.Text = gridViewEmployees.GetFocusedRowCellValue("IdentityNumber").ToString();
            txtPhoneNumber.Text = txtLastName.Text = gridViewEmployees.GetFocusedRowCellValue("Phone").ToString();
            deDateOfBirth.Text = txtLastName.Text = gridViewEmployees.GetFocusedRowCellValue("DateOfBirth").ToString();
            lueDepartmentName.Text = txtLastName.Text = gridViewEmployees.GetFocusedRowCellValue("DepartmentName").ToString();
            memoAddress.Text = txtLastName.Text = gridViewEmployees.GetFocusedRowCellValue("Address").ToString();

            using (MemoryStream ms = new MemoryStream((byte[])gridViewEmployees.GetFocusedRowCellValue("Picture")))
            {
                pictureEditEmployeePicture.Image = Image.FromStream(ms);
            }
       


        }

        private void btnClearEmployees_Click(object sender, EventArgs e)
        {
            txtEmployeeId.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtPhoneNumber.Text = "";
            txtEmailAddress.Text = "";
            txtIdentityNumber.Text = "";
            deDateOfBirth.Text = "";
            lueDepartmentName.EditValue = -1;
            pictureEditEmployeePicture.Image = null;
            memoAddress.Text = "";

        }
    }
}