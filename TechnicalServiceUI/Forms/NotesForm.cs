using Business.Abstract;
using Business.DependencyResolvers.AutoFac;
using DevExpress.XtraEditors;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechnicalServiceUI.Forms
{
    public partial class NotesForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly INoteService _noteService;
        public NotesForm()
        {
            InitializeComponent();
            _noteService = InstanceFactory.GetInstance<INoteService>();
        }

        private void NotesForm_Load(object sender, EventArgs e)
        {
            GetAllNotesWithRead();
            GetAllNotesWithUnRead();
        }

        private void GetAllNotesWithRead()
        {
            gridControlReadNotes.DataSource = _noteService.GetAllNotesWithRead().Data;
        }

        private void GetAllNotesWithUnRead()
        {
            gridControlUnReadNotes.DataSource = _noteService.GetAllNotesWithUnRead().Data;
        }

        private void gridViewReadNotes_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtNoteId.Text = gridViewReadNotes.GetFocusedRowCellValue("NoteId").ToString();
            txtNoteTitle.Text = gridViewReadNotes.GetFocusedRowCellValue("Title").ToString();
            memoNoteContent.Text = gridViewReadNotes.GetFocusedRowCellValue("NoteContent").ToString();
            toogleSwitchIsRead.IsOn = (bool)gridViewReadNotes.GetFocusedRowCellValue("IsRead");
        }

        private void gridViewUnReadNotes_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtNoteId.Text = gridViewUnReadNotes.GetFocusedRowCellValue("NoteId").ToString();
            txtNoteTitle.Text = gridViewUnReadNotes.GetFocusedRowCellValue("Title").ToString();
            memoNoteContent.Text = gridViewUnReadNotes.GetFocusedRowCellValue("NoteContent").ToString();
            toogleSwitchIsRead.IsOn = (bool)gridViewUnReadNotes.GetFocusedRowCellValue("IsRead");
        }

        private void btnAddNote_Click(object sender, EventArgs e)
        {
            var result = _noteService.Add(new Note
            {
                Title = txtNoteTitle.Text,
                NoteContent = memoNoteContent.Text,
                IsRead = toogleSwitchIsRead.IsOn
            });

            if (result.Success)
            {
                XtraMessageBox.Show(result.Message,"Adding a note",MessageBoxButtons.OK,MessageBoxIcon.Information);
                GetAllNotesWithRead();
                GetAllNotesWithUnRead();
            }
        }

        private void btnUpdateNote_Click(object sender, EventArgs e)
        {
            var result = _noteService.Update(new Note
            {
                NoteId= Convert.ToInt32(txtNoteId.Text),
                Title = txtNoteTitle.Text,
                NoteContent = memoNoteContent.Text,
                IsRead = toogleSwitchIsRead.IsOn
            });

            if (result.Success)
            {
                XtraMessageBox.Show(result.Message, "Updating a note", MessageBoxButtons.OK, MessageBoxIcon.Question);
                GetAllNotesWithRead();
                GetAllNotesWithUnRead();
            }
        }

        private void btnDeleteNote_Click(object sender, EventArgs e)
        {
            var result = _noteService.Delete(new Note
            {
                NoteId = Convert.ToInt32(txtNoteId.Text)
            });

            if (result.Success)
            {
                XtraMessageBox.Show(result.Message, "Deleting a note", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                GetAllNotesWithRead();
                GetAllNotesWithUnRead();
            }
        }

        private void btnClearNotes_Click(object sender, EventArgs e)
        {
            txtNoteId.Text = "";
            txtNoteTitle.Text = "";
            memoNoteContent.Text = "";
            toogleSwitchIsRead.IsOn = false;
        }
    }
}