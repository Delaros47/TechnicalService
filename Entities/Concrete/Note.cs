using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universal.Entities;

namespace Entities.Concrete
{
    public class Note:IEntity
    {
        public int NoteId { get; set; }
        public string Title { get; set; }
        public string NoteContent { get; set; }
        public bool IsRead { get; set; }


    }
}
