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
    public partial class ProductAcceptancesForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly IProductAcceptanceService _productAcceptanceService;
        public ProductAcceptancesForm()
        {
            InitializeComponent();
            _productAcceptanceService = InstanceFactory.GetInstance<IProductAcceptanceService>();
        }

        private void ProductAcceptancesForm_Load(object sender, EventArgs e)
        {
            GetProductAcceptanceDetailDto();
            chartControlProductAcceptances.Series["Series 1"].LegendTextPattern = "{A}";
        }

        private void GetProductAcceptanceDetailDto()
        {
            gridControlProductAcceptances.DataSource = _productAcceptanceService.GetProductAcceptanceDetailDto().Data;
        }

    }
}