using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.VisualBasic.CompilerServices;
using Universal.DataAccess.EntityFramework;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, TechinalServiceContext>, ICategoryDal
    {
        public List<CategoryProductDetailDto> GetCategoryProductDetailDto()
        {
            using (var context = new TechinalServiceContext())
            {
                var result = from c in context.Categories
                             join p in context.Products
                                 on c.CategoryId equals p.CategoryId
                             group c.CategoryName by c.CategoryName
                    into groupCategory
                             select new CategoryProductDetailDto
                             {
                                 CategoryName = groupCategory.Key,
                                 ProductNumber = groupCategory.Count()
                             };
                return result.ToList();
            }
        }

        public List<MaxProductCategoryDto> GetMaxProductCategoryDto()
        {
            using (var context = new TechinalServiceContext())
            {
                var result = from c in context.Categories
                    join p in context.Products
                        on c.CategoryId equals p.CategoryId
                    group c.CategoryName by c.CategoryName
                    into groupCategory
                    orderby groupCategory.Count()
                    select new MaxProductCategoryDto
                    {
                        CategoryName = groupCategory.Key,
                        TotalProducts = groupCategory.Count()
                    };
                return result.ToList();
            }
        }
    }
}
