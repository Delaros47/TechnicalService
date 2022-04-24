namespace TechnicalServiceUI.Forms
{
    partial class ProductAddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductAddForm));
            DevExpress.XtraLayout.ColumnDefinition columnDefinition1 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition1 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition2 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition3 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition4 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition5 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition6 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition7 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition8 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition9 = new DevExpress.XtraLayout.RowDefinition();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnClearProducts = new TechnicalServiceUI.Controls.MySimpleButton();
            this.btnAdd = new TechnicalServiceUI.Controls.MySimpleButton();
            this.myDataLayoutControl1 = new TechnicalServiceUI.Controls.MyDataLayoutControl();
            this.toogleSwitchState = new TechnicalServiceUI.Controls.MyToogleSwitch();
            this.txtSalesPrice = new TechnicalServiceUI.Controls.MyPriceTextEdit();
            this.txtPurchasePrice = new TechnicalServiceUI.Controls.MyPriceTextEdit();
            this.txtUnitsInStock = new TechnicalServiceUI.Controls.MyTextBox();
            this.lueBrand = new TechnicalServiceUI.Controls.MyLookUpEdit();
            this.lueCategory = new TechnicalServiceUI.Controls.MyLookUpEdit();
            this.txtProductName = new TechnicalServiceUI.Controls.MyTextBox();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl1)).BeginInit();
            this.myDataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toogleSwitchState.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSalesPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPurchasePrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnitsInStock.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueBrand.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnClearProducts);
            this.panelControl2.Controls.Add(this.btnAdd);
            this.panelControl2.Controls.Add(this.myDataLayoutControl1);
            this.panelControl2.Location = new System.Drawing.Point(12, 12);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(400, 362);
            this.panelControl2.TabIndex = 3;
            // 
            // btnClearProducts
            // 
            this.btnClearProducts.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.btnClearProducts.Appearance.Options.UseForeColor = true;
            this.btnClearProducts.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClearProducts.ImageOptions.Image")));
            this.btnClearProducts.Location = new System.Drawing.Point(98, 262);
            this.btnClearProducts.Name = "btnClearProducts";
            this.btnClearProducts.Size = new System.Drawing.Size(288, 25);
            this.btnClearProducts.TabIndex = 3;
            this.btnClearProducts.Text = "Clear Products";
            this.btnClearProducts.Click += new System.EventHandler(this.btnClearProducts_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.btnAdd.Appearance.Options.UseForeColor = true;
            this.btnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.Image")));
            this.btnAdd.Location = new System.Drawing.Point(98, 231);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(288, 25);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add Product";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // myDataLayoutControl1
            // 
            this.myDataLayoutControl1.Controls.Add(this.toogleSwitchState);
            this.myDataLayoutControl1.Controls.Add(this.txtSalesPrice);
            this.myDataLayoutControl1.Controls.Add(this.txtPurchasePrice);
            this.myDataLayoutControl1.Controls.Add(this.txtUnitsInStock);
            this.myDataLayoutControl1.Controls.Add(this.lueBrand);
            this.myDataLayoutControl1.Controls.Add(this.lueCategory);
            this.myDataLayoutControl1.Controls.Add(this.txtProductName);
            this.myDataLayoutControl1.Location = new System.Drawing.Point(2, 2);
            this.myDataLayoutControl1.Name = "myDataLayoutControl1";
            this.myDataLayoutControl1.OptionsFocus.EnableAutoTabOrder = false;
            this.myDataLayoutControl1.Root = this.Root;
            this.myDataLayoutControl1.Size = new System.Drawing.Size(396, 239);
            this.myDataLayoutControl1.TabIndex = 0;
            this.myDataLayoutControl1.Text = "myDataLayoutControl1";
            // 
            // toogleSwitchState
            // 
            this.toogleSwitchState.EnterMoveNextControl = true;
            this.toogleSwitchState.Location = new System.Drawing.Point(94, 180);
            this.toogleSwitchState.Name = "toogleSwitchState";
            this.toogleSwitchState.Properties.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.toogleSwitchState.Properties.Appearance.Options.UseForeColor = true;
            this.toogleSwitchState.Properties.AutoHeight = false;
            this.toogleSwitchState.Properties.AutoWidth = true;
            this.toogleSwitchState.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.toogleSwitchState.Properties.OffText = "Passive";
            this.toogleSwitchState.Properties.OnText = "Active";
            this.toogleSwitchState.Size = new System.Drawing.Size(89, 20);
            this.toogleSwitchState.StyleController = this.myDataLayoutControl1;
            this.toogleSwitchState.TabIndex = 11;
            // 
            // txtSalesPrice
            // 
            this.txtSalesPrice.Location = new System.Drawing.Point(94, 156);
            this.txtSalesPrice.Name = "txtSalesPrice";
            this.txtSalesPrice.Properties.Appearance.Options.UseTextOptions = true;
            this.txtSalesPrice.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtSalesPrice.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtSalesPrice.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtSalesPrice.Properties.Mask.EditMask = "c";
            this.txtSalesPrice.Properties.MaskSettings.Set("mask", "c");
            this.txtSalesPrice.Size = new System.Drawing.Size(290, 20);
            this.txtSalesPrice.StyleController = this.myDataLayoutControl1;
            this.txtSalesPrice.TabIndex = 10;
            // 
            // txtPurchasePrice
            // 
            this.txtPurchasePrice.Location = new System.Drawing.Point(94, 132);
            this.txtPurchasePrice.Name = "txtPurchasePrice";
            this.txtPurchasePrice.Properties.Appearance.Options.UseTextOptions = true;
            this.txtPurchasePrice.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtPurchasePrice.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtPurchasePrice.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtPurchasePrice.Properties.Mask.EditMask = "c";
            this.txtPurchasePrice.Properties.MaskSettings.Set("mask", "c");
            this.txtPurchasePrice.Size = new System.Drawing.Size(290, 20);
            this.txtPurchasePrice.StyleController = this.myDataLayoutControl1;
            this.txtPurchasePrice.TabIndex = 9;
            // 
            // txtUnitsInStock
            // 
            this.txtUnitsInStock.EnterMoveNextControl = true;
            this.txtUnitsInStock.Location = new System.Drawing.Point(94, 108);
            this.txtUnitsInStock.Name = "txtUnitsInStock";
            this.txtUnitsInStock.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtUnitsInStock.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtUnitsInStock.Size = new System.Drawing.Size(290, 20);
            this.txtUnitsInStock.StyleController = this.myDataLayoutControl1;
            this.txtUnitsInStock.TabIndex = 8;
            // 
            // lueBrand
            // 
            this.lueBrand.EnterMoveNextControl = true;
            this.lueBrand.Location = new System.Drawing.Point(94, 84);
            this.lueBrand.Name = "lueBrand";
            this.lueBrand.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.lueBrand.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.lueBrand.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BrandName", "Brands")});
            this.lueBrand.Properties.NullText = "";
            this.lueBrand.Size = new System.Drawing.Size(290, 20);
            this.lueBrand.StyleController = this.myDataLayoutControl1;
            this.lueBrand.TabIndex = 7;
            // 
            // lueCategory
            // 
            this.lueCategory.EnterMoveNextControl = true;
            this.lueCategory.Location = new System.Drawing.Point(94, 60);
            this.lueCategory.Name = "lueCategory";
            this.lueCategory.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.lueCategory.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.lueCategory.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CategoryName", "Categories")});
            this.lueCategory.Properties.NullText = "";
            this.lueCategory.Size = new System.Drawing.Size(290, 20);
            this.lueCategory.StyleController = this.myDataLayoutControl1;
            this.lueCategory.TabIndex = 6;
            // 
            // txtProductName
            // 
            this.txtProductName.EnterMoveNextControl = true;
            this.txtProductName.Location = new System.Drawing.Point(94, 36);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtProductName.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtProductName.Size = new System.Drawing.Size(290, 20);
            this.txtProductName.StyleController = this.myDataLayoutControl1;
            this.txtProductName.TabIndex = 5;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem8});
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
            rowDefinition4.Height = 24D;
            rowDefinition4.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition5.Height = 24D;
            rowDefinition5.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition6.Height = 24D;
            rowDefinition6.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition7.Height = 24D;
            rowDefinition7.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition8.Height = 24D;
            rowDefinition8.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition9.Height = 24D;
            rowDefinition9.SizeType = System.Windows.Forms.SizeType.Absolute;
            this.Root.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition1,
            rowDefinition2,
            rowDefinition3,
            rowDefinition4,
            rowDefinition5,
            rowDefinition6,
            rowDefinition7,
            rowDefinition8,
            rowDefinition9});
            this.Root.Size = new System.Drawing.Size(396, 239);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem2.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem2.Control = this.txtProductName;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlItem2.Size = new System.Drawing.Size(376, 24);
            this.layoutControlItem2.Text = "Product Name";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(70, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem3.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem3.Control = this.lueCategory;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.OptionsTableLayoutItem.RowIndex = 2;
            this.layoutControlItem3.Size = new System.Drawing.Size(376, 24);
            this.layoutControlItem3.Text = "Category";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(70, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem4.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem4.Control = this.lueBrand;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.OptionsTableLayoutItem.RowIndex = 3;
            this.layoutControlItem4.Size = new System.Drawing.Size(376, 24);
            this.layoutControlItem4.Text = "Brand";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(70, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem5.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem5.Control = this.txtUnitsInStock;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.OptionsTableLayoutItem.RowIndex = 4;
            this.layoutControlItem5.Size = new System.Drawing.Size(376, 24);
            this.layoutControlItem5.Text = "Units In Stock";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(70, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem6.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem6.Control = this.txtPurchasePrice;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 120);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.OptionsTableLayoutItem.RowIndex = 5;
            this.layoutControlItem6.Size = new System.Drawing.Size(376, 24);
            this.layoutControlItem6.Text = "Purchase Price";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(70, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem7.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem7.Control = this.txtSalesPrice;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 144);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.OptionsTableLayoutItem.RowIndex = 6;
            this.layoutControlItem7.Size = new System.Drawing.Size(376, 24);
            this.layoutControlItem7.Text = "Sales Price";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(70, 13);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem8.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem8.Control = this.toogleSwitchState;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 168);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.OptionsTableLayoutItem.RowIndex = 7;
            this.layoutControlItem8.Size = new System.Drawing.Size(376, 24);
            this.layoutControlItem8.Text = "State";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(70, 13);
            // 
            // ProductAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 382);
            this.Controls.Add(this.panelControl2);
            this.Name = "ProductAddForm";
            this.Text = "Add Product";
            this.Load += new System.EventHandler(this.ProductAddForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl1)).EndInit();
            this.myDataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.toogleSwitchState.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSalesPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPurchasePrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnitsInStock.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueBrand.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl2;
        private Controls.MySimpleButton btnClearProducts;
        private Controls.MySimpleButton btnAdd;
        private Controls.MyDataLayoutControl myDataLayoutControl1;
        private Controls.MyToogleSwitch toogleSwitchState;
        private Controls.MyPriceTextEdit txtSalesPrice;
        private Controls.MyPriceTextEdit txtPurchasePrice;
        private Controls.MyTextBox txtUnitsInStock;
        private Controls.MyLookUpEdit lueBrand;
        private Controls.MyLookUpEdit lueCategory;
        private Controls.MyTextBox txtProductName;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
    }
}