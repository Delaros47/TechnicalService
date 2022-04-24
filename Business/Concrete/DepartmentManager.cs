using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universal.CrossCuttingCorcerns.Validation;
using Universal.Utilities.Abstract;
using Universal.Utilities.Concrete;

namespace Business.Concrete
{
    public class DepartmentManager : IDepartmentService
    {

        private readonly IDepartmentDal _departmentDal;
        public DepartmentManager(IDepartmentDal departmentDal)
        {
            _departmentDal = departmentDal;
        }

        public IResult Add(Department department)
        {
            ValidationTool.Validate(new DepartmentValidator(),department);
            _departmentDal.Add(department);
            return new SuccessResult(Messages.GetMessage("Department",Proccess.Add));
        }

        public IResult Delete(Department department)
        {
            _departmentDal.Delete(department);
            return new SuccessResult(Messages.GetMessage("Department",Proccess.Delete));
        }

        public IDataResult<Department> Get(int departmentId)
        {
            return new SuccessDataResult<Department>(_departmentDal.Get(d=>d.DepartmentId==departmentId));
        }

        public IDataResult<List<Department>> GetAll()
        {
            return new SuccessDataResult<List<Department>>(_departmentDal.GetAll());
        }

        public IResult Update(Department department)
        {
            _departmentDal.Update(department);
            return new SuccessResult(Messages.GetMessage("Department", Proccess.Update));
        }
    }
}
