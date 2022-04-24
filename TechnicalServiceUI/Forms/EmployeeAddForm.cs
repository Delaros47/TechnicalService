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
    public partial class EmployeeAddForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly IEmployeeService _employeeService;
        private readonly IDepartmentService _departmentService;
        public EmployeeAddForm()
        {
            InitializeComponent();
            _employeeService = InstanceFactory.GetInstance<IEmployeeService>();
            _departmentService = InstanceFactory.GetInstance<IDepartmentService>();
        }

        private void EmployeeAddForm_Load(object sender, EventArgs e)
        {
            GetAllDepartments();
        }

        private void GetAllDepartments()
        {
            lueDepartmentName.Properties.DataSource = _departmentService.GetAll().Data;
            lueDepartmentName.Properties.DisplayMember = "DepartmentName";
            lueDepartmentName.Properties.ValueMember = "DepartmentId";
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
                XtraMessageBox.Show(result.Message, "Adding an Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClearEmployees_Click(object sender, EventArgs e)
        {
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