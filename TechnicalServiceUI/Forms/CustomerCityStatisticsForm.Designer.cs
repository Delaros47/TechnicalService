namespace TechnicalServiceUI.Forms
{
    partial class CustomerCityStatisticsForm
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
            DevExpress.XtraCharts.Pie3DSeriesView pie3dSeriesView1 = new DevExpress.XtraCharts.Pie3DSeriesView();
            this.gridControlCustomerCityStatistics = new TechnicalServiceUI.Controls.MyGridControl();
            this.gridViewCustomerCityStatistics = new TechnicalServiceUI.Controls.MyGridView();
            this.colCityName = new TechnicalServiceUI.Controls.MyGridColumn();
            this.colTotalCustomers = new TechnicalServiceUI.Controls.MyGridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.chartControlCustomerCityStatistics = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCustomerCityStatistics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCustomerCityStatistics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControlCustomerCityStatistics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(simpleDiagram3d1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pie3dSeriesView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlCustomerCityStatistics
            // 
            this.gridControlCustomerCityStatistics.Dock = System.Windows.Forms.DockStyle.Left;
            this.gridControlCustomerCityStatistics.Location = new System.Drawing.Point(0, 0);
            this.gridControlCustomerCityStatistics.MainView = this.gridViewCustomerCityStatistics;
            this.gridControlCustomerCityStatistics.Name = "gridControlCustomerCityStatistics";
            this.gridControlCustomerCityStatistics.Size = new System.Drawing.Size(355, 543);
            this.gridControlCustomerCityStatistics.TabIndex = 0;
            this.gridControlCustomerCityStatistics.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCustomerCityStatistics});
            // 
            // gridViewCustomerCityStatistics
            // 
            this.gridViewCustomerCityStatistics.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gridViewCustomerCityStatistics.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewCustomerCityStatistics.Appearance.FooterPanel.Options.UseFont = true;
            this.gridViewCustomerCityStatistics.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridViewCustomerCityStatistics.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewCustomerCityStatistics.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridViewCustomerCityStatistics.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewCustomerCityStatistics.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewCustomerCityStatistics.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewCustomerCityStatistics.Appearance.ViewCaption.Options.UseForeColor = true;
            this.gridViewCustomerCityStatistics.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCityName,
            this.colTotalCustomers});
            this.gridViewCustomerCityStatistics.GridControl = this.gridControlCustomerCityStatistics;
            this.gridViewCustomerCityStatistics.Name = "gridViewCustomerCityStatistics";
            this.gridViewCustomerCityStatistics.OptionsMenu.EnableColumnMenu = false;
            this.gridViewCustomerCityStatistics.OptionsMenu.EnableFooterMenu = false;
            this.gridViewCustomerCityStatistics.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridViewCustomerCityStatistics.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridViewCustomerCityStatistics.OptionsPrint.AutoWidth = false;
            this.gridViewCustomerCityStatistics.OptionsPrint.PrintFooter = false;
            this.gridViewCustomerCityStatistics.OptionsPrint.PrintGroupFooter = false;
            this.gridViewCustomerCityStatistics.OptionsView.ColumnAutoWidth = false;
            this.gridViewCustomerCityStatistics.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.gridViewCustomerCityStatistics.OptionsView.RowAutoHeight = true;
            this.gridViewCustomerCityStatistics.OptionsView.ShowAutoFilterRow = true;
            this.gridViewCustomerCityStatistics.OptionsView.ShowGroupPanel = false;
            this.gridViewCustomerCityStatistics.OptionsView.ShowViewCaption = true;
            this.gridViewCustomerCityStatistics.ViewCaption = "Customer City Statistics";
            // 
            // colCityName
            // 
            this.colCityName.Caption = "City Name";
            this.colCityName.FieldName = "CityName";
            this.colCityName.Name = "colCityName";
            this.colCityName.OptionsColumn.AllowEdit = false;
            this.colCityName.Visible = true;
            this.colCityName.VisibleIndex = 0;
            this.colCityName.Width = 170;
            // 
            // colTotalCustomers
            // 
            this.colTotalCustomers.Caption = "Total Customers";
            this.colTotalCustomers.FieldName = "TotalCustomers";
            this.colTotalCustomers.Name = "colTotalCustomers";
            this.colTotalCustomers.OptionsColumn.AllowEdit = false;
            this.colTotalCustomers.Visible = true;
            this.colTotalCustomers.VisibleIndex = 1;
            this.colTotalCustomers.Width = 150;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.chartControlCustomerCityStatistics);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(355, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(938, 543);
            this.panelControl1.TabIndex = 1;
            // 
            // chartControlCustomerCityStatistics
            // 
            simpleDiagram3d1.RotationMatrixSerializable = "1;0;0;0;0;0.5000000000000001;-0.8660254037844386;0;0;0.8660254037844386;0.5000000" +
    "000000001;0;0;0;0;1";
            this.chartControlCustomerCityStatistics.Diagram = simpleDiagram3d1;
            this.chartControlCustomerCityStatistics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControlCustomerCityStatistics.Location = new System.Drawing.Point(2, 2);
            this.chartControlCustomerCityStatistics.Name = "chartControlCustomerCityStatistics";
            series1.Name = "Series 1";
            series1.View = pie3dSeriesView1;
            this.chartControlCustomerCityStatistics.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartControlCustomerCityStatistics.Size = new System.Drawing.Size(934, 539);
            this.chartControlCustomerCityStatistics.TabIndex = 0;
            // 
            // CustomerCityStatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 543);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.gridControlCustomerCityStatistics);
            this.Name = "CustomerCityStatisticsForm";
            this.Text = "Customer City Statistics";
            this.Load += new System.EventHandler(this.CustomerCityStatisticsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCustomerCityStatistics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCustomerCityStatistics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(simpleDiagram3d1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pie3dSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControlCustomerCityStatistics)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.MyGridControl gridControlCustomerCityStatistics;
        private Controls.MyGridView gridViewCustomerCityStatistics;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraCharts.ChartControl chartControlCustomerCityStatistics;
        private Controls.MyGridColumn colCityName;
        private Controls.MyGridColumn colTotalCustomers;
    }
}