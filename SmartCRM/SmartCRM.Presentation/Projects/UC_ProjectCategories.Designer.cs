namespace SmartCRM.Presentation.Projects
{
    partial class UC_ProjectCategories
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.layoutControlProjectCategories = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroupProjectCategories = new DevExpress.XtraLayout.LayoutControlGroup();
            this.gridControlProjectCategories = new DevExpress.XtraGrid.GridControl();
            this.gridViewProjectCategories = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.gridColId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColName = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlProjectCategories)).BeginInit();
            this.layoutControlProjectCategories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupProjectCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProjectCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProjectCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControlProjectCategories
            // 
            this.layoutControlProjectCategories.Controls.Add(this.gridControlProjectCategories);
            this.layoutControlProjectCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControlProjectCategories.Location = new System.Drawing.Point(0, 0);
            this.layoutControlProjectCategories.Name = "layoutControlProjectCategories";
            this.layoutControlProjectCategories.Root = this.layoutControlGroupProjectCategories;
            this.layoutControlProjectCategories.Size = new System.Drawing.Size(351, 441);
            this.layoutControlProjectCategories.TabIndex = 0;
            this.layoutControlProjectCategories.Text = "layoutControl1";
            // 
            // layoutControlGroupProjectCategories
            // 
            this.layoutControlGroupProjectCategories.CustomizationFormText = "layoutControlGroupProjectCategories";
            this.layoutControlGroupProjectCategories.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroupProjectCategories.GroupBordersVisible = false;
            this.layoutControlGroupProjectCategories.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroupProjectCategories.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroupProjectCategories.Name = "layoutControlGroupProjectCategories";
            this.layoutControlGroupProjectCategories.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3);
            this.layoutControlGroupProjectCategories.Size = new System.Drawing.Size(351, 441);
            this.layoutControlGroupProjectCategories.Text = "layoutControlGroupProjectCategories";
            this.layoutControlGroupProjectCategories.TextVisible = false;
            // 
            // gridControlProjectCategories
            // 
            this.gridControlProjectCategories.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControlProjectCategories.Location = new System.Drawing.Point(5, 5);
            this.gridControlProjectCategories.MainView = this.gridViewProjectCategories;
            this.gridControlProjectCategories.Name = "gridControlProjectCategories";
            this.gridControlProjectCategories.Size = new System.Drawing.Size(341, 431);
            this.gridControlProjectCategories.TabIndex = 1;
            this.gridControlProjectCategories.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewProjectCategories});
            // 
            // gridViewProjectCategories
            // 
            this.gridViewProjectCategories.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColId,
            this.gridColName});
            this.gridViewProjectCategories.GridControl = this.gridControlProjectCategories;
            this.gridViewProjectCategories.Name = "gridViewProjectCategories";
            this.gridViewProjectCategories.OptionsView.ShowGroupPanel = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControlProjectCategories;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(345, 435);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // gridColId
            // 
            this.gridColId.Caption = "Id";
            this.gridColId.FieldName = "Id";
            this.gridColId.MaxWidth = 50;
            this.gridColId.Name = "gridColId";
            this.gridColId.OptionsColumn.AllowEdit = false;
            this.gridColId.Visible = true;
            this.gridColId.VisibleIndex = 0;
            this.gridColId.Width = 50;
            // 
            // gridColName
            // 
            this.gridColName.Caption = "Name";
            this.gridColName.FieldName = "Name";
            this.gridColName.Name = "gridColName";
            this.gridColName.Visible = true;
            this.gridColName.VisibleIndex = 1;
            this.gridColName.Width = 263;
            // 
            // UC_ProjectCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControlProjectCategories);
            this.Name = "UC_ProjectCategories";
            this.Size = new System.Drawing.Size(351, 441);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlProjectCategories)).EndInit();
            this.layoutControlProjectCategories.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupProjectCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProjectCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProjectCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControlProjectCategories;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroupProjectCategories;
        private DevExpress.XtraGrid.GridControl gridControlProjectCategories;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewProjectCategories;
        private DevExpress.XtraGrid.Columns.GridColumn gridColId;
        private DevExpress.XtraGrid.Columns.GridColumn gridColName;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}
