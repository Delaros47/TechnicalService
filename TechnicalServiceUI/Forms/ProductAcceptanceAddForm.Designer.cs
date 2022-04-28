namespace TechnicalServiceUI.Forms
{
    partial class ProductAcceptanceAddForm
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
            DevExpress.XtraLayout.RowDefinition rowDefinition4 = new DevExpress.XtraLayout.RowDefinition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductAcceptanceAddForm));
            this.myDataLayoutControl1 = new TechnicalServiceUI.Controls.MyDataLayoutControl();
            this.txtProductSeriesNumber = new TechnicalServiceUI.Controls.MyTextBox();
            this.deArrivalDate = new TechnicalServiceUI.Controls.MyDateEdit();
            this.lueEmployeeName = new TechnicalServiceUI.Controls.MyLookUpEdit();
            this.lueCustomerName = new TechnicalServiceUI.Controls.MyLookUpEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnAddProductAcceptance = new TechnicalServiceUI.Controls.MySimpleButton();
            this.btnClearAll = new TechnicalServiceUI.Controls.MySimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl1)).BeginInit();
            this.myDataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductSeriesNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deArrivalDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deArrivalDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueEmployeeName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueCustomerName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // myDataLayoutControl1
            // 
            this.myDataLayoutControl1.Controls.Add(this.txtProductSeriesNumber);
            this.myDataLayoutControl1.Controls.Add(this.deArrivalDate);
            this.myDataLayoutControl1.Controls.Add(this.lueEmployeeName);
            this.myDataLayoutControl1.Controls.Add(this.lueCustomerName);
            this.myDataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.myDataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.myDataLayoutControl1.Name = "myDataLayoutControl1";
            this.myDataLayoutControl1.OptionsFocus.EnableAutoTabOrder = false;
            this.myDataLayoutControl1.Root = this.Root;
            this.myDataLayoutControl1.Size = new System.Drawing.Size(398, 135);
            this.myDataLayoutControl1.TabIndex = 0;
            this.myDataLayoutControl1.Text = "myDataLayoutControl1";
            // 
            // txtProductSeriesNumber
            // 
            this.txtProductSeriesNumber.EnterMoveNextControl = true;
            this.txtProductSeriesNumber.Location = new System.Drawing.Point(133, 84);
            this.txtProductSeriesNumber.Name = "txtProductSeriesNumber";
            this.txtProductSeriesNumber.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtProductSeriesNumber.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtProductSeriesNumber.Size = new System.Drawing.Size(253, 20);
            this.txtProductSeriesNumber.StyleController = this.myDataLayoutControl1;
            this.txtProductSeriesNumber.TabIndex = 7;
            // 
            // deArrivalDate
            // 
            this.deArrivalDate.EditValue = null;
            this.deArrivalDate.EnterMoveNextControl = true;
            this.deArrivalDate.Location = new System.Drawing.Point(133, 60);
            this.deArrivalDate.Name = "deArrivalDate";
            this.deArrivalDate.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.deArrivalDate.Properties.Appearance.Options.UseTextOptions = true;
            this.deArrivalDate.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.deArrivalDate.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.deArrivalDate.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.deArrivalDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deArrivalDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deArrivalDate.Size = new System.Drawing.Size(253, 20);
            this.deArrivalDate.StyleController = this.myDataLayoutControl1;
            this.deArrivalDate.TabIndex = 6;
            // 
            // lueEmployeeName
            // 
            this.lueEmployeeName.EnterMoveNextControl = true;
            this.lueEmployeeName.Location = new System.Drawing.Point(133, 36);
            this.lueEmployeeName.Name = "lueEmployeeName";
            this.lueEmployeeName.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.lueEmployeeName.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.lueEmployeeName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueEmployeeName.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EmployeeId", "Employee ID"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EmployeeFullName", "Employee Full Name")});
            this.lueEmployeeName.Properties.NullText = "";
            this.lueEmployeeName.Size = new System.Drawing.Size(253, 20);
            this.lueEmployeeName.StyleController = this.myDataLayoutControl1;
            this.lueEmployeeName.TabIndex = 5;
            // 
            // lueCustomerName
            // 
            this.lueCustomerName.EnterMoveNextControl = true;
            this.lueCustomerName.Location = new System.Drawing.Point(133, 12);
            this.lueCustomerName.Name = "lueCustomerName";
            this.lueCustomerName.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.lueCustomerName.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.lueCustomerName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueCustomerName.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomerId", "Customer ID"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomerFullName", "Customer Full Name")});
            this.lueCustomerName.Properties.NullText = "";
            this.lueCustomerName.Size = new System.Drawing.Size(253, 20);
            this.lueCustomerName.StyleController = this.myDataLayoutControl1;
            this.lueCustomerName.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4});
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
            this.Root.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition1,
            rowDefinition2,
            rowDefinition3,
            rowDefinition4});
            this.Root.Size = new System.Drawing.Size(398, 135);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem1.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem1.Control = this.lueCustomerName;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(378, 24);
            this.layoutControlItem1.Text = "Customer Name";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(109, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem2.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem2.Control = this.lueEmployeeName;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlItem2.Size = new System.Drawing.Size(378, 24);
            this.layoutControlItem2.Text = "Employee Name";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(109, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem3.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem3.Control = this.deArrivalDate;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.OptionsTableLayoutItem.RowIndex = 2;
            this.layoutControlItem3.Size = new System.Drawing.Size(378, 24);
            this.layoutControlItem3.Text = "Arrival Date";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(109, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem4.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem4.Control = this.txtProductSeriesNumber;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.OptionsTableLayoutItem.RowIndex = 3;
            this.layoutControlItem4.Size = new System.Drawing.Size(378, 43);
            this.layoutControlItem4.Text = "Product Series Number";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(109, 13);
            // 
            // btnAddProductAcceptance
            // 
            this.btnAddProductAcceptance.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.btnAddProductAcceptance.Appearance.Options.UseForeColor = true;
            this.btnAddProductAcceptance.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddProductAcceptance.ImageOptions.Image")));
            this.btnAddProductAcceptance.Location = new System.Drawing.Point(102, 141);
            this.btnAddProductAcceptance.Name = "btnAddProductAcceptance";
            this.btnAddProductAcceptance.Size = new System.Drawing.Size(158, 23);
            this.btnAddProductAcceptance.TabIndex = 1;
            this.btnAddProductAcceptance.Text = "Add Product Acceptance";
            this.btnAddProductAcceptance.Click += new System.EventHandler(this.btnAddProductAcceptance_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.btnClearAll.Appearance.Options.UseForeColor = true;
            this.btnClearAll.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClearAll.ImageOptions.Image")));
            this.btnClearAll.Location = new System.Drawing.Point(277, 141);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(97, 23);
            this.btnClearAll.TabIndex = 2;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // ProductAcceptanceAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 189);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnAddProductAcceptance);
            this.Controls.Add(this.myDataLayoutControl1);
            this.Name = "ProductAcceptanceAddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Product Acceptance";
            this.Load += new System.EventHandler(this.ProductAcceptanceAddForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl1)).EndInit();
            this.myDataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtProductSeriesNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deArrivalDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deArrivalDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueEmployeeName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueCustomerName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.MyDataLayoutControl myDataLayoutControl1;
        private Controls.MyTextBox txtProductSeriesNumber;
        private Controls.MyDateEdit deArrivalDate;
        private Controls.MyLookUpEdit lueEmployeeName;
        private Controls.MyLookUpEdit lueCustomerName;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private Controls.MySimpleButton btnAddProductAcceptance;
        private Controls.MySimpleButton btnClearAll;
    }
}