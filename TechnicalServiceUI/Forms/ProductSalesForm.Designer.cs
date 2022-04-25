namespace TechnicalServiceUI.Forms
{
    partial class ProductSalesForm
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
            this.gridControlProductSales = new TechnicalServiceUI.Controls.MyGridControl();
            this.gridViewProductSales = new TechnicalServiceUI.Controls.MyGridView();
            this.colProductSaleId = new TechnicalServiceUI.Controls.MyGridColumn();
            this.colProductName = new TechnicalServiceUI.Controls.MyGridColumn();
            this.colCustomerName = new TechnicalServiceUI.Controls.MyGridColumn();
            this.colEmplpyeeName = new TechnicalServiceUI.Controls.MyGridColumn();
            this.colSalesDate = new TechnicalServiceUI.Controls.MyGridColumn();
            this.colUnit = new TechnicalServiceUI.Controls.MyGridColumn();
            this.colPrice = new TechnicalServiceUI.Controls.MyGridColumn();
            this.colProductSeriesNumber = new TechnicalServiceUI.Controls.MyGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProductSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProductSales)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlProductSales
            // 
            this.gridControlProductSales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlProductSales.Location = new System.Drawing.Point(0, 0);
            this.gridControlProductSales.MainView = this.gridViewProductSales;
            this.gridControlProductSales.Name = "gridControlProductSales";
            this.gridControlProductSales.Size = new System.Drawing.Size(1293, 543);
            this.gridControlProductSales.TabIndex = 0;
            this.gridControlProductSales.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewProductSales});
            // 
            // gridViewProductSales
            // 
            this.gridViewProductSales.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gridViewProductSales.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewProductSales.Appearance.FooterPanel.Options.UseFont = true;
            this.gridViewProductSales.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridViewProductSales.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewProductSales.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridViewProductSales.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewProductSales.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewProductSales.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewProductSales.Appearance.ViewCaption.Options.UseForeColor = true;
            this.gridViewProductSales.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProductSaleId,
            this.colProductName,
            this.colCustomerName,
            this.colEmplpyeeName,
            this.colSalesDate,
            this.colUnit,
            this.colPrice,
            this.colProductSeriesNumber});
            this.gridViewProductSales.GridControl = this.gridControlProductSales;
            this.gridViewProductSales.Name = "gridViewProductSales";
            this.gridViewProductSales.OptionsMenu.EnableColumnMenu = false;
            this.gridViewProductSales.OptionsMenu.EnableFooterMenu = false;
            this.gridViewProductSales.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridViewProductSales.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridViewProductSales.OptionsPrint.AutoWidth = false;
            this.gridViewProductSales.OptionsPrint.PrintFooter = false;
            this.gridViewProductSales.OptionsPrint.PrintGroupFooter = false;
            this.gridViewProductSales.OptionsView.ColumnAutoWidth = false;
            this.gridViewProductSales.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.gridViewProductSales.OptionsView.RowAutoHeight = true;
            this.gridViewProductSales.OptionsView.ShowAutoFilterRow = true;
            this.gridViewProductSales.OptionsView.ShowGroupPanel = false;
            this.gridViewProductSales.OptionsView.ShowViewCaption = true;
            this.gridViewProductSales.ViewCaption = "Product Sales";
            // 
            // colProductSaleId
            // 
            this.colProductSaleId.Caption = "Product Sale ID";
            this.colProductSaleId.FieldName = "ProductSaleId";
            this.colProductSaleId.Name = "colProductSaleId";
            this.colProductSaleId.OptionsColumn.AllowEdit = false;
            this.colProductSaleId.Visible = true;
            this.colProductSaleId.VisibleIndex = 0;
            this.colProductSaleId.Width = 160;
            // 
            // colProductName
            // 
            this.colProductName.Caption = "Product Name";
            this.colProductName.FieldName = "ProductName";
            this.colProductName.Name = "colProductName";
            this.colProductName.OptionsColumn.AllowEdit = false;
            this.colProductName.Visible = true;
            this.colProductName.VisibleIndex = 1;
            this.colProductName.Width = 160;
            // 
            // colCustomerName
            // 
            this.colCustomerName.Caption = "Customer Name";
            this.colCustomerName.FieldName = "CustomerFullName";
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.OptionsColumn.AllowEdit = false;
            this.colCustomerName.Visible = true;
            this.colCustomerName.VisibleIndex = 2;
            this.colCustomerName.Width = 160;
            // 
            // colEmplpyeeName
            // 
            this.colEmplpyeeName.Caption = "Employee Name";
            this.colEmplpyeeName.FieldName = "EmployeeFullName";
            this.colEmplpyeeName.Name = "colEmplpyeeName";
            this.colEmplpyeeName.OptionsColumn.AllowEdit = false;
            this.colEmplpyeeName.Visible = true;
            this.colEmplpyeeName.VisibleIndex = 3;
            this.colEmplpyeeName.Width = 160;
            // 
            // colSalesDate
            // 
            this.colSalesDate.Caption = "Sales Date";
            this.colSalesDate.FieldName = "SalesDate";
            this.colSalesDate.Name = "colSalesDate";
            this.colSalesDate.OptionsColumn.AllowEdit = false;
            this.colSalesDate.Visible = true;
            this.colSalesDate.VisibleIndex = 4;
            this.colSalesDate.Width = 160;
            // 
            // colUnit
            // 
            this.colUnit.Caption = "Unit";
            this.colUnit.FieldName = "Unit";
            this.colUnit.Name = "colUnit";
            this.colUnit.OptionsColumn.AllowEdit = false;
            this.colUnit.Visible = true;
            this.colUnit.VisibleIndex = 5;
            this.colUnit.Width = 150;
            // 
            // colPrice
            // 
            this.colPrice.Caption = "Price";
            this.colPrice.FieldName = "Price";
            this.colPrice.Name = "colPrice";
            this.colPrice.OptionsColumn.AllowEdit = false;
            this.colPrice.Visible = true;
            this.colPrice.VisibleIndex = 6;
            this.colPrice.Width = 150;
            // 
            // colProductSeriesNumber
            // 
            this.colProductSeriesNumber.Caption = "Product Series Number";
            this.colProductSeriesNumber.FieldName = "ProductSeriesNumber";
            this.colProductSeriesNumber.Name = "colProductSeriesNumber";
            this.colProductSeriesNumber.OptionsColumn.AllowEdit = false;
            this.colProductSeriesNumber.Visible = true;
            this.colProductSeriesNumber.VisibleIndex = 7;
            this.colProductSeriesNumber.Width = 150;
            // 
            // ProductSalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 543);
            this.Controls.Add(this.gridControlProductSales);
            this.Name = "ProductSalesForm";
            this.Text = "Product Sales";
            this.Load += new System.EventHandler(this.ProductSalesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProductSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProductSales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.MyGridControl gridControlProductSales;
        private Controls.MyGridView gridViewProductSales;
        private Controls.MyGridColumn colProductSaleId;
        private Controls.MyGridColumn colProductName;
        private Controls.MyGridColumn colCustomerName;
        private Controls.MyGridColumn colEmplpyeeName;
        private Controls.MyGridColumn colSalesDate;
        private Controls.MyGridColumn colUnit;
        private Controls.MyGridColumn colPrice;
        private Controls.MyGridColumn colProductSeriesNumber;
    }
}