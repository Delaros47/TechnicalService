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
    public class NoteManager : INoteService
    {

        private readonly INoteDal _noteDal;
        public NoteManager(INoteDal noteDal)
        {
            _noteDal = noteDal;
        }

        public IResult Add(Note note)
        {
            ValidationTool.Validate(new NoteValidator(),note);
            _noteDal.Add(note);
            return new SuccessResult(Messages.GetMessage("Note",Proccess.Add));
        }

        public IResult Delete(Note note)
        {
            _noteDal.Delete(note);
            return new SuccessResult(Messages.GetMessage("Note", Proccess.Delete));
        }

        public IDataResult<Note> Get(int noteId)
        {
            return new SuccessDataResult<Note>(_noteDal.Get(n=>n.NoteId==noteId));
        }

        public IDataResult<List<Note>> GetAll()
        {
            return new SuccessDataResult<List<Note>>(_noteDal.GetAll());
        }

        public IDataResult<List<Note>> GetAllNotesWithRead()
        {
            return new SuccessDataResult<List<Note>>(_noteDal.GetAll(n=>n.IsRead==true));
        }

        public IDataResult<List<Note>> GetAllNotesWithUnRead()
        {
            return new SuccessDataResult<List<Note>>(_noteDal.GetAll(n => n.IsRead == false));
        }

        public IResult Update(Note note)
        {
            _noteDal.Update(note);
            return new SuccessResult(Messages.GetMessage("Note", Proccess.Update));
        }
    }
}
