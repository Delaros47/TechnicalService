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
    public partial class BrandStatisticsForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly IBrandService _brandService;
        public BrandStatisticsForm()
        {
            InitializeComponent();
            _brandService = InstanceFactory.GetInstance<IBrandService>();
        }

        private void BrandStatisticsForm_Load(object sender, EventArgs e)
        {
            GetBrandStatisticsDto();
            chartControlBrands.Series["Series 1"].LegendTextPattern = "{A}";
            chartControlBrandProducts.Series["Series 1"].LegendTextPattern = "{A}";
        }
       
        private void GetBrandStatisticsDto()
        {
            gridControlBrandStatistics.DataSource = _brandService.GetBrandStatisticsDto().Data;
        }
    }
}