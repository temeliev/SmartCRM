namespace SmartCRM.Presentation
{
    partial class UC_AccountInfo
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
            this.layoutControlAccountInfo = new DevExpress.XtraLayout.LayoutControl();
            this.tabControlAccountInfo = new DevExpress.XtraTab.XtraTabControl();
            this.tabPageEmployeeInfo = new DevExpress.XtraTab.XtraTabPage();
            this.layoutControlEmployeeInfo = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroupEmployeeInfo = new DevExpress.XtraLayout.LayoutControlGroup();
            this.tabPageUserInfo = new DevExpress.XtraTab.XtraTabPage();
            this.layoutControlUserInfo = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroupUserInfo = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroupAccountInfo = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlAccountInfo)).BeginInit();
            this.layoutControlAccountInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAccountInfo)).BeginInit();
            this.tabControlAccountInfo.SuspendLayout();
            this.tabPageEmployeeInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlEmployeeInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupEmployeeInfo)).BeginInit();
            this.tabPageUserInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlUserInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupUserInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupAccountInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControlAccountInfo
            // 
            this.layoutControlAccountInfo.Controls.Add(this.tabControlAccountInfo);
            this.layoutControlAccountInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControlAccountInfo.Location = new System.Drawing.Point(0, 0);
            this.layoutControlAccountInfo.Name = "layoutControlAccountInfo";
            this.layoutControlAccountInfo.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(936, 235, 447, 460);
            this.layoutControlAccountInfo.Root = this.layoutControlGroupAccountInfo;
            this.layoutControlAccountInfo.Size = new System.Drawing.Size(656, 441);
            this.layoutControlAccountInfo.TabIndex = 0;
            this.layoutControlAccountInfo.Text = "layoutControl1";
            // 
            // tabControlAccountInfo
            // 
            this.tabControlAccountInfo.Location = new System.Drawing.Point(12, 12);
            this.tabControlAccountInfo.Name = "tabControlAccountInfo";
            this.tabControlAccountInfo.SelectedTabPage = this.tabPageEmployeeInfo;
            this.tabControlAccountInfo.Size = new System.Drawing.Size(632, 417);
            this.tabControlAccountInfo.TabIndex = 4;
            this.tabControlAccountInfo.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabPageEmployeeInfo,
            this.tabPageUserInfo});
            // 
            // tabPageEmployeeInfo
            // 
            this.tabPageEmployeeInfo.Controls.Add(this.layoutControlEmployeeInfo);
            this.tabPageEmployeeInfo.Name = "tabPageEmployeeInfo";
            this.tabPageEmployeeInfo.Size = new System.Drawing.Size(626, 389);
            this.tabPageEmployeeInfo.Text = "Employee Info";
            // 
            // layoutControlEmployeeInfo
            // 
            this.layoutControlEmployeeInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControlEmployeeInfo.Location = new System.Drawing.Point(0, 0);
            this.layoutControlEmployeeInfo.Name = "layoutControlEmployeeInfo";
            this.layoutControlEmployeeInfo.Root = this.layoutControlGroupEmployeeInfo;
            this.layoutControlEmployeeInfo.Size = new System.Drawing.Size(626, 389);
            this.layoutControlEmployeeInfo.TabIndex = 0;
            this.layoutControlEmployeeInfo.Text = "layoutControl1";
            // 
            // layoutControlGroupEmployeeInfo
            // 
            this.layoutControlGroupEmployeeInfo.CustomizationFormText = "layoutControlGroupEmployeeInfo";
            this.layoutControlGroupEmployeeInfo.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroupEmployeeInfo.GroupBordersVisible = false;
            this.layoutControlGroupEmployeeInfo.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroupEmployeeInfo.Name = "layoutControlGroupEmployeeInfo";
            this.layoutControlGroupEmployeeInfo.Size = new System.Drawing.Size(626, 389);
            this.layoutControlGroupEmployeeInfo.Text = "layoutControlGroupEmployeeInfo";
            this.layoutControlGroupEmployeeInfo.TextVisible = false;
            // 
            // tabPageUserInfo
            // 
            this.tabPageUserInfo.Controls.Add(this.layoutControlUserInfo);
            this.tabPageUserInfo.Name = "tabPageUserInfo";
            this.tabPageUserInfo.Size = new System.Drawing.Size(626, 389);
            this.tabPageUserInfo.Tooltip = "Create Login";
            // 
            // layoutControlUserInfo
            // 
            this.layoutControlUserInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControlUserInfo.Location = new System.Drawing.Point(0, 0);
            this.layoutControlUserInfo.Name = "layoutControlUserInfo";
            this.layoutControlUserInfo.Root = this.layoutControlGroupUserInfo;
            this.layoutControlUserInfo.Size = new System.Drawing.Size(626, 389);
            this.layoutControlUserInfo.TabIndex = 0;
            this.layoutControlUserInfo.Text = "layoutControl1";
            // 
            // layoutControlGroupUserInfo
            // 
            this.layoutControlGroupUserInfo.CustomizationFormText = "layoutControlGroupUserInfo";
            this.layoutControlGroupUserInfo.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroupUserInfo.GroupBordersVisible = false;
            this.layoutControlGroupUserInfo.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroupUserInfo.Name = "layoutControlGroupUserInfo";
            this.layoutControlGroupUserInfo.Size = new System.Drawing.Size(626, 389);
            this.layoutControlGroupUserInfo.Text = "layoutControlGroupUserInfo";
            this.layoutControlGroupUserInfo.TextVisible = false;
            // 
            // layoutControlGroupAccountInfo
            // 
            this.layoutControlGroupAccountInfo.CustomizationFormText = "Root";
            this.layoutControlGroupAccountInfo.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroupAccountInfo.GroupBordersVisible = false;
            this.layoutControlGroupAccountInfo.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroupAccountInfo.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroupAccountInfo.Name = "Root";
            this.layoutControlGroupAccountInfo.Size = new System.Drawing.Size(656, 441);
            this.layoutControlGroupAccountInfo.Text = "Root";
            this.layoutControlGroupAccountInfo.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.tabControlAccountInfo;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(636, 421);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // UC_AccountInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControlAccountInfo);
            this.Name = "UC_AccountInfo";
            this.Size = new System.Drawing.Size(656, 441);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlAccountInfo)).EndInit();
            this.layoutControlAccountInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAccountInfo)).EndInit();
            this.tabControlAccountInfo.ResumeLayout(false);
            this.tabPageEmployeeInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlEmployeeInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupEmployeeInfo)).EndInit();
            this.tabPageUserInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlUserInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupUserInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupAccountInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControlAccountInfo;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroupAccountInfo;
        private DevExpress.XtraTab.XtraTabControl tabControlAccountInfo;
        private DevExpress.XtraTab.XtraTabPage tabPageEmployeeInfo;
        private DevExpress.XtraLayout.LayoutControl layoutControlEmployeeInfo;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroupEmployeeInfo;
        private DevExpress.XtraTab.XtraTabPage tabPageUserInfo;
        private DevExpress.XtraLayout.LayoutControl layoutControlUserInfo;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroupUserInfo;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}
