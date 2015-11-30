namespace SmartCRM.Presentation.Projects
{
    partial class UC_Projects
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
            this.gridControlProjects = new DevExpress.XtraGrid.GridControl();
            this.gridViewProjects = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColStartDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColEndDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColProjectCategoryId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rep_ProjectCategories = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlProjects = new DevExpress.XtraLayout.LayoutControl();
            this.gridControlEmployees = new DevExpress.XtraGrid.GridControl();
            this.gridViewEmployees = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColEmployeeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColEmployeePosition = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroupProjects = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitterItem1 = new DevExpress.XtraLayout.SplitterItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rep_ProjectCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlProjects)).BeginInit();
            this.layoutControlProjects.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupProjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlProjects
            // 
            this.gridControlProjects.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControlProjects.Location = new System.Drawing.Point(5, 5);
            this.gridControlProjects.MainView = this.gridViewProjects;
            this.gridControlProjects.Name = "gridControlProjects";
            this.gridControlProjects.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rep_ProjectCategories});
            this.gridControlProjects.Size = new System.Drawing.Size(721, 523);
            this.gridControlProjects.TabIndex = 4;
            this.gridControlProjects.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewProjects});
            // 
            // gridViewProjects
            // 
            this.gridViewProjects.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColName,
            this.gridColStartDate,
            this.gridColEndDate,
            this.gridColProjectCategoryId,
            this.gridColStatus});
            this.gridViewProjects.GridControl = this.gridControlProjects;
            this.gridViewProjects.GroupCount = 1;
            this.gridViewProjects.GroupFormat = "{1}({2})";
            this.gridViewProjects.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "ProjectCategoryId", null, "Count - {0}")});
            this.gridViewProjects.Name = "gridViewProjects";
            this.gridViewProjects.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridViewProjects.OptionsBehavior.Editable = false;
            this.gridViewProjects.OptionsFind.AlwaysVisible = true;
            this.gridViewProjects.OptionsView.ShowDetailButtons = false;
            this.gridViewProjects.OptionsView.ShowGroupPanel = false;
            this.gridViewProjects.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColProjectCategoryId, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // gridColName
            // 
            this.gridColName.Caption = "Name";
            this.gridColName.FieldName = "Name";
            this.gridColName.Name = "gridColName";
            this.gridColName.OptionsColumn.AllowFocus = false;
            this.gridColName.Visible = true;
            this.gridColName.VisibleIndex = 0;
            // 
            // gridColStartDate
            // 
            this.gridColStartDate.Caption = "Start Date";
            this.gridColStartDate.FieldName = "StartDate";
            this.gridColStartDate.Name = "gridColStartDate";
            this.gridColStartDate.OptionsColumn.AllowFocus = false;
            this.gridColStartDate.Visible = true;
            this.gridColStartDate.VisibleIndex = 1;
            // 
            // gridColEndDate
            // 
            this.gridColEndDate.Caption = "End Date";
            this.gridColEndDate.FieldName = "EndDate";
            this.gridColEndDate.Name = "gridColEndDate";
            this.gridColEndDate.OptionsColumn.AllowFocus = false;
            this.gridColEndDate.Visible = true;
            this.gridColEndDate.VisibleIndex = 2;
            // 
            // gridColProjectCategoryId
            // 
            this.gridColProjectCategoryId.Caption = "Category";
            this.gridColProjectCategoryId.ColumnEdit = this.rep_ProjectCategories;
            this.gridColProjectCategoryId.FieldName = "ProjectCategoryId";
            this.gridColProjectCategoryId.FieldNameSortGroup = "ProjectCategoryId";
            this.gridColProjectCategoryId.Name = "gridColProjectCategoryId";
            this.gridColProjectCategoryId.OptionsColumn.AllowFocus = false;
            this.gridColProjectCategoryId.OptionsFilter.FilterBySortField = DevExpress.Utils.DefaultBoolean.True;
            this.gridColProjectCategoryId.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value;
            // 
            // rep_ProjectCategories
            // 
            this.rep_ProjectCategories.AutoHeight = false;
            this.rep_ProjectCategories.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rep_ProjectCategories.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ProjectCategpryId", "Test")});
            this.rep_ProjectCategories.DisplayMember = "Name";
            this.rep_ProjectCategories.Name = "rep_ProjectCategories";
            this.rep_ProjectCategories.NullText = "";
            this.rep_ProjectCategories.ValueMember = "Id";
            // 
            // gridColStatus
            // 
            this.gridColStatus.Caption = "Status";
            this.gridColStatus.FieldName = "Status";
            this.gridColStatus.Name = "gridColStatus";
            this.gridColStatus.OptionsColumn.AllowFocus = false;
            this.gridColStatus.Visible = true;
            this.gridColStatus.VisibleIndex = 3;
            // 
            // layoutControlProjects
            // 
            this.layoutControlProjects.Controls.Add(this.gridControlEmployees);
            this.layoutControlProjects.Controls.Add(this.gridControlProjects);
            this.layoutControlProjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControlProjects.Location = new System.Drawing.Point(0, 0);
            this.layoutControlProjects.Name = "layoutControlProjects";
            this.layoutControlProjects.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(535, 304, 250, 350);
            this.layoutControlProjects.Root = this.layoutControlGroupProjects;
            this.layoutControlProjects.Size = new System.Drawing.Size(1065, 533);
            this.layoutControlProjects.TabIndex = 0;
            this.layoutControlProjects.Text = "layoutControl1";
            // 
            // gridControlEmployees
            // 
            this.gridControlEmployees.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControlEmployees.Location = new System.Drawing.Point(735, 21);
            this.gridControlEmployees.MainView = this.gridViewEmployees;
            this.gridControlEmployees.Name = "gridControlEmployees";
            this.gridControlEmployees.Size = new System.Drawing.Size(325, 507);
            this.gridControlEmployees.TabIndex = 5;
            this.gridControlEmployees.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewEmployees});
            // 
            // gridViewEmployees
            // 
            this.gridViewEmployees.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColEmployeeName,
            this.gridColEmployeePosition});
            this.gridViewEmployees.GridControl = this.gridControlEmployees;
            this.gridViewEmployees.Name = "gridViewEmployees";
            this.gridViewEmployees.OptionsBehavior.Editable = false;
            this.gridViewEmployees.OptionsView.ShowGroupPanel = false;
            // 
            // gridColEmployeeName
            // 
            this.gridColEmployeeName.Caption = "Name";
            this.gridColEmployeeName.FieldName = "FullName";
            this.gridColEmployeeName.Name = "gridColEmployeeName";
            this.gridColEmployeeName.OptionsColumn.AllowFocus = false;
            this.gridColEmployeeName.Visible = true;
            this.gridColEmployeeName.VisibleIndex = 0;
            // 
            // gridColEmployeePosition
            // 
            this.gridColEmployeePosition.Caption = "Position";
            this.gridColEmployeePosition.Name = "gridColEmployeePosition";
            this.gridColEmployeePosition.OptionsColumn.AllowFocus = false;
            this.gridColEmployeePosition.Visible = true;
            this.gridColEmployeePosition.VisibleIndex = 1;
            // 
            // layoutControlGroupProjects
            // 
            this.layoutControlGroupProjects.CustomizationFormText = "Root";
            this.layoutControlGroupProjects.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroupProjects.GroupBordersVisible = false;
            this.layoutControlGroupProjects.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.splitterItem1});
            this.layoutControlGroupProjects.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroupProjects.Name = "Root";
            this.layoutControlGroupProjects.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3);
            this.layoutControlGroupProjects.Size = new System.Drawing.Size(1065, 533);
            this.layoutControlGroupProjects.Text = "Root";
            this.layoutControlGroupProjects.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControlProjects;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(725, 527);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gridControlEmployees;
            this.layoutControlItem2.CustomizationFormText = "Development Team";
            this.layoutControlItem2.Location = new System.Drawing.Point(730, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(329, 527);
            this.layoutControlItem2.Text = "Development Team";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(92, 13);
            // 
            // splitterItem1
            // 
            this.splitterItem1.AllowHotTrack = true;
            this.splitterItem1.CustomizationFormText = "splitterItem1";
            this.splitterItem1.Location = new System.Drawing.Point(725, 0);
            this.splitterItem1.Name = "splitterItem1";
            this.splitterItem1.Size = new System.Drawing.Size(5, 527);
            // 
            // UC_Projects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControlProjects);
            this.Name = "UC_Projects";
            this.Size = new System.Drawing.Size(1065, 533);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rep_ProjectCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlProjects)).EndInit();
            this.layoutControlProjects.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupProjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControlProjects;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroupProjects;
        private DevExpress.XtraGrid.GridControl gridControlProjects;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewProjects;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColStartDate;
        private DevExpress.XtraGrid.Columns.GridColumn gridColEndDate;
        private DevExpress.XtraGrid.Columns.GridColumn gridColProjectCategoryId;
        private DevExpress.XtraGrid.Columns.GridColumn gridColStatus;
        private DevExpress.XtraLayout.SplitterItem splitterItem1;
        private DevExpress.XtraGrid.GridControl gridControlEmployees;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewEmployees;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColEmployeeName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColEmployeePosition;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rep_ProjectCategories;
    }
}
