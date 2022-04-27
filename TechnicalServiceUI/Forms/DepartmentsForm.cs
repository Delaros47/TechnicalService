using Business.Abstract;
using Business.DependencyResolvers.AutoFac;
using DevExpress.XtraEditors;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechnicalServiceUI.Forms
{
    public partial class DepartmentsForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly IDepartmentService _departmentService;
        public DepartmentsForm()
        {
            InitializeComponent();
            _departmentService = InstanceFactory.GetInstance<IDepartmentService>();
        }

        private void DepartmentsForm_Load(object sender, EventArgs e)
        {
            gridViewDepartments.Appearance.Row.BackColor = Color.Silver;
            gridViewDepartments.Appearance.Row.BackColor2 = Color.FromArgb(224, 224, 224);

            GetAllDepartments();
        }

        private void GetAllDepartments()
        {
            gridControlDepartments.DataSource = _departmentService.GetAll().Data;
        }

        private void btnAddDepartment_Click(object sender, EventArgs e)
        {
            var result = _departmentService.Add(new Department
            {
               DepartmentName = txtDepartmentName.Text
            });

            if (result.Success)
            {
                XtraMessageBox.Show(result.Message,"Adding a department",MessageBoxButtons.OK,MessageBoxIcon.Information);
                GetAllDepartments();
            }
        }

        private void btnUpdateDepartment_Click(object sender, EventArgs e)
        {
            var result = _departmentService.Update(new Department
            {
                DepartmentId = Convert.ToInt32(txtDepartmentId.Text),
                DepartmentName = txtDepartmentName.Text
            });

            if (result.Success)
            {
                XtraMessageBox.Show(result.Message, "Updating a department", MessageBoxButtons.OK, MessageBoxIcon.Question);
                GetAllDepartments();
            }
        }

        private void btnDeleteDepartment_Click(object sender, EventArgs e)
        {
            var result = _departmentService.Delete(new Department
            {
                DepartmentId = Convert.ToInt32(txtDepartmentId.Text)
            });

            if (result.Success)
            {
                XtraMessageBox.Show(result.Message, "Deleting a department", MessageBoxButtons.OK, MessageBoxIcon.Question);
                GetAllDepartments();
            }
        }

        private void btnClearDepartment_Click(object sender, EventArgs e)
        {
            txtDepartmentId.Text = "";
            txtDepartmentName.Text = "";
        }

        private void gridViewDepartments_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtDepartmentId.Text = gridViewDepartments.GetFocusedRowCellValue("DepartmentId").ToString();
            txtDepartmentName.Text = gridViewDepartments.GetFocusedRowCellValue("DepartmentName").ToString();
        }
    }
}