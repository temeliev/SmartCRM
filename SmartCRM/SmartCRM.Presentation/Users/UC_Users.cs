using System.Windows.Forms;
namespace SmartCRM.Presentation.Users
{
    using System;

    using SmartCRM.BOL.Controllers;
    using SmartCRM.BOL.Models;
    using SmartCRM.BOL.Models.Enums;

    public partial class UC_Users : UserControl, INavigateable, IGridInfo, IMainView
    {
        private AccountController controller;

        private int lastFocusedRowHandle = 0;

        private UC_Users()
        {
            this.InitializeComponent();
            this.Load += this.UC_Users_Load;
            this.checkAllUsers.CheckStateChanged += this.checkAllUsers_CheckStateChanged;
            this.gridViewUsers.FocusedRowChanged += this.gridViewUsers_FocusedRowChanged;
            this.gridViewUsers.RowCellClick += this.gridViewUsers_RowCellClick;
        }

        void gridViewUsers_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (e.Clicks == 2)
            {
                this.EditFocusedItem();
            }
        }

        void gridViewUsers_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle >= 0 && e.FocusedRowHandle != e.PrevFocusedRowHandle)
            {
                var form = this.FindForm() as RF_Main;
                if (form != null)
                {
                    form.SetNavigationBar(e.FocusedRowHandle, this.gridViewUsers.DataRowCount);
                }
            }
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

        public void IncreaseRow()
        {
            this.gridViewUsers.FocusedRowHandle++;
        }

        public void DecreaseRow()
        {
            this.gridViewUsers.FocusedRowHandle--;
        }

        public void AddItem()
        {
            this.controller.SetUser(UserModel.Create());
            this.controller.SetEmployee(EmployeeModel.Create());
            this.ShowAccountInfo(AccountType.User);
        }

        public void EditFocusedItem()
        {
            var model = this.GetFocusedItem();
            this.controller.SetUser(model);

            var employee = this.controller.GetEmbloyeeById(model.EmployeeId);
            this.controller.SetEmployee(employee);

            this.lastFocusedRowHandle = this.gridViewUsers.FocusedRowHandle;

            this.ShowAccountInfo(AccountType.User);
        }

        public void RefreshDataSource()
        {
            this.LoadUsers();
        }

        private void ShowAccountInfo(AccountType type)
        {
            var accInfo = UC_AccountInfo.GetUserControl(this.controller);
            accInfo.SetSelectedTabPage(type);
            var form = this.FindForm() as RF_Main;
            if (form != null)
            {
                form.AddControlToLayout(accInfo);
                form.SetSaveButtons(this.controller.AccountIsDirty());
                form.SetEditItemControls("Users List");
            }
        }

        public static UC_Users GetUserControl(AccountController accountController)
        {
            UC_Users uc = new UC_Users();
            uc.controller = accountController;
            return uc;
        }

        public void InitializeControls()
        {
            var form = this.FindForm() as RF_Main;
            if (form != null)
            {
                form.SetEditCollectionControls("Users Management");
                this.gridViewUsers.FocusedRowHandle = this.lastFocusedRowHandle;
            }
        }
    }
}
