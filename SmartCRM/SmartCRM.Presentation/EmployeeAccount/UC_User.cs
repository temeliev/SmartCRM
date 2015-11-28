namespace SmartCRM.Presentation.Users
{
    using System.Linq;

    using System.Windows.Forms;

    using SmartCRM.BOL.Models;
    using SmartCRM.BOL.Utilities;

    public partial class UC_User : UserControl
    {
        private UserModel model;

        private UC_User()
        {
            this.InitializeComponent();
            this.Load += this.UC_User_Load;
        }

        void UC_User_Load(object sender, System.EventArgs e)
        {
            this.txtUsername.Properties.ReadOnly = !this.model.IsNew;

            BindingSource bs = new BindingSource();
            bs.DataSource = this.model;

            this.txtUsername.DataBindings.Add("EditValue", bs, StaticReflection.GetMemberName<UserModel>(x => x.Username), true, DataSourceUpdateMode.OnPropertyChanged);
            this.txtPassword.DataBindings.Add("EditValue", bs, StaticReflection.GetMemberName<UserModel>(x => x.Password), true, DataSourceUpdateMode.OnPropertyChanged);
            this.IsAdmin.DataBindings.Add("Checked", bs, StaticReflection.GetMemberName<UserModel>(x => x.IsAdmin), true, DataSourceUpdateMode.OnPropertyChanged);
            this.IsEnabled.DataBindings.Add("Checked", bs, StaticReflection.GetMemberName<UserModel>(x => x.IsEnabled), true, DataSourceUpdateMode.OnPropertyChanged);
        }

        public bool ShowErrors(CheckResult result)
        {
            bool hasErrors = false;
            var passwordError = result.Details.FirstOrDefault(x => x.PropertyName == StaticReflection.GetMemberName<UserModel>(u => u.Password).ToString());
            if (passwordError != null)
            {
                this.dxErrorProvider1.SetError(this.txtPassword, passwordError.Message);
                hasErrors = true;
            }

            var usernameError = result.Details.FirstOrDefault(x => x.PropertyName == StaticReflection.GetMemberName<UserModel>(u => u.Username).ToString());
            if (usernameError != null)
            {
                this.dxErrorProvider1.SetError(this.txtUsername, usernameError.Message);
                hasErrors = true;
            }

            return hasErrors;
        }

        public void ClearErrors()
        {
            this.dxErrorProvider1.ClearErrors();
        }

        public static UC_User GetUserControl(UserModel userModel)
        {
            UC_User uc = new UC_User();
            uc.model = userModel;
            return uc;
        }
    }
}
