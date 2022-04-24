namespace TechnicalServiceUI.Forms
{
    partial class BrandsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrandsForm));
            this.myDataLayoutControl1 = new TechnicalServiceUI.Controls.MyDataLayoutControl();
            this.memoEditBrandDescription = new TechnicalServiceUI.Controls.MyMemoEdit();
            this.txtBrandName = new TechnicalServiceUI.Controls.MyTextBox();
            this.txtBrandId = new TechnicalServiceUI.Controls.MyTextBox();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnClearBrands = new TechnicalServiceUI.Controls.MySimpleButton();
            this.btnDeleteBrand = new TechnicalServiceUI.Controls.MySimpleButton();
            this.btnUpdateBrand = new TechnicalServiceUI.Controls.MySimpleButton();
            this.btnAddBrand = new TechnicalServiceUI.Controls.MySimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gridControlBrands = new TechnicalServiceUI.Controls.MyGridControl();
            this.gridViewBrands = new TechnicalServiceUI.Controls.MyGridView();
            this.colBrandId = new TechnicalServiceUI.Controls.MyGridColumn();
            this.colBrandName = new TechnicalServiceUI.Controls.MyGridColumn();
            this.colBrandDescription = new TechnicalServiceUI.Controls.MyGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl1)).BeginInit();
            this.myDataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditBrandDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBrandName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBrandId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlBrands)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBrands)).BeginInit();
            this.SuspendLayout();
            // 
            // myDataLayoutControl1
            // 
            this.myDataLayoutControl1.Controls.Add(this.memoEditBrandDescription);
            this.myDataLayoutControl1.Controls.Add(this.txtBrandName);
            this.myDataLayoutControl1.Controls.Add(this.txtBrandId);
            this.myDataLayoutControl1.Location = new System.Drawing.Point(2, 2);
            this.myDataLayoutControl1.Name = "myDataLayoutControl1";
            this.myDataLayoutControl1.OptionsFocus.EnableAutoTabOrder = false;
            this.myDataLayoutControl1.Root = this.Root;
            this.myDataLayoutControl1.Size = new System.Drawing.Size(396, 303);
            this.myDataLayoutControl1.TabIndex = 0;
            this.myDataLayoutControl1.Text = "myDataLayoutControl1";
            // 
            // memoEditBrandDescription
            // 
            this.memoEditBrandDescription.EnterMoveNextControl = true;
            this.memoEditBrandDescription.Location = new System.Drawing.Point(108, 60);
            this.memoEditBrandDescription.Name = "memoEditBrandDescription";
            this.memoEditBrandDescription.Properties.Appearance.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.memoEditBrandDescription.Properties.Appearance.Options.UseBackColor = true;
            this.memoEditBrandDescription.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.memoEditBrandDescription.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.memoEditBrandDescription.Properties.MaxLength = 500;
            this.memoEditBrandDescription.Size = new System.Drawing.Size(276, 231);
            this.memoEditBrandDescription.StyleController = this.myDataLayoutControl1;
            this.memoEditBrandDescription.TabIndex = 6;
            // 
            // txtBrandName
            // 
            this.txtBrandName.EnterMoveNextControl = true;
            this.txtBrandName.Location = new System.Drawing.Point(108, 36);
            this.txtBrandName.Name = "txtBrandName";
            this.txtBrandName.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtBrandName.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtBrandName.Size = new System.Drawing.Size(276, 20);
            this.txtBrandName.StyleController = this.myDataLayoutControl1;
            this.txtBrandName.TabIndex = 5;
            // 
            // txtBrandId
            // 
            this.txtBrandId.EnterMoveNextControl = true;
            this.txtBrandId.Location = new System.Drawing.Point(108, 12);
            this.txtBrandId.Name = "txtBrandId";
            this.txtBrandId.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtBrandId.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtBrandId.Properties.ReadOnly = true;
            this.txtBrandId.Size = new System.Drawing.Size(276, 20);
            this.txtBrandId.StyleController = this.myDataLayoutControl1;
            this.txtBrandId.TabIndex = 4;
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
            this.layoutControlItem1.Control = this.txtBrandId;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(376, 24);
            this.layoutControlItem1.Text = "Brand ID";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(84, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem2.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem2.Control = this.txtBrandName;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlItem2.Size = new System.Drawing.Size(376, 24);
            this.layoutControlItem2.Text = "Brand Name";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(84, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem3.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem3.Control = this.memoEditBrandDescription;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.OptionsTableLayoutItem.RowIndex = 2;
            this.layoutControlItem3.Size = new System.Drawing.Size(376, 235);
            this.layoutControlItem3.Text = "Brand Description";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(84, 13);
            // 
            // btnClearBrands
            // 
            this.btnClearBrands.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.btnClearBrands.Appearance.Options.UseForeColor = true;
            this.btnClearBrands.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClearBrands.ImageOptions.Image")));
            this.btnClearBrands.Location = new System.Drawing.Point(98, 409);
            this.btnClearBrands.Name = "btnClearBrands";
            this.btnClearBrands.Size = new System.Drawing.Size(288, 25);
            this.btnClearBrands.TabIndex = 3;
            this.btnClearBrands.Text = "Clear Brands";
            this.btnClearBrands.Click += new System.EventHandler(this.btnClearBrands_Click);
            // 
            // btnDeleteBrand
            // 
            this.btnDeleteBrand.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.btnDeleteBrand.Appearance.Options.UseForeColor = true;
            this.btnDeleteBrand.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteBrand.ImageOptions.Image")));
            this.btnDeleteBrand.Location = new System.Drawing.Point(98, 378);
            this.btnDeleteBrand.Name = "btnDeleteBrand";
            this.btnDeleteBrand.Size = new System.Drawing.Size(288, 25);
            this.btnDeleteBrand.TabIndex = 2;
            this.btnDeleteBrand.Text = "Delete Brand";
            this.btnDeleteBrand.Click += new System.EventHandler(this.btnDeleteBrand_Click);
            // 
            // btnUpdateBrand
            // 
            this.btnUpdateBrand.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.btnUpdateBrand.Appearance.Options.UseForeColor = true;
            this.btnUpdateBrand.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateBrand.ImageOptions.Image")));
            this.btnUpdateBrand.Location = new System.Drawing.Point(98, 347);
            this.btnUpdateBrand.Name = "btnUpdateBrand";
            this.btnUpdateBrand.Size = new System.Drawing.Size(288, 25);
            this.btnUpdateBrand.TabIndex = 1;
            this.btnUpdateBrand.Text = "Update Brand";
            this.btnUpdateBrand.Click += new System.EventHandler(this.btnUpdateBrand_Click);
            // 
            // btnAddBrand
            // 
            this.btnAddBrand.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.btnAddBrand.Appearance.Options.UseForeColor = true;
            this.btnAddBrand.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddBrand.ImageOptions.Image")));
            this.btnAddBrand.Location = new System.Drawing.Point(98, 316);
            this.btnAddBrand.Name = "btnAddBrand";
            this.btnAddBrand.Size = new System.Drawing.Size(288, 25);
            this.btnAddBrand.TabIndex = 1;
            this.btnAddBrand.Text = "Add Brand";
            this.btnAddBrand.Click += new System.EventHandler(this.btnAddBrand_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnClearBrands);
            this.panelControl2.Controls.Add(this.btnDeleteBrand);
            this.panelControl2.Controls.Add(this.btnUpdateBrand);
            this.panelControl2.Controls.Add(this.btnAddBrand);
            this.panelControl2.Controls.Add(this.myDataLayoutControl1);
            this.panelControl2.Location = new System.Drawing.Point(879, 7);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(400, 527);
            this.panelControl2.TabIndex = 4;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gridControlBrands);
            this.panelControl1.Location = new System.Drawing.Point(14, 7);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(860, 529);
            this.panelControl1.TabIndex = 3;
            // 
            // gridControlBrands
            // 
            this.gridControlBrands.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlBrands.Location = new System.Drawing.Point(2, 2);
            this.gridControlBrands.MainView = this.gridViewBrands;
            this.gridControlBrands.Name = "gridControlBrands";
            this.gridControlBrands.Size = new System.Drawing.Size(856, 525);
            this.gridControlBrands.TabIndex = 0;
            this.gridControlBrands.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewBrands});
            // 
            // gridViewBrands
            // 
            this.gridViewBrands.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gridViewBrands.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewBrands.Appearance.FooterPanel.Options.UseFont = true;
            this.gridViewBrands.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridViewBrands.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewBrands.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridViewBrands.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewBrands.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewBrands.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewBrands.Appearance.ViewCaption.Options.UseForeColor = true;
            this.gridViewBrands.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colBrandId,
            this.colBrandName,
            this.colBrandDescription});
            this.gridViewBrands.GridControl = this.gridControlBrands;
            this.gridViewBrands.Name = "gridViewBrands";
            this.gridViewBrands.OptionsMenu.EnableColumnMenu = false;
            this.gridViewBrands.OptionsMenu.EnableFooterMenu = false;
            this.gridViewBrands.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridViewBrands.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridViewBrands.OptionsPrint.AutoWidth = false;
            this.gridViewBrands.OptionsPrint.PrintFooter = false;
            this.gridViewBrands.OptionsPrint.PrintGroupFooter = false;
            this.gridViewBrands.OptionsView.ColumnAutoWidth = false;
            this.gridViewBrands.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.gridViewBrands.OptionsView.RowAutoHeight = true;
            this.gridViewBrands.OptionsView.ShowAutoFilterRow = true;
            this.gridViewBrands.OptionsView.ShowGroupPanel = false;
            this.gridViewBrands.OptionsView.ShowViewCaption = true;
            this.gridViewBrands.ViewCaption = "Brands";
            this.gridViewBrands.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewBrands_FocusedRowChanged);
            // 
            // colBrandId
            // 
            this.colBrandId.Caption = "Brand ID";
            this.colBrandId.FieldName = "BrandId";
            this.colBrandId.Name = "colBrandId";
            this.colBrandId.OptionsColumn.AllowEdit = false;
            this.colBrandId.Visible = true;
            this.colBrandId.VisibleIndex = 0;
            this.colBrandId.Width = 200;
            // 
            // colBrandName
            // 
            this.colBrandName.Caption = "Brand Name";
            this.colBrandName.FieldName = "BrandName";
            this.colBrandName.Name = "colBrandName";
            this.colBrandName.OptionsColumn.AllowEdit = false;
            this.colBrandName.Visible = true;
            this.colBrandName.VisibleIndex = 1;
            this.colBrandName.Width = 200;
            // 
            // colBrandDescription
            // 
            this.colBrandDescription.Caption = "Brand Description";
            this.colBrandDescription.FieldName = "BrandDescription";
            this.colBrandDescription.Name = "colBrandDescription";
            this.colBrandDescription.OptionsColumn.AllowEdit = false;
            this.colBrandDescription.Visible = true;
            this.colBrandDescription.VisibleIndex = 2;
            this.colBrandDescription.Width = 410;
            // 
            // BrandsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 543);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "BrandsForm";
            this.Text = "Brands";
            this.Load += new System.EventHandler(this.BrandsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl1)).EndInit();
            this.myDataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.memoEditBrandDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBrandName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBrandId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlBrands)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBrands)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Controls.MyDataLayoutControl myDataLayoutControl1;
        private Controls.MyTextBox txtBrandName;
        private Controls.MyTextBox txtBrandId;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private Controls.MySimpleButton btnClearBrands;
        private Controls.MySimpleButton btnDeleteBrand;
        private Controls.MySimpleButton btnUpdateBrand;
        private Controls.MySimpleButton btnAddBrand;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private Controls.MyGridControl gridControlBrands;
        private Controls.MyGridView gridViewBrands;
        private Controls.MyGridColumn colBrandId;
        private Controls.MyGridColumn colBrandName;
        private Controls.MyGridColumn colBrandDescription;
        private Controls.MyMemoEdit memoEditBrandDescription;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    }
}