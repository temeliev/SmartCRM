namespace SmartCRM.Presentation.EmployeeAccount
{
    using System.Windows.Forms;

    using SmartCRM.BOL.Controllers;

    public partial class XF_AccountInfo : DevExpress.XtraEditors.XtraForm
    {
        private AccountController controller;

        private UC_AccountInfo ucAccountInfo;

        private XF_AccountInfo()
        {
            this.InitializeComponent();
            this.Load += this.XF_AccountInfo_Load;
            this.btnSave.Click += this.btnSave_Click;
            this.btnSaveAndClose.Click += this.btnSaveAndClose_Click;
            this.FormClosing += this.XF_AccountInfo_FormClosing;
        }

        void XF_AccountInfo_Load(object sender, System.EventArgs e)
        {
            this.ucAccountInfo = UC_AccountInfo.GetUserControl(this.controller);
            this.ucAccountInfo.SetSelectedTabPage(BOL.Models.Enums.AccountType.User);
            this.ucAccountInfo.Size = this.panelControl.Size;
            this.panelControl.Controls.Add(this.ucAccountInfo);
            this.controller.AccountChanged += this.controller_Changed;
        }

        void controller_Changed(object sender, BOL.Controllers.Events.AccountChangedEventArgs e)
        {
            if (e.IsDirty && !this.btnSave.Enabled)
            {
                this.btnSave.Enabled = true;
                this.btnSaveAndClose.Enabled = true;
            }
            else if (!e.IsDirty && this.btnSave.Enabled)
            {
                this.btnSave.Enabled = false;
                this.btnSaveAndClose.Enabled = false;
            }
        }

        void XF_AccountInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!this.ucAccountInfo.CheckBeforeSave())
            {
                e.Cancel = true;
            }
        }

        void btnSaveAndClose_Click(object sender, System.EventArgs e)
        {
            bool isSaved = this.ucAccountInfo.Save();
            if (isSaved)
            {
                this.SetButtons(true);
                this.Close();
            }
        }

        void btnSave_Click(object sender, System.EventArgs e)
        {
            bool isSaved = this.ucAccountInfo.Save();
            if (isSaved)
            {
                this.SetButtons(true);
            }
        }

        private void SetButtons(bool isEnabled)
        {
            if (this.ucAccountInfo.Save())
            {
                this.btnSave.Enabled = isEnabled;
                this.btnSaveAndClose.Enabled = isEnabled;
            }
        }

        public static void ShowForm(AccountController accController)
        {
            using (XF_AccountInfo form = new XF_AccountInfo())
            {
                form.controller = accController;
                form.ShowDialog();
            }
        }
    }
}