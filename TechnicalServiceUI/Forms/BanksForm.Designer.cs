namespace TechnicalServiceUI.Forms
{
    partial class BanksForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BanksForm));
            DevExpress.XtraLayout.ColumnDefinition columnDefinition1 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition1 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition2 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition3 = new DevExpress.XtraLayout.RowDefinition();
            this.colBankDescription = new TechnicalServiceUI.Controls.MyGridColumn();
            this.colBankId = new TechnicalServiceUI.Controls.MyGridColumn();
            this.gridViewBanks = new TechnicalServiceUI.Controls.MyGridView();
            this.colBankName = new TechnicalServiceUI.Controls.MyGridColumn();
            this.gridControlBanks = new TechnicalServiceUI.Controls.MyGridControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnClearBank = new TechnicalServiceUI.Controls.MySimpleButton();
            this.btnDeleteBank = new TechnicalServiceUI.Controls.MySimpleButton();
            this.btnUpdateBank = new TechnicalServiceUI.Controls.MySimpleButton();
            this.btnAddBank = new TechnicalServiceUI.Controls.MySimpleButton();
            this.myDataLayoutControl1 = new TechnicalServiceUI.Controls.MyDataLayoutControl();
            this.memoEditBankDescription = new TechnicalServiceUI.Controls.MyMemoEdit();
            this.txtBankName = new TechnicalServiceUI.Controls.MyTextBox();
            this.txtBankId = new TechnicalServiceUI.Controls.MyTextBox();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBanks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlBanks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl1)).BeginInit();
            this.myDataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditBankDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // colBankDescription
            // 
            this.colBankDescription.Caption = "Bank Description";
            this.colBankDescription.FieldName = "BankDescription";
            this.colBankDescription.Name = "colBankDescription";
            this.colBankDescription.OptionsColumn.AllowEdit = false;
            this.colBankDescription.Visible = true;
            this.colBankDescription.VisibleIndex = 2;
            this.colBankDescription.Width = 410;
            // 
            // colBankId
            // 
            this.colBankId.Caption = "Bank ID";
            this.colBankId.FieldName = "BankId";
            this.colBankId.Name = "colBankId";
            this.colBankId.OptionsColumn.AllowEdit = false;
            this.colBankId.Visible = true;
            this.colBankId.VisibleIndex = 0;
            this.colBankId.Width = 200;
            // 
            // gridViewBanks
            // 
            this.gridViewBanks.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gridViewBanks.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewBanks.Appearance.FooterPanel.Options.UseFont = true;
            this.gridViewBanks.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridViewBanks.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewBanks.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridViewBanks.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewBanks.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewBanks.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewBanks.Appearance.ViewCaption.Options.UseForeColor = true;
            this.gridViewBanks.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colBankId,
            this.colBankName,
            this.colBankDescription});
            this.gridViewBanks.GridControl = this.gridControlBanks;
            this.gridViewBanks.Name = "gridViewBanks";
            this.gridViewBanks.OptionsMenu.EnableColumnMenu = false;
            this.gridViewBanks.OptionsMenu.EnableFooterMenu = false;
            this.gridViewBanks.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridViewBanks.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridViewBanks.OptionsPrint.AutoWidth = false;
            this.gridViewBanks.OptionsPrint.PrintFooter = false;
            this.gridViewBanks.OptionsPrint.PrintGroupFooter = false;
            this.gridViewBanks.OptionsView.ColumnAutoWidth = false;
            this.gridViewBanks.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.gridViewBanks.OptionsView.RowAutoHeight = true;
            this.gridViewBanks.OptionsView.ShowAutoFilterRow = true;
            this.gridViewBanks.OptionsView.ShowGroupPanel = false;
            this.gridViewBanks.OptionsView.ShowViewCaption = true;
            this.gridViewBanks.ViewCaption = "Banks";
            this.gridViewBanks.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewBanks_FocusedRowChanged);
            // 
            // colBankName
            // 
            this.colBankName.Caption = "Bank Name";
            this.colBankName.FieldName = "BankName";
            this.colBankName.Name = "colBankName";
            this.colBankName.OptionsColumn.AllowEdit = false;
            this.colBankName.Visible = true;
            this.colBankName.VisibleIndex = 1;
            this.colBankName.Width = 200;
            // 
            // gridControlBanks
            // 
            this.gridControlBanks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlBanks.Location = new System.Drawing.Point(2, 2);
            this.gridControlBanks.MainView = this.gridViewBanks;
            this.gridControlBanks.Name = "gridControlBanks";
            this.gridControlBanks.Size = new System.Drawing.Size(856, 525);
            this.gridControlBanks.TabIndex = 0;
            this.gridControlBanks.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewBanks});
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnClearBank);
            this.panelControl2.Controls.Add(this.btnDeleteBank);
            this.panelControl2.Controls.Add(this.btnUpdateBank);
            this.panelControl2.Controls.Add(this.btnAddBank);
            this.panelControl2.Controls.Add(this.myDataLayoutControl1);
            this.panelControl2.Location = new System.Drawing.Point(879, 7);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(400, 527);
            this.panelControl2.TabIndex = 6;
            // 
            // btnClearBank
            // 
            this.btnClearBank.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.btnClearBank.Appearance.Options.UseForeColor = true;
            this.btnClearBank.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClearBank.ImageOptions.Image")));
            this.btnClearBank.Location = new System.Drawing.Point(98, 409);
            this.btnClearBank.Name = "btnClearBank";
            this.btnClearBank.Size = new System.Drawing.Size(288, 25);
            this.btnClearBank.TabIndex = 3;
            this.btnClearBank.Text = "Clear Banks";
            this.btnClearBank.Click += new System.EventHandler(this.btnClearBank_Click);
            // 
            // btnDeleteBank
            // 
            this.btnDeleteBank.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.btnDeleteBank.Appearance.Options.UseForeColor = true;
            this.btnDeleteBank.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteBank.ImageOptions.Image")));
            this.btnDeleteBank.Location = new System.Drawing.Point(98, 378);
            this.btnDeleteBank.Name = "btnDeleteBank";
            this.btnDeleteBank.Size = new System.Drawing.Size(288, 25);
            this.btnDeleteBank.TabIndex = 2;
            this.btnDeleteBank.Text = "Delete Bank";
            this.btnDeleteBank.Click += new System.EventHandler(this.btnDeleteBank_Click);
            // 
            // btnUpdateBank
            // 
            this.btnUpdateBank.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.btnUpdateBank.Appearance.Options.UseForeColor = true;
            this.btnUpdateBank.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateBank.ImageOptions.Image")));
            this.btnUpdateBank.Location = new System.Drawing.Point(98, 347);
            this.btnUpdateBank.Name = "btnUpdateBank";
            this.btnUpdateBank.Size = new System.Drawing.Size(288, 25);
            this.btnUpdateBank.TabIndex = 1;
            this.btnUpdateBank.Text = "Update Bank";
            this.btnUpdateBank.Click += new System.EventHandler(this.btnUpdateBank_Click);
            // 
            // btnAddBank
            // 
            this.btnAddBank.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.btnAddBank.Appearance.Options.UseForeColor = true;
            this.btnAddBank.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddBank.ImageOptions.Image")));
            this.btnAddBank.Location = new System.Drawing.Point(98, 316);
            this.btnAddBank.Name = "btnAddBank";
            this.btnAddBank.Size = new System.Drawing.Size(288, 25);
            this.btnAddBank.TabIndex = 1;
            this.btnAddBank.Text = "Add Bank";
            this.btnAddBank.Click += new System.EventHandler(this.btnAddBank_Click);
            // 
            // myDataLayoutControl1
            // 
            this.myDataLayoutControl1.Controls.Add(this.memoEditBankDescription);
            this.myDataLayoutControl1.Controls.Add(this.txtBankName);
            this.myDataLayoutControl1.Controls.Add(this.txtBankId);
            this.myDataLayoutControl1.Location = new System.Drawing.Point(2, 2);
            this.myDataLayoutControl1.Name = "myDataLayoutControl1";
            this.myDataLayoutControl1.OptionsFocus.EnableAutoTabOrder = false;
            this.myDataLayoutControl1.Root = this.Root;
            this.myDataLayoutControl1.Size = new System.Drawing.Size(396, 303);
            this.myDataLayoutControl1.TabIndex = 0;
            this.myDataLayoutControl1.Text = "myDataLayoutControl1";
            // 
            // memoEditBankDescription
            // 
            this.memoEditBankDescription.EnterMoveNextControl = true;
            this.memoEditBankDescription.Location = new System.Drawing.Point(103, 60);
            this.memoEditBankDescription.Name = "memoEditBankDescription";
            this.memoEditBankDescription.Properties.Appearance.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.memoEditBankDescription.Properties.Appearance.Options.UseBackColor = true;
            this.memoEditBankDescription.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.memoEditBankDescription.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.memoEditBankDescription.Properties.MaxLength = 500;
            this.memoEditBankDescription.Size = new System.Drawing.Size(281, 231);
            this.memoEditBankDescription.StyleController = this.myDataLayoutControl1;
            this.memoEditBankDescription.TabIndex = 6;
            // 
            // txtBankName
            // 
            this.txtBankName.EnterMoveNextControl = true;
            this.txtBankName.Location = new System.Drawing.Point(103, 36);
            this.txtBankName.Name = "txtBankName";
            this.txtBankName.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtBankName.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtBankName.Size = new System.Drawing.Size(281, 20);
            this.txtBankName.StyleController = this.myDataLayoutControl1;
            this.txtBankName.TabIndex = 5;
            // 
            // txtBankId
            // 
            this.txtBankId.EnterMoveNextControl = true;
            this.txtBankId.Location = new System.Drawing.Point(103, 12);
            this.txtBankId.Name = "txtBankId";
            this.txtBankId.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtBankId.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtBankId.Properties.ReadOnly = true;
            this.txtBankId.Size = new System.Drawing.Size(281, 20);
            this.txtBankId.StyleController = this.myDataLayoutControl1;
            this.txtBankId.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3});
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
            this.Root.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition1,
            rowDefinition2,
            rowDefinition3});
            this.Root.Size = new System.Drawing.Size(396, 303);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem1.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem1.Control = this.txtBankId;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(376, 24);
            this.layoutControlItem1.Text = "Bank ID";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(79, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem2.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem2.Control = this.txtBankName;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlItem2.Size = new System.Drawing.Size(376, 24);
            this.layoutControlItem2.Text = "Bank Name";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(79, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem3.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem3.Control = this.memoEditBankDescription;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.OptionsTableLayoutItem.RowIndex = 2;
            this.layoutControlItem3.Size = new System.Drawing.Size(376, 235);
            this.layoutControlItem3.Text = "Bank Description";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(79, 13);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gridControlBanks);
            this.panelControl1.Location = new System.Drawing.Point(14, 7);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(860, 529);
            this.panelControl1.TabIndex = 5;
            // 
            // BanksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 543);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "BanksForm";
            this.Text = "Banks";
            this.Load += new System.EventHandler(this.BanksForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBanks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlBanks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl1)).EndInit();
            this.myDataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.memoEditBankDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.MyGridColumn colBankDescription;
        private Controls.MyGridColumn colBankId;
        private Controls.MyGridView gridViewBanks;
        private Controls.MyGridColumn colBankName;
        private Controls.MyGridControl gridControlBanks;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private Controls.MySimpleButton btnClearBank;
        private Controls.MySimpleButton btnDeleteBank;
        private Controls.MySimpleButton btnUpdateBank;
        private Controls.MySimpleButton btnAddBank;
        private Controls.MyDataLayoutControl myDataLayoutControl1;
        private Controls.MyMemoEdit memoEditBankDescription;
        private Controls.MyTextBox txtBankName;
        private Controls.MyTextBox txtBankId;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.PanelControl panelControl1;
    }
}