namespace TechnicalServiceUI.Forms
{
    partial class BrandAddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrandAddForm));
            DevExpress.XtraLayout.ColumnDefinition columnDefinition1 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition1 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition2 = new DevExpress.XtraLayout.RowDefinition();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnClearBrands = new TechnicalServiceUI.Controls.MySimpleButton();
            this.btnAddBrand = new TechnicalServiceUI.Controls.MySimpleButton();
            this.myDataLayoutControl1 = new TechnicalServiceUI.Controls.MyDataLayoutControl();
            this.memoEditBrandDescription = new TechnicalServiceUI.Controls.MyMemoEdit();
            this.txtBrandName = new TechnicalServiceUI.Controls.MyTextBox();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl1)).BeginInit();
            this.myDataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditBrandDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBrandName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnClearBrands);
            this.panelControl2.Controls.Add(this.btnAddBrand);
            this.panelControl2.Controls.Add(this.myDataLayoutControl1);
            this.panelControl2.Location = new System.Drawing.Point(8, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(400, 385);
            this.panelControl2.TabIndex = 5;
            // 
            // btnClearBrands
            // 
            this.btnClearBrands.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.btnClearBrands.Appearance.Options.UseForeColor = true;
            this.btnClearBrands.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClearBrands.ImageOptions.Image")));
            this.btnClearBrands.Location = new System.Drawing.Point(286, 311);
            this.btnClearBrands.Name = "btnClearBrands";
            this.btnClearBrands.Size = new System.Drawing.Size(100, 25);
            this.btnClearBrands.TabIndex = 3;
            this.btnClearBrands.Text = "Clear Brands";
            this.btnClearBrands.Click += new System.EventHandler(this.btnClearBrands_Click);
            // 
            // btnAddBrand
            // 
            this.btnAddBrand.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.btnAddBrand.Appearance.Options.UseForeColor = true;
            this.btnAddBrand.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddBrand.ImageOptions.Image")));
            this.btnAddBrand.Location = new System.Drawing.Point(110, 311);
            this.btnAddBrand.Name = "btnAddBrand";
            this.btnAddBrand.Size = new System.Drawing.Size(100, 25);
            this.btnAddBrand.TabIndex = 1;
            this.btnAddBrand.Text = "Add Brand";
            this.btnAddBrand.Click += new System.EventHandler(this.btnAddBrand_Click);
            // 
            // myDataLayoutControl1
            // 
            this.myDataLayoutControl1.Controls.Add(this.memoEditBrandDescription);
            this.myDataLayoutControl1.Controls.Add(this.txtBrandName);
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
            this.memoEditBrandDescription.Location = new System.Drawing.Point(108, 36);
            this.memoEditBrandDescription.Name = "memoEditBrandDescription";
            this.memoEditBrandDescription.Properties.Appearance.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.memoEditBrandDescription.Properties.Appearance.Options.UseBackColor = true;
            this.memoEditBrandDescription.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.memoEditBrandDescription.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.memoEditBrandDescription.Properties.MaxLength = 500;
            this.memoEditBrandDescription.Size = new System.Drawing.Size(276, 255);
            this.memoEditBrandDescription.StyleController = this.myDataLayoutControl1;
            this.memoEditBrandDescription.TabIndex = 6;
            // 
            // txtBrandName
            // 
            this.txtBrandName.EnterMoveNextControl = true;
            this.txtBrandName.Location = new System.Drawing.Point(108, 12);
            this.txtBrandName.Name = "txtBrandName";
            this.txtBrandName.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtBrandName.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtBrandName.Size = new System.Drawing.Size(276, 20);
            this.txtBrandName.StyleController = this.myDataLayoutControl1;
            this.txtBrandName.TabIndex = 5;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
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
            this.Root.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition1,
            rowDefinition2});
            this.Root.Size = new System.Drawing.Size(396, 303);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem2.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem2.Control = this.txtBrandName;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(376, 24);
            this.layoutControlItem2.Text = "Brand Name";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(84, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem3.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem3.Control = this.memoEditBrandDescription;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlItem3.Size = new System.Drawing.Size(376, 259);
            this.layoutControlItem3.Text = "Brand Description";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(84, 13);
            // 
            // BrandNewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 394);
            this.Controls.Add(this.panelControl2);
            this.Name = "BrandNewForm";
            this.Text = "Add Brand";
            this.Load += new System.EventHandler(this.BrandNewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl1)).EndInit();
            this.myDataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.memoEditBrandDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBrandName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl2;
        private Controls.MySimpleButton btnClearBrands;
        private Controls.MySimpleButton btnAddBrand;
        private Controls.MyDataLayoutControl myDataLayoutControl1;
        private Controls.MyMemoEdit memoEditBrandDescription;
        private Controls.MyTextBox txtBrandName;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    }
}