namespace SmartCRM.Presentation
{
    using System;
    using System.Linq;
    using System.Windows.Forms;

    using DevExpress.XtraEditors;

    using SmartCRM.BOL.Controllers;
    using SmartCRM.BOL.Models;
    using SmartCRM.BOL.Utilities;

    public partial class XF_Login : XtraForm
    {
        private LoginController loginController;

        private XF_Login(LoginController controller)
        {
            this.InitializeComponent();
            this.loginController = controller;
            this.btnEnter.Click += this.btnEnter_Click;
            this.Load += this.XF_Login_Load;
        }

        void XF_Login_Load(object sender, System.EventArgs e)
        {
            this.BindModel();
        }

        void btnEnter_Click(object sender, System.EventArgs e)
        {
            var result = this.loginController.Login();
            this.dxErrorProvider1.ClearErrors();
            this.lblMissingUser.Text = string.Empty;
            bool isValidated = true;
            if (!result.Success)
            {
                var usernameError = result.Details.FirstOrDefault(x => x.PropertyName == "Username");
                if (usernameError != null)
                {
                    this.dxErrorProvider1.SetError(this.txtUsername, usernameError.Message);
                    isValidated = false;
                }
                var passwordError = result.Details.FirstOrDefault(x => x.PropertyName == "Password");
                if (passwordError != null)
                {
                    this.dxErrorProvider1.SetError(this.txtPassword, passwordError.Message);
                    isValidated = false;
                }

                if (isValidated)
                {
                    var userError = result.Details.FirstOrDefault(x => x.PropertyName == "NoUser");
                    if (userError != null)
                    {
                        this.lblMissingUser.Text = userError.Message;
                    }
                    else
                    {
                        this.lblMissingUser.Text = string.Empty;
                    }
                }

            }
            else
            {
                this.Close();
                this.Hide();
                XF_Main main = new XF_Main();
                main.ShowDialog();
            }
        }

        public static DialogResult ShowForm(LoginController controller)
        {
            using (XF_Login form = new XF_Login(controller))
            {
                return form.ShowDialog();
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                this.btnEnter_Click(this.btnEnter, EventArgs.Empty);
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void BindModel()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = this.loginController.Model;
            this.txtUsername.DataBindings.Add("EditValue", bs, StaticReflection.GetMemberName<LoginModel>(x => x.Username), true, DataSourceUpdateMode.OnPropertyChanged);
            this.txtPassword.DataBindings.Add("EditValue", bs, StaticReflection.GetMemberName<LoginModel>(x => x.Password), true, DataSourceUpdateMode.OnPropertyChanged);
        }
    }
}
