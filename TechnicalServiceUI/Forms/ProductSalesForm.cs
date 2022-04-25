using Business.Abstract;
using Business.DependencyResolvers.AutoFac;
using DataAccess.Abstract;
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
    public partial class ProductSalesForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly IProductSaleService _productSaleService;
        public ProductSalesForm()
        {
            InitializeComponent();
            _productSaleService = InstanceFactory.GetInstance<IProductSaleService>();
        }

        private void ProductSalesForm_Load(object sender, EventArgs e)
        {
            GetProductSaleDetailDto();
        }

        private void GetProductSaleDetailDto()
        {
            gridControlProductSales.DataSource = _productSaleService.GetProductSalesDetailDto().Data;
        }

    }
}