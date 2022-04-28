namespace TechnicalServiceUI.Forms
{
    partial class BankAddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BankAddForm));
            DevExpress.XtraLayout.ColumnDefinition columnDefinition1 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition1 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition2 = new DevExpress.XtraLayout.RowDefinition();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnClearBank = new TechnicalServiceUI.Controls.MySimpleButton();
            this.btnAddBank = new TechnicalServiceUI.Controls.MySimpleButton();
            this.myDataLayoutControl1 = new TechnicalServiceUI.Controls.MyDataLayoutControl();
            this.memoEditBankDescription = new TechnicalServiceUI.Controls.MyMemoEdit();
            this.txtBankName = new TechnicalServiceUI.Controls.MyTextBox();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl1)).BeginInit();
            this.myDataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditBankDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnClearBank);
            this.panelControl2.Controls.Add(this.btnAddBank);
            this.panelControl2.Controls.Add(this.myDataLayoutControl1);
            this.panelControl2.Location = new System.Drawing.Point(12, 12);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(400, 352);
            this.panelControl2.TabIndex = 7;
            // 
            // btnClearBank
            // 
            this.btnClearBank.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.btnClearBank.Appearance.Options.UseForeColor = true;
            this.btnClearBank.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClearBank.ImageOptions.Image")));
            this.btnClearBank.Location = new System.Drawing.Point(259, 311);
            this.btnClearBank.Name = "btnClearBank";
            this.btnClearBank.Size = new System.Drawing.Size(106, 25);
            this.btnClearBank.TabIndex = 3;
            this.btnClearBank.Text = "Clear Banks";
            this.btnClearBank.Click += new System.EventHandler(this.btnClearBank_Click);
            // 
            // btnAddBank
            // 
            this.btnAddBank.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.btnAddBank.Appearance.Options.UseForeColor = true;
            this.btnAddBank.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddBank.ImageOptions.Image")));
            this.btnAddBank.Location = new System.Drawing.Point(117, 311);
            this.btnAddBank.Name = "btnAddBank";
            this.btnAddBank.Size = new System.Drawing.Size(106, 25);
            this.btnAddBank.TabIndex = 1;
            this.btnAddBank.Text = "Add Bank";
            this.btnAddBank.Click += new System.EventHandler(this.btnAddBank_Click);
            // 
            // myDataLayoutControl1
            // 
            this.myDataLayoutControl1.Controls.Add(this.memoEditBankDescription);
            this.myDataLayoutControl1.Controls.Add(this.txtBankName);
            this.myDataLayoutControl1.HiddenItems.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.myDataLayoutControl1.Location = new System.Drawing.Point(2, 2);
            this.myDataLayoutControl1.Name = "myDataLayoutControl1";
            this.myDataLayoutControl1.OptionsFocus.EnableAutoTabOrder = false;
            this.myDataLayoutControl1.Root = this.Root;
            this.myDataLayoutControl1.Size = new System.Drawing.Size(396, 303);
            this.myDataLayoutControl1.TabIndex = 0;
            this.myDataLayoutControl1.Text = "myDataLayoutControl1";
            // 
            // memoEditBankDescription
            // 
            this.memoEditBankDescription.EnterMoveNextControl = true;
            this.memoEditBankDescription.Location = new System.Drawing.Point(103, 36);
            this.memoEditBankDescription.Name = "memoEditBankDescription";
            this.memoEditBankDescription.Properties.Appearance.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.memoEditBankDescription.Properties.Appearance.Options.UseBackColor = true;
            this.memoEditBankDescription.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.memoEditBankDescription.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.memoEditBankDescription.Properties.MaxLength = 500;
            this.memoEditBankDescription.Size = new System.Drawing.Size(281, 255);
            this.memoEditBankDescription.StyleController = this.myDataLayoutControl1;
            this.memoEditBankDescription.TabIndex = 6;
            // 
            // txtBankName
            // 
            this.txtBankName.EnterMoveNextControl = true;
            this.txtBankName.Location = new System.Drawing.Point(103, 12);
            this.txtBankName.Name = "txtBankName";
            this.txtBankName.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtBankName.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtBankName.Size = new System.Drawing.Size(281, 20);
            this.txtBankName.StyleController = this.myDataLayoutControl1;
            this.txtBankName.TabIndex = 5;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem1.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(376, 24);
            this.layoutControlItem1.Text = "Bank ID";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(79, 13);
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
            this.layoutControlItem2.Control = this.txtBankName;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(376, 24);
            this.layoutControlItem2.Text = "Bank Name";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(79, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem3.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem3.Control = this.memoEditBankDescription;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlItem3.Size = new System.Drawing.Size(376, 259);
            this.layoutControlItem3.Text = "Bank Description";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(79, 13);
            // 
            // BankAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 372);
            this.Controls.Add(this.panelControl2);
            this.Name = "BankAddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Bank";
            this.Load += new System.EventHandler(this.BankAddForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl1)).EndInit();
            this.myDataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.memoEditBankDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl2;
        private Controls.MySimpleButton btnClearBank;
        private Controls.MySimpleButton btnAddBank;
        private Controls.MyDataLayoutControl myDataLayoutControl1;
        private Controls.MyMemoEdit memoEditBankDescription;
        private Controls.MyTextBox txtBankName;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    }
}