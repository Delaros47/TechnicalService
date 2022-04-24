using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universal.CrossCuttingCorcerns.Validation;
using Universal.Utilities.Abstract;
using Universal.Utilities.Concrete;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {

        private readonly IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public IResult Add(Product product)
        {
             ValidationTool.Validate(new ProductValidator(),product);
             _productDal.Add(product);
            return new SuccessResult(Messages.ProductAdded);
        }

        public IResult Delete(Product product)
        {
            _productDal.Delete(product);
            return new SuccessResult(Messages.ProductDeleted);
        }

        public IDataResult<Product> Get(int productId)
        {
            return new SuccessDataResult<Product>(_productDal.Get(p=>p.ProductId==productId));
        }

        public IDataResult<List<Product>> GetAll()
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll());
        }

        public IDataResult<Product> GetHighestProductPrice()
        {
            return new SuccessDataResult<Product>(_productDal.GetAll().OrderByDescending(p=>p.SalePrice).First());
        }

        public IDataResult<Product> GetLowestProductPrice()
        {
            return new SuccessDataResult<Product>(_productDal.GetAll().OrderBy(p=>p.SalePrice).First());
        }

        public IDataResult<Product> GetMaximumStockedProduct()
        {
            return new SuccessDataResult<Product>(_productDal.GetAll().OrderByDescending(p=>p.UnitsInStock).First());
        }

        public IDataResult<Product> GetMinimumStockedProduct()
        {
            return new SuccessDataResult<Product>(_productDal.GetAll().OrderBy(p=>p.UnitsInStock).First());
        }

        public IDataResult<List<ProductDetailDto>> GetProductDetail()
        {
            return new SuccessDataResult<List<ProductDetailDto>>(_productDal.GetProductDetail());
        }

        public IDataResult<int> GetTotalComputerStockNumber(int categoryId)
        {
            return new SuccessDataResult<int>(_productDal.GetAll().Where(p=>p.CategoryId==categoryId).Sum(p=>p.UnitsInStock));
        }

        public IDataResult<int> GetTotalProductsCount()
        {
            return new SuccessDataResult<int>(_productDal.GetAll().Count);
        }

        public IDataResult<int> GetTotalProductsStock()
        {
            return new SuccessDataResult<int>(_productDal.GetAll().Sum(p=>p.UnitsInStock));
        }

        public IDataResult<int> GetTotalSmallAppliancesStockNumber(int categoryId)
        {
            return new SuccessDataResult<int>(_productDal.GetAll().Where(p=>p.CategoryId==categoryId).Sum(p=>p.UnitsInStock));
        }

        public IDataResult<int> GetTotalWhiteGoodsStockNumber(int categoryId)
        {
            return new SuccessDataResult<int>(_productDal.GetAll().Where(p=>p.CategoryId==categoryId).Sum(p=>p.UnitsInStock));
        }

        public IResult Update(Product product)
        {
            _productDal.Update(product);
            return new SuccessResult(Messages.ProductUpdated);
        }
    }
}
