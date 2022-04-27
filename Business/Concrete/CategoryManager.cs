using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.DTOs;
using Universal.CrossCuttingCorcerns.Validation;
using Universal.Utilities.Abstract;
using Universal.Utilities.Concrete;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {

        private readonly ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public IDataResult<List<CategoryProductDetailDto>> GetCategoryProductDetailDto()
        {
            return new SuccessDataResult<List<CategoryProductDetailDto>>(_categoryDal.GetCategoryProductDetailDto());
        }

        public IDataResult<MaxProductCategoryDto> GetGetMaxProductCategoryDto()
        {
            return new SuccessDataResult<MaxProductCategoryDto>(_categoryDal.GetMaxProductCategoryDto());
        }


        public IResult Add(Category category)
        {
            ValidationTool.Validate(new CategoryValidator(), category);
            _categoryDal.Add(category);
            return new SuccessResult(Messages.CategoryAdded);
        }

        public IResult Delete(Category category)
        {
            _categoryDal.Delete(category);
            return new SuccessResult(Messages.CategoryDeleted);
        }

        public IDataResult<Category> Get(int categoryId)
        {
            return new SuccessDataResult<Category>(_categoryDal.Get(c => c.CategoryId == categoryId));
        }

        public IDataResult<List<Category>> GetAll()
        {
            return new SuccessDataResult<List<Category>>(_categoryDal.GetAll());
        }

        public IDataResult<int> GetTotalCategoriesCount()
        {
            return new SuccessDataResult<int>(_categoryDal.GetAll().Count);
        }

        public IResult Update(Category category)
        {
            _categoryDal.Update(category);
            return new SuccessResult(Messages.CategoryUpdated);
        }
    }
}
