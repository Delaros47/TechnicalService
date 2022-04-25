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
using MessagingToolkit.QRCode.Codec;

namespace TechnicalServiceUI.Forms
{
    public partial class QRCodeAddForm : DevExpress.XtraEditors.XtraForm
    {
        public QRCodeAddForm()
        {
            InitializeComponent();
        }

        private void btnCreateQRCode_Click(object sender, EventArgs e)
        {
            QRCodeEncoder encoder = new QRCodeEncoder();
            pictureEditQRCode.Image = encoder.Encode(txtProductSeriesNumber.Text);
        }
    }
}