namespace SmartCRM.Presentation.EmployeeAccount
{
    partial class XF_AccountInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XF_AccountInfo));
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlAccount = new DevExpress.XtraLayout.LayoutControl();
            this.panelControl = new DevExpress.XtraEditors.PanelControl();
            this.layoutControlItemPanel = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.btnSaveAndClose = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlAccount)).BeginInit();
            this.layoutControlAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "Root";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItemPanel,
            this.emptySpaceItem1,
            this.layoutControlItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Size = new System.Drawing.Size(526, 383);
            this.layoutControlGroup1.Text = "Root";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btnSave;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItemSave";
            this.layoutControlItem1.Location = new System.Drawing.Point(263, 329);
            this.layoutControlItem1.MaxSize = new System.Drawing.Size(263, 54);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(263, 54);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(263, 54);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.Text = "layoutControlItemSave";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Enabled = false;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(265, 331);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(259, 50);
            this.btnSave.StyleController = this.layoutControlAccount;
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "SAVE";
            // 
            // layoutControlAccount
            // 
            this.layoutControlAccount.Controls.Add(this.btnSaveAndClose);
            this.layoutControlAccount.Controls.Add(this.panelControl);
            this.layoutControlAccount.Controls.Add(this.btnSave);
            this.layoutControlAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControlAccount.Location = new System.Drawing.Point(0, 0);
            this.layoutControlAccount.Name = "layoutControlAccount";
            this.layoutControlAccount.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(685, 274, 250, 350);
            this.layoutControlAccount.Root = this.layoutControlGroup1;
            this.layoutControlAccount.Size = new System.Drawing.Size(526, 383);
            this.layoutControlAccount.TabIndex = 0;
            this.layoutControlAccount.Text = "layoutControlAccount";
            // 
            // panelControl
            // 
            this.panelControl.Location = new System.Drawing.Point(2, 2);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(522, 325);
            this.panelControl.TabIndex = 5;
            // 
            // layoutControlItemPanel
            // 
            this.layoutControlItemPanel.Control = this.panelControl;
            this.layoutControlItemPanel.CustomizationFormText = "layoutControlItemPanel";
            this.layoutControlItemPanel.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItemPanel.Name = "layoutControlItemPanel";
            this.layoutControlItemPanel.Size = new System.Drawing.Size(526, 329);
            this.layoutControlItemPanel.Text = "layoutControlItemPanel";
            this.layoutControlItemPanel.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItemPanel.TextToControlDistance = 0;
            this.layoutControlItemPanel.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 329);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(36, 54);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // btnSaveAndClose
            // 
            this.btnSaveAndClose.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSaveAndClose.Appearance.Options.UseFont = true;
            this.btnSaveAndClose.Enabled = false;
            this.btnSaveAndClose.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveAndClose.Image")));
            this.btnSaveAndClose.Location = new System.Drawing.Point(38, 331);
            this.btnSaveAndClose.Name = "btnSaveAndClose";
            this.btnSaveAndClose.Size = new System.Drawing.Size(223, 50);
            this.btnSaveAndClose.StyleController = this.layoutControlAccount;
            this.btnSaveAndClose.TabIndex = 6;
            this.btnSaveAndClose.Text = "SAVE AND CLOSE";
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnSaveAndClose;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(36, 329);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(227, 54);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(227, 54);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(227, 54);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.Text = "layoutControlItem2";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextToControlDistance = 0;
            this.layoutControlItem2.TextVisible = false;
            // 
            // XF_AccountInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 383);
            this.Controls.Add(this.layoutControlAccount);
            this.Name = "XF_AccountInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlAccount)).EndInit();
            this.layoutControlAccount.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControl layoutControlAccount;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.PanelControl panelControl;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemPanel;
        private DevExpress.XtraEditors.SimpleButton btnSaveAndClose;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;

    }
}