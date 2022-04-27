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

namespace TechnicalServiceUI.FormReports
{
    public partial class BrandsReport : DevExpress.XtraEditors.XtraForm
    {
        public BrandsReport()
        {
            InitializeComponent();
        }

        private void BrandsReport_Load(object sender, EventArgs e)
        {
            var reports = new ReportBrands();
            documentViewer1.DocumentSource = reports;
            documentViewer1.InitiateDocumentCreation();
        }
    }
}