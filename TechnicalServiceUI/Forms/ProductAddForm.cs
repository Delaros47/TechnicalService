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
    public partial class ProductAddForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly ICategoryService _categoryService;
        private readonly IBrandService _brandService;
        private readonly IProductService _productService;
        public ProductAddForm()
        {
            InitializeComponent();
            _categoryService = InstanceFactory.GetInstance<ICategoryService>();
            _brandService = InstanceFactory.GetInstance<IBrandService>();
            _productService = InstanceFactory.GetInstance<IProductService>();
        }

        private void ProductAddForm_Load(object sender, EventArgs e)
        {
            GetAllBrands();
            GetAllCategories();
        }

        private void GetAllBrands()
        {
            lueBrand.Properties.DataSource = _brandService.GetAll().Data;
            lueBrand.Properties.DisplayMember = "BrandName";
            lueBrand.Properties.ValueMember = "BrandId";
        }

        private void GetAllCategories()
        {
            lueCategory.Properties.DataSource = _categoryService.GetAll().Data;
            lueCategory.Properties.DisplayMember = "CategoryName";
            lueCategory.Properties.ValueMember = "CategoryId";
        }

        private void btnClearProducts_Click(object sender, EventArgs e)
        {
            txtProductName.Text = "";
            txtPurchasePrice.Text = "";
            txtSalesPrice.Text = "";
            txtUnitsInStock.Text = "";
            lueBrand.EditValue = -1;
            lueCategory.EditValue = -1;
            toogleSwitchState.IsOn = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var result = _productService.Add(new Product 
            {
                ProductName = txtProductName.Text,
                UnitsInStock = Convert.ToInt32(txtUnitsInStock.Text),
                State = toogleSwitchState.IsOn,
                SalePrice = Convert.ToDecimal(txtSalesPrice.Text),
                PurchasePrice = Convert.ToDecimal(txtPurchasePrice.Text),
                CategoryId = Convert.ToInt32(lueCategory.EditValue.ToString()),
                BrandId = Convert.ToInt32(lueBrand.EditValue.ToString())
            });

            if (result.Success)
            {
                XtraMessageBox.Show(result.Message,"Adding a Product",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
    }
}