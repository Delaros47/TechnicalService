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
    public partial class ProductsForm : DevExpress.XtraEditors.XtraForm
    {
        private IProductService _productService;
        private IBrandService _brandService;
        private ICategoryService _categoryService;
        public ProductsForm()
        {
            InitializeComponent();
            _productService = InstanceFactory.GetInstance<IProductService>();
            _brandService = InstanceFactory.GetInstance<IBrandService>();
            _categoryService = InstanceFactory.GetInstance<ICategoryService>();
        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {
            GetAllBrands();
            GetAllCategories();
            GetAllProducts();

        }

        private void GetAllProducts()
        {
            gridControlProducts.DataSource = _productService.GetProductDetail().Data;
        }

        private void gridViewProducts_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtProductId.Text = gridViewProducts.GetFocusedRowCellValue("ProductId").ToString();
            txtProductName.Text = gridViewProducts.GetFocusedRowCellValue("ProductName").ToString();
            txtUnitsInStock.Text = gridViewProducts.GetFocusedRowCellValue("UnitsInStock").ToString();
            txtPurchasePrice.Text = gridViewProducts.GetFocusedRowCellValue("PurchasePrice").ToString();
            txtSalesPrice.Text = gridViewProducts.GetFocusedRowCellValue("SalePrice").ToString();
            lueCategory.Text = gridViewProducts.GetFocusedRowCellValue("CategoryName").ToString();
            lueBrand.Text = gridViewProducts.GetFocusedRowCellValue("BrandName").ToString();
            toogleSwitchState.IsOn = (bool)gridViewProducts.GetFocusedRowCellValue("State");
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

        private void btnAdd_Click(object sender, EventArgs e)
        {

            var result = _productService.Add(new Product
            {
                ProductName = txtProductName.Text,
                SalePrice = Convert.ToDecimal(txtSalesPrice.Text),
                PurchasePrice = Convert.ToDecimal(txtPurchasePrice.Text),
                State = toogleSwitchState.IsOn,
                UnitsInStock = Convert.ToInt32(txtUnitsInStock.Text),
                CategoryId = Convert.ToInt32(lueCategory.EditValue.ToString()),
                BrandId = Convert.ToInt32(lueBrand.EditValue.ToString())
            });

            if (result.Success)
            {
                XtraMessageBox.Show(result.Message,"Adding a Product",MessageBoxButtons.OK,MessageBoxIcon.Information);
                GetAllProducts();
            }

        }

        private void btnClearProducts_Click(object sender, EventArgs e)
        {
            ClearProducts();
        }

        private void ClearProducts()
        {
            txtProductId.Text = "";
            txtProductName.Text = "";
            txtPurchasePrice.Text = "";
            txtSalesPrice.Text = "";
            txtUnitsInStock.Text = "";
            lueBrand.EditValue = -1;
            lueCategory.EditValue = -1;
            toogleSwitchState.IsOn = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = _productService.Delete(new Product 
            {
                ProductId= Convert.ToInt32(txtProductId.Text)
            });

            if (result.Success)
            {
                XtraMessageBox.Show(result.Message, "Deleting a Product", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                GetAllProducts();
            }
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            var result = _productService.Update(new Product
            {
                ProductId = Convert.ToInt32(txtProductId.Text),
                ProductName = txtProductName.Text,
                UnitsInStock = Convert.ToInt32(txtUnitsInStock.Text),
                PurchasePrice = Convert.ToDecimal(txtPurchasePrice.Text),
                SalePrice = Convert.ToDecimal(txtSalesPrice.Text),
                State = toogleSwitchState.IsOn,
                CategoryId = Convert.ToInt32(lueCategory.EditValue.ToString()),
                BrandId = Convert.ToInt32(lueBrand.EditValue.ToString())
            });
            if (result.Success)
            {
                XtraMessageBox.Show(result.Message, "Updating a Product", MessageBoxButtons.OK, MessageBoxIcon.Question);
                GetAllProducts();
            }
        }
    }
}