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
    public partial class CustomerCityStatisticsForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly ICustomerService _customerService;
        public CustomerCityStatisticsForm()
        {
            InitializeComponent();
            _customerService = InstanceFactory.GetInstance<ICustomerService>();
        }

        private void CustomerCityStatisticsForm_Load(object sender, EventArgs e)
        {
            GetCustomerCityStatisticsDto();
            chartControlCustomerCityStatistics.Series["Series 1"].LegendTextPattern = "{A}";
            FillMyCustomerCityStatisticsChart();

        }

        private void GetCustomerCityStatisticsDto()
        {
            gridControlCustomerCityStatistics.DataSource = _customerService.GetCustomerCityStatisticsDto().Data;
        }

        private void FillMyCustomerCityStatisticsChart()
        {
            foreach (var item in _customerService.GetCustomerCityStatisticsDto().Data)
            {
                chartControlCustomerCityStatistics.Series["Series 1"].Points.AddPoint(item.CityName,item.TotalCustomers);
            }
        }
    }
}