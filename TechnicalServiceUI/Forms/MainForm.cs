using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechnicalServiceUI.Forms
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        ProductsForm _productsForm;
        ProductAddForm _productAddForm;
        CategoriesForm _categoriesForm;
        CategoryAddForm _categoryAddForm;
        ProductStatisticsForm _productStatisticsForm;
        BrandsForm _brandsForm;
        BrandAddForm _brandAddForm;
        BankAddForm _bankAddForm;
        BanksForm _banksForm;
        BrandStatisticsForm _brandStatisticsForm;
        CustomersForm _customersForm;
        CustomerAddForm _customerAddForm;
        CustomerCityStatisticsForm _customerCityStatisticsForm;
        DepartmentAddForm _departmentAddForm;
        DepartmentsForm _departmentsForm;
        NotesForm _notesForm;
        EmployeesForm _employeesForm;
        EmployeeAddForm _employeeAddForm;
        ProductAcceptancesForm _productAcceptancesForm;
        ProductSalesForm _productSalesForm;
        public MainForm()
        {
            InitializeComponent();
        }

        private void barBtnProducts_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (_productsForm == null || _productsForm.IsDisposed)
            {
                _productsForm = new ProductsForm();
                _productsForm.MdiParent = this;
                _productsForm.Show();
            }

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void barBtnNewProduct_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (_productAddForm == null || _productAddForm.IsDisposed)
            {
                _productAddForm = new ProductAddForm();
                _productAddForm.Show();
            }
        }

        private void barBtnCategories_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (_categoriesForm == null || _categoriesForm.IsDisposed)
            {
                _categoriesForm = new CategoriesForm();
                _categoriesForm.MdiParent = this;
                _categoriesForm.Show();
            }
        }

        private void barBtnNewCategory_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (_categoryAddForm==null || _categoryAddForm.IsDisposed)
            {
                _categoryAddForm = new CategoryAddForm();
                _categoryAddForm.Show();
            }
        }

        private void barBtnProductStatistics_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (_productStatisticsForm==null || _productStatisticsForm.IsDisposed)
            {
                _productStatisticsForm = new ProductStatisticsForm();
                _productStatisticsForm.MdiParent = this;
                _productStatisticsForm.Show();
            }
        }

        private void barBtnNewBrand_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (_brandAddForm==null || _brandAddForm.IsDisposed)
            {
                _brandAddForm = new BrandAddForm();
                _brandAddForm.Show();
            }
        }

        private void barBtnBrands_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (_brandsForm==null || _brandsForm.IsDisposed)
            {
                _brandsForm = new BrandsForm();
                _brandsForm.MdiParent = this;
                _brandsForm.Show();
            }
        }

        private void barBtnNewBank_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (_bankAddForm==null || _bankAddForm.IsDisposed)
            {
                _bankAddForm = new BankAddForm();
                _bankAddForm.Show();
            }
        }

        private void barBtnBanks_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (_banksForm==null || _banksForm.IsDisposed)
            {
                _banksForm = new BanksForm();
                _banksForm.MdiParent = this;
                _banksForm.Show();
            }
        }

        private void barBtnBrandStatistics_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (_brandStatisticsForm==null || _brandStatisticsForm.IsDisposed)
            {
                _brandStatisticsForm = new BrandStatisticsForm();
                _brandStatisticsForm.MdiParent = this;
                _brandStatisticsForm.Show();
            }
        }

        private void barBtnCustomers_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (_customersForm==null || _customersForm.IsDisposed)
            {
                _customersForm = new CustomersForm();
                _customersForm.MdiParent = this;
                _customersForm.Show();
            }
        }

        private void barBtnNewCustomer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (_customerAddForm==null || _customerAddForm.IsDisposed)
            {
                _customerAddForm = new CustomerAddForm();
                _customerAddForm.Show();
            }
        }

        private void barBtnCustomerCityStatistics_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (_customerCityStatisticsForm==null || _customerCityStatisticsForm.IsDisposed)
            {
                _customerCityStatisticsForm = new CustomerCityStatisticsForm();
                _customerCityStatisticsForm.MdiParent = this;
                _customerCityStatisticsForm.Show();
            }
        }

        private void barBtnNewDepartment_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (_departmentAddForm==null || _departmentAddForm.IsDisposed)
            {
                _departmentAddForm = new DepartmentAddForm();
                _departmentAddForm.Show();
            }
        }

        private void barBtnDepartments_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (_departmentsForm == null || _departmentsForm.IsDisposed)
            {
                _departmentsForm = new DepartmentsForm();
                _departmentsForm.MdiParent = this;
                _departmentsForm.Show();
            }
        }

        private void barBtnCalculator_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Process.Start("calc.exe");
        }

        private void barBtnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ProcessStartInfo ps = new ProcessStartInfo();
            ps.FileName = "excel";
            ps.UseShellExecute = true;
            Process.Start(ps);
        }

        private void barBtnWord_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ProcessStartInfo ps = new ProcessStartInfo();
            ps.FileName = "winword";
            ps.UseShellExecute = true;
            Process.Start(ps);
        }

        private void barBtnNewNote_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (_notesForm ==null || _notesForm.IsDisposed)
            {
                _notesForm = new NotesForm();
                _notesForm.MdiParent = this;
                _notesForm.Show();
            }
        }

        private void barBtnEmployees_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (_employeesForm == null || _employeesForm.IsDisposed)
            {
                _employeesForm = new EmployeesForm();
                _employeesForm.MdiParent = this;
                _employeesForm.Show();
            }
        }

        private void btnBtnNewEmployee_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (_employeeAddForm==null || _employeeAddForm.IsDisposed)
            {
                _employeeAddForm = new EmployeeAddForm();
                _employeeAddForm.Show();
            }
        }

        private void barBtnMalfunctionProducts_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (_productAcceptancesForm==null || _productAcceptancesForm.IsDisposed)
            {
                _productAcceptancesForm = new ProductAcceptancesForm();
                _productAcceptancesForm.MdiParent = this;
                _productAcceptancesForm.Show();
            }
        }

        private void btnBtnProductSales_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (_productSalesForm ==null || _productSalesForm.IsDisposed)
            {
                _productSalesForm = new ProductSalesForm();
                _productSalesForm.MdiParent = this;
                _productSalesForm.Show();
            }
        }
    }
}