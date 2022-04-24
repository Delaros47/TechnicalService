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
using Universal.CrossCuttingCorcerns.Validation;
using Universal.Utilities.Abstract;
using Universal.Utilities.Concrete;

namespace Business.Concrete
{
    public class CityManager : ICityService
    {

        private readonly ICityDal _cityDal;
        public CityManager(ICityDal cityDal)
        {
            _cityDal = cityDal;
        }

        public IResult Add(City city)
        {
            ValidationTool.Validate(new CityValidator(),city);
            _cityDal.Add(city);
            return new SuccessResult(Messages.CityAdded);
        }

        public IResult Delete(City city)
        {
            _cityDal.Delete(city);
            return new SuccessResult(Messages.CityDeleted);
        }

        public IDataResult<City> Get(int cityId)
        {
            return new SuccessDataResult<City>(_cityDal.Get(c=>c.CityId==cityId));
        }

        public IDataResult<List<City>> GetAll()
        {
            return new SuccessDataResult<List<City>>(_cityDal.GetAll());
        }

        public IResult Update(City city)
        {
            _cityDal.Update(city);
            return new SuccessResult(Messages.CityUpdated);
        }
    }
}
