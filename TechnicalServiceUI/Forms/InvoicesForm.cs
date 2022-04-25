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
    public partial class InvoicesForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly IInvoiceInfoService _invoiceInfoService;
        public InvoicesForm()
        {
            InitializeComponent();
            _invoiceInfoService = InstanceFactory.GetInstance<IInvoiceInfoService>();
        }

        private void InvoicesForm_Load(object sender, EventArgs e)
        {
            GetAllInvoiceInfosDetailDto();
        }

        private void GetAllInvoiceInfosDetailDto()
        {
            gridControlInvoices.DataSource = _invoiceInfoService.GetInvoiceInfosDetailDto().Data;
        }

    }
}