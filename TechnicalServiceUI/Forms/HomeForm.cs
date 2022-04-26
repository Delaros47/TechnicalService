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

namespace TechnicalServiceUI.Forms
{
    public partial class HomeForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly IProductService _productService;
        private readonly IBrandService _brandService;
        private readonly IDepartmentService _departmentService;
        public HomeForm()
        {
            InitializeComponent();
            _productService = InstanceFactory.GetInstance<IProductService>();
            _brandService = InstanceFactory.GetInstance<IBrandService>();
            _departmentService = InstanceFactory.GetInstance<IDepartmentService>();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            GetProductDetailDto();
            GetBrandsWithTotalProductNumber();
            GetDeparmentEmployeeDto();
        }

        private void GetProductDetailDto()
        {
            gridControlProducts.DataSource = _productService.GetProductDetail().Data;
        }

        private void GetBrandsWithTotalProductNumber()
        {
            gridControlBrands.DataSource = _brandService.GetBrandStatisticsDto().Data;
        }

        private void GetDeparmentEmployeeDto()
        {
            gridControlDepartments.DataSource = _departmentService.GetDepartmentEmployeeDto().Data;
        }

    }
}