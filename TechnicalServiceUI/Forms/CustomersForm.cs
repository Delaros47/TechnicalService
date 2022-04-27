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
    public partial class CustomersForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly ICustomerService _customerService;
        private readonly ICityService _cityService;
        private readonly IBankService _bankService;

        public CustomersForm()
        {
            InitializeComponent();
            _customerService = InstanceFactory.GetInstance<ICustomerService>();
            _cityService = InstanceFactory.GetInstance<ICityService>();
            _bankService = InstanceFactory.GetInstance<IBankService>();
        }

        private void CustomersForm_Load(object sender, EventArgs e)
        {
            gridViewCustomers.Appearance.Row.BackColor = Color.Silver;
            gridViewCustomers.Appearance.Row.BackColor2 = Color.FromArgb(224, 224, 224);

            GetAllCities();
            GetAllBanks();
            GetAllCustomers();
        }

        private void GetAllCustomers()
        {

            gridControlCustomers.DataSource = _customerService.GetCustomerDetailDto().Data;

        }

        private void GetAllBanks()
        {
            lueBankName.Properties.DataSource = _bankService.GetAll().Data;
            lueBankName.Properties.DisplayMember = "BankName";
            lueBankName.Properties.ValueMember = "BankId";
        }

        private void GetAllCities()
        {
            lueCity.Properties.DataSource = _cityService.GetAll().Data;
            lueCity.Properties.DisplayMember = "CityName";
            lueCity.Properties.ValueMember = "CityId";
        }

        private void gridViewCustomers_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtCustomerId.Text = gridViewCustomers.GetFocusedRowCellValue("CustomerId").ToString();
            txtFirstName.Text = gridViewCustomers.GetFocusedRowCellValue("FirstName").ToString();
            txtLastName.Text = gridViewCustomers.GetFocusedRowCellValue("LastName").ToString();
            txtEmailAddress.Text = gridViewCustomers.GetFocusedRowCellValue("Email").ToString();
            txtIdentityNumber.Text = gridViewCustomers.GetFocusedRowCellValue("IdentityNumber").ToString();
            txtPhoneNumber.Text = gridViewCustomers.GetFocusedRowCellValue("Phone").ToString();
            txtTaxNumber.Text = gridViewCustomers.GetFocusedRowCellValue("TaxNumber").ToString();
            txtTaxOffice.Text = gridViewCustomers.GetFocusedRowCellValue("TaxOffice").ToString();
            txtTitle.Text = gridViewCustomers.GetFocusedRowCellValue("Title").ToString();
            deDateOfBirth.Text = gridViewCustomers.GetFocusedRowCellValue("DateOfBirth").ToString();
            lueCity.Text = gridViewCustomers.GetFocusedRowCellValue("CityName").ToString();
            lueBankName.Text = gridViewCustomers.GetFocusedRowCellValue("BankName").ToString();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            var result = _customerService.Add(new Customer
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Email = txtEmailAddress.Text,
                IdentityNumber = txtIdentityNumber.Text,
                Phone = txtPhoneNumber.Text,
                TaxNumber = txtTaxNumber.Text,
                TaxOffice = txtTaxOffice.Text,
                Title = txtTitle.Text,
                DateOfBirth = Convert.ToDateTime(deDateOfBirth.Text),
                CityId = Convert.ToInt32(lueCity.EditValue.ToString()),
                BankId = Convert.ToInt32(lueBankName.EditValue.ToString())
            }); ;

            if (result.Success)
            {
                XtraMessageBox.Show(result.Message, "Adding a new Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetAllCustomers();
            }
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            var result = _customerService.Delete(new Customer
            {
                CustomerId = Convert.ToInt32(txtCustomerId.Text)
            });

            if (result.Success)
            {
                XtraMessageBox.Show(result.Message, "Deleting a new Customer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                GetAllCustomers();
            }
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            var result = _customerService.Update(new Customer
            {
                CustomerId = Convert.ToInt32(txtCustomerId.Text),
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Email = txtEmailAddress.Text,
                IdentityNumber = txtIdentityNumber.Text,
                DateOfBirth = Convert.ToDateTime(deDateOfBirth.Text),
                Phone = txtPhoneNumber.Text,
                Title = txtTitle.Text,
                TaxNumber = txtTaxNumber.Text,
                TaxOffice = txtTaxOffice.Text,
                CityId = Convert.ToInt32(lueCity.EditValue.ToString()),
                BankId = Convert.ToInt32(lueBankName.EditValue.ToString())
            });

            if (result.Success)
            {
                XtraMessageBox.Show(result.Message, "Updating a new Customer", MessageBoxButtons.OK, MessageBoxIcon.Question);
                GetAllCustomers();
            }
        }

        private void btnClearCustomers_Click(object sender, EventArgs e)
        {
            txtCustomerId.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtEmailAddress.Text = "";
            txtIdentityNumber.Text = "";
            txtPhoneNumber.Text = "";
            txtTaxNumber.Text = "";
            txtTaxOffice.Text = "";
            txtTitle.Text = "";
            deDateOfBirth.Text = "";
            lueBankName.EditValue = -1;
            lueCity.EditValue = -1;
        }
    }
}