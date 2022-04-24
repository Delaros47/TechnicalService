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
    public partial class BrandsForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly IBrandService _brandService;
        public BrandsForm()
        {
            InitializeComponent();
            _brandService = InstanceFactory.GetInstance<IBrandService>();
        }

        private void BrandsForm_Load(object sender, EventArgs e)
        {
            GetAllBrands();
        }

        private void GetAllBrands()
        {
            gridControlBrands.DataSource = _brandService.GetAll().Data;
        }

        private void gridViewBrands_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtBrandId.Text = gridViewBrands.GetFocusedRowCellValue("BrandId").ToString();
            txtBrandName.Text = gridViewBrands.GetFocusedRowCellValue("BrandName").ToString();
            memoEditBrandDescription.Text = gridViewBrands.GetFocusedRowCellValue("BrandDescription").ToString();
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
                GetAllBrands();
            }
        }

        private void btnUpdateBrand_Click(object sender, EventArgs e)
        {
            var result = _brandService.Update(new Brand
            {
                BrandId = Convert.ToInt32(txtBrandId.Text),
                BrandName = txtBrandName.Text,
                BrandDescription = memoEditBrandDescription.Text
            });

            if (result.Success)
            {
                XtraMessageBox.Show(result.Message, "Updating current Brand", MessageBoxButtons.OK, MessageBoxIcon.Question);
                GetAllBrands();
            }
        }

        private void btnDeleteBrand_Click(object sender, EventArgs e)
        {
            var result = _brandService.Delete(new Brand
            {
                BrandId = Convert.ToInt32(txtBrandId.Text)
            });

            if (result.Success)
            {
                XtraMessageBox.Show(result.Message, "Deleting current Brand", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                GetAllBrands();
            }
        }

        private void btnClearBrands_Click(object sender, EventArgs e)
        {
            txtBrandId.Text = "";
            txtBrandName.Text = "";
            memoEditBrandDescription.Text = "";
        }
    }
}