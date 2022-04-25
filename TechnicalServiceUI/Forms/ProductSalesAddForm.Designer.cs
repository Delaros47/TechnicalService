namespace TechnicalServiceUI.Forms
{
    partial class ProductSalesAddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductSalesAddForm));
            DevExpress.XtraLayout.ColumnDefinition columnDefinition1 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition1 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition2 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition3 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition4 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition5 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition6 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition7 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition8 = new DevExpress.XtraLayout.RowDefinition();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnClearProductSales = new TechnicalServiceUI.Controls.MySimpleButton();
            this.btnAddProductSale = new TechnicalServiceUI.Controls.MySimpleButton();
            this.myDataLayoutControl1 = new TechnicalServiceUI.Controls.MyDataLayoutControl();
            this.txtProductSeriesNumber = new TechnicalServiceUI.Controls.MyTextBox();
            this.txtPrice = new TechnicalServiceUI.Controls.MyPriceTextEdit();
            this.txtUnit = new TechnicalServiceUI.Controls.MyTextBox();
            this.deSalesDate = new TechnicalServiceUI.Controls.MyDateEdit();
            this.lueEmployeeName = new TechnicalServiceUI.Controls.MyLookUpEdit();
            this.lueCustomerName = new TechnicalServiceUI.Controls.MyLookUpEdit();
            this.lueProductName = new TechnicalServiceUI.Controls.MyLookUpEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl1)).BeginInit();
            this.myDataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductSeriesNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deSalesDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deSalesDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueEmployeeName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueCustomerName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueProductName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnClearProductSales);
            this.panelControl1.Controls.Add(this.btnAddProductSale);
            this.panelControl1.Controls.Add(this.myDataLayoutControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(398, 297);
            this.panelControl1.TabIndex = 0;
            // 
            // btnClearProductSales
            // 
            this.btnClearProductSales.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.btnClearProductSales.Appearance.Options.UseForeColor = true;
            this.btnClearProductSales.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnClearProductSales.ImageOptions.SvgImage")));
            this.btnClearProductSales.Location = new System.Drawing.Point(248, 222);
            this.btnClearProductSales.Name = "btnClearProductSales";
            this.btnClearProductSales.Size = new System.Drawing.Size(136, 46);
            this.btnClearProductSales.TabIndex = 2;
            this.btnClearProductSales.Text = "Clear Product Sales";
            this.btnClearProductSales.Click += new System.EventHandler(this.btnClearProductSales_Click);
            // 
            // btnAddProductSale
            // 
            this.btnAddProductSale.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.btnAddProductSale.Appearance.Options.UseForeColor = true;
            this.btnAddProductSale.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAddProductSale.ImageOptions.SvgImage")));
            this.btnAddProductSale.Location = new System.Drawing.Point(84, 222);
            this.btnAddProductSale.Name = "btnAddProductSale";
            this.btnAddProductSale.Size = new System.Drawing.Size(136, 46);
            this.btnAddProductSale.TabIndex = 1;
            this.btnAddProductSale.Text = "Add Product Sale";
            this.btnAddProductSale.Click += new System.EventHandler(this.btnAddProductSale_Click);
            // 
            // myDataLayoutControl1
            // 
            this.myDataLayoutControl1.Controls.Add(this.txtProductSeriesNumber);
            this.myDataLayoutControl1.Controls.Add(this.txtPrice);
            this.myDataLayoutControl1.Controls.Add(this.txtUnit);
            this.myDataLayoutControl1.Controls.Add(this.deSalesDate);
            this.myDataLayoutControl1.Controls.Add(this.lueEmployeeName);
            this.myDataLayoutControl1.Controls.Add(this.lueCustomerName);
            this.myDataLayoutControl1.Controls.Add(this.lueProductName);
            this.myDataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.myDataLayoutControl1.Location = new System.Drawing.Point(2, 2);
            this.myDataLayoutControl1.Name = "myDataLayoutControl1";
            this.myDataLayoutControl1.OptionsFocus.EnableAutoTabOrder = false;
            this.myDataLayoutControl1.Root = this.Root;
            this.myDataLayoutControl1.Size = new System.Drawing.Size(394, 214);
            this.myDataLayoutControl1.TabIndex = 0;
            this.myDataLayoutControl1.Text = "myDataLayoutControl1";
            // 
            // txtProductSeriesNumber
            // 
            this.txtProductSeriesNumber.EnterMoveNextControl = true;
            this.txtProductSeriesNumber.Location = new System.Drawing.Point(133, 156);
            this.txtProductSeriesNumber.Name = "txtProductSeriesNumber";
            this.txtProductSeriesNumber.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtProductSeriesNumber.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtProductSeriesNumber.Size = new System.Drawing.Size(249, 20);
            this.txtProductSeriesNumber.StyleController = this.myDataLayoutControl1;
            this.txtProductSeriesNumber.TabIndex = 10;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(133, 132);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Properties.Appearance.Options.UseTextOptions = true;
            this.txtPrice.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtPrice.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtPrice.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtPrice.Properties.Mask.EditMask = "c";
            this.txtPrice.Properties.MaskSettings.Set("mask", "c");
            this.txtPrice.Size = new System.Drawing.Size(249, 20);
            this.txtPrice.StyleController = this.myDataLayoutControl1;
            this.txtPrice.TabIndex = 9;
            // 
            // txtUnit
            // 
            this.txtUnit.EnterMoveNextControl = true;
            this.txtUnit.Location = new System.Drawing.Point(133, 108);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtUnit.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtUnit.Size = new System.Drawing.Size(249, 20);
            this.txtUnit.StyleController = this.myDataLayoutControl1;
            this.txtUnit.TabIndex = 8;
            // 
            // deSalesDate
            // 
            this.deSalesDate.EditValue = null;
            this.deSalesDate.EnterMoveNextControl = true;
            this.deSalesDate.Location = new System.Drawing.Point(133, 84);
            this.deSalesDate.Name = "deSalesDate";
            this.deSalesDate.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.deSalesDate.Properties.Appearance.Options.UseTextOptions = true;
            this.deSalesDate.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.deSalesDate.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.deSalesDate.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.deSalesDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deSalesDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deSalesDate.Size = new System.Drawing.Size(249, 20);
            this.deSalesDate.StyleController = this.myDataLayoutControl1;
            this.deSalesDate.TabIndex = 7;
            // 
            // lueEmployeeName
            // 
            this.lueEmployeeName.EnterMoveNextControl = true;
            this.lueEmployeeName.Location = new System.Drawing.Point(133, 60);
            this.lueEmployeeName.Name = "lueEmployeeName";
            this.lueEmployeeName.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.lueEmployeeName.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.lueEmployeeName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueEmployeeName.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EmployeeId", "Employee ID"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EmployeeFullName", "Employee Full Name")});
            this.lueEmployeeName.Properties.NullText = "";
            this.lueEmployeeName.Size = new System.Drawing.Size(249, 20);
            this.lueEmployeeName.StyleController = this.myDataLayoutControl1;
            this.lueEmployeeName.TabIndex = 6;
            // 
            // lueCustomerName
            // 
            this.lueCustomerName.EnterMoveNextControl = true;
            this.lueCustomerName.Location = new System.Drawing.Point(133, 36);
            this.lueCustomerName.Name = "lueCustomerName";
            this.lueCustomerName.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.lueCustomerName.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.lueCustomerName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueCustomerName.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomerId", "Customer ID"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomerFullName", "Customer Full Name")});
            this.lueCustomerName.Properties.NullText = "";
            this.lueCustomerName.Size = new System.Drawing.Size(249, 20);
            this.lueCustomerName.StyleController = this.myDataLayoutControl1;
            this.lueCustomerName.TabIndex = 5;
            // 
            // lueProductName
            // 
            this.lueProductName.EnterMoveNextControl = true;
            this.lueProductName.Location = new System.Drawing.Point(133, 12);
            this.lueProductName.Name = "lueProductName";
            this.lueProductName.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.lueProductName.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.lueProductName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueProductName.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ProductId", "Product ID"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ProductName", "Product Name")});
            this.lueProductName.Properties.NullText = "";
            this.lueProductName.Size = new System.Drawing.Size(249, 20);
            this.lueProductName.StyleController = this.myDataLayoutControl1;
            this.lueProductName.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7});
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
            this.Root.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition1,
            rowDefinition2,
            rowDefinition3,
            rowDefinition4,
            rowDefinition5,
            rowDefinition6,
            rowDefinition7,
            rowDefinition8});
            this.Root.Size = new System.Drawing.Size(394, 214);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem1.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem1.Control = this.lueProductName;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(374, 24);
            this.layoutControlItem1.Text = "Product Name";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(109, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem2.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem2.Control = this.lueCustomerName;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlItem2.Size = new System.Drawing.Size(374, 24);
            this.layoutControlItem2.Text = "Customer Name";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(109, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem3.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem3.Control = this.lueEmployeeName;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.OptionsTableLayoutItem.RowIndex = 2;
            this.layoutControlItem3.Size = new System.Drawing.Size(374, 24);
            this.layoutControlItem3.Text = "Employee Name";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(109, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem4.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem4.Control = this.deSalesDate;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.OptionsTableLayoutItem.RowIndex = 3;
            this.layoutControlItem4.Size = new System.Drawing.Size(374, 24);
            this.layoutControlItem4.Text = "Sales Date";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(109, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem5.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem5.Control = this.txtUnit;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.OptionsTableLayoutItem.RowIndex = 4;
            this.layoutControlItem5.Size = new System.Drawing.Size(374, 24);
            this.layoutControlItem5.Text = "Unit";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(109, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem6.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem6.Control = this.txtPrice;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 120);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.OptionsTableLayoutItem.RowIndex = 5;
            this.layoutControlItem6.Size = new System.Drawing.Size(374, 24);
            this.layoutControlItem6.Text = "Price";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(109, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem7.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem7.Control = this.txtProductSeriesNumber;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 144);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.OptionsTableLayoutItem.RowIndex = 6;
            this.layoutControlItem7.Size = new System.Drawing.Size(374, 24);
            this.layoutControlItem7.Text = "Product Series Number";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(109, 13);
            // 
            // ProductSalesAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 297);
            this.Controls.Add(this.panelControl1);
            this.Name = "ProductSalesAddForm";
            this.Text = "Add Product Sales";
            this.Load += new System.EventHandler(this.ProductSalesAddForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl1)).EndInit();
            this.myDataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtProductSeriesNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deSalesDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deSalesDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueEmployeeName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueCustomerName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueProductName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private Controls.MyDataLayoutControl myDataLayoutControl1;
        private Controls.MyLookUpEdit lueEmployeeName;
        private Controls.MyLookUpEdit lueCustomerName;
        private Controls.MyLookUpEdit lueProductName;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private Controls.MyTextBox txtProductSeriesNumber;
        private Controls.MyPriceTextEdit txtPrice;
        private Controls.MyTextBox txtUnit;
        private Controls.MyDateEdit deSalesDate;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private Controls.MySimpleButton btnClearProductSales;
        private Controls.MySimpleButton btnAddProductSale;
    }
}