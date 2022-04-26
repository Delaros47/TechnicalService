namespace TechnicalServiceUI.Forms
{
    partial class HomeForm
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
            this.gridControlProducts = new TechnicalServiceUI.Controls.MyGridControl();
            this.gridViewProducts = new TechnicalServiceUI.Controls.MyGridView();
            this.gridControlDepartments = new TechnicalServiceUI.Controls.MyGridControl();
            this.gridViewDepartments = new TechnicalServiceUI.Controls.MyGridView();
            this.gridControlBrands = new TechnicalServiceUI.Controls.MyGridControl();
            this.gridViewBrands = new TechnicalServiceUI.Controls.MyGridView();
            this.gridControlCategories = new TechnicalServiceUI.Controls.MyGridControl();
            this.gridViewCategories = new TechnicalServiceUI.Controls.MyGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDepartments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDepartments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlBrands)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBrands)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlProducts
            // 
            this.gridControlProducts.Location = new System.Drawing.Point(12, 17);
            this.gridControlProducts.MainView = this.gridViewProducts;
            this.gridControlProducts.Name = "gridControlProducts";
            this.gridControlProducts.Size = new System.Drawing.Size(630, 250);
            this.gridControlProducts.TabIndex = 0;
            this.gridControlProducts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewProducts});
            // 
            // gridViewProducts
            // 
            this.gridViewProducts.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gridViewProducts.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewProducts.Appearance.FooterPanel.Options.UseFont = true;
            this.gridViewProducts.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridViewProducts.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewProducts.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridViewProducts.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewProducts.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewProducts.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewProducts.Appearance.ViewCaption.Options.UseForeColor = true;
            this.gridViewProducts.GridControl = this.gridControlProducts;
            this.gridViewProducts.Name = "gridViewProducts";
            this.gridViewProducts.OptionsMenu.EnableColumnMenu = false;
            this.gridViewProducts.OptionsMenu.EnableFooterMenu = false;
            this.gridViewProducts.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridViewProducts.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridViewProducts.OptionsPrint.AutoWidth = false;
            this.gridViewProducts.OptionsPrint.PrintFooter = false;
            this.gridViewProducts.OptionsPrint.PrintGroupFooter = false;
            this.gridViewProducts.OptionsView.ColumnAutoWidth = false;
            this.gridViewProducts.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.gridViewProducts.OptionsView.RowAutoHeight = true;
            this.gridViewProducts.OptionsView.ShowAutoFilterRow = true;
            this.gridViewProducts.OptionsView.ShowGroupPanel = false;
            this.gridViewProducts.OptionsView.ShowViewCaption = true;
            this.gridViewProducts.ViewCaption = "Products";
            // 
            // gridControlDepartments
            // 
            this.gridControlDepartments.Location = new System.Drawing.Point(12, 283);
            this.gridControlDepartments.MainView = this.gridViewDepartments;
            this.gridControlDepartments.Name = "gridControlDepartments";
            this.gridControlDepartments.Size = new System.Drawing.Size(630, 250);
            this.gridControlDepartments.TabIndex = 1;
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
            // 
            // gridControlBrands
            // 
            this.gridControlBrands.Location = new System.Drawing.Point(651, 17);
            this.gridControlBrands.MainView = this.gridViewBrands;
            this.gridControlBrands.Name = "gridControlBrands";
            this.gridControlBrands.Size = new System.Drawing.Size(630, 250);
            this.gridControlBrands.TabIndex = 2;
            this.gridControlBrands.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewBrands});
            // 
            // gridViewBrands
            // 
            this.gridViewBrands.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gridViewBrands.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewBrands.Appearance.FooterPanel.Options.UseFont = true;
            this.gridViewBrands.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridViewBrands.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewBrands.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridViewBrands.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewBrands.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewBrands.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewBrands.Appearance.ViewCaption.Options.UseForeColor = true;
            this.gridViewBrands.GridControl = this.gridControlBrands;
            this.gridViewBrands.Name = "gridViewBrands";
            this.gridViewBrands.OptionsMenu.EnableColumnMenu = false;
            this.gridViewBrands.OptionsMenu.EnableFooterMenu = false;
            this.gridViewBrands.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridViewBrands.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridViewBrands.OptionsPrint.AutoWidth = false;
            this.gridViewBrands.OptionsPrint.PrintFooter = false;
            this.gridViewBrands.OptionsPrint.PrintGroupFooter = false;
            this.gridViewBrands.OptionsView.ColumnAutoWidth = false;
            this.gridViewBrands.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.gridViewBrands.OptionsView.RowAutoHeight = true;
            this.gridViewBrands.OptionsView.ShowAutoFilterRow = true;
            this.gridViewBrands.OptionsView.ShowGroupPanel = false;
            this.gridViewBrands.OptionsView.ShowViewCaption = true;
            this.gridViewBrands.ViewCaption = "Brands";
            // 
            // gridControlCategories
            // 
            this.gridControlCategories.Location = new System.Drawing.Point(651, 283);
            this.gridControlCategories.MainView = this.gridViewCategories;
            this.gridControlCategories.Name = "gridControlCategories";
            this.gridControlCategories.Size = new System.Drawing.Size(630, 250);
            this.gridControlCategories.TabIndex = 3;
            this.gridControlCategories.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCategories});
            // 
            // gridViewCategories
            // 
            this.gridViewCategories.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gridViewCategories.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewCategories.Appearance.FooterPanel.Options.UseFont = true;
            this.gridViewCategories.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridViewCategories.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewCategories.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridViewCategories.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewCategories.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewCategories.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewCategories.Appearance.ViewCaption.Options.UseForeColor = true;
            this.gridViewCategories.GridControl = this.gridControlCategories;
            this.gridViewCategories.Name = "gridViewCategories";
            this.gridViewCategories.OptionsMenu.EnableColumnMenu = false;
            this.gridViewCategories.OptionsMenu.EnableFooterMenu = false;
            this.gridViewCategories.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridViewCategories.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridViewCategories.OptionsPrint.AutoWidth = false;
            this.gridViewCategories.OptionsPrint.PrintFooter = false;
            this.gridViewCategories.OptionsPrint.PrintGroupFooter = false;
            this.gridViewCategories.OptionsView.ColumnAutoWidth = false;
            this.gridViewCategories.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.gridViewCategories.OptionsView.RowAutoHeight = true;
            this.gridViewCategories.OptionsView.ShowAutoFilterRow = true;
            this.gridViewCategories.OptionsView.ShowGroupPanel = false;
            this.gridViewCategories.OptionsView.ShowViewCaption = true;
            this.gridViewCategories.ViewCaption = "Categories";
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 543);
            this.Controls.Add(this.gridControlCategories);
            this.Controls.Add(this.gridControlBrands);
            this.Controls.Add(this.gridControlDepartments);
            this.Controls.Add(this.gridControlProducts);
            this.Name = "HomeForm";
            this.Text = "Home Form";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDepartments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDepartments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlBrands)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBrands)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCategories)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.MyGridControl gridControlProducts;
        private Controls.MyGridView gridViewProducts;
        private Controls.MyGridControl gridControlDepartments;
        private Controls.MyGridView gridViewDepartments;
        private Controls.MyGridControl gridControlBrands;
        private Controls.MyGridView gridViewBrands;
        private Controls.MyGridControl gridControlCategories;
        private Controls.MyGridView gridViewCategories;
    }
}