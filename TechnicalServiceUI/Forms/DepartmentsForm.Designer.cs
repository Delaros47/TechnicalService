namespace TechnicalServiceUI.Forms
{
    partial class DepartmentsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepartmentsForm));
            DevExpress.XtraLayout.ColumnDefinition columnDefinition1 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition1 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition2 = new DevExpress.XtraLayout.RowDefinition();
            this.gridControlDepartments = new TechnicalServiceUI.Controls.MyGridControl();
            this.gridViewDepartments = new TechnicalServiceUI.Controls.MyGridView();
            this.colDepartmentId = new TechnicalServiceUI.Controls.MyGridColumn();
            this.colDepartmentName = new TechnicalServiceUI.Controls.MyGridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnDeleteDepartment = new TechnicalServiceUI.Controls.MySimpleButton();
            this.btnAddDepartment = new TechnicalServiceUI.Controls.MySimpleButton();
            this.btnClearDepartment = new TechnicalServiceUI.Controls.MySimpleButton();
            this.btnUpdateDepartment = new TechnicalServiceUI.Controls.MySimpleButton();
            this.myDataLayoutControl1 = new TechnicalServiceUI.Controls.MyDataLayoutControl();
            this.txtDepartmentName = new TechnicalServiceUI.Controls.MyTextBox();
            this.txtDepartmentId = new TechnicalServiceUI.Controls.MyTextBox();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDepartments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDepartments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl1)).BeginInit();
            this.myDataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepartmentName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepartmentId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlDepartments
            // 
            this.gridControlDepartments.Dock = System.Windows.Forms.DockStyle.Left;
            this.gridControlDepartments.Location = new System.Drawing.Point(0, 0);
            this.gridControlDepartments.MainView = this.gridViewDepartments;
            this.gridControlDepartments.Name = "gridControlDepartments";
            this.gridControlDepartments.Size = new System.Drawing.Size(923, 543);
            this.gridControlDepartments.TabIndex = 0;
            this.gridControlDepartments.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDepartments});
            // 
            // gridViewDepartments
            // 
            this.gridViewDepartments.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gridViewDepartments.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewDepartments.Appearance.FooterPanel.Options.UseFont = true;
            this.gridViewDepartments.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridViewDepartments.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewDepartments.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridViewDepartments.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewDepartments.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewDepartments.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewDepartments.Appearance.ViewCaption.Options.UseForeColor = true;
            this.gridViewDepartments.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDepartmentId,
            this.colDepartmentName});
            this.gridViewDepartments.GridControl = this.gridControlDepartments;
            this.gridViewDepartments.Name = "gridViewDepartments";
            this.gridViewDepartments.OptionsMenu.EnableColumnMenu = false;
            this.gridViewDepartments.OptionsMenu.EnableFooterMenu = false;
            this.gridViewDepartments.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridViewDepartments.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridViewDepartments.OptionsPrint.AutoWidth = false;
            this.gridViewDepartments.OptionsPrint.PrintFooter = false;
            this.gridViewDepartments.OptionsPrint.PrintGroupFooter = false;
            this.gridViewDepartments.OptionsView.ColumnAutoWidth = false;
            this.gridViewDepartments.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.gridViewDepartments.OptionsView.RowAutoHeight = true;
            this.gridViewDepartments.OptionsView.ShowAutoFilterRow = true;
            this.gridViewDepartments.OptionsView.ShowGroupPanel = false;
            this.gridViewDepartments.OptionsView.ShowViewCaption = true;
            this.gridViewDepartments.ViewCaption = "Departments";
            this.gridViewDepartments.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewDepartments_FocusedRowChanged);
            // 
            // colDepartmentId
            // 
            this.colDepartmentId.Caption = "Department ID";
            this.colDepartmentId.FieldName = "DepartmentId";
            this.colDepartmentId.Name = "colDepartmentId";
            this.colDepartmentId.OptionsColumn.AllowEdit = false;
            this.colDepartmentId.Visible = true;
            this.colDepartmentId.VisibleIndex = 0;
            this.colDepartmentId.Width = 440;
            // 
            // colDepartmentName
            // 
            this.colDepartmentName.Caption = "Department Name";
            this.colDepartmentName.FieldName = "DepartmentName";
            this.colDepartmentName.Name = "colDepartmentName";
            this.colDepartmentName.OptionsColumn.AllowEdit = false;
            this.colDepartmentName.Visible = true;
            this.colDepartmentName.VisibleIndex = 1;
            this.colDepartmentName.Width = 440;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnDeleteDepartment);
            this.panelControl1.Controls.Add(this.btnAddDepartment);
            this.panelControl1.Controls.Add(this.btnClearDepartment);
            this.panelControl1.Controls.Add(this.btnUpdateDepartment);
            this.panelControl1.Controls.Add(this.myDataLayoutControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(923, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(370, 543);
            this.panelControl1.TabIndex = 1;
            // 
            // btnDeleteDepartment
            // 
            this.btnDeleteDepartment.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.btnDeleteDepartment.Appearance.Options.UseForeColor = true;
            this.btnDeleteDepartment.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteDepartment.ImageOptions.Image")));
            this.btnDeleteDepartment.Location = new System.Drawing.Point(78, 122);
            this.btnDeleteDepartment.Name = "btnDeleteDepartment";
            this.btnDeleteDepartment.Size = new System.Drawing.Size(136, 23);
            this.btnDeleteDepartment.TabIndex = 4;
            this.btnDeleteDepartment.Text = "Delete Department";
            this.btnDeleteDepartment.Click += new System.EventHandler(this.btnDeleteDepartment_Click);
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
            this.btnClearDepartment.Location = new System.Drawing.Point(220, 122);
            this.btnClearDepartment.Name = "btnClearDepartment";
            this.btnClearDepartment.Size = new System.Drawing.Size(136, 23);
            this.btnClearDepartment.TabIndex = 2;
            this.btnClearDepartment.Text = "Clear Department";
            this.btnClearDepartment.Click += new System.EventHandler(this.btnClearDepartment_Click);
            // 
            // btnUpdateDepartment
            // 
            this.btnUpdateDepartment.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.btnUpdateDepartment.Appearance.Options.UseForeColor = true;
            this.btnUpdateDepartment.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateDepartment.ImageOptions.Image")));
            this.btnUpdateDepartment.Location = new System.Drawing.Point(220, 93);
            this.btnUpdateDepartment.Name = "btnUpdateDepartment";
            this.btnUpdateDepartment.Size = new System.Drawing.Size(136, 23);
            this.btnUpdateDepartment.TabIndex = 1;
            this.btnUpdateDepartment.Text = "Update Department";
            this.btnUpdateDepartment.Click += new System.EventHandler(this.btnUpdateDepartment_Click);
            // 
            // myDataLayoutControl1
            // 
            this.myDataLayoutControl1.Controls.Add(this.txtDepartmentName);
            this.myDataLayoutControl1.Controls.Add(this.txtDepartmentId);
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
            this.txtDepartmentName.Location = new System.Drawing.Point(111, 36);
            this.txtDepartmentName.Name = "txtDepartmentName";
            this.txtDepartmentName.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtDepartmentName.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtDepartmentName.Size = new System.Drawing.Size(243, 20);
            this.txtDepartmentName.StyleController = this.myDataLayoutControl1;
            this.txtDepartmentName.TabIndex = 5;
            // 
            // txtDepartmentId
            // 
            this.txtDepartmentId.EnterMoveNextControl = true;
            this.txtDepartmentId.Location = new System.Drawing.Point(111, 12);
            this.txtDepartmentId.Name = "txtDepartmentId";
            this.txtDepartmentId.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtDepartmentId.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtDepartmentId.Properties.ReadOnly = true;
            this.txtDepartmentId.Size = new System.Drawing.Size(243, 20);
            this.txtDepartmentId.StyleController = this.myDataLayoutControl1;
            this.txtDepartmentId.TabIndex = 4;
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
            this.Root.Size = new System.Drawing.Size(366, 98);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem1.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem1.Control = this.txtDepartmentId;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(346, 24);
            this.layoutControlItem1.Text = "Department ID";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(87, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem2.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem2.Control = this.txtDepartmentName;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlItem2.Size = new System.Drawing.Size(346, 54);
            this.layoutControlItem2.Text = "Department Name";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(87, 13);
            // 
            // DepartmentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 543);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.gridControlDepartments);
            this.Name = "DepartmentsForm";
            this.Text = "Departments";
            this.Load += new System.EventHandler(this.DepartmentsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDepartments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDepartments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl1)).EndInit();
            this.myDataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtDepartmentName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepartmentId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.MyGridControl gridControlDepartments;
        private Controls.MyGridView gridViewDepartments;
        private Controls.MyGridColumn colDepartmentId;
        private Controls.MyGridColumn colDepartmentName;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private Controls.MyDataLayoutControl myDataLayoutControl1;
        private Controls.MyTextBox txtDepartmentName;
        private Controls.MyTextBox txtDepartmentId;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private Controls.MySimpleButton btnDeleteDepartment;
        private Controls.MySimpleButton btnAddDepartment;
        private Controls.MySimpleButton btnClearDepartment;
        private Controls.MySimpleButton btnUpdateDepartment;
    }
}