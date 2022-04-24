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
    public partial class DepartmentAddForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly IDepartmentService _departmentService;

        public DepartmentAddForm()
        {
            InitializeComponent();
            _departmentService = InstanceFactory.GetInstance<IDepartmentService>();

        }

        private void DepartmentAddForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAddDepartment_Click(object sender, EventArgs e)
        {
            var result = _departmentService.Add(new Department
            {
                DepartmentName = txtDepartmentName.Text
            });

            if (result.Success)
            {
                XtraMessageBox.Show(result.Message, "Adding a department", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClearDepartment_Click(object sender, EventArgs e)
        {
            txtDepartmentName.Text = "";
        }
    }
}