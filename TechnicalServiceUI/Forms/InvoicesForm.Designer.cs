namespace TechnicalServiceUI.Forms
{
    partial class InvoicesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoicesForm));
            DevExpress.XtraLayout.ColumnDefinition columnDefinition1 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition1 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition2 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition3 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition4 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition5 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition6 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition7 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition8 = new DevExpress.XtraLayout.RowDefinition();
            this.gridControlInvoices = new TechnicalServiceUI.Controls.MyGridControl();
            this.gridViewInvoices = new TechnicalServiceUI.Controls.MyGridView();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnDeleteInvoice = new TechnicalServiceUI.Controls.MySimpleButton();
            this.btnUpdateInvoice = new TechnicalServiceUI.Controls.MySimpleButton();
            this.btnClearInvoices = new TechnicalServiceUI.Controls.MySimpleButton();
            this.btnAddInvoice = new TechnicalServiceUI.Controls.MySimpleButton();
            this.myDataLayoutControl1 = new TechnicalServiceUI.Controls.MyDataLayoutControl();
            this.lueEmployeeName = new TechnicalServiceUI.Controls.MyLookUpEdit();
            this.lueCustomerName = new TechnicalServiceUI.Controls.MyLookUpEdit();
            this.txtTaxOffice = new TechnicalServiceUI.Controls.MyTextBox();
            this.deInvoiceDate = new TechnicalServiceUI.Controls.MyDateEdit();
            this.txtInvoiceOrderNumber = new TechnicalServiceUI.Controls.MyTextBox();
            this.txtInvoiceSerialNumber = new TechnicalServiceUI.Controls.MyTextBox();
            this.txtInvoiceInfoId = new TechnicalServiceUI.Controls.MyTextBox();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlInvoices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewInvoices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl1)).BeginInit();
            this.myDataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueEmployeeName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueCustomerName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaxOffice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deInvoiceDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deInvoiceDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInvoiceOrderNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInvoiceSerialNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInvoiceInfoId.Properties)).BeginInit();
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
            // gridControlInvoices
            // 
            this.gridControlInvoices.Dock = System.Windows.Forms.DockStyle.Left;
            this.gridControlInvoices.Location = new System.Drawing.Point(0, 0);
            this.gridControlInvoices.MainView = this.gridViewInvoices;
            this.gridControlInvoices.Name = "gridControlInvoices";
            this.gridControlInvoices.Size = new System.Drawing.Size(970, 543);
            this.gridControlInvoices.TabIndex = 0;
            this.gridControlInvoices.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewInvoices});
            // 
            // gridViewInvoices
            // 
            this.gridViewInvoices.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gridViewInvoices.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewInvoices.Appearance.FooterPanel.Options.UseFont = true;
            this.gridViewInvoices.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridViewInvoices.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewInvoices.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridViewInvoices.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewInvoices.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewInvoices.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewInvoices.Appearance.ViewCaption.Options.UseForeColor = true;
            this.gridViewInvoices.GridControl = this.gridControlInvoices;
            this.gridViewInvoices.Name = "gridViewInvoices";
            this.gridViewInvoices.OptionsMenu.EnableColumnMenu = false;
            this.gridViewInvoices.OptionsMenu.EnableFooterMenu = false;
            this.gridViewInvoices.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridViewInvoices.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridViewInvoices.OptionsPrint.AutoWidth = false;
            this.gridViewInvoices.OptionsPrint.PrintFooter = false;
            this.gridViewInvoices.OptionsPrint.PrintGroupFooter = false;
            this.gridViewInvoices.OptionsView.ColumnAutoWidth = false;
            this.gridViewInvoices.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.gridViewInvoices.OptionsView.RowAutoHeight = true;
            this.gridViewInvoices.OptionsView.ShowAutoFilterRow = true;
            this.gridViewInvoices.OptionsView.ShowGroupPanel = false;
            this.gridViewInvoices.OptionsView.ShowViewCaption = true;
            this.gridViewInvoices.ViewCaption = "Invoices";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnDeleteInvoice);
            this.panelControl1.Controls.Add(this.btnUpdateInvoice);
            this.panelControl1.Controls.Add(this.btnClearInvoices);
            this.panelControl1.Controls.Add(this.btnAddInvoice);
            this.panelControl1.Controls.Add(this.myDataLayoutControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(970, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(323, 543);
            this.panelControl1.TabIndex = 1;
            // 
            // btnDeleteInvoice
            // 
            this.btnDeleteInvoice.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.btnDeleteInvoice.Appearance.Options.UseForeColor = true;
            this.btnDeleteInvoice.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteInvoice.ImageOptions.Image")));
            this.btnDeleteInvoice.Location = new System.Drawing.Point(71, 270);
            this.btnDeleteInvoice.Name = "btnDeleteInvoice";
            this.btnDeleteInvoice.Size = new System.Drawing.Size(116, 41);
            this.btnDeleteInvoice.TabIndex = 4;
            this.btnDeleteInvoice.Text = "Delete Invoice";
            // 
            // btnUpdateInvoice
            // 
            this.btnUpdateInvoice.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.btnUpdateInvoice.Appearance.Options.UseForeColor = true;
            this.btnUpdateInvoice.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateInvoice.ImageOptions.Image")));
            this.btnUpdateInvoice.Location = new System.Drawing.Point(193, 219);
            this.btnUpdateInvoice.Name = "btnUpdateInvoice";
            this.btnUpdateInvoice.Size = new System.Drawing.Size(116, 41);
            this.btnUpdateInvoice.TabIndex = 3;
            this.btnUpdateInvoice.Text = "Update Invoice";
            // 
            // btnClearInvoices
            // 
            this.btnClearInvoices.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.btnClearInvoices.Appearance.Options.UseForeColor = true;
            this.btnClearInvoices.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClearInvoices.ImageOptions.Image")));
            this.btnClearInvoices.Location = new System.Drawing.Point(193, 270);
            this.btnClearInvoices.Name = "btnClearInvoices";
            this.btnClearInvoices.Size = new System.Drawing.Size(116, 41);
            this.btnClearInvoices.TabIndex = 2;
            this.btnClearInvoices.Text = "Clear Invoices";
            // 
            // btnAddInvoice
            // 
            this.btnAddInvoice.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.btnAddInvoice.Appearance.Options.UseForeColor = true;
            this.btnAddInvoice.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddInvoice.ImageOptions.Image")));
            this.btnAddInvoice.Location = new System.Drawing.Point(71, 219);
            this.btnAddInvoice.Name = "btnAddInvoice";
            this.btnAddInvoice.Size = new System.Drawing.Size(116, 41);
            this.btnAddInvoice.TabIndex = 1;
            this.btnAddInvoice.Text = "Add Invoice";
            // 
            // myDataLayoutControl1
            // 
            this.myDataLayoutControl1.Controls.Add(this.lueEmployeeName);
            this.myDataLayoutControl1.Controls.Add(this.lueCustomerName);
            this.myDataLayoutControl1.Controls.Add(this.txtTaxOffice);
            this.myDataLayoutControl1.Controls.Add(this.deInvoiceDate);
            this.myDataLayoutControl1.Controls.Add(this.txtInvoiceOrderNumber);
            this.myDataLayoutControl1.Controls.Add(this.txtInvoiceSerialNumber);
            this.myDataLayoutControl1.Controls.Add(this.txtInvoiceInfoId);
            this.myDataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.myDataLayoutControl1.Location = new System.Drawing.Point(2, 2);
            this.myDataLayoutControl1.Name = "myDataLayoutControl1";
            this.myDataLayoutControl1.OptionsFocus.EnableAutoTabOrder = false;
            this.myDataLayoutControl1.Root = this.Root;
            this.myDataLayoutControl1.Size = new System.Drawing.Size(319, 228);
            this.myDataLayoutControl1.TabIndex = 0;
            this.myDataLayoutControl1.Text = "myDataLayoutControl1";
            // 
            // lueEmployeeName
            // 
            this.lueEmployeeName.EnterMoveNextControl = true;
            this.lueEmployeeName.Location = new System.Drawing.Point(130, 156);
            this.lueEmployeeName.Name = "lueEmployeeName";
            this.lueEmployeeName.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.lueEmployeeName.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.lueEmployeeName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueEmployeeName.Properties.NullText = "";
            this.lueEmployeeName.Size = new System.Drawing.Size(177, 20);
            this.lueEmployeeName.StyleController = this.myDataLayoutControl1;
            this.lueEmployeeName.TabIndex = 10;
            // 
            // lueCustomerName
            // 
            this.lueCustomerName.EnterMoveNextControl = true;
            this.lueCustomerName.Location = new System.Drawing.Point(130, 132);
            this.lueCustomerName.Name = "lueCustomerName";
            this.lueCustomerName.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.lueCustomerName.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.lueCustomerName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueCustomerName.Properties.NullText = "";
            this.lueCustomerName.Size = new System.Drawing.Size(177, 20);
            this.lueCustomerName.StyleController = this.myDataLayoutControl1;
            this.lueCustomerName.TabIndex = 9;
            // 
            // txtTaxOffice
            // 
            this.txtTaxOffice.EnterMoveNextControl = true;
            this.txtTaxOffice.Location = new System.Drawing.Point(130, 108);
            this.txtTaxOffice.Name = "txtTaxOffice";
            this.txtTaxOffice.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtTaxOffice.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtTaxOffice.Size = new System.Drawing.Size(177, 20);
            this.txtTaxOffice.StyleController = this.myDataLayoutControl1;
            this.txtTaxOffice.TabIndex = 8;
            // 
            // deInvoiceDate
            // 
            this.deInvoiceDate.EditValue = null;
            this.deInvoiceDate.EnterMoveNextControl = true;
            this.deInvoiceDate.Location = new System.Drawing.Point(130, 84);
            this.deInvoiceDate.Name = "deInvoiceDate";
            this.deInvoiceDate.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.deInvoiceDate.Properties.Appearance.Options.UseTextOptions = true;
            this.deInvoiceDate.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.deInvoiceDate.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.deInvoiceDate.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.deInvoiceDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deInvoiceDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deInvoiceDate.Size = new System.Drawing.Size(177, 20);
            this.deInvoiceDate.StyleController = this.myDataLayoutControl1;
            this.deInvoiceDate.TabIndex = 7;
            // 
            // txtInvoiceOrderNumber
            // 
            this.txtInvoiceOrderNumber.EnterMoveNextControl = true;
            this.txtInvoiceOrderNumber.Location = new System.Drawing.Point(130, 60);
            this.txtInvoiceOrderNumber.Name = "txtInvoiceOrderNumber";
            this.txtInvoiceOrderNumber.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtInvoiceOrderNumber.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtInvoiceOrderNumber.Size = new System.Drawing.Size(177, 20);
            this.txtInvoiceOrderNumber.StyleController = this.myDataLayoutControl1;
            this.txtInvoiceOrderNumber.TabIndex = 6;
            // 
            // txtInvoiceSerialNumber
            // 
            this.txtInvoiceSerialNumber.EnterMoveNextControl = true;
            this.txtInvoiceSerialNumber.Location = new System.Drawing.Point(130, 36);
            this.txtInvoiceSerialNumber.Name = "txtInvoiceSerialNumber";
            this.txtInvoiceSerialNumber.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtInvoiceSerialNumber.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtInvoiceSerialNumber.Size = new System.Drawing.Size(177, 20);
            this.txtInvoiceSerialNumber.StyleController = this.myDataLayoutControl1;
            this.txtInvoiceSerialNumber.TabIndex = 5;
            // 
            // txtInvoiceInfoId
            // 
            this.txtInvoiceInfoId.EnterMoveNextControl = true;
            this.txtInvoiceInfoId.Location = new System.Drawing.Point(130, 12);
            this.txtInvoiceInfoId.Name = "txtInvoiceInfoId";
            this.txtInvoiceInfoId.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtInvoiceInfoId.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtInvoiceInfoId.Size = new System.Drawing.Size(177, 20);
            this.txtInvoiceInfoId.StyleController = this.myDataLayoutControl1;
            this.txtInvoiceInfoId.TabIndex = 4;
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
            this.Root.Size = new System.Drawing.Size(319, 228);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem1.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem1.Control = this.txtInvoiceInfoId;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(299, 24);
            this.layoutControlItem1.Text = "Invoice ID";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(106, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem2.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem2.Control = this.txtInvoiceSerialNumber;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlItem2.Size = new System.Drawing.Size(299, 24);
            this.layoutControlItem2.Text = "Invoice Serial Number";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(106, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem3.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem3.Control = this.txtInvoiceOrderNumber;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.OptionsTableLayoutItem.RowIndex = 2;
            this.layoutControlItem3.Size = new System.Drawing.Size(299, 24);
            this.layoutControlItem3.Text = "Invoice Order Number";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(106, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem4.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem4.Control = this.deInvoiceDate;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.OptionsTableLayoutItem.RowIndex = 3;
            this.layoutControlItem4.Size = new System.Drawing.Size(299, 24);
            this.layoutControlItem4.Text = "Invoice Date";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(106, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem5.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem5.Control = this.txtTaxOffice;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.OptionsTableLayoutItem.RowIndex = 4;
            this.layoutControlItem5.Size = new System.Drawing.Size(299, 24);
            this.layoutControlItem5.Text = "Tax Office";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(106, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem6.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem6.Control = this.lueCustomerName;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 120);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.OptionsTableLayoutItem.RowIndex = 5;
            this.layoutControlItem6.Size = new System.Drawing.Size(299, 24);
            this.layoutControlItem6.Text = "Customer Name";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(106, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem7.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem7.Control = this.lueEmployeeName;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 144);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.OptionsTableLayoutItem.RowIndex = 6;
            this.layoutControlItem7.Size = new System.Drawing.Size(299, 24);
            this.layoutControlItem7.Text = "Employee Name";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(106, 13);
            // 
            // InvoicesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 543);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.gridControlInvoices);
            this.Name = "InvoicesForm";
            this.Text = "Invoices";
            ((System.ComponentModel.ISupportInitialize)(this.gridControlInvoices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewInvoices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl1)).EndInit();
            this.myDataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lueEmployeeName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueCustomerName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaxOffice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deInvoiceDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deInvoiceDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInvoiceOrderNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInvoiceSerialNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInvoiceInfoId.Properties)).EndInit();
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

        private Controls.MyGridControl gridControlInvoices;
        private Controls.MyGridView gridViewInvoices;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private Controls.MyDataLayoutControl myDataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private Controls.MySimpleButton btnDeleteInvoice;
        private Controls.MySimpleButton btnUpdateInvoice;
        private Controls.MySimpleButton btnClearInvoices;
        private Controls.MySimpleButton btnAddInvoice;
        private Controls.MyLookUpEdit lueEmployeeName;
        private Controls.MyLookUpEdit lueCustomerName;
        private Controls.MyTextBox txtTaxOffice;
        private Controls.MyDateEdit deInvoiceDate;
        private Controls.MyTextBox txtInvoiceOrderNumber;
        private Controls.MyTextBox txtInvoiceSerialNumber;
        private Controls.MyTextBox txtInvoiceInfoId;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
    }
}