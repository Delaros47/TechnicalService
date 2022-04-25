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
    public class TrackingManager:ITrackingService
    {

        private readonly ITrackingDal _trackingDal;
        public TrackingManager(ITrackingDal trackingDal)
        {
            _trackingDal = trackingDal;
        }

        public IDataResult<List<Tracking>> GetAll()
        {
            return new SuccessDataResult<List<Tracking>>(_trackingDal.GetAll());
        }

        public IDataResult<Tracking> Get(int trackingId)
        {
            return new SuccessDataResult<Tracking>(_trackingDal.Get(t => t.TrackingId == trackingId));
        }

        public IResult Add(Tracking tracking)
        {
            ValidationTool.Validate(new TrackingValidator(),tracking);
            _trackingDal.Add(tracking);
            return new SuccessResult(Messages.GetMessage("Tracking",Proccess.Add));
        }

        public IResult Update(Tracking tracking)
        {
            _trackingDal.Update(tracking);
            return new SuccessResult(Messages.GetMessage("Tracking", Proccess.Update));
        }

        public IResult Delete(Tracking tracking)
        {
            _trackingDal.Delete(tracking);
            return new SuccessResult(Messages.GetMessage("Tracking", Proccess.Delete));
        }
    }
}
