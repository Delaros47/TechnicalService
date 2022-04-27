namespace TechnicalServiceUI.Forms
{
    partial class BrandStatisticsForm
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
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PieSeriesView pieSeriesView1 = new DevExpress.XtraCharts.PieSeriesView();
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            this.gridControlBrandStatistics = new TechnicalServiceUI.Controls.MyGridControl();
            this.gridViewBrandStatistics = new TechnicalServiceUI.Controls.MyGridView();
            this.colBrandName = new TechnicalServiceUI.Controls.MyGridColumn();
            this.colTotalProducts = new TechnicalServiceUI.Controls.MyGridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.chartControlBrands = new DevExpress.XtraCharts.ChartControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.chartControlBrandProducts = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlBrandStatistics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBrandStatistics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControlBrands)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControlBrandProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlBrandStatistics
            // 
            this.gridControlBrandStatistics.Dock = System.Windows.Forms.DockStyle.Left;
            this.gridControlBrandStatistics.Location = new System.Drawing.Point(0, 0);
            this.gridControlBrandStatistics.MainView = this.gridViewBrandStatistics;
            this.gridControlBrandStatistics.Name = "gridControlBrandStatistics";
            this.gridControlBrandStatistics.Size = new System.Drawing.Size(346, 543);
            this.gridControlBrandStatistics.TabIndex = 0;
            this.gridControlBrandStatistics.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewBrandStatistics});
            // 
            // gridViewBrandStatistics
            // 
            this.gridViewBrandStatistics.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gridViewBrandStatistics.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewBrandStatistics.Appearance.FooterPanel.Options.UseFont = true;
            this.gridViewBrandStatistics.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridViewBrandStatistics.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewBrandStatistics.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridViewBrandStatistics.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewBrandStatistics.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewBrandStatistics.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewBrandStatistics.Appearance.ViewCaption.Options.UseForeColor = true;
            this.gridViewBrandStatistics.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colBrandName,
            this.colTotalProducts});
            this.gridViewBrandStatistics.GridControl = this.gridControlBrandStatistics;
            this.gridViewBrandStatistics.Name = "gridViewBrandStatistics";
            this.gridViewBrandStatistics.OptionsMenu.EnableColumnMenu = false;
            this.gridViewBrandStatistics.OptionsMenu.EnableFooterMenu = false;
            this.gridViewBrandStatistics.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridViewBrandStatistics.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridViewBrandStatistics.OptionsPrint.AutoWidth = false;
            this.gridViewBrandStatistics.OptionsPrint.PrintFooter = false;
            this.gridViewBrandStatistics.OptionsPrint.PrintGroupFooter = false;
            this.gridViewBrandStatistics.OptionsView.ColumnAutoWidth = false;
            this.gridViewBrandStatistics.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.gridViewBrandStatistics.OptionsView.RowAutoHeight = true;
            this.gridViewBrandStatistics.OptionsView.ShowAutoFilterRow = true;
            this.gridViewBrandStatistics.OptionsView.ShowGroupPanel = false;
            this.gridViewBrandStatistics.OptionsView.ShowViewCaption = true;
            this.gridViewBrandStatistics.ViewCaption = "Brand Statistics";
            // 
            // colBrandName
            // 
            this.colBrandName.Caption = "Brand Name";
            this.colBrandName.FieldName = "BrandName";
            this.colBrandName.Name = "colBrandName";
            this.colBrandName.OptionsColumn.AllowEdit = false;
            this.colBrandName.Visible = true;
            this.colBrandName.VisibleIndex = 0;
            this.colBrandName.Width = 200;
            // 
            // colTotalProducts
            // 
            this.colTotalProducts.Caption = "Total Products";
            this.colTotalProducts.FieldName = "TotalProducts";
            this.colTotalProducts.Name = "colTotalProducts";
            this.colTotalProducts.OptionsColumn.AllowEdit = false;
            this.colTotalProducts.Visible = true;
            this.colTotalProducts.VisibleIndex = 1;
            this.colTotalProducts.Width = 100;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.chartControlBrands);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(346, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(947, 350);
            this.panelControl1.TabIndex = 1;
            // 
            // chartControlBrands
            // 
            this.chartControlBrands.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControlBrands.Location = new System.Drawing.Point(2, 2);
            this.chartControlBrands.Name = "chartControlBrands";
            series1.Name = "Series 1";
            series1.View = pieSeriesView1;
            this.chartControlBrands.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartControlBrands.Size = new System.Drawing.Size(943, 346);
            this.chartControlBrands.TabIndex = 0;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.chartControlBrandProducts);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(346, 350);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(947, 193);
            this.panelControl2.TabIndex = 2;
            // 
            // chartControlBrandProducts
            // 
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControlBrandProducts.Diagram = xyDiagram1;
            this.chartControlBrandProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControlBrandProducts.Location = new System.Drawing.Point(2, 2);
            this.chartControlBrandProducts.Name = "chartControlBrandProducts";
            series2.LegendTextPattern = "{A}";
            series2.Name = "Categories";
            this.chartControlBrandProducts.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series2};
            this.chartControlBrandProducts.Size = new System.Drawing.Size(943, 189);
            this.chartControlBrandProducts.TabIndex = 0;
            // 
            // BrandStatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 543);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.gridControlBrandStatistics);
            this.Name = "BrandStatisticsForm";
            this.Text = "Brand Statistics";
            this.Load += new System.EventHandler(this.BrandStatisticsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlBrandStatistics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBrandStatistics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControlBrands)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControlBrandProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.MyGridControl gridControlBrandStatistics;
        private Controls.MyGridView gridViewBrandStatistics;
        private Controls.MyGridColumn colBrandName;
        private Controls.MyGridColumn colTotalProducts;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraCharts.ChartControl chartControlBrands;
        private DevExpress.XtraCharts.ChartControl chartControlBrandProducts;
    }
}