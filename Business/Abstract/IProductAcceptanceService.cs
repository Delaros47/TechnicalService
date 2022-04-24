using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universal.Utilities.Abstract;

namespace Business.Abstract
{
    public interface IProductAcceptanceService
    {

        IDataResult<List<ProductAcceptance>> GetAll();
        IDataResult<ProductAcceptance> Get(int productAcceptanceId);
        IDataResult<List<ProductAcceptanceDetailDto>> GetProductAcceptanceDetailDto();
        IResult Add(ProductAcceptance productAcceptance);
        IResult Update(ProductAcceptance productAcceptance);
        IResult Delete(ProductAcceptance productAcceptance);
    }
}
