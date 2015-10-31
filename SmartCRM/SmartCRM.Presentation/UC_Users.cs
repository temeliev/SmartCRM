using System.Windows.Forms;
namespace SmartCRM.Presentation
{
    using SmartCRM.BOL.Controllers;

    public partial class UC_Users : UserControl
    {
        private UserController controller;

        private UC_Users()
        {
            this.InitializeComponent();
            this.Load += this.UC_Users_Load;
            this.checkAllUsers.CheckStateChanged += this.checkAllUsers_CheckStateChanged;
        }

        void checkAllUsers_CheckStateChanged(object sender, System.EventArgs e)
        {
            this.LoadUsers();
        }

        void UC_Users_Load(object sender, System.EventArgs e)
        {
            this.gridControlUsers.DataSource = this.controller.Users;
        }

        public void LoadUsers()
        {
            if (this.checkAllUsers.CheckState == CheckState.Checked)
            {
                this.controller.LoadAllUsers();
            }
            else
            {
                this.controller.LoadAllActiveUsers();
            }

            this.gridControlUsers.DataSource = this.controller.Users;
        }

        public static UC_Users GetUserControl(UserController userController)
        {
            UC_Users uc = new UC_Users();
            uc.controller = userController;
            return uc;
        }
    }
}
