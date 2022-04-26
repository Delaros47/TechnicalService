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
    public partial class InvoicesForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly IInvoiceInfoService _invoiceInfoService;
        private readonly ICustomerService _customerService;
        private readonly IEmployeeService _employeeService;
        public InvoicesForm()
        {
            InitializeComponent();
            _invoiceInfoService = InstanceFactory.GetInstance<IInvoiceInfoService>();
            _customerService = InstanceFactory.GetInstance<ICustomerService>();
            _employeeService = InstanceFactory.GetInstance<IEmployeeService>();
        }

        private void InvoicesForm_Load(object sender, EventArgs e)
        {
            GetCustomerFullNameDto();
            GetEmployeeFullNameDto();
            GetAllInvoiceInfosDetailDto();
        }

        private void GetAllInvoiceInfosDetailDto()
        {
            gridControlInvoices.DataSource = _invoiceInfoService.GetInvoiceInfosDetailDto().Data;
        }

        private void btnAddInvoice_Click(object sender, EventArgs e)
        {
            var result = _invoiceInfoService.Add(new InvoiceInfo
            {
                InvoiceSerialNumber = txtInvoiceSerialNumber.Text,
                InvoiceOrderNumber = txtInvoiceOrderNumber.Text,
                InvoiceDate = Convert.ToDateTime(deInvoiceDate.Text),
                TaxOffice = txtTaxOffice.Text,
                CustomerId = Convert.ToInt32(lueCustomerName.EditValue.ToString()),
                EmployeeId = Convert.ToInt32(lueEmployeeName.EditValue.ToString()),
            });

            if (result.Success)
            {
                XtraMessageBox.Show(result.Message, "Adding a new Invoice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetAllInvoiceInfosDetailDto();
            }

        }

        private void GetCustomerFullNameDto()
        {
            lueCustomerName.Properties.DataSource = _customerService.GetCustomersFullNameDto().Data;
            lueCustomerName.Properties.DisplayMember = "CustomerFullName";
            lueCustomerName.Properties.ValueMember = "CustomerId";
        }

        private void GetEmployeeFullNameDto()
        {
            lueEmployeeName.Properties.DataSource = _employeeService.GetEmployeesFullNameDto().Data;
            lueEmployeeName.Properties.DisplayMember = "EmployeeFullName";
            lueEmployeeName.Properties.ValueMember = "EmployeeId";
        }

        private void btnUpdateInvoice_Click(object sender, EventArgs e)
        {
            var result = _invoiceInfoService.Update(new InvoiceInfo
            {
                InvoiceInfoId = Convert.ToInt32(txtInvoiceInfoId.Text),
                InvoiceSerialNumber = txtInvoiceSerialNumber.Text,
                InvoiceOrderNumber = txtInvoiceOrderNumber.Text,
                InvoiceDate = Convert.ToDateTime(deInvoiceDate.Text),
                TaxOffice = txtTaxOffice.Text,
                CustomerId = Convert.ToInt32(lueCustomerName.EditValue.ToString()),
                EmployeeId = Convert.ToInt32(lueEmployeeName.EditValue.ToString()),
            });

            if (result.Success)
            {
                XtraMessageBox.Show(result.Message, "Updating the current Invoice", MessageBoxButtons.OK, MessageBoxIcon.Question);
                GetAllInvoiceInfosDetailDto();
            }
        }

        private void btnDeleteInvoice_Click(object sender, EventArgs e)
        {
            var result = _invoiceInfoService.Delete(new InvoiceInfo
            {
                InvoiceInfoId = Convert.ToInt32(txtInvoiceInfoId.Text)
            });

            if (result.Success)
            {
                XtraMessageBox.Show(result.Message, "Deleting the current Invoice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                GetAllInvoiceInfosDetailDto();
            }
        }

        private void gridViewInvoices_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtInvoiceInfoId.Text = gridViewInvoices.GetFocusedRowCellValue("InvoiceInfoId").ToString();
            txtInvoiceOrderNumber.Text = gridViewInvoices.GetFocusedRowCellValue("InvoiceOrderNumber").ToString();
            txtInvoiceSerialNumber.Text = gridViewInvoices.GetFocusedRowCellValue("InvoiceSerialNumber").ToString();
            txtTaxOffice.Text = gridViewInvoices.GetFocusedRowCellValue("TaxOffice").ToString();
            deInvoiceDate.Text = gridViewInvoices.GetFocusedRowCellValue("InvoiceDate").ToString();
            lueCustomerName.Text = gridViewInvoices.GetFocusedRowCellValue("CustomerFullName").ToString();
            lueEmployeeName.Text = gridViewInvoices.GetFocusedRowCellValue("EmployeeFullName").ToString();
        }

        private void btnClearInvoices_Click(object sender, EventArgs e)
        {
            txtInvoiceInfoId.Text = "";
            txtInvoiceOrderNumber.Text = "";
            txtInvoiceSerialNumber.Text = "";
            txtTaxOffice.Text = "";
            deInvoiceDate.Text = "";
            lueCustomerName.EditValue = -1;
            lueEmployeeName.EditValue = -1;
        }
    }
}