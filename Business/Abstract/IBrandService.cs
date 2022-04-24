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
    public interface IBrandService
    {

        IDataResult<List<Brand>> GetAll();
        IDataResult<List<BrandStatisticsDto>> GetBrandStatisticsDto();
        IDataResult<Brand> Get(int brandId);
        IDataResult<int> GetTotalBrandNumber();
        IResult Add(Brand brand);
        IResult Update(Brand brand);
        IResult Delete(Brand brand);
        

    }
}
