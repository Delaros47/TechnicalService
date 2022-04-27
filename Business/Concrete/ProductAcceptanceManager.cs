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
    public class ProductAcceptanceManager : IProductAcceptanceService
    {

        private readonly IProductAcceptanceDal _productAcceptanceDal;
        public ProductAcceptanceManager(IProductAcceptanceDal productAcceptanceDal)
        {
            _productAcceptanceDal = productAcceptanceDal;
        }

        public IDataResult<int> GetProductMalfunctionNumber()
        {
            return new SuccessDataResult<int>(_productAcceptanceDal.GetAll().Count);
        }

        public IResult Add(ProductAcceptance productAcceptance)
        {
            ValidationTool.Validate(new ProductAcceptanceValidator(),productAcceptance);
            _productAcceptanceDal.Add(productAcceptance);
            return new SuccessResult(Messages.GetMessage("Product Acceptance",Proccess.Add));
        }

        public IResult Delete(ProductAcceptance productAcceptance)
        {
            _productAcceptanceDal.Delete(productAcceptance);
            return new SuccessResult(Messages.GetMessage("Product Acceptance", Proccess.Delete));
        }

        public IDataResult<ProductAcceptance> Get(int productAcceptanceId)
        {
            return new SuccessDataResult<ProductAcceptance>(_productAcceptanceDal.Get(p=>p.ProductAcceptanceId==productAcceptanceId));
        }

        public IDataResult<List<ProductAcceptance>> GetAll()
        {
            return new SuccessDataResult<List<ProductAcceptance>>(_productAcceptanceDal.GetAll());
        }

        public IDataResult<List<ProductAcceptanceDetailDto>> GetProductAcceptanceDetailDto()
        {
            return new SuccessDataResult<List<ProductAcceptanceDetailDto>>(_productAcceptanceDal.GetProductAcceptanceDetailDto());
        }

        public IResult Update(ProductAcceptance productAcceptance)
        {
            _productAcceptanceDal.Update(productAcceptance);
            return new SuccessResult(Messages.GetMessage("Product Acceptance", Proccess.Update));
        }
    }
}
