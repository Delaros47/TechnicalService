namespace TechnicalServiceUI.Forms
{
    partial class NotesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraLayout.ColumnDefinition columnDefinition1 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition1 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition2 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition3 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition4 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition5 = new DevExpress.XtraLayout.RowDefinition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotesForm));
            this.gridControlReadNotes = new TechnicalServiceUI.Controls.MyGridControl();
            this.gridViewReadNotes = new TechnicalServiceUI.Controls.MyGridView();
            this.colNoteId = new TechnicalServiceUI.Controls.MyGridColumn();
            this.colTitle = new TechnicalServiceUI.Controls.MyGridColumn();
            this.colNoteContent = new TechnicalServiceUI.Controls.MyGridColumn();
            this.colIsRead = new TechnicalServiceUI.Controls.MyGridColumn();
            this.gridControlUnReadNotes = new TechnicalServiceUI.Controls.MyGridControl();
            this.gridViewUnReadNotes = new TechnicalServiceUI.Controls.MyGridView();
            this.colUnReadNoteId = new TechnicalServiceUI.Controls.MyGridColumn();
            this.colUnReadTitle = new TechnicalServiceUI.Controls.MyGridColumn();
            this.colUnReadContent = new TechnicalServiceUI.Controls.MyGridColumn();
            this.colUnReadIsRead = new TechnicalServiceUI.Controls.MyGridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.myDataLayoutControl1 = new TechnicalServiceUI.Controls.MyDataLayoutControl();
            this.toogleSwitchIsRead = new TechnicalServiceUI.Controls.MyToogleSwitch();
            this.memoNoteContent = new TechnicalServiceUI.Controls.MyMemoEdit();
            this.txtNoteTitle = new TechnicalServiceUI.Controls.MyTextBox();
            this.txtNoteId = new TechnicalServiceUI.Controls.MyTextBox();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnAddNote = new TechnicalServiceUI.Controls.MySimpleButton();
            this.btnUpdateNote = new TechnicalServiceUI.Controls.MySimpleButton();
            this.btnDeleteNote = new TechnicalServiceUI.Controls.MySimpleButton();
            this.btnClearNotes = new TechnicalServiceUI.Controls.MySimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlReadNotes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewReadNotes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlUnReadNotes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUnReadNotes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl1)).BeginInit();
            this.myDataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toogleSwitchIsRead.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoNoteContent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoteTitle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoteId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlReadNotes
            // 
            this.gridControlReadNotes.Location = new System.Drawing.Point(3, 12);
            this.gridControlReadNotes.MainView = this.gridViewReadNotes;
            this.gridControlReadNotes.Name = "gridControlReadNotes";
            this.gridControlReadNotes.Size = new System.Drawing.Size(930, 261);
            this.gridControlReadNotes.TabIndex = 1;
            this.gridControlReadNotes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewReadNotes});
            // 
            // gridViewReadNotes
            // 
            this.gridViewReadNotes.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gridViewReadNotes.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewReadNotes.Appearance.FooterPanel.Options.UseFont = true;
            this.gridViewReadNotes.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridViewReadNotes.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewReadNotes.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridViewReadNotes.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewReadNotes.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewReadNotes.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewReadNotes.Appearance.ViewCaption.Options.UseForeColor = true;
            this.gridViewReadNotes.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNoteId,
            this.colTitle,
            this.colNoteContent,
            this.colIsRead});
            this.gridViewReadNotes.GridControl = this.gridControlReadNotes;
            this.gridViewReadNotes.Name = "gridViewReadNotes";
            this.gridViewReadNotes.OptionsMenu.EnableColumnMenu = false;
            this.gridViewReadNotes.OptionsMenu.EnableFooterMenu = false;
            this.gridViewReadNotes.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridViewReadNotes.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridViewReadNotes.OptionsPrint.AutoWidth = false;
            this.gridViewReadNotes.OptionsPrint.PrintFooter = false;
            this.gridViewReadNotes.OptionsPrint.PrintGroupFooter = false;
            this.gridViewReadNotes.OptionsView.ColumnAutoWidth = false;
            this.gridViewReadNotes.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.gridViewReadNotes.OptionsView.RowAutoHeight = true;
            this.gridViewReadNotes.OptionsView.ShowAutoFilterRow = true;
            this.gridViewReadNotes.OptionsView.ShowGroupPanel = false;
            this.gridViewReadNotes.OptionsView.ShowViewCaption = true;
            this.gridViewReadNotes.ViewCaption = "Read Notes";
            this.gridViewReadNotes.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewReadNotes_FocusedRowChanged);
            // 
            // colNoteId
            // 
            this.colNoteId.Caption = "Note ID";
            this.colNoteId.FieldName = "NoteId";
            this.colNoteId.Name = "colNoteId";
            this.colNoteId.OptionsColumn.AllowEdit = false;
            this.colNoteId.Visible = true;
            this.colNoteId.VisibleIndex = 0;
            this.colNoteId.Width = 200;
            // 
            // colTitle
            // 
            this.colTitle.Caption = "Note Title";
            this.colTitle.FieldName = "Title";
            this.colTitle.Name = "colTitle";
            this.colTitle.OptionsColumn.AllowEdit = false;
            this.colTitle.Visible = true;
            this.colTitle.VisibleIndex = 1;
            this.colTitle.Width = 200;
            // 
            // colNoteContent
            // 
            this.colNoteContent.Caption = "Note Content";
            this.colNoteContent.FieldName = "NoteContent";
            this.colNoteContent.Name = "colNoteContent";
            this.colNoteContent.OptionsColumn.AllowEdit = false;
            this.colNoteContent.Visible = true;
            this.colNoteContent.VisibleIndex = 2;
            this.colNoteContent.Width = 280;
            // 
            // colIsRead
            // 
            this.colIsRead.Caption = "Is Read?";
            this.colIsRead.FieldName = "IsRead";
            this.colIsRead.Name = "colIsRead";
            this.colIsRead.OptionsColumn.AllowEdit = false;
            this.colIsRead.Visible = true;
            this.colIsRead.VisibleIndex = 3;
            this.colIsRead.Width = 200;
            // 
            // gridControlUnReadNotes
            // 
            this.gridControlUnReadNotes.Location = new System.Drawing.Point(3, 279);
            this.gridControlUnReadNotes.MainView = this.gridViewUnReadNotes;
            this.gridControlUnReadNotes.Name = "gridControlUnReadNotes";
            this.gridControlUnReadNotes.Size = new System.Drawing.Size(930, 263);
            this.gridControlUnReadNotes.TabIndex = 2;
            this.gridControlUnReadNotes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewUnReadNotes});
            // 
            // gridViewUnReadNotes
            // 
            this.gridViewUnReadNotes.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gridViewUnReadNotes.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewUnReadNotes.Appearance.FooterPanel.Options.UseFont = true;
            this.gridViewUnReadNotes.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridViewUnReadNotes.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewUnReadNotes.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridViewUnReadNotes.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewUnReadNotes.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewUnReadNotes.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewUnReadNotes.Appearance.ViewCaption.Options.UseForeColor = true;
            this.gridViewUnReadNotes.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUnReadNoteId,
            this.colUnReadTitle,
            this.colUnReadContent,
            this.colUnReadIsRead});
            this.gridViewUnReadNotes.GridControl = this.gridControlUnReadNotes;
            this.gridViewUnReadNotes.Name = "gridViewUnReadNotes";
            this.gridViewUnReadNotes.OptionsMenu.EnableColumnMenu = false;
            this.gridViewUnReadNotes.OptionsMenu.EnableFooterMenu = false;
            this.gridViewUnReadNotes.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridViewUnReadNotes.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridViewUnReadNotes.OptionsPrint.AutoWidth = false;
            this.gridViewUnReadNotes.OptionsPrint.PrintFooter = false;
            this.gridViewUnReadNotes.OptionsPrint.PrintGroupFooter = false;
            this.gridViewUnReadNotes.OptionsView.ColumnAutoWidth = false;
            this.gridViewUnReadNotes.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.gridViewUnReadNotes.OptionsView.RowAutoHeight = true;
            this.gridViewUnReadNotes.OptionsView.ShowAutoFilterRow = true;
            this.gridViewUnReadNotes.OptionsView.ShowGroupPanel = false;
            this.gridViewUnReadNotes.OptionsView.ShowViewCaption = true;
            this.gridViewUnReadNotes.ViewCaption = "Unread Notes";
            this.gridViewUnReadNotes.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewUnReadNotes_FocusedRowChanged);
            // 
            // colUnReadNoteId
            // 
            this.colUnReadNoteId.Caption = "Note ID";
            this.colUnReadNoteId.FieldName = "NoteId";
            this.colUnReadNoteId.Name = "colUnReadNoteId";
            this.colUnReadNoteId.OptionsColumn.AllowEdit = false;
            this.colUnReadNoteId.Visible = true;
            this.colUnReadNoteId.VisibleIndex = 0;
            this.colUnReadNoteId.Width = 200;
            // 
            // colUnReadTitle
            // 
            this.colUnReadTitle.Caption = "Title";
            this.colUnReadTitle.FieldName = "Title";
            this.colUnReadTitle.Name = "colUnReadTitle";
            this.colUnReadTitle.OptionsColumn.AllowEdit = false;
            this.colUnReadTitle.Visible = true;
            this.colUnReadTitle.VisibleIndex = 1;
            this.colUnReadTitle.Width = 200;
            // 
            // colUnReadContent
            // 
            this.colUnReadContent.Caption = "Note Content";
            this.colUnReadContent.FieldName = "NoteContent";
            this.colUnReadContent.Name = "colUnReadContent";
            this.colUnReadContent.OptionsColumn.AllowEdit = false;
            this.colUnReadContent.Visible = true;
            this.colUnReadContent.VisibleIndex = 2;
            this.colUnReadContent.Width = 280;
            // 
            // colUnReadIsRead
            // 
            this.colUnReadIsRead.Caption = "Is Read?";
            this.colUnReadIsRead.FieldName = "IsRead";
            this.colUnReadIsRead.Name = "colUnReadIsRead";
            this.colUnReadIsRead.OptionsColumn.AllowEdit = false;
            this.colUnReadIsRead.Visible = true;
            this.colUnReadIsRead.VisibleIndex = 3;
            this.colUnReadIsRead.Width = 200;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.myDataLayoutControl1);
            this.panelControl1.Location = new System.Drawing.Point(939, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(349, 374);
            this.panelControl1.TabIndex = 3;
            // 
            // myDataLayoutControl1
            // 
            this.myDataLayoutControl1.Controls.Add(this.toogleSwitchIsRead);
            this.myDataLayoutControl1.Controls.Add(this.memoNoteContent);
            this.myDataLayoutControl1.Controls.Add(this.txtNoteTitle);
            this.myDataLayoutControl1.Controls.Add(this.txtNoteId);
            this.myDataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myDataLayoutControl1.Location = new System.Drawing.Point(2, 2);
            this.myDataLayoutControl1.Name = "myDataLayoutControl1";
            this.myDataLayoutControl1.OptionsFocus.EnableAutoTabOrder = false;
            this.myDataLayoutControl1.Root = this.Root;
            this.myDataLayoutControl1.Size = new System.Drawing.Size(345, 370);
            this.myDataLayoutControl1.TabIndex = 0;
            this.myDataLayoutControl1.Text = "myDataLayoutControl1";
            // 
            // toogleSwitchIsRead
            // 
            this.toogleSwitchIsRead.EnterMoveNextControl = true;
            this.toogleSwitchIsRead.Location = new System.Drawing.Point(89, 310);
            this.toogleSwitchIsRead.Name = "toogleSwitchIsRead";
            this.toogleSwitchIsRead.Properties.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.toogleSwitchIsRead.Properties.Appearance.Options.UseForeColor = true;
            this.toogleSwitchIsRead.Properties.AutoHeight = false;
            this.toogleSwitchIsRead.Properties.AutoWidth = true;
            this.toogleSwitchIsRead.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.toogleSwitchIsRead.Properties.OffText = "Unread";
            this.toogleSwitchIsRead.Properties.OnText = "Read";
            this.toogleSwitchIsRead.Size = new System.Drawing.Size(88, 20);
            this.toogleSwitchIsRead.StyleController = this.myDataLayoutControl1;
            this.toogleSwitchIsRead.TabIndex = 7;
            // 
            // memoNoteContent
            // 
            this.memoNoteContent.EnterMoveNextControl = true;
            this.memoNoteContent.Location = new System.Drawing.Point(89, 60);
            this.memoNoteContent.Name = "memoNoteContent";
            this.memoNoteContent.Properties.Appearance.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.memoNoteContent.Properties.Appearance.Options.UseBackColor = true;
            this.memoNoteContent.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.memoNoteContent.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.memoNoteContent.Properties.MaxLength = 500;
            this.memoNoteContent.Size = new System.Drawing.Size(244, 246);
            this.memoNoteContent.StyleController = this.myDataLayoutControl1;
            this.memoNoteContent.TabIndex = 6;
            // 
            // txtNoteTitle
            // 
            this.txtNoteTitle.EnterMoveNextControl = true;
            this.txtNoteTitle.Location = new System.Drawing.Point(89, 36);
            this.txtNoteTitle.Name = "txtNoteTitle";
            this.txtNoteTitle.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtNoteTitle.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtNoteTitle.Size = new System.Drawing.Size(244, 20);
            this.txtNoteTitle.StyleController = this.myDataLayoutControl1;
            this.txtNoteTitle.TabIndex = 5;
            // 
            // txtNoteId
            // 
            this.txtNoteId.EnterMoveNextControl = true;
            this.txtNoteId.Location = new System.Drawing.Point(89, 12);
            this.txtNoteId.Name = "txtNoteId";
            this.txtNoteId.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtNoteId.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtNoteId.Properties.ReadOnly = true;
            this.txtNoteId.Size = new System.Drawing.Size(244, 20);
            this.txtNoteId.StyleController = this.myDataLayoutControl1;
            this.txtNoteId.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4});
            this.Root.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
            this.Root.Name = "Root";
            columnDefinition1.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition1.Width = 200D;
            this.Root.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition1});
            rowDefinition1.Height = 24D;
            rowDefinition1.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition2.Height = 24D;
            rowDefinition2.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition3.Height = 250D;
            rowDefinition3.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition4.Height = 24D;
            rowDefinition4.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition5.Height = 24D;
            rowDefinition5.SizeType = System.Windows.Forms.SizeType.Absolute;
            this.Root.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition1,
            rowDefinition2,
            rowDefinition3,
            rowDefinition4,
            rowDefinition5});
            this.Root.Size = new System.Drawing.Size(345, 370);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem1.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem1.Control = this.txtNoteId;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(325, 24);
            this.layoutControlItem1.Text = "Note ID";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(65, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem2.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem2.Control = this.txtNoteTitle;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlItem2.Size = new System.Drawing.Size(325, 24);
            this.layoutControlItem2.Text = "Title";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(65, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem3.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem3.Control = this.memoNoteContent;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.OptionsTableLayoutItem.RowIndex = 2;
            this.layoutControlItem3.Size = new System.Drawing.Size(325, 250);
            this.layoutControlItem3.Text = "Note Content";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(65, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem4.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem4.Control = this.toogleSwitchIsRead;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 298);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.OptionsTableLayoutItem.RowIndex = 3;
            this.layoutControlItem4.Size = new System.Drawing.Size(325, 24);
            this.layoutControlItem4.Text = "Is Read";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(65, 13);
            // 
            // btnAddNote
            // 
            this.btnAddNote.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.btnAddNote.Appearance.Options.UseForeColor = true;
            this.btnAddNote.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNote.ImageOptions.Image")));
            this.btnAddNote.Location = new System.Drawing.Point(1032, 392);
            this.btnAddNote.Name = "btnAddNote";
            this.btnAddNote.Size = new System.Drawing.Size(114, 23);
            this.btnAddNote.TabIndex = 4;
            this.btnAddNote.Text = "Add Note";
            this.btnAddNote.Click += new System.EventHandler(this.btnAddNote_Click);
            // 
            // btnUpdateNote
            // 
            this.btnUpdateNote.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.btnUpdateNote.Appearance.Options.UseForeColor = true;
            this.btnUpdateNote.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateNote.ImageOptions.Image")));
            this.btnUpdateNote.Location = new System.Drawing.Point(1160, 392);
            this.btnUpdateNote.Name = "btnUpdateNote";
            this.btnUpdateNote.Size = new System.Drawing.Size(114, 23);
            this.btnUpdateNote.TabIndex = 5;
            this.btnUpdateNote.Text = "Update Note";
            this.btnUpdateNote.Click += new System.EventHandler(this.btnUpdateNote_Click);
            // 
            // btnDeleteNote
            // 
            this.btnDeleteNote.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.btnDeleteNote.Appearance.Options.UseForeColor = true;
            this.btnDeleteNote.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteNote.ImageOptions.Image")));
            this.btnDeleteNote.Location = new System.Drawing.Point(1032, 429);
            this.btnDeleteNote.Name = "btnDeleteNote";
            this.btnDeleteNote.Size = new System.Drawing.Size(114, 23);
            this.btnDeleteNote.TabIndex = 6;
            this.btnDeleteNote.Text = "Delete Note";
            this.btnDeleteNote.Click += new System.EventHandler(this.btnDeleteNote_Click);
            // 
            // btnClearNotes
            // 
            this.btnClearNotes.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.btnClearNotes.Appearance.Options.UseForeColor = true;
            this.btnClearNotes.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClearNotes.ImageOptions.Image")));
            this.btnClearNotes.Location = new System.Drawing.Point(1160, 429);
            this.btnClearNotes.Name = "btnClearNotes";
            this.btnClearNotes.Size = new System.Drawing.Size(114, 23);
            this.btnClearNotes.TabIndex = 7;
            this.btnClearNotes.Text = "Clear Notes";
            this.btnClearNotes.Click += new System.EventHandler(this.btnClearNotes_Click);
            // 
            // NotesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 543);
            this.Controls.Add(this.btnClearNotes);
            this.Controls.Add(this.btnDeleteNote);
            this.Controls.Add(this.btnUpdateNote);
            this.Controls.Add(this.btnAddNote);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.gridControlUnReadNotes);
            this.Controls.Add(this.gridControlReadNotes);
            this.Name = "NotesForm";
            this.Text = "Notes";
            this.Load += new System.EventHandler(this.NotesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlReadNotes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewReadNotes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlUnReadNotes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUnReadNotes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl1)).EndInit();
            this.myDataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.toogleSwitchIsRead.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoNoteContent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoteTitle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoteId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.MyGridControl gridControlReadNotes;
        private Controls.MyGridView gridViewReadNotes;
        private Controls.MyGridControl gridControlUnReadNotes;
        private Controls.MyGridView gridViewUnReadNotes;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private Controls.MyDataLayoutControl myDataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private Controls.MyToogleSwitch toogleSwitchIsRead;
        private Controls.MyMemoEdit memoNoteContent;
        private Controls.MyTextBox txtNoteTitle;
        private Controls.MyTextBox txtNoteId;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private Controls.MySimpleButton btnAddNote;
        private Controls.MySimpleButton btnUpdateNote;
        private Controls.MySimpleButton btnDeleteNote;
        private Controls.MySimpleButton btnClearNotes;
        private Controls.MyGridColumn colNoteId;
        private Controls.MyGridColumn colTitle;
        private Controls.MyGridColumn colNoteContent;
        private Controls.MyGridColumn colIsRead;
        private Controls.MyGridColumn colUnReadNoteId;
        private Controls.MyGridColumn colUnReadTitle;
        private Controls.MyGridColumn colUnReadContent;
        private Controls.MyGridColumn colUnReadIsRead;
    }
}