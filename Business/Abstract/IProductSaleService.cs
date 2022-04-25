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
    public interface IProductSaleService
    {

        IDataResult<List<ProductSale>> GetAll();
        IDataResult<ProductSale> Get(int productSaleId);
        IDataResult<List<ProductSalesDetailDto>> GetProductSalesDetailDto();
        IResult Add(ProductSale productSale);
        IResult Update(ProductSale productSale);
        IResult Delete(ProductSale productSale);

    }
}
