using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class NoteValidator:AbstractValidator<Note>
    {
        public NoteValidator()
        {
            RuleFor(n=>n.Title).NotEmpty().WithMessage("Not Title cannot be empty");
            RuleFor(n => n.NoteContent).NotEmpty().WithMessage("Not Content cannot be empty");
        }
    }
}
