using Business.Abstract;
using Business.DependencyResolvers.AutoFac;
using DevExpress.XtraEditors;
using Entities.Concrete;
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
    public partial class BankAddForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly IBankService _bankService;

        public BankAddForm()
        {
            InitializeComponent();
            _bankService = InstanceFactory.GetInstance<IBankService>();

        }

        private void BankAddForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAddBank_Click(object sender, EventArgs e)
        {
            var result = _bankService.Add(new Bank
            {
                BankName = txtBankName.Text,
                BankDescription = memoEditBankDescription.Text
            });

            if (result.Success)
            {
                XtraMessageBox.Show(result.Message, "Adding a new Bank", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClearBank_Click(object sender, EventArgs e)
        {
            memoEditBankDescription.Text = "";
            txtBankName.Text = "";
        }
    }
}