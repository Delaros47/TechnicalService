namespace TechnicalServiceUI.Forms
{
    partial class ProductAcceptancesForm
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
            DevExpress.XtraCharts.SimpleDiagram3D simpleDiagram3d1 = new DevExpress.XtraCharts.SimpleDiagram3D();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.Doughnut3DSeriesView doughnut3dSeriesView1 = new DevExpress.XtraCharts.Doughnut3DSeriesView();
            this.gridControlProductAcceptances = new TechnicalServiceUI.Controls.MyGridControl();
            this.gridViewProductAcceptances = new TechnicalServiceUI.Controls.MyGridView();
            this.colProductAcceptanceId = new TechnicalServiceUI.Controls.MyGridColumn();
            this.colCustomerName = new TechnicalServiceUI.Controls.MyGridColumn();
            this.colEmployeeId = new TechnicalServiceUI.Controls.MyGridColumn();
            this.colArrivalDate = new TechnicalServiceUI.Controls.MyGridColumn();
            this.colLeftDate = new TechnicalServiceUI.Controls.MyGridColumn();
            this.colProductSeriesNumber = new TechnicalServiceUI.Controls.MyGridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.chartControlProductAcceptances = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProductAcceptances)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProductAcceptances)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControlProductAcceptances)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(simpleDiagram3d1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(doughnut3dSeriesView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlProductAcceptances
            // 
            this.gridControlProductAcceptances.Dock = System.Windows.Forms.DockStyle.Left;
            this.gridControlProductAcceptances.Location = new System.Drawing.Point(0, 0);
            this.gridControlProductAcceptances.MainView = this.gridViewProductAcceptances;
            this.gridControlProductAcceptances.Name = "gridControlProductAcceptances";
            this.gridControlProductAcceptances.Size = new System.Drawing.Size(634, 543);
            this.gridControlProductAcceptances.TabIndex = 0;
            this.gridControlProductAcceptances.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewProductAcceptances});
            // 
            // gridViewProductAcceptances
            // 
            this.gridViewProductAcceptances.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gridViewProductAcceptances.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewProductAcceptances.Appearance.FooterPanel.Options.UseFont = true;
            this.gridViewProductAcceptances.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridViewProductAcceptances.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewProductAcceptances.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridViewProductAcceptances.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewProductAcceptances.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewProductAcceptances.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewProductAcceptances.Appearance.ViewCaption.Options.UseForeColor = true;
            this.gridViewProductAcceptances.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProductAcceptanceId,
            this.colCustomerName,
            this.colEmployeeId,
            this.colArrivalDate,
            this.colLeftDate,
            this.colProductSeriesNumber});
            this.gridViewProductAcceptances.GridControl = this.gridControlProductAcceptances;
            this.gridViewProductAcceptances.Name = "gridViewProductAcceptances";
            this.gridViewProductAcceptances.OptionsMenu.EnableColumnMenu = false;
            this.gridViewProductAcceptances.OptionsMenu.EnableFooterMenu = false;
            this.gridViewProductAcceptances.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridViewProductAcceptances.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridViewProductAcceptances.OptionsPrint.AutoWidth = false;
            this.gridViewProductAcceptances.OptionsPrint.PrintFooter = false;
            this.gridViewProductAcceptances.OptionsPrint.PrintGroupFooter = false;
            this.gridViewProductAcceptances.OptionsView.ColumnAutoWidth = false;
            this.gridViewProductAcceptances.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.gridViewProductAcceptances.OptionsView.RowAutoHeight = true;
            this.gridViewProductAcceptances.OptionsView.ShowAutoFilterRow = true;
            this.gridViewProductAcceptances.OptionsView.ShowGroupPanel = false;
            this.gridViewProductAcceptances.OptionsView.ShowViewCaption = true;
            this.gridViewProductAcceptances.ViewCaption = "Product Acceptances";
            // 
            // colProductAcceptanceId
            // 
            this.colProductAcceptanceId.Caption = "Product Acceptance ID";
            this.colProductAcceptanceId.FieldName = "ProductAcceptanceId";
            this.colProductAcceptanceId.Name = "colProductAcceptanceId";
            this.colProductAcceptanceId.OptionsColumn.AllowEdit = false;
            this.colProductAcceptanceId.Visible = true;
            this.colProductAcceptanceId.VisibleIndex = 0;
            this.colProductAcceptanceId.Width = 125;
            // 
            // colCustomerName
            // 
            this.colCustomerName.Caption = "Customer Name";
            this.colCustomerName.FieldName = "CustomerFullName";
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.OptionsColumn.AllowEdit = false;
            this.colCustomerName.Visible = true;
            this.colCustomerName.VisibleIndex = 1;
            this.colCustomerName.Width = 100;
            // 
            // colEmployeeId
            // 
            this.colEmployeeId.Caption = "Employee Name";
            this.colEmployeeId.FieldName = "EmployeeFullName";
            this.colEmployeeId.Name = "colEmployeeId";
            this.colEmployeeId.OptionsColumn.AllowEdit = false;
            this.colEmployeeId.Visible = true;
            this.colEmployeeId.VisibleIndex = 2;
            this.colEmployeeId.Width = 100;
            // 
            // colArrivalDate
            // 
            this.colArrivalDate.Caption = "Arrival Date";
            this.colArrivalDate.FieldName = "ArrivalDate";
            this.colArrivalDate.Name = "colArrivalDate";
            this.colArrivalDate.OptionsColumn.AllowEdit = false;
            this.colArrivalDate.Visible = true;
            this.colArrivalDate.VisibleIndex = 3;
            // 
            // colLeftDate
            // 
            this.colLeftDate.Caption = "Left Date";
            this.colLeftDate.FieldName = "LeftDate";
            this.colLeftDate.Name = "colLeftDate";
            this.colLeftDate.OptionsColumn.AllowEdit = false;
            this.colLeftDate.Visible = true;
            this.colLeftDate.VisibleIndex = 4;
            // 
            // colProductSeriesNumber
            // 
            this.colProductSeriesNumber.Caption = "Product Series Number";
            this.colProductSeriesNumber.FieldName = "ProductSeriesNumber";
            this.colProductSeriesNumber.Name = "colProductSeriesNumber";
            this.colProductSeriesNumber.OptionsColumn.AllowEdit = false;
            this.colProductSeriesNumber.Visible = true;
            this.colProductSeriesNumber.VisibleIndex = 5;
            this.colProductSeriesNumber.Width = 125;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.chartControlProductAcceptances);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(634, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(659, 543);
            this.panelControl1.TabIndex = 1;
            // 
            // chartControlProductAcceptances
            // 
            simpleDiagram3d1.RotationMatrixSerializable = "1;0;0;0;0;0.5000000000000001;-0.8660254037844386;0;0;0.8660254037844386;0.5000000" +
    "000000001;0;0;0;0;1";
            this.chartControlProductAcceptances.Diagram = simpleDiagram3d1;
            this.chartControlProductAcceptances.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControlProductAcceptances.Location = new System.Drawing.Point(2, 2);
            this.chartControlProductAcceptances.Name = "chartControlProductAcceptances";
            series1.Name = "Series 1";
            series1.View = doughnut3dSeriesView1;
            this.chartControlProductAcceptances.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartControlProductAcceptances.Size = new System.Drawing.Size(655, 539);
            this.chartControlProductAcceptances.TabIndex = 0;
            // 
            // ProductAcceptancesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 543);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.gridControlProductAcceptances);
            this.Name = "ProductAcceptancesForm";
            this.Text = "Product Acceptance";
            this.Load += new System.EventHandler(this.ProductAcceptancesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProductAcceptances)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProductAcceptances)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(simpleDiagram3d1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(doughnut3dSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControlProductAcceptances)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.MyGridControl gridControlProductAcceptances;
        private Controls.MyGridView gridViewProductAcceptances;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraCharts.ChartControl chartControlProductAcceptances;
        private Controls.MyGridColumn colProductAcceptanceId;
        private Controls.MyGridColumn colCustomerName;
        private Controls.MyGridColumn colEmployeeId;
        private Controls.MyGridColumn colArrivalDate;
        private Controls.MyGridColumn colLeftDate;
        private Controls.MyGridColumn colProductSeriesNumber;
    }
}