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
    public partial class ProductSalesAddForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly IProductService _productService;
        private readonly ICustomerService _customerService;
        private readonly IEmployeeService _employeeService;
        private readonly IProductSaleService _productSaleService;
        public ProductSalesAddForm()
        {
            InitializeComponent();
            _productService = InstanceFactory.GetInstance<IProductService>();
            _customerService = InstanceFactory.GetInstance<ICustomerService>();
            _employeeService = InstanceFactory.GetInstance<IEmployeeService>();
            _productSaleService = InstanceFactory.GetInstance<IProductSaleService>();
        }

        private void ProductSalesAddForm_Load(object sender, EventArgs e)
        {
            GetAllProductsWithDistinctProductName();
            GetCustomersFullName();
            GetEmployeesFullName();
        }


        private void GetAllProductsWithDistinctProductName()
        {
            lueProductName.Properties.DataSource = _productService.GetAllByDistinctProductName().Data;
            lueProductName.Properties.DisplayMember = "ProductName";
            lueProductName.Properties.ValueMember = "ProductId";
        }

        private void GetCustomersFullName()
        {
            lueCustomerName.Properties.DataSource = _customerService.GetCustomersFullNameDto().Data;
            lueCustomerName.Properties.DisplayMember = "CustomerFullName";
            lueCustomerName.Properties.ValueMember = "CustomerId";
        }

        private void GetEmployeesFullName()
        {
            lueEmployeeName.Properties.DataSource = _employeeService.GetEmployeesFullNameDto().Data;
            lueEmployeeName.Properties.DisplayMember = "EmployeeFullName";
            lueEmployeeName.Properties.ValueMember = "EmployeeId";
        }

        private void btnAddProductSale_Click(object sender, EventArgs e)
        {
            var result = _productSaleService.Add(new ProductSale
            {
                Price = Convert.ToInt32(txtPrice.Text),
                ProductSeriesNumber = txtProductSeriesNumber.Text,
                SalesDate = Convert.ToDateTime(deSalesDate.Text),
                Unit = Convert.ToInt32(txtUnit.Text),
                CustomerId = Convert.ToInt32(lueCustomerName.EditValue.ToString()),
                EmployeeId = Convert.ToInt32(lueEmployeeName.EditValue.ToString()),
                ProductId = Convert.ToInt32(lueProductName.EditValue.ToString()),
            });

            if (result.Success)
            {
                XtraMessageBox.Show(result.Message,"Adding Product Sale",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void btnClearProductSales_Click(object sender, EventArgs e)
        {
            txtUnit.Text = "";
            txtPrice.Text = "";
            txtProductSeriesNumber.Text = "";
            deSalesDate.Text = "";
            lueProductName.EditValue = -1;
            lueCustomerName.EditValue = -1;
            lueEmployeeName.EditValue = -1;
        }
    }
}