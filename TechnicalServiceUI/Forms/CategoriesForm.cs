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
    public partial class CategoriesForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly ICategoryService _categoryService;
        public CategoriesForm()
        {
            InitializeComponent();
            _categoryService = InstanceFactory.GetInstance<ICategoryService>();
        }

        private void CategoriesForm_Load(object sender, EventArgs e)
        {

            gridViewCategories.Appearance.Row.BackColor = Color.Silver;
            gridViewCategories.Appearance.Row.BackColor2 = Color.FromArgb(224, 224, 224);

            GetAllCategories();
        }

        private void GetAllCategories()
        {
            gridControlCategories.DataSource = _categoryService.GetAll().Data;
        }

        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            var result = _categoryService.Update(new Category
            {
                CategoryId = Convert.ToInt32(txtCategoryId.Text),
                CategoryName = txtCategoryName.Text
            });

            if (result.Success)
            {
                XtraMessageBox.Show(result.Message,"Updating a Category",MessageBoxButtons.OK,MessageBoxIcon.Question);
                GetAllCategories();
            }
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            var result = _categoryService.Delete(new Category
            {
                CategoryId = Convert.ToInt32(txtCategoryId.Text)
            });

            if (result.Success)
            {
                XtraMessageBox.Show(result.Message, "Deleting a Category", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                GetAllCategories();
            }
        }

        private void btnClearCategories_Click(object sender, EventArgs e)
        {
            txtCategoryId.Text = "";
            txtCategoryName.Text = "";
        }

        private void gridViewCategories_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtCategoryId.Text = gridViewCategories.GetFocusedRowCellValue("CategoryId").ToString();
            txtCategoryName.Text = gridViewCategories.GetFocusedRowCellValue("CategoryName").ToString();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            var result = _categoryService.Add(new Category
            {
                CategoryName = txtCategoryName.Text
            });

            if (result.Success)
            {
                XtraMessageBox.Show(result.Message, "Adding a Category", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetAllCategories();
            }
        }
    }
}