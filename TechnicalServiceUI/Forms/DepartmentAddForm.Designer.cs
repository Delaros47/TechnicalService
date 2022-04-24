namespace TechnicalServiceUI.Forms
{
    partial class DepartmentAddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepartmentAddForm));
            DevExpress.XtraLayout.ColumnDefinition columnDefinition2 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition2 = new DevExpress.XtraLayout.RowDefinition();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnAddDepartment = new TechnicalServiceUI.Controls.MySimpleButton();
            this.btnClearDepartment = new TechnicalServiceUI.Controls.MySimpleButton();
            this.myDataLayoutControl1 = new TechnicalServiceUI.Controls.MyDataLayoutControl();
            this.txtDepartmentName = new TechnicalServiceUI.Controls.MyTextBox();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl1)).BeginInit();
            this.myDataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepartmentName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnAddDepartment);
            this.panelControl1.Controls.Add(this.btnClearDepartment);
            this.panelControl1.Controls.Add(this.myDataLayoutControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(370, 132);
            this.panelControl1.TabIndex = 2;
            // 
            // btnAddDepartment
            // 
            this.btnAddDepartment.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.btnAddDepartment.Appearance.Options.UseForeColor = true;
            this.btnAddDepartment.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddDepartment.ImageOptions.Image")));
            this.btnAddDepartment.Location = new System.Drawing.Point(78, 93);
            this.btnAddDepartment.Name = "btnAddDepartment";
            this.btnAddDepartment.Size = new System.Drawing.Size(136, 23);
            this.btnAddDepartment.TabIndex = 3;
            this.btnAddDepartment.Text = "Add Department";
            this.btnAddDepartment.Click += new System.EventHandler(this.btnAddDepartment_Click);
            // 
            // btnClearDepartment
            // 
            this.btnClearDepartment.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.btnClearDepartment.Appearance.Options.UseForeColor = true;
            this.btnClearDepartment.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClearDepartment.ImageOptions.Image")));
            this.btnClearDepartment.Location = new System.Drawing.Point(220, 93);
            this.btnClearDepartment.Name = "btnClearDepartment";
            this.btnClearDepartment.Size = new System.Drawing.Size(136, 23);
            this.btnClearDepartment.TabIndex = 2;
            this.btnClearDepartment.Text = "Clear Department";
            this.btnClearDepartment.Click += new System.EventHandler(this.btnClearDepartment_Click);
            // 
            // myDataLayoutControl1
            // 
            this.myDataLayoutControl1.Controls.Add(this.txtDepartmentName);
            this.myDataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.myDataLayoutControl1.Location = new System.Drawing.Point(2, 2);
            this.myDataLayoutControl1.Name = "myDataLayoutControl1";
            this.myDataLayoutControl1.OptionsFocus.EnableAutoTabOrder = false;
            this.myDataLayoutControl1.Root = this.Root;
            this.myDataLayoutControl1.Size = new System.Drawing.Size(366, 98);
            this.myDataLayoutControl1.TabIndex = 0;
            this.myDataLayoutControl1.Text = "myDataLayoutControl1";
            // 
            // txtDepartmentName
            // 
            this.txtDepartmentName.EnterMoveNextControl = true;
            this.txtDepartmentName.Location = new System.Drawing.Point(111, 12);
            this.txtDepartmentName.Name = "txtDepartmentName";
            this.txtDepartmentName.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtDepartmentName.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtDepartmentName.Size = new System.Drawing.Size(243, 20);
            this.txtDepartmentName.StyleController = this.myDataLayoutControl1;
            this.txtDepartmentName.TabIndex = 5;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2});
            this.Root.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
            this.Root.Name = "Root";
            columnDefinition2.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition2.Width = 200D;
            this.Root.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition2});
            rowDefinition2.Height = 24D;
            rowDefinition2.SizeType = System.Windows.Forms.SizeType.Absolute;
            this.Root.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition2});
            this.Root.Size = new System.Drawing.Size(366, 98);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem2.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem2.Control = this.txtDepartmentName;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(346, 78);
            this.layoutControlItem2.Text = "Department Name";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(87, 13);
            // 
            // DepartmentAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 132);
            this.Controls.Add(this.panelControl1);
            this.Name = "DepartmentAddForm";
            this.Text = "Add Department";
            this.Load += new System.EventHandler(this.DepartmentAddForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl1)).EndInit();
            this.myDataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtDepartmentName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private Controls.MySimpleButton btnAddDepartment;
        private Controls.MySimpleButton btnClearDepartment;
        private Controls.MyDataLayoutControl myDataLayoutControl1;
        private Controls.MyTextBox txtDepartmentName;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}