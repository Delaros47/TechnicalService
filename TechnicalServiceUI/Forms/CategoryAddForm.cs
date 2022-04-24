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
    public partial class CategoryAddForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly ICategoryService _categoryService;
        public CategoryAddForm()
        {
            InitializeComponent();
            _categoryService = InstanceFactory.GetInstance<ICategoryService>();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            var result = _categoryService.Add(new Category
            {
                CategoryName = txtCategoryName.Text
            });

            if (result.Success)
            {
                XtraMessageBox.Show(result.Message,"Adding a Category",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
    }
}