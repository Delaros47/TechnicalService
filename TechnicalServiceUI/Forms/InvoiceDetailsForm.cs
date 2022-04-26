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

namespace TechnicalServiceUI.Forms
{
    public partial class InvoiceDetailsForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly IInvoiceDetailService _invoiceDetailService;
        private readonly IProductService _productService;
        private readonly IInvoiceInfoService _invoiceInfoService;
        public InvoiceDetailsForm()
        {
            InitializeComponent();
            _invoiceDetailService = InstanceFactory.GetInstance<IInvoiceDetailService>();
            _productService = InstanceFactory.GetInstance<IProductService>();
            _invoiceInfoService = InstanceFactory.GetInstance<IInvoiceInfoService>();
        }

        private void InvoiceDetailsForm_Load(object sender, EventArgs e)
        {
            GetAllByDistinctProductName();
            GetInvoiceInfosId();
            GetInvoiceDetailDto();
        }

        private void GetInvoiceDetailDto()
        {
            gridControlInvoiceDetails.DataSource = _invoiceDetailService.GetInvoiceDetailDto().Data;
        }

        private void GetAllByDistinctProductName()
        {
            lueProductName.Properties.DataSource = _productService.GetAllByDistinctProductName().Data;
            lueProductName.Properties.DisplayMember = "ProductName";
            lueProductName.Properties.ValueMember = "ProductId";
        }

        private void GetInvoiceInfosId()
        {
            lueInvoiceId.Properties.DataSource = _invoiceInfoService.GetAll().Data;
            lueInvoiceId.Properties.DisplayMember = "InvoiceInfoId";
            lueInvoiceId.Properties.ValueMember = "InvoiceInfoId";
        }

    }
}