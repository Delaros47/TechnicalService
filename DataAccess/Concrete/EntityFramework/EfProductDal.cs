using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using Entities.DTOs;
using Universal.DataAccess.EntityFramework;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, TechinalServiceContext>, IProductDal
    {
        public List<ProductDetailDto> GetProductDetail()
        {
            using (var context = new TechinalServiceContext())
            {

                var result = from p in context.Products
                             join c in context.Categories
                             on p.CategoryId equals c.CategoryId
                             join b in context.Brands
                             on p.BrandId equals b.BrandId
                             select new ProductDetailDto
                             {
                                 ProductId = p.ProductId,
                                 ProductName = p.ProductName,
                                 PurchasePrice = p.PurchasePrice,
                                 SalePrice = p.SalePrice,
                                 State = p.State,
                                 UnitsInStock = p.UnitsInStock,
                                 CategoryName = c.CategoryName,
                                 BrandName = b.BrandName
                             };
                return result.ToList();
            }
        }
    }
}
