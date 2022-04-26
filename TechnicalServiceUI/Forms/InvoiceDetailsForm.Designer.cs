namespace TechnicalServiceUI.Forms
{
    partial class InvoiceDetailsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceDetailsForm));
            DevExpress.XtraLayout.ColumnDefinition columnDefinition1 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition1 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition2 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition3 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition4 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition5 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition6 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition7 = new DevExpress.XtraLayout.RowDefinition();
            this.gridControlInvoiceDetails = new TechnicalServiceUI.Controls.MyGridControl();
            this.myGridView1 = new TechnicalServiceUI.Controls.MyGridView();
            this.colInvoiceDetailId = new TechnicalServiceUI.Controls.MyGridColumn();
            this.colProductName = new TechnicalServiceUI.Controls.MyGridColumn();
            this.colUnit = new TechnicalServiceUI.Controls.MyGridColumn();
            this.colPrice = new TechnicalServiceUI.Controls.MyGridColumn();
            this.colTotalPrice = new TechnicalServiceUI.Controls.MyGridColumn();
            this.colInvoiceInfoId = new TechnicalServiceUI.Controls.MyGridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnClearInvoiceDetails = new TechnicalServiceUI.Controls.MySimpleButton();
            this.btnUpdateInvoiceDetail = new TechnicalServiceUI.Controls.MySimpleButton();
            this.btnDeleteInvoiceDetail = new TechnicalServiceUI.Controls.MySimpleButton();
            this.btnAddInvoiceDetail = new TechnicalServiceUI.Controls.MySimpleButton();
            this.myDataLayoutControl1 = new TechnicalServiceUI.Controls.MyDataLayoutControl();
            this.lueProductName = new TechnicalServiceUI.Controls.MyLookUpEdit();
            this.lueInvoiceId = new TechnicalServiceUI.Controls.MyLookUpEdit();
            this.txtTotalPrice = new TechnicalServiceUI.Controls.MyPriceTextEdit();
            this.txtPrice = new TechnicalServiceUI.Controls.MyPriceTextEdit();
            this.txtUnit = new TechnicalServiceUI.Controls.MyTextBox();
            this.txtInvoiceDetailId = new TechnicalServiceUI.Controls.MyTextBox();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlInvoiceDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl1)).BeginInit();
            this.myDataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueProductName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueInvoiceId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInvoiceDetailId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlInvoiceDetails
            // 
            this.gridControlInvoiceDetails.Dock = System.Windows.Forms.DockStyle.Left;
            this.gridControlInvoiceDetails.Location = new System.Drawing.Point(0, 0);
            this.gridControlInvoiceDetails.MainView = this.myGridView1;
            this.gridControlInvoiceDetails.Name = "gridControlInvoiceDetails";
            this.gridControlInvoiceDetails.Size = new System.Drawing.Size(976, 543);
            this.gridControlInvoiceDetails.TabIndex = 0;
            this.gridControlInvoiceDetails.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.myGridView1});
            // 
            // myGridView1
            // 
            this.myGridView1.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.myGridView1.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Maroon;
            this.myGridView1.Appearance.FooterPanel.Options.UseFont = true;
            this.myGridView1.Appearance.FooterPanel.Options.UseForeColor = true;
            this.myGridView1.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.myGridView1.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.myGridView1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.myGridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.myGridView1.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon;
            this.myGridView1.Appearance.ViewCaption.Options.UseForeColor = true;
            this.myGridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colInvoiceDetailId,
            this.colProductName,
            this.colUnit,
            this.colPrice,
            this.colTotalPrice,
            this.colInvoiceInfoId});
            this.myGridView1.GridControl = this.gridControlInvoiceDetails;
            this.myGridView1.Name = "myGridView1";
            this.myGridView1.OptionsMenu.EnableColumnMenu = false;
            this.myGridView1.OptionsMenu.EnableFooterMenu = false;
            this.myGridView1.OptionsMenu.EnableGroupPanelMenu = false;
            this.myGridView1.OptionsNavigation.EnterMoveNextColumn = true;
            this.myGridView1.OptionsPrint.AutoWidth = false;
            this.myGridView1.OptionsPrint.PrintFooter = false;
            this.myGridView1.OptionsPrint.PrintGroupFooter = false;
            this.myGridView1.OptionsView.ColumnAutoWidth = false;
            this.myGridView1.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.myGridView1.OptionsView.RowAutoHeight = true;
            this.myGridView1.OptionsView.ShowAutoFilterRow = true;
            this.myGridView1.OptionsView.ShowGroupPanel = false;
            this.myGridView1.OptionsView.ShowViewCaption = true;
            // 
            // colInvoiceDetailId
            // 
            this.colInvoiceDetailId.Caption = "Invoice Detail ID";
            this.colInvoiceDetailId.FieldName = "InvoiceDetailId";
            this.colInvoiceDetailId.Name = "colInvoiceDetailId";
            this.colInvoiceDetailId.OptionsColumn.AllowEdit = false;
            this.colInvoiceDetailId.Visible = true;
            this.colInvoiceDetailId.VisibleIndex = 0;
            this.colInvoiceDetailId.Width = 150;
            // 
            // colProductName
            // 
            this.colProductName.Caption = "Product Name";
            this.colProductName.FieldName = "ProductName";
            this.colProductName.Name = "colProductName";
            this.colProductName.OptionsColumn.AllowEdit = false;
            this.colProductName.Visible = true;
            this.colProductName.VisibleIndex = 1;
            this.colProductName.Width = 175;
            // 
            // colUnit
            // 
            this.colUnit.Caption = "Unit";
            this.colUnit.FieldName = "Unit";
            this.colUnit.Name = "colUnit";
            this.colUnit.OptionsColumn.AllowEdit = false;
            this.colUnit.Visible = true;
            this.colUnit.VisibleIndex = 2;
            this.colUnit.Width = 150;
            // 
            // colPrice
            // 
            this.colPrice.Caption = "Price";
            this.colPrice.FieldName = "Price";
            this.colPrice.Name = "colPrice";
            this.colPrice.OptionsColumn.AllowEdit = false;
            this.colPrice.Visible = true;
            this.colPrice.VisibleIndex = 3;
            this.colPrice.Width = 150;
            // 
            // colTotalPrice
            // 
            this.colTotalPrice.Caption = "Total Price";
            this.colTotalPrice.FieldName = "TotalPrice";
            this.colTotalPrice.Name = "colTotalPrice";
            this.colTotalPrice.OptionsColumn.AllowEdit = false;
            this.colTotalPrice.Visible = true;
            this.colTotalPrice.VisibleIndex = 4;
            this.colTotalPrice.Width = 150;
            // 
            // colInvoiceInfoId
            // 
            this.colInvoiceInfoId.Caption = "Invoice ID";
            this.colInvoiceInfoId.FieldName = "InvoiceInfoId";
            this.colInvoiceInfoId.Name = "colInvoiceInfoId";
            this.colInvoiceInfoId.OptionsColumn.AllowEdit = false;
            this.colInvoiceInfoId.Visible = true;
            this.colInvoiceInfoId.VisibleIndex = 5;
            this.colInvoiceInfoId.Width = 150;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnClearInvoiceDetails);
            this.panelControl1.Controls.Add(this.btnUpdateInvoiceDetail);
            this.panelControl1.Controls.Add(this.btnDeleteInvoiceDetail);
            this.panelControl1.Controls.Add(this.btnAddInvoiceDetail);
            this.panelControl1.Controls.Add(this.myDataLayoutControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(976, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(317, 543);
            this.panelControl1.TabIndex = 1;
            // 
            // btnClearInvoiceDetails
            // 
            this.btnClearInvoiceDetails.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.btnClearInvoiceDetails.Appearance.Options.UseForeColor = true;
            this.btnClearInvoiceDetails.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClearInvoiceDetails.ImageOptions.Image")));
            this.btnClearInvoiceDetails.Location = new System.Drawing.Point(140, 273);
            this.btnClearInvoiceDetails.Name = "btnClearInvoiceDetails";
            this.btnClearInvoiceDetails.Size = new System.Drawing.Size(137, 23);
            this.btnClearInvoiceDetails.TabIndex = 4;
            this.btnClearInvoiceDetails.Text = "Clear All";
            // 
            // btnUpdateInvoiceDetail
            // 
            this.btnUpdateInvoiceDetail.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.btnUpdateInvoiceDetail.Appearance.Options.UseForeColor = true;
            this.btnUpdateInvoiceDetail.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateInvoiceDetail.ImageOptions.Image")));
            this.btnUpdateInvoiceDetail.Location = new System.Drawing.Point(140, 215);
            this.btnUpdateInvoiceDetail.Name = "btnUpdateInvoiceDetail";
            this.btnUpdateInvoiceDetail.Size = new System.Drawing.Size(137, 23);
            this.btnUpdateInvoiceDetail.TabIndex = 3;
            this.btnUpdateInvoiceDetail.Text = "Update Invoice Detail";
            // 
            // btnDeleteInvoiceDetail
            // 
            this.btnDeleteInvoiceDetail.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.btnDeleteInvoiceDetail.Appearance.Options.UseForeColor = true;
            this.btnDeleteInvoiceDetail.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteInvoiceDetail.ImageOptions.Image")));
            this.btnDeleteInvoiceDetail.Location = new System.Drawing.Point(140, 244);
            this.btnDeleteInvoiceDetail.Name = "btnDeleteInvoiceDetail";
            this.btnDeleteInvoiceDetail.Size = new System.Drawing.Size(137, 23);
            this.btnDeleteInvoiceDetail.TabIndex = 2;
            this.btnDeleteInvoiceDetail.Text = "Delete Invoice Detail";
            // 
            // btnAddInvoiceDetail
            // 
            this.btnAddInvoiceDetail.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.btnAddInvoiceDetail.Appearance.Options.UseForeColor = true;
            this.btnAddInvoiceDetail.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddInvoiceDetail.ImageOptions.Image")));
            this.btnAddInvoiceDetail.Location = new System.Drawing.Point(140, 186);
            this.btnAddInvoiceDetail.Name = "btnAddInvoiceDetail";
            this.btnAddInvoiceDetail.Size = new System.Drawing.Size(137, 23);
            this.btnAddInvoiceDetail.TabIndex = 1;
            this.btnAddInvoiceDetail.Text = "Add Invoice Detail";
            // 
            // myDataLayoutControl1
            // 
            this.myDataLayoutControl1.Controls.Add(this.lueProductName);
            this.myDataLayoutControl1.Controls.Add(this.lueInvoiceId);
            this.myDataLayoutControl1.Controls.Add(this.txtTotalPrice);
            this.myDataLayoutControl1.Controls.Add(this.txtPrice);
            this.myDataLayoutControl1.Controls.Add(this.txtUnit);
            this.myDataLayoutControl1.Controls.Add(this.txtInvoiceDetailId);
            this.myDataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.myDataLayoutControl1.Location = new System.Drawing.Point(2, 2);
            this.myDataLayoutControl1.Name = "myDataLayoutControl1";
            this.myDataLayoutControl1.OptionsFocus.EnableAutoTabOrder = false;
            this.myDataLayoutControl1.Root = this.Root;
            this.myDataLayoutControl1.Size = new System.Drawing.Size(313, 189);
            this.myDataLayoutControl1.TabIndex = 0;
            this.myDataLayoutControl1.Text = "myDataLayoutControl1";
            // 
            // lueProductName
            // 
            this.lueProductName.EnterMoveNextControl = true;
            this.lueProductName.Location = new System.Drawing.Point(103, 36);
            this.lueProductName.Name = "lueProductName";
            this.lueProductName.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.lueProductName.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.lueProductName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueProductName.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ProductId", "Product ID"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ProductName", "Product Name")});
            this.lueProductName.Properties.NullText = "";
            this.lueProductName.Size = new System.Drawing.Size(198, 20);
            this.lueProductName.StyleController = this.myDataLayoutControl1;
            this.lueProductName.TabIndex = 10;
            // 
            // lueInvoiceId
            // 
            this.lueInvoiceId.EnterMoveNextControl = true;
            this.lueInvoiceId.Location = new System.Drawing.Point(103, 132);
            this.lueInvoiceId.Name = "lueInvoiceId";
            this.lueInvoiceId.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.lueInvoiceId.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.lueInvoiceId.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueInvoiceId.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("InvoiceInfoId", "Invoice ID")});
            this.lueInvoiceId.Properties.NullText = "";
            this.lueInvoiceId.Size = new System.Drawing.Size(198, 20);
            this.lueInvoiceId.StyleController = this.myDataLayoutControl1;
            this.lueInvoiceId.TabIndex = 9;
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Location = new System.Drawing.Point(103, 108);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Properties.Appearance.Options.UseTextOptions = true;
            this.txtTotalPrice.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtTotalPrice.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtTotalPrice.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtTotalPrice.Properties.Mask.EditMask = "c";
            this.txtTotalPrice.Properties.MaskSettings.Set("mask", "c");
            this.txtTotalPrice.Size = new System.Drawing.Size(198, 20);
            this.txtTotalPrice.StyleController = this.myDataLayoutControl1;
            this.txtTotalPrice.TabIndex = 8;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(103, 84);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Properties.Appearance.Options.UseTextOptions = true;
            this.txtPrice.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtPrice.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtPrice.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtPrice.Properties.Mask.EditMask = "c";
            this.txtPrice.Properties.MaskSettings.Set("mask", "c");
            this.txtPrice.Size = new System.Drawing.Size(198, 20);
            this.txtPrice.StyleController = this.myDataLayoutControl1;
            this.txtPrice.TabIndex = 7;
            // 
            // txtUnit
            // 
            this.txtUnit.EnterMoveNextControl = true;
            this.txtUnit.Location = new System.Drawing.Point(103, 60);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtUnit.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtUnit.Size = new System.Drawing.Size(198, 20);
            this.txtUnit.StyleController = this.myDataLayoutControl1;
            this.txtUnit.TabIndex = 6;
            // 
            // txtInvoiceDetailId
            // 
            this.txtInvoiceDetailId.EnterMoveNextControl = true;
            this.txtInvoiceDetailId.Location = new System.Drawing.Point(103, 12);
            this.txtInvoiceDetailId.Name = "txtInvoiceDetailId";
            this.txtInvoiceDetailId.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtInvoiceDetailId.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtInvoiceDetailId.Size = new System.Drawing.Size(198, 20);
            this.txtInvoiceDetailId.StyleController = this.myDataLayoutControl1;
            this.txtInvoiceDetailId.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
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
            this.Root.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition1,
            rowDefinition2,
            rowDefinition3,
            rowDefinition4,
            rowDefinition5,
            rowDefinition6,
            rowDefinition7});
            this.Root.Size = new System.Drawing.Size(313, 189);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem1.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem1.Control = this.txtInvoiceDetailId;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(293, 24);
            this.layoutControlItem1.Text = "Invoice Detail ID";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(79, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem3.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem3.Control = this.txtUnit;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.OptionsTableLayoutItem.RowIndex = 2;
            this.layoutControlItem3.Size = new System.Drawing.Size(293, 24);
            this.layoutControlItem3.Text = "Unit";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(79, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem4.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem4.Control = this.txtPrice;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.OptionsTableLayoutItem.RowIndex = 3;
            this.layoutControlItem4.Size = new System.Drawing.Size(293, 24);
            this.layoutControlItem4.Text = "Price";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(79, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem5.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem5.Control = this.txtTotalPrice;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.OptionsTableLayoutItem.RowIndex = 4;
            this.layoutControlItem5.Size = new System.Drawing.Size(293, 24);
            this.layoutControlItem5.Text = "Total Price";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(79, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem6.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem6.Control = this.lueInvoiceId;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 120);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.OptionsTableLayoutItem.RowIndex = 5;
            this.layoutControlItem6.Size = new System.Drawing.Size(293, 24);
            this.layoutControlItem6.Text = "Invoice ID";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(79, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem2.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem2.Control = this.lueProductName;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlItem2.Size = new System.Drawing.Size(293, 24);
            this.layoutControlItem2.Text = "Product Name";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(79, 13);
            // 
            // InvoiceDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 543);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.gridControlInvoiceDetails);
            this.Name = "InvoiceDetailsForm";
            this.Text = "Invoice Details";
            this.Load += new System.EventHandler(this.InvoiceDetailsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlInvoiceDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl1)).EndInit();
            this.myDataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lueProductName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueInvoiceId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInvoiceDetailId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.MyGridControl gridControlInvoiceDetails;
        private Controls.MyGridView myGridView1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private Controls.MyDataLayoutControl myDataLayoutControl1;
        private Controls.MyLookUpEdit lueProductName;
        private Controls.MyLookUpEdit lueInvoiceId;
        private Controls.MyPriceTextEdit txtTotalPrice;
        private Controls.MyPriceTextEdit txtPrice;
        private Controls.MyTextBox txtUnit;
        private Controls.MyTextBox txtInvoiceDetailId;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private Controls.MySimpleButton btnClearInvoiceDetails;
        private Controls.MySimpleButton btnUpdateInvoiceDetail;
        private Controls.MySimpleButton btnDeleteInvoiceDetail;
        private Controls.MySimpleButton btnAddInvoiceDetail;
        private Controls.MyGridColumn colInvoiceDetailId;
        private Controls.MyGridColumn colProductName;
        private Controls.MyGridColumn colUnit;
        private Controls.MyGridColumn colPrice;
        private Controls.MyGridColumn colTotalPrice;
        private Controls.MyGridColumn colInvoiceInfoId;
    }
}