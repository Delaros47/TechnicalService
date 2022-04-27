using Business.Abstract;
using Business.DependencyResolvers.AutoFac;
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

namespace TechnicalServiceUI.Forms
{
    public partial class ProductStatisticsForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        private readonly IBrandService _brandService;
        private readonly IProductAcceptanceService _productAcceptanceService;
        public ProductStatisticsForm()
        {
            InitializeComponent();
            _productService = InstanceFactory.GetInstance<IProductService>();
            _categoryService = InstanceFactory.GetInstance<ICategoryService>();
            _brandService = InstanceFactory.GetInstance<IBrandService>();
            _productAcceptanceService = InstanceFactory.GetInstance<IProductAcceptanceService>();
        }

        private void ProductStatisticsForm_Load(object sender, EventArgs e)
        {
            GetTotalProductsCount();
            GetTotalCategoriesCount();
            GetTotalProductsStock();
            GetMaximumStockedProduct();
            GetMinimumStockedProduct();
            GetHighestPriceProduct();
            GetLowestPriceProduct();
            GetTotalBrandNumber();
            GetTotalWhiteGoodsStockNumber();
            GetTotalComputerStockNumber();
            GetTotalSmallAppliancesStockNumber();
            GetMalfunctionProductNumber();
            GetMaximumProductCategory();
        }

        private void GetTotalProductsCount()
        {
            lblTotalProducts.Text = _productService.GetTotalProductsCount().Data.ToString();
        }

        private void GetTotalCategoriesCount()
        {
            lblTotalCategories.Text = _categoryService.GetTotalCategoriesCount().Data.ToString();
        }

        private void GetTotalProductsStock()
        {
            lblTotalStocks.Text = _productService.GetTotalProductsStock().Data.ToString();
        }

        private void GetMaximumStockedProduct()
        {
            lblMaximumStockedProduct.Text = _productService.GetMaximumStockedProduct().Data.ProductName;
        }

        private void GetMinimumStockedProduct()
        {
            lblMinimalStockedProduct.Text = _productService.GetMinimumStockedProduct().Data.ProductName;
        }

        private void GetHighestPriceProduct()
        {
            lblHighestPriceProduct.Text = _productService.GetHighestProductPrice().Data.ProductName;
        }

        private void GetLowestPriceProduct()
        {
            lblLowestPriceProduct.Text = _productService.GetLowestProductPrice().Data.ProductName;
        }

        private void GetTotalBrandNumber()
        {
            lblTotalBrands.Text = _brandService.GetTotalBrandNumber().Data.ToString();
        }

        private void GetTotalWhiteGoodsStockNumber()
        {
            lblWhiteGoodsStock.Text = _productService.GetTotalWhiteGoodsStockNumber(4).Data.ToString();
        }

        private void GetTotalComputerStockNumber()
        {
            lblComputerProductStock.Text = _productService.GetTotalComputerStockNumber(1).Data.ToString();
        }
        
        private void GetTotalSmallAppliancesStockNumber()
        {
            lblSmallAppliancesStock.Text = _productService.GetTotalSmallAppliancesStockNumber(5).Data.ToString();
        }

        private void GetMalfunctionProductNumber()
        {
            lblMalfunctionProductNumber.Text = _productAcceptanceService.GetProductMalfunctionNumber().Data.ToString();
        }

        private void GetMaximumProductCategory()
        {
            lblMaximumProductCategory.Text = _categoryService.GetGetMaxProductCategoryDto().Data.CategoryName;
        }
    }
}