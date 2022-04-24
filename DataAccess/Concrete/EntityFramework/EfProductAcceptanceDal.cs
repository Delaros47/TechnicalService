using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using Universal.DataAccess.EntityFramework;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductAcceptanceDal:EfEntityRepositoryBase<ProductAcceptance,TechinalServiceContext>,IProductAcceptanceDal
    {
    }
}
