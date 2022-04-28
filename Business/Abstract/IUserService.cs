using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using Universal.Entities;
using Universal.Utilities.Abstract;

namespace Business.Abstract
{
    public interface IUserService:IDto
    {

        IDataResult<List<User>> GetAll();
        IDataResult<User> Get(int userId);
        IResult Add(User user);
        IResult Update(User user);
        IResult Delete(User user);


    }
}
