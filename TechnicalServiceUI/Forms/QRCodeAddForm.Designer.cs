namespace TechnicalServiceUI.Forms
{
    partial class QRCodeAddForm
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
            DevExpress.XtraLayout.ColumnDefinition columnDefinition2 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition4 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition5 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition6 = new DevExpress.XtraLayout.RowDefinition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QRCodeAddForm));
            this.myDataLayoutControl1 = new TechnicalServiceUI.Controls.MyDataLayoutControl();
            this.pictureEditQRCode = new DevExpress.XtraEditors.PictureEdit();
            this.txtProductSeriesNumber = new TechnicalServiceUI.Controls.MyTextBox();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnCreateQRCode = new TechnicalServiceUI.Controls.MySimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl1)).BeginInit();
            this.myDataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEditQRCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductSeriesNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // myDataLayoutControl1
            // 
            this.myDataLayoutControl1.Controls.Add(this.pictureEditQRCode);
            this.myDataLayoutControl1.Controls.Add(this.txtProductSeriesNumber);
            this.myDataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.myDataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.myDataLayoutControl1.Name = "myDataLayoutControl1";
            this.myDataLayoutControl1.OptionsFocus.EnableAutoTabOrder = false;
            this.myDataLayoutControl1.Root = this.Root;
            this.myDataLayoutControl1.Size = new System.Drawing.Size(319, 219);
            this.myDataLayoutControl1.TabIndex = 0;
            this.myDataLayoutControl1.Text = "myDataLayoutControl1";
            // 
            // pictureEditQRCode
            // 
            this.pictureEditQRCode.Location = new System.Drawing.Point(133, 36);
            this.pictureEditQRCode.Name = "pictureEditQRCode";
            this.pictureEditQRCode.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEditQRCode.Size = new System.Drawing.Size(174, 146);
            this.pictureEditQRCode.StyleController = this.myDataLayoutControl1;
            this.pictureEditQRCode.TabIndex = 5;
            // 
            // txtProductSeriesNumber
            // 
            this.txtProductSeriesNumber.EnterMoveNextControl = true;
            this.txtProductSeriesNumber.Location = new System.Drawing.Point(133, 12);
            this.txtProductSeriesNumber.Name = "txtProductSeriesNumber";
            this.txtProductSeriesNumber.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtProductSeriesNumber.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtProductSeriesNumber.Size = new System.Drawing.Size(174, 20);
            this.txtProductSeriesNumber.StyleController = this.myDataLayoutControl1;
            this.txtProductSeriesNumber.TabIndex = 4;
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
            columnDefinition2.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition2.Width = 200D;
            this.Root.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition2});
            rowDefinition4.Height = 24D;
            rowDefinition4.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition5.Height = 150D;
            rowDefinition5.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition6.Height = 24D;
            rowDefinition6.SizeType = System.Windows.Forms.SizeType.Absolute;
            this.Root.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition4,
            rowDefinition5,
            rowDefinition6});
            this.Root.Size = new System.Drawing.Size(319, 219);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem1.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem1.Control = this.txtProductSeriesNumber;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(299, 24);
            this.layoutControlItem1.Text = "Product Series Number";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(109, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem2.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem2.Control = this.pictureEditQRCode;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlItem2.Size = new System.Drawing.Size(299, 150);
            this.layoutControlItem2.Text = "QR Code";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(109, 13);
            // 
            // btnCreateQRCode
            // 
            this.btnCreateQRCode.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.btnCreateQRCode.Appearance.Options.UseForeColor = true;
            this.btnCreateQRCode.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCreateQRCode.ImageOptions.Image")));
            this.btnCreateQRCode.Location = new System.Drawing.Point(140, 225);
            this.btnCreateQRCode.Name = "btnCreateQRCode";
            this.btnCreateQRCode.Size = new System.Drawing.Size(125, 45);
            this.btnCreateQRCode.TabIndex = 6;
            this.btnCreateQRCode.Text = "Create QR Code";
            // 
            // QRCodeAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 282);
            this.Controls.Add(this.btnCreateQRCode);
            this.Controls.Add(this.myDataLayoutControl1);
            this.Name = "QRCodeAddForm";
            this.Text = "Add QR Code";
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl1)).EndInit();
            this.myDataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEditQRCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductSeriesNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.MyDataLayoutControl myDataLayoutControl1;
        private DevExpress.XtraEditors.PictureEdit pictureEditQRCode;
        private Controls.MyTextBox txtProductSeriesNumber;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private Controls.MySimpleButton btnCreateQRCode;
    }
}