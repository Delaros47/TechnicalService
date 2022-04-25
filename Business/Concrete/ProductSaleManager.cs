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
    public class ProductSaleManager : IProductSaleService
    {

        private readonly IProductSaleDal _productSaleDal;
        public ProductSaleManager(IProductSaleDal productSaleDal)
        {
            _productSaleDal = productSaleDal;
        }

        public IResult Add(ProductSale productSale)
        {
            ValidationTool.Validate(new ProductSaleValidator(),productSale);
            _productSaleDal.Add(productSale);
            return new SuccessResult(Messages.GetMessage("Product Sale",Proccess.Add));
        }

        public IResult Delete(ProductSale productSale)
        {
            _productSaleDal.Delete(productSale);
            return new SuccessResult(Messages.GetMessage("Product Sale", Proccess.Delete));
        }

        public IDataResult<ProductSale> Get(int productSaleId)
        {
            return new SuccessDataResult<ProductSale>(_productSaleDal.Get(p=>p.ProductSaleId==productSaleId));
        }

        public IDataResult<List<ProductSale>> GetAll()
        {
            return new SuccessDataResult<List<ProductSale>>(_productSaleDal.GetAll());
        }

        public IDataResult<List<ProductSalesDetailDto>> GetProductSalesDetailDto()
        {
            return new SuccessDataResult<List<ProductSalesDetailDto>>(_productSaleDal.ProductSalesDetailDto());
        }

        public IResult Update(ProductSale productSale)
        {
            _productSaleDal.Update(productSale);
            return new SuccessResult(Messages.GetMessage("Product Sale", Proccess.Update));
        }
    }
}
