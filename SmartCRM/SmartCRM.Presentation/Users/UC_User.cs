namespace SmartCRM.Presentation.Users
{
    using System.Linq;

    using SmartCRM.BOL.Controllers;
    using System.Windows.Forms;

    using SmartCRM.BOL.Models;
    using SmartCRM.BOL.Utilities;

    public partial class UC_User : UserControl
    {
        private UserController controller;

        private UC_User()
        {
            this.InitializeComponent();
            this.Load += this.UC_User_Load;
        }

        void UC_User_Load(object sender, System.EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = this.controller.CurrentUser;

            this.txtUsername.DataBindings.Add("EditValue", bs, StaticReflection.GetMemberName<UserModel>(x => x.Username), true, DataSourceUpdateMode.OnPropertyChanged);
            this.txtPassword.DataBindings.Add("EditValue", bs, StaticReflection.GetMemberName<UserModel>(x => x.Password), true, DataSourceUpdateMode.OnPropertyChanged);
            this.IsAdmin.DataBindings.Add("Checked", bs, StaticReflection.GetMemberName<UserModel>(x => x.IsAdmin), true, DataSourceUpdateMode.OnPropertyChanged);
            this.IsEnabled.DataBindings.Add("Checked", bs, StaticReflection.GetMemberName<UserModel>(x => x.IsEnabled), true, DataSourceUpdateMode.OnPropertyChanged);
        }

        public void ShowErrors(CheckResult result)
        {
            var passwordError = result.Details.FirstOrDefault(x => x.PropertyName == StaticReflection.GetMemberName<UserModel>(u => u.Password).ToString());
            if (passwordError != null)
            {
                this.dxErrorProvider1.SetError(this.txtPassword, passwordError.Message);
            }

            var usernameError = result.Details.FirstOrDefault(x => x.PropertyName == StaticReflection.GetMemberName<UserModel>(u => u.Username).ToString());
            if (usernameError != null)
            {
                this.dxErrorProvider1.SetError(this.txtUsername, usernameError.Message);
            }
        }

        public static UC_User GetUserControl(UserController userController)
        {
            UC_User uc = new UC_User();
            uc.controller = userController;
            return uc;
        }

        public void ClearErrors()
        {
            this.dxErrorProvider1.ClearErrors();
        }

        public void SetUsernameReadOnly(bool value)
        {
            this.txtUsername.Properties.ReadOnly = value;
        }
    }
}
