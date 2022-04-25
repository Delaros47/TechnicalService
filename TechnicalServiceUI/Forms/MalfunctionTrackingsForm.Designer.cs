namespace TechnicalServiceUI.Forms
{
    partial class MalfunctionTrackingsForm
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
            DevExpress.XtraLayout.RowDefinition rowDefinition5 = new DevExpress.XtraLayout.RowDefinition();
            this.gridControlMalfunctionTrackings = new TechnicalServiceUI.Controls.MyGridControl();
            this.gridViewMalfunctionTracking = new TechnicalServiceUI.Controls.MyGridView();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.myDataLayoutControl1 = new TechnicalServiceUI.Controls.MyDataLayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.myTextBox1 = new TechnicalServiceUI.Controls.MyTextBox();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.myDateEdit1 = new TechnicalServiceUI.Controls.MyDateEdit();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.myTextBox2 = new TechnicalServiceUI.Controls.MyTextBox();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.myMemoEdit1 = new TechnicalServiceUI.Controls.MyMemoEdit();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMalfunctionTrackings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMalfunctionTracking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl1)).BeginInit();
            this.myDataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myTextBox1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myTextBox2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myMemoEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlMalfunctionTrackings
            // 
            this.gridControlMalfunctionTrackings.Dock = System.Windows.Forms.DockStyle.Left;
            this.gridControlMalfunctionTrackings.Location = new System.Drawing.Point(0, 0);
            this.gridControlMalfunctionTrackings.MainView = this.gridViewMalfunctionTracking;
            this.gridControlMalfunctionTrackings.Name = "gridControlMalfunctionTrackings";
            this.gridControlMalfunctionTrackings.Size = new System.Drawing.Size(956, 543);
            this.gridControlMalfunctionTrackings.TabIndex = 0;
            this.gridControlMalfunctionTrackings.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMalfunctionTracking});
            // 
            // gridViewMalfunctionTracking
            // 
            this.gridViewMalfunctionTracking.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gridViewMalfunctionTracking.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewMalfunctionTracking.Appearance.FooterPanel.Options.UseFont = true;
            this.gridViewMalfunctionTracking.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridViewMalfunctionTracking.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewMalfunctionTracking.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridViewMalfunctionTracking.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewMalfunctionTracking.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewMalfunctionTracking.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewMalfunctionTracking.Appearance.ViewCaption.Options.UseForeColor = true;
            this.gridViewMalfunctionTracking.GridControl = this.gridControlMalfunctionTrackings;
            this.gridViewMalfunctionTracking.Name = "gridViewMalfunctionTracking";
            this.gridViewMalfunctionTracking.OptionsMenu.EnableColumnMenu = false;
            this.gridViewMalfunctionTracking.OptionsMenu.EnableFooterMenu = false;
            this.gridViewMalfunctionTracking.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridViewMalfunctionTracking.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridViewMalfunctionTracking.OptionsPrint.AutoWidth = false;
            this.gridViewMalfunctionTracking.OptionsPrint.PrintFooter = false;
            this.gridViewMalfunctionTracking.OptionsPrint.PrintGroupFooter = false;
            this.gridViewMalfunctionTracking.OptionsView.ColumnAutoWidth = false;
            this.gridViewMalfunctionTracking.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.gridViewMalfunctionTracking.OptionsView.RowAutoHeight = true;
            this.gridViewMalfunctionTracking.OptionsView.ShowAutoFilterRow = true;
            this.gridViewMalfunctionTracking.OptionsView.ShowGroupPanel = false;
            this.gridViewMalfunctionTracking.OptionsView.ShowViewCaption = true;
            this.gridViewMalfunctionTracking.ViewCaption = "Malfunction Trackings";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.myDataLayoutControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(956, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(337, 543);
            this.panelControl1.TabIndex = 1;
            // 
            // myDataLayoutControl1
            // 
            this.myDataLayoutControl1.Controls.Add(this.myMemoEdit1);
            this.myDataLayoutControl1.Controls.Add(this.myTextBox2);
            this.myDataLayoutControl1.Controls.Add(this.myDateEdit1);
            this.myDataLayoutControl1.Controls.Add(this.myTextBox1);
            this.myDataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.myDataLayoutControl1.Location = new System.Drawing.Point(2, 2);
            this.myDataLayoutControl1.Name = "myDataLayoutControl1";
            this.myDataLayoutControl1.OptionsFocus.EnableAutoTabOrder = false;
            this.myDataLayoutControl1.Root = this.Root;
            this.myDataLayoutControl1.Size = new System.Drawing.Size(333, 266);
            this.myDataLayoutControl1.TabIndex = 0;
            this.myDataLayoutControl1.Text = "myDataLayoutControl1";
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
            rowDefinition4.Height = 150D;
            rowDefinition4.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition5.Height = 24D;
            rowDefinition5.SizeType = System.Windows.Forms.SizeType.Absolute;
            this.Root.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition1,
            rowDefinition2,
            rowDefinition3,
            rowDefinition4,
            rowDefinition5});
            this.Root.Size = new System.Drawing.Size(333, 266);
            this.Root.TextVisible = false;
            // 
            // myTextBox1
            // 
            this.myTextBox1.EnterMoveNextControl = true;
            this.myTextBox1.Location = new System.Drawing.Point(117, 12);
            this.myTextBox1.Name = "myTextBox1";
            this.myTextBox1.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.myTextBox1.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.myTextBox1.Size = new System.Drawing.Size(204, 20);
            this.myTextBox1.StyleController = this.myDataLayoutControl1;
            this.myTextBox1.TabIndex = 4;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem1.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem1.Control = this.myTextBox1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(313, 24);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(93, 13);
            // 
            // myDateEdit1
            // 
            this.myDateEdit1.EditValue = null;
            this.myDateEdit1.EnterMoveNextControl = true;
            this.myDateEdit1.Location = new System.Drawing.Point(117, 36);
            this.myDateEdit1.Name = "myDateEdit1";
            this.myDateEdit1.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.myDateEdit1.Properties.Appearance.Options.UseTextOptions = true;
            this.myDateEdit1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.myDateEdit1.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.myDateEdit1.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.myDateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.myDateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.myDateEdit1.Size = new System.Drawing.Size(204, 20);
            this.myDateEdit1.StyleController = this.myDataLayoutControl1;
            this.myDateEdit1.TabIndex = 5;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem2.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem2.Control = this.myDateEdit1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlItem2.Size = new System.Drawing.Size(313, 24);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(93, 13);
            // 
            // myTextBox2
            // 
            this.myTextBox2.EnterMoveNextControl = true;
            this.myTextBox2.Location = new System.Drawing.Point(117, 60);
            this.myTextBox2.Name = "myTextBox2";
            this.myTextBox2.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.myTextBox2.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.myTextBox2.Size = new System.Drawing.Size(204, 20);
            this.myTextBox2.StyleController = this.myDataLayoutControl1;
            this.myTextBox2.TabIndex = 6;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem3.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem3.Control = this.myTextBox2;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.OptionsTableLayoutItem.RowIndex = 2;
            this.layoutControlItem3.Size = new System.Drawing.Size(313, 24);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(93, 13);
            // 
            // myMemoEdit1
            // 
            this.myMemoEdit1.EnterMoveNextControl = true;
            this.myMemoEdit1.Location = new System.Drawing.Point(117, 84);
            this.myMemoEdit1.Name = "myMemoEdit1";
            this.myMemoEdit1.Properties.Appearance.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.myMemoEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.myMemoEdit1.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.myMemoEdit1.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.myMemoEdit1.Properties.MaxLength = 500;
            this.myMemoEdit1.Size = new System.Drawing.Size(204, 146);
            this.myMemoEdit1.StyleController = this.myDataLayoutControl1;
            this.myMemoEdit1.TabIndex = 7;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem4.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem4.Control = this.myMemoEdit1;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.OptionsTableLayoutItem.RowIndex = 3;
            this.layoutControlItem4.Size = new System.Drawing.Size(313, 150);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(93, 13);
            // 
            // MalfunctionTrackingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 543);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.gridControlMalfunctionTrackings);
            this.Name = "MalfunctionTrackingsForm";
            this.Text = "Malfunction Trackings";
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMalfunctionTrackings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMalfunctionTracking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl1)).EndInit();
            this.myDataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myTextBox1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myTextBox2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myMemoEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.MyGridControl gridControlMalfunctionTrackings;
        private Controls.MyGridView gridViewMalfunctionTracking;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private Controls.MyDataLayoutControl myDataLayoutControl1;
        private Controls.MyMemoEdit myMemoEdit1;
        private Controls.MyTextBox myTextBox2;
        private Controls.MyDateEdit myDateEdit1;
        private Controls.MyTextBox myTextBox1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    }
}