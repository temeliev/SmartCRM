namespace SmartCRM.Presentation
{
    partial class UC_Users
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gridControlUsers = new DevExpress.XtraGrid.GridControl();
            this.gridViewUsers = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColUserId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColUsername = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColPassword = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColIsAdmin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColIsEnabled = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.checkAllUsers = new DevExpress.XtraEditors.CheckEdit();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkAllUsers.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.checkAllUsers);
            this.layoutControl1.Controls.Add(this.gridControlUsers);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(383, 328, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(813, 605);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridControlUsers
            // 
            this.gridControlUsers.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControlUsers.Location = new System.Drawing.Point(5, 28);
            this.gridControlUsers.MainView = this.gridViewUsers;
            this.gridControlUsers.Name = "gridControlUsers";
            this.gridControlUsers.Size = new System.Drawing.Size(803, 572);
            this.gridControlUsers.TabIndex = 4;
            this.gridControlUsers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewUsers});
            // 
            // gridViewUsers
            // 
            this.gridViewUsers.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColUserId,
            this.gridColUsername,
            this.gridColPassword,
            this.gridColIsAdmin,
            this.gridColIsEnabled});
            this.gridViewUsers.GridControl = this.gridControlUsers;
            this.gridViewUsers.Name = "gridViewUsers";
            this.gridViewUsers.OptionsBehavior.Editable = false;
            this.gridViewUsers.OptionsFind.AlwaysVisible = true;
            this.gridViewUsers.OptionsView.ShowGroupPanel = false;
            // 
            // gridColUserId
            // 
            this.gridColUserId.Caption = "User Id";
            this.gridColUserId.FieldName = "UserId";
            this.gridColUserId.Name = "gridColUserId";
            this.gridColUserId.Visible = true;
            this.gridColUserId.VisibleIndex = 0;
            this.gridColUserId.Width = 99;
            // 
            // gridColUsername
            // 
            this.gridColUsername.Caption = "User Name";
            this.gridColUsername.FieldName = "Username";
            this.gridColUsername.Name = "gridColUsername";
            this.gridColUsername.Visible = true;
            this.gridColUsername.VisibleIndex = 1;
            this.gridColUsername.Width = 374;
            // 
            // gridColPassword
            // 
            this.gridColPassword.Caption = "Password";
            this.gridColPassword.FieldName = "Password";
            this.gridColPassword.Name = "gridColPassword";
            this.gridColPassword.Visible = true;
            this.gridColPassword.VisibleIndex = 2;
            this.gridColPassword.Width = 457;
            // 
            // gridColIsAdmin
            // 
            this.gridColIsAdmin.Caption = "Admin";
            this.gridColIsAdmin.FieldName = "IsAdmin";
            this.gridColIsAdmin.Name = "gridColIsAdmin";
            this.gridColIsAdmin.Visible = true;
            this.gridColIsAdmin.VisibleIndex = 3;
            this.gridColIsAdmin.Width = 204;
            // 
            // gridColIsEnabled
            // 
            this.gridColIsEnabled.Caption = "Active";
            this.gridColIsEnabled.FieldName = "IsEnabled";
            this.gridColIsEnabled.Name = "gridColIsEnabled";
            this.gridColIsEnabled.Visible = true;
            this.gridColIsEnabled.VisibleIndex = 4;
            this.gridColIsEnabled.Width = 178;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "Root";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.emptySpaceItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3);
            this.layoutControlGroup1.Size = new System.Drawing.Size(813, 605);
            this.layoutControlGroup1.Text = "Root";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControlUsers;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 23);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(807, 576);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // checkAllUsers
            // 
            this.checkAllUsers.Location = new System.Drawing.Point(5, 5);
            this.checkAllUsers.Name = "checkAllUsers";
            this.checkAllUsers.Properties.Caption = "All Users";
            this.checkAllUsers.Size = new System.Drawing.Size(111, 19);
            this.checkAllUsers.StyleController = this.layoutControl1;
            this.checkAllUsers.TabIndex = 5;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.checkAllUsers;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(115, 23);
            this.layoutControlItem2.Text = "layoutControlItem2";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextToControlDistance = 0;
            this.layoutControlItem2.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(115, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(692, 23);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // UC_Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "UC_Users";
            this.Size = new System.Drawing.Size(813, 605);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkAllUsers.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.GridControl gridControlUsers;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColUserId;
        private DevExpress.XtraGrid.Columns.GridColumn gridColUsername;
        private DevExpress.XtraGrid.Columns.GridColumn gridColPassword;
        private DevExpress.XtraGrid.Columns.GridColumn gridColIsAdmin;
        private DevExpress.XtraGrid.Columns.GridColumn gridColIsEnabled;
        public DevExpress.XtraGrid.Views.Grid.GridView gridViewUsers;
        private DevExpress.XtraEditors.CheckEdit checkAllUsers;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
    }
}
