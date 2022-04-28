using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator:AbstractValidator<User>
    {

        public UserValidator()
        {
            RuleFor(u=>u.UserName).NotEmpty().WithMessage("Username cannot be empty");
            RuleFor(u => u.Password).NotEmpty().WithMessage("Password cannot be empty");
        }

    }
}
