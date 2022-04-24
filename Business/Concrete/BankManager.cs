using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using DataAccess.Abstract;
using Entities.Concrete;
using Universal.CrossCuttingCorcerns.Validation;
using Universal.Utilities.Abstract;
using Universal.Utilities.Concrete;

namespace Business.Concrete
{
    public class BankManager : IBankService
    {

        private readonly IBankDal _bankDal;
        public BankManager(IBankDal bankDal)
        {
            _bankDal = bankDal;
        }


        public IDataResult<List<Bank>> GetAll()
        {
            return new SuccessDataResult<List<Bank>>(_bankDal.GetAll());
        }

        public IDataResult<Bank> Get(int bankId)
        {
            return new SuccessDataResult<Bank>(_bankDal.Get(b => b.BankId == bankId));
        }

        public IResult Add(Bank bank)
        {
            ValidationTool.Validate(new BankValidator(),bank);
            _bankDal.Add(bank);
            return new SuccessResult(Messages.BankAdded);
        }

        public IResult Update(Bank bank)
        {
            _bankDal.Update(bank);
            return new SuccessResult(Messages.BankUpdated);
        }

        public IResult Delete(Bank bank)
        {
            _bankDal.Delete(bank);
            return new SuccessResult(Messages.BankDeleted);
        }
    }
}
