using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using Universal.Utilities.Abstract;

namespace Business.Abstract
{
    public interface ITrackingService
    {
        IDataResult<List<Tracking>> GetAll();
        IDataResult<Tracking> Get(int trackingId);
        IResult Add(Tracking tracking);
        IResult Update(Tracking tracking);
        IResult Delete(Tracking tracking);
    }
}
