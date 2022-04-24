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
    public partial class BrandAddForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly IBrandService _brandService;
        public BrandAddForm()
        {
            InitializeComponent();
            _brandService = InstanceFactory.GetInstance<IBrandService>();
        }

        private void BrandNewForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAddBrand_Click(object sender, EventArgs e)
        {
            var result = _brandService.Add(new Brand
            {
                BrandName = txtBrandName.Text,
                BrandDescription = memoEditBrandDescription.Text
            });

            if (result.Success)
            {
                XtraMessageBox.Show(result.Message, "Adding a new Brand", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClearBrands_Click(object sender, EventArgs e)
        {
            txtBrandName.Text = "";
            memoEditBrandDescription.Text = "";
        }
    }
}