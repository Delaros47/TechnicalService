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
using DevExpress.Spreadsheet;

namespace TechnicalServiceUI.Forms
{
    public partial class BrandStatisticsForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly IBrandService _brandService;
        private readonly ICategoryService _categoryService;
        public BrandStatisticsForm()
        {
            InitializeComponent();
            _brandService = InstanceFactory.GetInstance<IBrandService>();
            _categoryService = InstanceFactory.GetInstance<ICategoryService>();
        }

        private void BrandStatisticsForm_Load(object sender, EventArgs e)
        {
            gridViewBrandStatistics.Appearance.Row.BackColor = Color.Silver;
            gridViewBrandStatistics.Appearance.Row.BackColor2 = Color.FromArgb(224, 224, 224);

            chartControlBrands.Series["Series 1"].LegendTextPattern = "{A}";
            chartControlBrandProducts.Series["Categories"].LegendTextPattern = "{A}";

            GetBrandStatisticsDto();
            FillMyBrandsChartControl();
            FillMyCategoryProductChartControl();
            
        }
       
        private void GetBrandStatisticsDto()
        {
            gridControlBrandStatistics.DataSource = _brandService.GetBrandStatisticsDto().Data;
        }

        private void FillMyBrandsChartControl()
        {
            foreach (var brands in _brandService.GetBrandStatisticsDto().Data)
            {
                chartControlBrands.Series["Series 1"].Points.AddPoint(brands.BrandName, brands.TotalProducts);
            }
        }

        private void FillMyCategoryProductChartControl()
        {
            foreach (var categories in _categoryService.GetCategoryProductDetailDto().Data)
            {
                chartControlBrandProducts.Series["Categories"].Points
                    .AddPoint(categories.CategoryName, categories.ProductNumber);
            }
        }

    }
}