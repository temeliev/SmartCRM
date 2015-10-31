namespace SmartCRM.Presentation
{
    using System.Windows.Forms;

    using DevExpress.XtraGrid.Views.Grid;

    using SmartCRM.BOL.Controllers;
    using SmartCRM.BOL.Models;

    public partial class RF_Test : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private MainController mainController;

        private UC_Users ucUsers;
        private UC_User ucUser;

        public RF_Test()
        {
            this.InitializeComponent();

            this.navBarUsers.LinkClicked += this.navBarUsers_LinkClicked;

            this.layoutControl2.Resize += this.layoutControl2_Resize;

            this.barBtnRefresh.ItemClick += this.barBtnRefresh_ItemClick;
            this.barBtnAdd.ItemClick += this.barBtnAdd_ItemClick;
            this.barBtnEdit.ItemClick += this.barBtnEdit_ItemClick;
            this.barBtnDelete.ItemClick += this.barBtnDelete_ItemClick;

            this.barBtnNavUp.ItemClick += this.barBtnNavUp_ItemClick;
            this.barBtnNavDown.ItemClick += this.barBtnNavDown_ItemClick;

            this.barBtnList.ItemClick += this.barBtnList_ItemClick;

            this.barBtnSave.ItemClick += this.barBtnSave_ItemClick;
            this.barBtnSaveAndClose.ItemClick += this.barBtnSaveAndClose_ItemClick;
            this.barBtnClose.ItemClick += this.barBtnClose_ItemClick;
        }

        #region Group CRUD

        void barBtnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (DialogResult.OK == MessageBox.Show(
                    "Are You sure that you want to delete this record?",
                    "Attention",
                    MessageBoxButtons.OKCancel, 
                    MessageBoxIcon.Warning))
            {
                var focusedUser = (UserModel)this.ucUsers.gridViewUsers.GetFocusedRow();
                if (focusedUser != null)
                {
                    this.mainController.UserController.DeleteUser(focusedUser);
                }
            }
        }

        void barBtnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var focusedUser = (UserModel)this.ucUsers.gridViewUsers.GetFocusedRow();
            if (focusedUser != null)
            {
                this.EditUser(focusedUser);
            }
        }

        void barBtnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.ucUsers != null)
            {
                this.mainController.UserController.CreateUser();
                this.ribbonPageGroupCRUD.Visible = false;
                this.ribbonPageGroupNavigation.Visible = false;
                this.LoadUCUser();
            }
        }

        void barBtnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.ucUsers.LoadUsers();
        }

        #endregion Group CRUD

        #region Group Main

        void barBtnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.ucUser != null)
            {
                this.ucUsers.LoadUsers();
                this.ShowUsers();
            }
        }

        void barBtnSaveAndClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.ucUser != null)
            {
                this.mainController.UserController.SaveUser();
                this.ShowUsers();
            }
        }

        void barBtnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.ucUser != null)
            {
                this.mainController.UserController.SaveUser();
                this.ucUsers.LoadUsers();
            }
        }

        #endregion Group Main

        #region UC_Users

        void navBarUsers_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            this.ShowUsers();
        }

        private void ShowUsers()
        {
            this.layoutControl2.Controls.Clear();

            if (this.ucUsers == null)
            {
                this.ucUsers = UC_Users.GetUserControl(this.mainController.UserController);
                this.ucUsers.Size = this.layoutControl2.Size;
                this.ucUsers.gridViewUsers.FocusedRowChanged += this.gridViewUsers_FocusedRowChanged;
                this.ucUsers.gridViewUsers.RowCellClick += this.gridViewUsers_RowCellClick;
            }

            this.layoutControl2.Controls.Add(this.ucUsers);

            this.ribbonPageGroupCRUD.Text = "Users Management";
            this.ribbonPageGroupCRUD.Visible = true;

            this.ribbonPageGroupNavigation.Visible = true;

            this.ribbonPageGroupHome.Visible = false;

            this.ribbonPageGroupMain.Visible = false;
        }

        void gridViewUsers_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            int rowCount = this.ucUsers.gridViewUsers.RowCount;
            if (rowCount <= 1)
            {
                this.barBtnNavUp.Enabled = false;
                this.barBtnNavDown.Enabled = false;
            }
            else
            {
                if (e.FocusedRowHandle == 0)
                {
                    this.barBtnNavDown.Enabled = true;
                    this.barBtnNavUp.Enabled = false;
                }
                else if (e.FocusedRowHandle == rowCount - 1)
                {
                    this.barBtnNavUp.Enabled = true;
                    this.barBtnNavDown.Enabled = false;
                }
                else
                {
                    this.barBtnNavUp.Enabled = true;
                    this.barBtnNavDown.Enabled = true;
                }
            }

        }

        void gridViewUsers_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            if (e.Clicks == 2)
            {
                var focusedUser = (UserModel)this.ucUsers.gridViewUsers.GetRow(e.RowHandle);
                if (focusedUser != null)
                {
                    this.EditUser(focusedUser);
                }
            }
        }

        private void EditUser(UserModel focusedUser)
        {
            this.mainController.UserController.SetUser(focusedUser);
            this.LoadUCUser();
        }

        private void LoadUCUser()
        {
            this.ucUser = UC_User.GetUserControl(this.mainController.UserController);
            this.layoutControl2.Controls.Clear();
            this.layoutControl2.Controls.Add(this.ucUser);
            this.ribbonPageGroupCRUD.Visible = false;
            this.ribbonPageGroupNavigation.Visible = false;
            this.ribbonPageGroupHome.Visible = true;
            this.ribbonPageGroupMain.Visible = true;
        }

        #endregion UC_Users

        #region Navigation

        void barBtnNavDown_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.ucUsers.gridViewUsers.FocusedRowHandle++;
        }

        void barBtnNavUp_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.ucUsers.gridViewUsers.FocusedRowHandle--;
        }

        #endregion Navigation

        void barBtnList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.ucUser != null)
            {
                this.ucUser = null;
            }

            if (this.ucUsers != null)
            {
                this.ShowUsers();
            }
        }

        void layoutControl2_Resize(object sender, System.EventArgs e)
        {
            if (this.ucUsers != null)
            {
                this.ucUsers.Size = this.layoutControl2.Size;
            }
        }

        public static DialogResult ShowForm(MainController controller)
        {
            using (RF_Test form = new RF_Test())
            {
                form.mainController = controller;
                return form.ShowDialog();
            }
        }
    }
}