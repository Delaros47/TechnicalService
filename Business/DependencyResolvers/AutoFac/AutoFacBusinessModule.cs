using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

namespace Business.DependencyResolvers.AutoFac
{
    public class AutoFacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<BankManager>().As<IBankService>().SingleInstance();
            builder.RegisterType<EfBankDal>().As<IBankDal>().SingleInstance();

            builder.RegisterType<ProductManager>().As<IProductService>().SingleInstance();
            builder.RegisterType<EfProductDal>().As<IProductDal>().SingleInstance();

            builder.RegisterType<BrandManager>().As<IBrandService>().SingleInstance();
            builder.RegisterType<EfBrandDal>().As<IBrandDal>().SingleInstance();

            builder.RegisterType<CategoryManager>().As<ICategoryService>().SingleInstance();
            builder.RegisterType<EfCategoryDal>().As<ICategoryDal>().SingleInstance();

            builder.RegisterType<CustomerManager>().As<ICustomerService>().SingleInstance();
            builder.RegisterType<EfCustomerDal>().As<ICustomerDal>().SingleInstance();

            builder.RegisterType<CityManager>().As<ICityService>().SingleInstance();
            builder.RegisterType<EfCityDal>().As<ICityDal>().SingleInstance();

            builder.RegisterType<DepartmentManager>().As<IDepartmentService>().SingleInstance();
            builder.RegisterType<EfDepartmentDal>().As<IDepartmentDal>().SingleInstance();

            builder.RegisterType<NoteManager>().As<INoteService>().SingleInstance();
            builder.RegisterType<EfNoteDal>().As<INoteDal>().SingleInstance();

            builder.RegisterType<EmployeeManager>().As<IEmployeeService>().SingleInstance();
            builder.RegisterType<EfEmployeeDal>().As<IEmployeeDal>().SingleInstance();

            builder.RegisterType<ProductAcceptanceManager>().As<IProductAcceptanceService>().SingleInstance();
            builder.RegisterType<EfProductAcceptanceDal>().As<IProductAcceptanceDal>().SingleInstance();

            builder.RegisterType<ProductSaleManager>().As<IProductSaleService>().SingleInstance();
            builder.RegisterType<EfProductSaleDal>().As<IProductSaleDal>().SingleInstance();

            builder.RegisterType<TrackingManager>().As<ITrackingService>().SingleInstance();
            builder.RegisterType<EfTrackingDal>().As<ITrackingDal>().SingleInstance();

            builder.RegisterType<InvoiceInfoManager>().As<IInvoiceInfoService>().SingleInstance();
            builder.RegisterType<EfInvoiceInfoDal>().As<IInvoiceInfoDal>().SingleInstance();

            builder.RegisterType<InvoiceDetailManager>().As<IInvoiceDetailService>().SingleInstance();
            builder.RegisterType<EfInvoiceDetailDal>().As<IInvoiceDetailDal>().SingleInstance();

            builder.RegisterType<UserManager>().As<IUserService>().SingleInstance();
            builder.RegisterType<EfUserDal>().As<IUserDal>().SingleInstance();


        }
    }
}
