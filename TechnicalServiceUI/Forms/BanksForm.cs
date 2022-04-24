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
    public partial class BanksForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly IBankService _bankService;
        public BanksForm()
        {
            InitializeComponent();
            _bankService = InstanceFactory.GetInstance<IBankService>();
        }

        private void gridViewBanks_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtBankId.Text = gridViewBanks.GetFocusedRowCellValue("BankId").ToString();
            txtBankName.Text = gridViewBanks.GetFocusedRowCellValue("BankName").ToString();
            memoEditBankDescription.Text = gridViewBanks.GetFocusedRowCellValue("BankDescription").ToString();
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
                GetAllBanks();
            }
        }

        private void BanksForm_Load(object sender, EventArgs e)
        {
            GetAllBanks();
        }

        private void GetAllBanks()
        {
            gridControlBanks.DataSource = _bankService.GetAll().Data;
        }

        private void btnUpdateBank_Click(object sender, EventArgs e)
        {
            var result = _bankService.Update(new Bank
            {
                BankId = Convert.ToInt32(txtBankId.Text),
                BankName = txtBankName.Text,
                BankDescription = memoEditBankDescription.Text
            });

            if (result.Success)
            {
                XtraMessageBox.Show(result.Message, "Updating the current Bank", MessageBoxButtons.OK, MessageBoxIcon.Question);
                GetAllBanks();
            }
        }

        private void btnDeleteBank_Click(object sender, EventArgs e)
        {
            var result = _bankService.Delete(new Bank
            {
                BankId = Convert.ToInt32(txtBankId.Text)
            });

            if (result.Success)
            {
                XtraMessageBox.Show(result.Message, "Deleting the current Bank", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                GetAllBanks();
            }
        }

        private void btnClearBank_Click(object sender, EventArgs e)
        {
            txtBankId.Text = "";
            txtBankName.Text = "";
            memoEditBankDescription.Text = "";
        }
    }
}