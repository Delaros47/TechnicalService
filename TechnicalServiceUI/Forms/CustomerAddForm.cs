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
    public partial class CustomerAddForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly ICustomerService _customerService;
        private readonly ICityService _cityService;
        private readonly IBankService _bankService;
        public CustomerAddForm()
        {
            InitializeComponent();
            _customerService = InstanceFactory.GetInstance<ICustomerService>();
            _cityService = InstanceFactory.GetInstance<ICityService>();
            _bankService = InstanceFactory.GetInstance<IBankService>();
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

            }
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

        private void CustomerAddForm_Load(object sender, EventArgs e)
        {
            GetAllBanks();
            GetAllCities();
        }

        private void btnClearCustomers_Click(object sender, EventArgs e)
        {
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