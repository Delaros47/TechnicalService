using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.DTOs;
using Universal.Utilities.Abstract;

namespace Business.Abstract
{
    public interface ICategoryService
    {

        IDataResult<List<Category>> GetAll();
        IDataResult<Category> Get(int categoryId);
        IDataResult<int> GetTotalCategoriesCount();
        IDataResult<List<CategoryProductDetailDto>> GetCategoryProductDetailDto();
        IResult Add(Category category);
        IResult Update(Category category);
        IResult Delete(Category category);


    }
}
