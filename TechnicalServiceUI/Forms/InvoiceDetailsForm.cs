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
using Entities.Concrete;

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

        private void btnAddInvoiceDetail_Click(object sender, EventArgs e)
        {
            var result = _invoiceDetailService.Add(new InvoiceDetail
            {
                Price = Convert.ToDecimal(txtPrice.Text),
                TotalPrice = Convert.ToDecimal(txtTotalPrice.Text),
                Unit = Convert.ToInt32(txtUnit.Text),
                ProductId = Convert.ToInt32(lueProductName.EditValue.ToString()),
                InvoiceInfoId = Convert.ToInt32(lueInvoiceId.EditValue.ToString())
            });

            if (result.Success)
            {
                XtraMessageBox.Show(result.Message,"Adding Invoice Detail",MessageBoxButtons.OK,MessageBoxIcon.Information);
                GetInvoiceDetailDto();
            }

        }

        private void gridViewInvoiceDetails_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtInvoiceDetailId.Text = gridViewInvoiceDetails.GetFocusedRowCellValue("InvoiceDetailId").ToString();
            txtPrice.Text = gridViewInvoiceDetails.GetFocusedRowCellValue("Price").ToString();
            txtUnit.Text = gridViewInvoiceDetails.GetFocusedRowCellValue("Unit").ToString();
            txtTotalPrice.Text = gridViewInvoiceDetails.GetFocusedRowCellValue("TotalPrice").ToString();
            lueInvoiceId.Text = gridViewInvoiceDetails.GetFocusedRowCellValue("InvoiceInfoId").ToString();
            lueProductName.Text = gridViewInvoiceDetails.GetFocusedRowCellValue("ProductName").ToString();
        }

        private void btnUpdateInvoiceDetail_Click(object sender, EventArgs e)
        {
            var result = _invoiceDetailService.Update(new InvoiceDetail
            {
                InvoiceDetailId = Convert.ToInt32(txtInvoiceDetailId.Text),
                Price = Convert.ToDecimal(txtPrice.Text),
                TotalPrice = Convert.ToDecimal(txtTotalPrice.Text),
                Unit = Convert.ToInt32(txtUnit.Text),
                ProductId = Convert.ToInt32(lueProductName.EditValue.ToString()),
                InvoiceInfoId = Convert.ToInt32(lueInvoiceId.EditValue.ToString())
            });

            if (result.Success)
            {
                XtraMessageBox.Show(result.Message, "Updating the current Invoice Detail", MessageBoxButtons.OK, MessageBoxIcon.Question);
                GetInvoiceDetailDto();
            }
        }

        private void btnDeleteInvoiceDetail_Click(object sender, EventArgs e)
        {
            var result = _invoiceDetailService.Delete(new InvoiceDetail
            {
                InvoiceDetailId = Convert.ToInt32(txtInvoiceDetailId.Text)
            });

            if (result.Success)
            {
                XtraMessageBox.Show(result.Message, "Deleting Invoice Detail", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                GetInvoiceDetailDto();
            }
        }

        private void btnClearInvoiceDetails_Click(object sender, EventArgs e)
        {
            txtPrice.Text = "";
            txtInvoiceDetailId.Text = "";
            txtTotalPrice.Text = "";
            txtUnit.Text = "";
            lueInvoiceId.EditValue = -1;
            lueProductName.EditValue = -1;
        }
    }
}