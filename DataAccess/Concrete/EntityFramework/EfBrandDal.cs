using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using Entities.DTOs;
using Universal.DataAccess;
using Universal.DataAccess.EntityFramework;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBrandDal : EfEntityRepositoryBase<Brand, TechinalServiceContext>, IBrandDal
    {
        public List<BrandStatisticsDto> GetBrandStatisticsDto()
        {
            using (var context = new TechinalServiceContext())
            {
                var result = from b in context.Brands
                             join p in context.Products
                             on b.BrandId equals p.BrandId
                             orderby b.BrandName ascending
                             group b.BrandName by b.BrandName into brandGroup
                             select new BrandStatisticsDto
                             {
                                 BrandName = brandGroup.Key,
                                 TotalProducts = brandGroup.Count()
                             };
                return result.ToList();
            }
        }
    }
}


//SELECT BrandName,COUNT(*) FROM Brands,Products WHERE Brands.BrandId=Products.BrandId GROUP BY BrandName