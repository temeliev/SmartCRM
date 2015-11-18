using System.Windows.Forms;
namespace SmartCRM.Presentation.Users
{
    using SmartCRM.BOL.Controllers;
    using SmartCRM.BOL.Models;

    public partial class UC_Users : UserControl
    {
        private AccountController controller;

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
            this.LoadUsers();
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

        internal UserModel GetFocusedItem()
        {
            var focusedUser = (UserModel)this.gridViewUsers.GetFocusedRow();
            return focusedUser;
        }

        public static UC_Users GetUserControl(AccountController accountController)
        {
            UC_Users uc = new UC_Users();
            uc.controller = accountController;
            return uc;
        }
    }
}
