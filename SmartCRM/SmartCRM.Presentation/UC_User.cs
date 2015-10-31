namespace SmartCRM.Presentation
{
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

        public static UC_User GetUserControl(UserController userController)
        {
            UC_User uc = new UC_User();
            uc.controller = userController;
            return uc;
        }
    }
}
