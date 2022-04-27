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
    public partial class EmployeesReport : DevExpress.XtraEditors.XtraForm
    {
        public EmployeesReport()
        {
            InitializeComponent();
        }

        private void EmployeesReport_Load(object sender, EventArgs e)
        {
            var reports = new ReportEmployees();
            documentViewer1.DocumentSource = reports;
            documentViewer1.InitiateDocumentCreation();
        }
    }
}