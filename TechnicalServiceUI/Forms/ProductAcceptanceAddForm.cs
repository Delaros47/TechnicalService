using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Abstract;
using Business.DependencyResolvers.AutoFac;
using Entities.Concrete;

namespace TechnicalServiceUI.Forms
{
    public partial class ProductAcceptanceAddForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly ICustomerService _customerService;
        private readonly IEmployeeService _employeeService;
        private readonly IProductAcceptanceService _productAcceptanceService;
        public ProductAcceptanceAddForm()
        {
            InitializeComponent();
            _customerService = InstanceFactory.GetInstance<ICustomerService>();
            _employeeService = InstanceFactory.GetInstance<IEmployeeService>();
            _productAcceptanceService = InstanceFactory.GetInstance<IProductAcceptanceService>();
        }

        private void ProductAcceptanceAddForm_Load(object sender, EventArgs e)
        {
            GetAllCustomersFullName();
            GetAllEmployeesFullName();
        }

        private void GetAllCustomersFullName()
        {
            lueCustomerName.Properties.DataSource = _customerService.GetCustomersFullNameDto().Data;
            lueCustomerName.Properties.DisplayMember = "CustomerFullName";
            lueCustomerName.Properties.ValueMember = "CustomerId";
        }

        private void GetAllEmployeesFullName()
        {
            lueEmployeeName.Properties.DataSource = _employeeService.GetEmployeesFullNameDto().Data;
            lueEmployeeName.Properties.DisplayMember = "EmployeeFullName";
            lueEmployeeName.Properties.ValueMember = "EmployeeId";
        }

        private void btnAddProductAcceptance_Click(object sender, EventArgs e)
        {
            var result = _productAcceptanceService.Add(new ProductAcceptance
            {
                ArrivalDate = Convert.ToDateTime(deArrivalDate.Text),
                ProductSeriesNumber = txtProductSeriesNumber.Text,
                EmployeeId = Convert.ToInt32(lueEmployeeName.EditValue.ToString()),
                CustomerId = Convert.ToInt32(lueCustomerName.EditValue.ToString()),
                LeftDate = Convert.ToDateTime(DateTime.Now.AddDays(7))
            });

            if (result.Success)
            {
                XtraMessageBox.Show(result.Message, "Adding a new Product Acceptance", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            txtProductSeriesNumber.Text = "";
            lueCustomerName.EditValue = -1;
            lueEmployeeName.EditValue = -1;
            deArrivalDate.Text = "";
        }
    }
}