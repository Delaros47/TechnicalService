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
    public partial class EmployeesForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly IEmployeeService _employeeService;
        public EmployeesForm()
        {
            InitializeComponent();
            _employeeService = InstanceFactory.GetInstance<IEmployeeService>();
        }

        private void EmployeesForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            var result = _employeeService.Add(new Employee
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Address = memoAddress.Text,
                DateOfBirth = Convert.ToDateTime(txtDateOfBirth.Text),
                Email = txtEmailAddress.Text,
                IdentityNumber = txtIdentityNumber.Text,
                Phone = txtPhoneNumber.Text,
                Picture = System.IO.File.ReadAllBytes(pictureEditEmployeePicture.EditValue.ToString()),
                DepartmentId = Convert.ToInt32(lueDepartment.EditValue.ToString()),

            }) ;
        }
    }
}