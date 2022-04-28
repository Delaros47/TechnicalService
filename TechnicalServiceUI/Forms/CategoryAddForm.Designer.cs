namespace TechnicalServiceUI.Forms
{
    partial class CategoryAddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryAddForm));
            DevExpress.XtraLayout.ColumnDefinition columnDefinition1 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition1 = new DevExpress.XtraLayout.RowDefinition();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnClearCategories = new TechnicalServiceUI.Controls.MySimpleButton();
            this.btnAddCategory = new TechnicalServiceUI.Controls.MySimpleButton();
            this.myDataLayoutControl1 = new TechnicalServiceUI.Controls.MyDataLayoutControl();
            this.txtCategoryName = new TechnicalServiceUI.Controls.MyTextBox();
            this.txtCategoryId = new TechnicalServiceUI.Controls.MyTextBox();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl1)).BeginInit();
            this.myDataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCategoryName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCategoryId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnClearCategories);
            this.panelControl2.Controls.Add(this.btnAddCategory);
            this.panelControl2.Controls.Add(this.myDataLayoutControl1);
            this.panelControl2.Location = new System.Drawing.Point(12, 12);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(400, 164);
            this.panelControl2.TabIndex = 5;
            // 
            // btnClearCategories
            // 
            this.btnClearCategories.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.btnClearCategories.Appearance.Options.UseForeColor = true;
            this.btnClearCategories.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClearCategories.ImageOptions.Image")));
            this.btnClearCategories.Location = new System.Drawing.Point(98, 127);
            this.btnClearCategories.Name = "btnClearCategories";
            this.btnClearCategories.Size = new System.Drawing.Size(288, 25);
            this.btnClearCategories.TabIndex = 3;
            this.btnClearCategories.Text = "Clear Category";
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.btnAddCategory.Appearance.Options.UseForeColor = true;
            this.btnAddCategory.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCategory.ImageOptions.Image")));
            this.btnAddCategory.Location = new System.Drawing.Point(98, 96);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(288, 25);
            this.btnAddCategory.TabIndex = 1;
            this.btnAddCategory.Text = "Add Category";
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // myDataLayoutControl1
            // 
            this.myDataLayoutControl1.Controls.Add(this.txtCategoryName);
            this.myDataLayoutControl1.Controls.Add(this.txtCategoryId);
            this.myDataLayoutControl1.HiddenItems.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.myDataLayoutControl1.Location = new System.Drawing.Point(2, 21);
            this.myDataLayoutControl1.Name = "myDataLayoutControl1";
            this.myDataLayoutControl1.OptionsFocus.EnableAutoTabOrder = false;
            this.myDataLayoutControl1.Root = this.Root;
            this.myDataLayoutControl1.Size = new System.Drawing.Size(396, 69);
            this.myDataLayoutControl1.TabIndex = 0;
            this.myDataLayoutControl1.Text = "myDataLayoutControl1";
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.EnterMoveNextControl = true;
            this.txtCategoryName.Location = new System.Drawing.Point(99, 12);
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
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem1.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem1.Control = this.txtCategoryId;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(376, 79);
            this.layoutControlItem1.Text = "Category ID";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(75, 13);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2});
            this.Root.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
            this.Root.Name = "Root";
            columnDefinition1.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition1.Width = 200D;
            this.Root.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition1});
            rowDefinition1.Height = 24D;
            rowDefinition1.SizeType = System.Windows.Forms.SizeType.Absolute;
            this.Root.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition1});
            this.Root.Size = new System.Drawing.Size(396, 69);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem2.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem2.Control = this.txtCategoryName;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(376, 49);
            this.layoutControlItem2.Text = "Category Name";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(75, 13);
            // 
            // CategoryAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 188);
            this.Controls.Add(this.panelControl2);
            this.Name = "CategoryAddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Category";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl1)).EndInit();
            this.myDataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtCategoryName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCategoryId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl2;
        private Controls.MySimpleButton btnClearCategories;
        private Controls.MySimpleButton btnAddCategory;
        private Controls.MyDataLayoutControl myDataLayoutControl1;
        private Controls.MyTextBox txtCategoryName;
        private Controls.MyTextBox txtCategoryId;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}