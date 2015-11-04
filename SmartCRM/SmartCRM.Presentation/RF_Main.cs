namespace SmartCRM.Presentation
{
    using System.Linq;
    using System.Windows.Forms;

    using DevExpress.XtraGrid.Views.Grid;
    using DevExpress.XtraNavBar;

    using SmartCRM.BOL.Controllers;
    using SmartCRM.BOL.Models;
    using SmartCRM.BOL.Utilities;

    public partial class RF_Main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private MainController mainController;

        private UC_Users ucUsers;
        private UC_User ucUser;

        public RF_Main()
        {
            this.InitializeComponent();

            this.navBarUsers.LinkClicked += this.navBarUsers_LinkClicked;

            this.layoutControlUC.Resize += this.layoutControl2_Resize;

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
            
            this.navBarControlLeftBar.MouseDown += this.navBarControlLeftBar_MouseDown;

            this.ribbon.Minimized = true;
        }

        void navBarControlLeftBar_MouseDown(object sender, MouseEventArgs e)
        {
            NavBarHitInfo hitInfo = this.navBarControlLeftBar.CalcHitInfo(e.Location);
            if (hitInfo.InGroupCaption && hitInfo.Group != this.navBarControlLeftBar.ActiveGroup)
            {
                this.layoutControlUC.Controls.Clear();
                this.ribbonPageGroupCRUD.Visible = false;
                this.ribbonPageGroupNavigation.Visible = false;
                this.ribbon.Minimized = true;
            }
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
                if (this.CheckUCUserForChanges())
                {
                    if (!this.SaveUser())
                    {
                        return;
                    }
                }

                this.ucUsers.LoadUsers();
                this.ShowUsers();
            }
        }

        void barBtnSaveAndClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.ucUser != null)
            {
                if (!this.SaveUser())
                {
                    return;
                }

                this.ucUsers.LoadUsers();
                this.ShowUsers();
            }
        }

        void barBtnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.ucUser != null)
            {
                if (!this.SaveUser())
                {
                    return;
                }

                this.ucUsers.LoadUsers();
            }
        }

        private bool SaveUser()
        {
            this.ucUser.ClearErrors();
            var check = this.mainController.UserController.SaveUser();
            if (!check.Success)
            {
                this.ucUser.ShowErrors(check);
                return false;
            }

            return true;
        }

        private bool CheckUCUserForChanges()
        {
            if (this.mainController.UserController.CurrentUser.IsDirty)
            {
                if (DialogResult.Yes == MessageBox.Show("Changes were made!\nDo You want to save?", "Attention", MessageBoxButtons.YesNo))
                {
                    return true;
                }

                this.mainController.UserController.CurrentUser.RejectChanges();
            }

            return false;
        }

        #endregion Group Main

        #region UC_Users

        void navBarUsers_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (this.ucUsers != null && this.ucUser != null && this.CheckUCUserForChanges())
            {
                if (!this.SaveUser())
                {
                    return;
                }
            }

            this.ShowUsers();
            this.ribbon.Minimized = false;
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
            this.layoutControlUC.Controls.Clear();
            this.layoutControlUC.Controls.Add(this.ucUser);
            this.ribbonPageGroupCRUD.Visible = false;
            this.ribbonPageGroupNavigation.Visible = false;
            this.ribbonPageGroupHome.Visible = true;
            this.ribbonPageGroupMain.Visible = true;
        }

        private void ShowUsers()
        {
            this.layoutControlUC.Controls.Clear();

            if (this.ucUsers == null)
            {
                this.ucUsers = UC_Users.GetUserControl(this.mainController.UserController);
                this.ucUsers.Size = this.layoutControlUC.Size;
                this.ucUsers.gridViewUsers.FocusedRowChanged += this.gridViewUsers_FocusedRowChanged;
                this.ucUsers.gridViewUsers.RowCellClick += this.gridViewUsers_RowCellClick;
            }

            this.layoutControlUC.Controls.Add(this.ucUsers);

            this.ribbonPageGroupCRUD.Text = "Users Management";
            this.ribbonPageGroupCRUD.Visible = true;

            this.ribbonPageGroupNavigation.Visible = true;

            this.ribbonPageGroupHome.Visible = false;

            this.ribbonPageGroupMain.Visible = false;
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
            if (this.ucUsers != null)
            {
                if (this.CheckUCUserForChanges())
                {
                    if (!this.SaveUser())
                    {
                        return;
                    }
                }

                if (this.ucUser != null)
                {
                    this.ucUser = null;
                }

                this.ShowUsers();
            }
        }

        void layoutControl2_Resize(object sender, System.EventArgs e)
        {
            if (this.ucUsers != null)
            {
                this.ucUsers.Size = this.layoutControlUC.Size;
            }
        }

        public static DialogResult ShowForm(MainController controller)
        {
            using (RF_Main form = new RF_Main())
            {
                form.mainController = controller;
                return form.ShowDialog();
            }
        }
    }
}