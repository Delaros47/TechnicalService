namespace TechnicalServiceUI.Forms
{
    partial class CategoriesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoriesForm));
            this.myDataLayoutControl1 = new TechnicalServiceUI.Controls.MyDataLayoutControl();
            this.txtCategoryName = new TechnicalServiceUI.Controls.MyTextBox();
            this.txtCategoryId = new TechnicalServiceUI.Controls.MyTextBox();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnClearCategories = new TechnicalServiceUI.Controls.MySimpleButton();
            this.btnDeleteCategory = new TechnicalServiceUI.Controls.MySimpleButton();
            this.btnUpdateCategory = new TechnicalServiceUI.Controls.MySimpleButton();
            this.btnAddCategory = new TechnicalServiceUI.Controls.MySimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gridControlCategories = new TechnicalServiceUI.Controls.MyGridControl();
            this.gridViewCategories = new TechnicalServiceUI.Controls.MyGridView();
            this.colCategoryId = new TechnicalServiceUI.Controls.MyGridColumn();
            this.colCategoryName = new TechnicalServiceUI.Controls.MyGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl1)).BeginInit();
            this.myDataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCategoryName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCategoryId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // myDataLayoutControl1
            // 
            this.myDataLayoutControl1.Controls.Add(this.txtCategoryName);
            this.myDataLayoutControl1.Controls.Add(this.txtCategoryId);
            this.myDataLayoutControl1.Location = new System.Drawing.Point(2, 21);
            this.myDataLayoutControl1.Name = "myDataLayoutControl1";
            this.myDataLayoutControl1.OptionsFocus.EnableAutoTabOrder = false;
            this.myDataLayoutControl1.Root = this.Root;
            this.myDataLayoutControl1.Size = new System.Drawing.Size(396, 99);
            this.myDataLayoutControl1.TabIndex = 0;
            this.myDataLayoutControl1.Text = "myDataLayoutControl1";
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.EnterMoveNextControl = true;
            this.txtCategoryName.Location = new System.Drawing.Point(99, 36);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtCategoryName.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtCategoryName.Size = new System.Drawing.Size(285, 20);
            this.txtCategoryName.StyleController = this.myDataLayoutControl1;
            this.txtCategoryName.TabIndex = 5;
            // 
            // txtCategoryId
            // 
            this.txtCategoryId.EnterMoveNextControl = true;
            this.txtCategoryId.Location = new System.Drawing.Point(99, 12);
            this.txtCategoryId.Name = "txtCategoryId";
            this.txtCategoryId.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtCategoryId.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtCategoryId.Properties.ReadOnly = true;
            this.txtCategoryId.Size = new System.Drawing.Size(285, 20);
            this.txtCategoryId.StyleController = this.myDataLayoutControl1;
            this.txtCategoryId.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
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
            this.Root.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition1,
            rowDefinition2});
            this.Root.Size = new System.Drawing.Size(396, 99);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem1.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem1.Control = this.txtCategoryId;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(376, 24);
            this.layoutControlItem1.Text = "Category ID";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(75, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem2.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem2.Control = this.txtCategoryName;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlItem2.Size = new System.Drawing.Size(376, 55);
            this.layoutControlItem2.Text = "Category Name";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(75, 13);
            // 
            // btnClearCategories
            // 
            this.btnClearCategories.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.btnClearCategories.Appearance.Options.UseForeColor = true;
            this.btnClearCategories.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClearCategories.ImageOptions.Image")));
            this.btnClearCategories.Location = new System.Drawing.Point(98, 218);
            this.btnClearCategories.Name = "btnClearCategories";
            this.btnClearCategories.Size = new System.Drawing.Size(288, 25);
            this.btnClearCategories.TabIndex = 3;
            this.btnClearCategories.Text = "Clear Category";
            this.btnClearCategories.Click += new System.EventHandler(this.btnClearCategories_Click);
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.btnDeleteCategory.Appearance.Options.UseForeColor = true;
            this.btnDeleteCategory.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteCategory.ImageOptions.Image")));
            this.btnDeleteCategory.Location = new System.Drawing.Point(98, 187);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(288, 25);
            this.btnDeleteCategory.TabIndex = 2;
            this.btnDeleteCategory.Text = "Delete Category";
            this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click);
            // 
            // btnUpdateCategory
            // 
            this.btnUpdateCategory.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.btnUpdateCategory.Appearance.Options.UseForeColor = true;
            this.btnUpdateCategory.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateCategory.ImageOptions.Image")));
            this.btnUpdateCategory.Location = new System.Drawing.Point(98, 156);
            this.btnUpdateCategory.Name = "btnUpdateCategory";
            this.btnUpdateCategory.Size = new System.Drawing.Size(288, 25);
            this.btnUpdateCategory.TabIndex = 1;
            this.btnUpdateCategory.Text = "Update Category";
            this.btnUpdateCategory.Click += new System.EventHandler(this.btnUpdateCategory_Click);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.btnAddCategory.Appearance.Options.UseForeColor = true;
            this.btnAddCategory.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCategory.ImageOptions.Image")));
            this.btnAddCategory.Location = new System.Drawing.Point(98, 125);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(288, 25);
            this.btnAddCategory.TabIndex = 1;
            this.btnAddCategory.Text = "Add Category";
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnClearCategories);
            this.panelControl2.Controls.Add(this.btnDeleteCategory);
            this.panelControl2.Controls.Add(this.btnUpdateCategory);
            this.panelControl2.Controls.Add(this.btnAddCategory);
            this.panelControl2.Controls.Add(this.myDataLayoutControl1);
            this.panelControl2.Location = new System.Drawing.Point(879, 7);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(400, 527);
            this.panelControl2.TabIndex = 4;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gridControlCategories);
            this.panelControl1.Location = new System.Drawing.Point(14, 7);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(860, 529);
            this.panelControl1.TabIndex = 3;
            // 
            // gridControlCategories
            // 
            this.gridControlCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlCategories.Location = new System.Drawing.Point(2, 2);
            this.gridControlCategories.MainView = this.gridViewCategories;
            this.gridControlCategories.Name = "gridControlCategories";
            this.gridControlCategories.Size = new System.Drawing.Size(856, 525);
            this.gridControlCategories.TabIndex = 0;
            this.gridControlCategories.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCategories});
            // 
            // gridViewCategories
            // 
            this.gridViewCategories.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gridViewCategories.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewCategories.Appearance.FooterPanel.Options.UseFont = true;
            this.gridViewCategories.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridViewCategories.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewCategories.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridViewCategories.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewCategories.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewCategories.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewCategories.Appearance.ViewCaption.Options.UseForeColor = true;
            this.gridViewCategories.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCategoryId,
            this.colCategoryName});
            this.gridViewCategories.GridControl = this.gridControlCategories;
            this.gridViewCategories.Name = "gridViewCategories";
            this.gridViewCategories.OptionsMenu.EnableColumnMenu = false;
            this.gridViewCategories.OptionsMenu.EnableFooterMenu = false;
            this.gridViewCategories.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridViewCategories.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridViewCategories.OptionsPrint.AutoWidth = false;
            this.gridViewCategories.OptionsPrint.PrintFooter = false;
            this.gridViewCategories.OptionsPrint.PrintGroupFooter = false;
            this.gridViewCategories.OptionsView.ColumnAutoWidth = false;
            this.gridViewCategories.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.gridViewCategories.OptionsView.RowAutoHeight = true;
            this.gridViewCategories.OptionsView.ShowAutoFilterRow = true;
            this.gridViewCategories.OptionsView.ShowGroupPanel = false;
            this.gridViewCategories.OptionsView.ShowViewCaption = true;
            this.gridViewCategories.ViewCaption = "Categories";
            this.gridViewCategories.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewCategories_FocusedRowChanged);
            // 
            // colCategoryId
            // 
            this.colCategoryId.Caption = "Category ID";
            this.colCategoryId.FieldName = "CategoryId";
            this.colCategoryId.Name = "colCategoryId";
            this.colCategoryId.OptionsColumn.AllowEdit = false;
            this.colCategoryId.Visible = true;
            this.colCategoryId.VisibleIndex = 0;
            this.colCategoryId.Width = 405;
            // 
            // colCategoryName
            // 
            this.colCategoryName.Caption = "Category Name";
            this.colCategoryName.FieldName = "CategoryName";
            this.colCategoryName.Name = "colCategoryName";
            this.colCategoryName.OptionsColumn.AllowEdit = false;
            this.colCategoryName.Visible = true;
            this.colCategoryName.VisibleIndex = 1;
            this.colCategoryName.Width = 405;
            // 
            // CategoriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 543);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "CategoriesForm";
            this.Text = "Categories";
            this.Load += new System.EventHandler(this.CategoriesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl1)).EndInit();
            this.myDataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtCategoryName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCategoryId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCategories)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Controls.MyDataLayoutControl myDataLayoutControl1;
        private Controls.MyTextBox txtCategoryName;
        private Controls.MyTextBox txtCategoryId;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private Controls.MySimpleButton btnClearCategories;
        private Controls.MySimpleButton btnDeleteCategory;
        private Controls.MySimpleButton btnUpdateCategory;
        private Controls.MySimpleButton btnAddCategory;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private Controls.MyGridControl gridControlCategories;
        private Controls.MyGridView gridViewCategories;
        private Controls.MyGridColumn colCategoryId;
        private Controls.MyGridColumn colCategoryName;
    }
}