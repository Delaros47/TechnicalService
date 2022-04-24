using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using Universal.Utilities.Abstract;

namespace Business.Abstract
{
    public interface IBankService
    {
        IDataResult<List<Bank>> GetAll();
        IDataResult<Bank> Get(int bankId);
        IResult Add(Bank bank);
        IResult Update(Bank bank);
        IResult Delete(Bank bank);
    }
}
