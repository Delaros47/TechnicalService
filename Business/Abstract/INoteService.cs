using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universal.Utilities.Abstract;

namespace Business.Abstract
{
    public interface INoteService
    {

        IDataResult<List<Note>> GetAll();
        IDataResult<List<Note>> GetAllNotesWithRead();
        IDataResult<List<Note>> GetAllNotesWithUnRead();
        IDataResult<Note> Get(int noteId);
        IResult Add(Note note);
        IResult Update(Note note);
        IResult Delete(Note note);

    }
}
