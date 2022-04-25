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
    public interface IProductService
    {
        IDataResult<List<Product>> GetAll();
        IDataResult<List<ProductDetailDto>> GetProductDetail();
        IDataResult<Product> Get(int productId);
        IDataResult<int> GetTotalProductsCount();
        IDataResult<int> GetTotalProductsStock();
        IDataResult<Product> GetMaximumStockedProduct();
        IDataResult<Product> GetMinimumStockedProduct();
        IDataResult<Product> GetHighestProductPrice();
        IDataResult<Product> GetLowestProductPrice();
        IDataResult<int> GetTotalWhiteGoodsStockNumber(int categoryId);
        IDataResult<int> GetTotalComputerStockNumber(int categoryId);
        IDataResult<int> GetTotalSmallAppliancesStockNumber(int categoryId);
        IDataResult<List<Product>> GetAllByDistinctProductName();
        IResult Add(Product product);
        IResult Update(Product product);
        IResult Delete(Product product);


    }
}
