namespace TechnicalServiceUI.Forms
{
    partial class MalfunctionTrackingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MalfunctionTrackingsForm));
            DevExpress.XtraLayout.ColumnDefinition columnDefinition1 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition1 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition2 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition3 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition4 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition5 = new DevExpress.XtraLayout.RowDefinition();
            this.gridControlMalfunctionTrackings = new TechnicalServiceUI.Controls.MyGridControl();
            this.gridViewMalfunctionTracking = new TechnicalServiceUI.Controls.MyGridView();
            this.colMalfunctionTrackingId = new TechnicalServiceUI.Controls.MyGridColumn();
            this.colTrackingDate = new TechnicalServiceUI.Controls.MyGridColumn();
            this.colProductSeriesNumber = new TechnicalServiceUI.Controls.MyGridColumn();
            this.colDescription = new TechnicalServiceUI.Controls.MyGridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnDeleteMalfunctionTracking = new TechnicalServiceUI.Controls.MySimpleButton();
            this.btnClearMalfunctionTrackings = new TechnicalServiceUI.Controls.MySimpleButton();
            this.btnUpdateMalfunctionTracking = new TechnicalServiceUI.Controls.MySimpleButton();
            this.btnAddMalfunctionTracking = new TechnicalServiceUI.Controls.MySimpleButton();
            this.myDataLayoutControl1 = new TechnicalServiceUI.Controls.MyDataLayoutControl();
            this.memoDescription = new TechnicalServiceUI.Controls.MyMemoEdit();
            this.txtProductSeriesNumber = new TechnicalServiceUI.Controls.MyTextBox();
            this.deTrackingDate = new TechnicalServiceUI.Controls.MyDateEdit();
            this.txtTrackingId = new TechnicalServiceUI.Controls.MyTextBox();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMalfunctionTrackings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMalfunctionTracking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl1)).BeginInit();
            this.myDataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductSeriesNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTrackingDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTrackingDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTrackingId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlMalfunctionTrackings
            // 
            this.gridControlMalfunctionTrackings.Dock = System.Windows.Forms.DockStyle.Left;
            this.gridControlMalfunctionTrackings.Location = new System.Drawing.Point(0, 0);
            this.gridControlMalfunctionTrackings.MainView = this.gridViewMalfunctionTracking;
            this.gridControlMalfunctionTrackings.Name = "gridControlMalfunctionTrackings";
            this.gridControlMalfunctionTrackings.Size = new System.Drawing.Size(956, 543);
            this.gridControlMalfunctionTrackings.TabIndex = 0;
            this.gridControlMalfunctionTrackings.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMalfunctionTracking});
            // 
            // gridViewMalfunctionTracking
            // 
            this.gridViewMalfunctionTracking.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gridViewMalfunctionTracking.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewMalfunctionTracking.Appearance.FooterPanel.Options.UseFont = true;
            this.gridViewMalfunctionTracking.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridViewMalfunctionTracking.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewMalfunctionTracking.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridViewMalfunctionTracking.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewMalfunctionTracking.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewMalfunctionTracking.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewMalfunctionTracking.Appearance.ViewCaption.Options.UseForeColor = true;
            this.gridViewMalfunctionTracking.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMalfunctionTrackingId,
            this.colTrackingDate,
            this.colProductSeriesNumber,
            this.colDescription});
            this.gridViewMalfunctionTracking.GridControl = this.gridControlMalfunctionTrackings;
            this.gridViewMalfunctionTracking.Name = "gridViewMalfunctionTracking";
            this.gridViewMalfunctionTracking.OptionsMenu.EnableColumnMenu = false;
            this.gridViewMalfunctionTracking.OptionsMenu.EnableFooterMenu = false;
            this.gridViewMalfunctionTracking.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridViewMalfunctionTracking.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridViewMalfunctionTracking.OptionsPrint.AutoWidth = false;
            this.gridViewMalfunctionTracking.OptionsPrint.PrintFooter = false;
            this.gridViewMalfunctionTracking.OptionsPrint.PrintGroupFooter = false;
            this.gridViewMalfunctionTracking.OptionsView.ColumnAutoWidth = false;
            this.gridViewMalfunctionTracking.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.gridViewMalfunctionTracking.OptionsView.RowAutoHeight = true;
            this.gridViewMalfunctionTracking.OptionsView.ShowAutoFilterRow = true;
            this.gridViewMalfunctionTracking.OptionsView.ShowGroupPanel = false;
            this.gridViewMalfunctionTracking.OptionsView.ShowViewCaption = true;
            this.gridViewMalfunctionTracking.ViewCaption = "Malfunction Trackings";
            this.gridViewMalfunctionTracking.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewMalfunctionTracking_FocusedRowChanged);
            // 
            // colMalfunctionTrackingId
            // 
            this.colMalfunctionTrackingId.Caption = "Tracking ID";
            this.colMalfunctionTrackingId.FieldName = "TrackingId";
            this.colMalfunctionTrackingId.Name = "colMalfunctionTrackingId";
            this.colMalfunctionTrackingId.OptionsColumn.AllowEdit = false;
            this.colMalfunctionTrackingId.Visible = true;
            this.colMalfunctionTrackingId.VisibleIndex = 0;
            this.colMalfunctionTrackingId.Width = 150;
            // 
            // colTrackingDate
            // 
            this.colTrackingDate.Caption = "Tracking Date";
            this.colTrackingDate.FieldName = "Date";
            this.colTrackingDate.Name = "colTrackingDate";
            this.colTrackingDate.OptionsColumn.AllowEdit = false;
            this.colTrackingDate.Visible = true;
            this.colTrackingDate.VisibleIndex = 1;
            this.colTrackingDate.Width = 150;
            // 
            // colProductSeriesNumber
            // 
            this.colProductSeriesNumber.Caption = "Product Series Number";
            this.colProductSeriesNumber.FieldName = "ProductSeriesNumber";
            this.colProductSeriesNumber.Name = "colProductSeriesNumber";
            this.colProductSeriesNumber.OptionsColumn.AllowEdit = false;
            this.colProductSeriesNumber.Visible = true;
            this.colProductSeriesNumber.VisibleIndex = 2;
            this.colProductSeriesNumber.Width = 150;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Description";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.OptionsColumn.AllowEdit = false;
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 3;
            this.colDescription.Width = 460;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnDeleteMalfunctionTracking);
            this.panelControl1.Controls.Add(this.btnClearMalfunctionTrackings);
            this.panelControl1.Controls.Add(this.btnUpdateMalfunctionTracking);
            this.panelControl1.Controls.Add(this.btnAddMalfunctionTracking);
            this.panelControl1.Controls.Add(this.myDataLayoutControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(956, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(337, 543);
            this.panelControl1.TabIndex = 1;
            // 
            // btnDeleteMalfunctionTracking
            // 
            this.btnDeleteMalfunctionTracking.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.btnDeleteMalfunctionTracking.Appearance.Options.UseForeColor = true;
            this.btnDeleteMalfunctionTracking.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteMalfunctionTracking.ImageOptions.Image")));
            this.btnDeleteMalfunctionTracking.Location = new System.Drawing.Point(135, 332);
            this.btnDeleteMalfunctionTracking.Name = "btnDeleteMalfunctionTracking";
            this.btnDeleteMalfunctionTracking.Size = new System.Drawing.Size(188, 23);
            this.btnDeleteMalfunctionTracking.TabIndex = 4;
            this.btnDeleteMalfunctionTracking.Text = "Delete Malfunction Tracking";
            this.btnDeleteMalfunctionTracking.Click += new System.EventHandler(this.btnDeleteMalfunctionTracking_Click);
            // 
            // btnClearMalfunctionTrackings
            // 
            this.btnClearMalfunctionTrackings.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.btnClearMalfunctionTrackings.Appearance.Options.UseForeColor = true;
            this.btnClearMalfunctionTrackings.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClearMalfunctionTrackings.ImageOptions.Image")));
            this.btnClearMalfunctionTrackings.Location = new System.Drawing.Point(135, 361);
            this.btnClearMalfunctionTrackings.Name = "btnClearMalfunctionTrackings";
            this.btnClearMalfunctionTrackings.Size = new System.Drawing.Size(188, 23);
            this.btnClearMalfunctionTrackings.TabIndex = 3;
            this.btnClearMalfunctionTrackings.Text = "Clear All";
            this.btnClearMalfunctionTrackings.Click += new System.EventHandler(this.btnClearMalfunctionTrackings_Click);
            // 
            // btnUpdateMalfunctionTracking
            // 
            this.btnUpdateMalfunctionTracking.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.btnUpdateMalfunctionTracking.Appearance.Options.UseForeColor = true;
            this.btnUpdateMalfunctionTracking.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateMalfunctionTracking.ImageOptions.Image")));
            this.btnUpdateMalfunctionTracking.Location = new System.Drawing.Point(135, 303);
            this.btnUpdateMalfunctionTracking.Name = "btnUpdateMalfunctionTracking";
            this.btnUpdateMalfunctionTracking.Size = new System.Drawing.Size(188, 23);
            this.btnUpdateMalfunctionTracking.TabIndex = 2;
            this.btnUpdateMalfunctionTracking.Text = "Update Malfunction Tracking";
            this.btnUpdateMalfunctionTracking.Click += new System.EventHandler(this.btnUpdateMalfunctionTracking_Click);
            // 
            // btnAddMalfunctionTracking
            // 
            this.btnAddMalfunctionTracking.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.btnAddMalfunctionTracking.Appearance.Options.UseForeColor = true;
            this.btnAddMalfunctionTracking.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddMalfunctionTracking.ImageOptions.Image")));
            this.btnAddMalfunctionTracking.Location = new System.Drawing.Point(135, 274);
            this.btnAddMalfunctionTracking.Name = "btnAddMalfunctionTracking";
            this.btnAddMalfunctionTracking.Size = new System.Drawing.Size(188, 23);
            this.btnAddMalfunctionTracking.TabIndex = 1;
            this.btnAddMalfunctionTracking.Text = "Add Malfunction Tracking";
            this.btnAddMalfunctionTracking.Click += new System.EventHandler(this.btnAddMalfunctionTracking_Click);
            // 
            // myDataLayoutControl1
            // 
            this.myDataLayoutControl1.Controls.Add(this.memoDescription);
            this.myDataLayoutControl1.Controls.Add(this.txtProductSeriesNumber);
            this.myDataLayoutControl1.Controls.Add(this.deTrackingDate);
            this.myDataLayoutControl1.Controls.Add(this.txtTrackingId);
            this.myDataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.myDataLayoutControl1.Location = new System.Drawing.Point(2, 2);
            this.myDataLayoutControl1.Name = "myDataLayoutControl1";
            this.myDataLayoutControl1.OptionsFocus.EnableAutoTabOrder = false;
            this.myDataLayoutControl1.Root = this.Root;
            this.myDataLayoutControl1.Size = new System.Drawing.Size(333, 266);
            this.myDataLayoutControl1.TabIndex = 0;
            this.myDataLayoutControl1.Text = "myDataLayoutControl1";
            // 
            // memoDescription
            // 
            this.memoDescription.EnterMoveNextControl = true;
            this.memoDescription.Location = new System.Drawing.Point(133, 84);
            this.memoDescription.Name = "memoDescription";
            this.memoDescription.Properties.Appearance.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.memoDescription.Properties.Appearance.Options.UseBackColor = true;
            this.memoDescription.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.memoDescription.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.memoDescription.Properties.MaxLength = 500;
            this.memoDescription.Size = new System.Drawing.Size(188, 146);
            this.memoDescription.StyleController = this.myDataLayoutControl1;
            this.memoDescription.TabIndex = 7;
            // 
            // txtProductSeriesNumber
            // 
            this.txtProductSeriesNumber.EnterMoveNextControl = true;
            this.txtProductSeriesNumber.Location = new System.Drawing.Point(133, 60);
            this.txtProductSeriesNumber.Name = "txtProductSeriesNumber";
            this.txtProductSeriesNumber.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtProductSeriesNumber.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtProductSeriesNumber.Size = new System.Drawing.Size(188, 20);
            this.txtProductSeriesNumber.StyleController = this.myDataLayoutControl1;
            this.txtProductSeriesNumber.TabIndex = 6;
            // 
            // deTrackingDate
            // 
            this.deTrackingDate.EditValue = null;
            this.deTrackingDate.EnterMoveNextControl = true;
            this.deTrackingDate.Location = new System.Drawing.Point(133, 36);
            this.deTrackingDate.Name = "deTrackingDate";
            this.deTrackingDate.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.deTrackingDate.Properties.Appearance.Options.UseTextOptions = true;
            this.deTrackingDate.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.deTrackingDate.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.deTrackingDate.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.deTrackingDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deTrackingDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deTrackingDate.Size = new System.Drawing.Size(188, 20);
            this.deTrackingDate.StyleController = this.myDataLayoutControl1;
            this.deTrackingDate.TabIndex = 5;
            // 
            // txtTrackingId
            // 
            this.txtTrackingId.EditValue = "";
            this.txtTrackingId.EnterMoveNextControl = true;
            this.txtTrackingId.Location = new System.Drawing.Point(133, 12);
            this.txtTrackingId.Name = "txtTrackingId";
            this.txtTrackingId.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtTrackingId.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtTrackingId.Properties.ReadOnly = true;
            this.txtTrackingId.Size = new System.Drawing.Size(188, 20);
            this.txtTrackingId.StyleController = this.myDataLayoutControl1;
            this.txtTrackingId.TabIndex = 4;
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
            rowDefinition3.Height = 24D;
            rowDefinition3.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition4.Height = 150D;
            rowDefinition4.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition5.Height = 24D;
            rowDefinition5.SizeType = System.Windows.Forms.SizeType.Absolute;
            this.Root.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition1,
            rowDefinition2,
            rowDefinition3,
            rowDefinition4,
            rowDefinition5});
            this.Root.Size = new System.Drawing.Size(333, 266);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem1.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem1.Control = this.txtTrackingId;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(313, 24);
            this.layoutControlItem1.Text = "Tracking ID";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(109, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem2.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem2.Control = this.deTrackingDate;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlItem2.Size = new System.Drawing.Size(313, 24);
            this.layoutControlItem2.Text = "Tracking Date";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(109, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem3.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem3.Control = this.txtProductSeriesNumber;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.OptionsTableLayoutItem.RowIndex = 2;
            this.layoutControlItem3.Size = new System.Drawing.Size(313, 24);
            this.layoutControlItem3.Text = "Product Series Number";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(109, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem4.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem4.Control = this.memoDescription;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.OptionsTableLayoutItem.RowIndex = 3;
            this.layoutControlItem4.Size = new System.Drawing.Size(313, 150);
            this.layoutControlItem4.Text = "Description";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(109, 13);
            // 
            // MalfunctionTrackingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 543);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.gridControlMalfunctionTrackings);
            this.Name = "MalfunctionTrackingsForm";
            this.Text = "Malfunction Trackings";
            this.Load += new System.EventHandler(this.MalfunctionTrackingsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMalfunctionTrackings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMalfunctionTracking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl1)).EndInit();
            this.myDataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.memoDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductSeriesNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTrackingDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTrackingDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTrackingId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.MyGridControl gridControlMalfunctionTrackings;
        private Controls.MyGridView gridViewMalfunctionTracking;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private Controls.MyDataLayoutControl myDataLayoutControl1;
        private Controls.MyMemoEdit memoDescription;
        private Controls.MyTextBox txtProductSeriesNumber;
        private Controls.MyDateEdit deTrackingDate;
        private Controls.MyTextBox txtTrackingId;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private Controls.MySimpleButton btnDeleteMalfunctionTracking;
        private Controls.MySimpleButton btnClearMalfunctionTrackings;
        private Controls.MySimpleButton btnUpdateMalfunctionTracking;
        private Controls.MySimpleButton btnAddMalfunctionTracking;
        private Controls.MyGridColumn colMalfunctionTrackingId;
        private Controls.MyGridColumn colTrackingDate;
        private Controls.MyGridColumn colProductSeriesNumber;
        private Controls.MyGridColumn colDescription;
    }
}