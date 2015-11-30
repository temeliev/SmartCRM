namespace SmartCRM.Presentation
{
    using System;
    using System.Linq;
    using System.Windows.Forms;

    using DevExpress.XtraGrid.Views.Base;
    using DevExpress.XtraGrid.Views.Grid;
    using DevExpress.XtraNavBar;

    using SmartCRM.BOL;
    using SmartCRM.BOL.Controllers;
    using SmartCRM.BOL.Models;
    using SmartCRM.Presentation.Users;
    using SmartCRM.BOL.Models.Enums;
    using SmartCRM.BOL.Utilities;
    using SmartCRM.Presentation.Employees;
    using SmartCRM.BOL.Controllers.Events;
    using SmartCRM.Presentation.EmployeeAccount;
    using SmartCRM.Presentation.Projects;

    public partial class RF_Main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private MainController mainController;

        private UC_Users ucUsers;

        private UC_AccountInfo ucAccountInfo;

        private UC_Employees ucEmployees;

        private int employeesLastFocusedRowHandle = 0;
        private int usersLastFocusedRowHandle = 0;

        public RF_Main()
        {
            this.InitializeComponent();

            this.navBarUsers.LinkClicked += this.navBarUsers_LinkClicked;
            this.navBarEmployees.LinkClicked += this.navBarEmployees_LinkClicked;

            this.layoutControlUC.Resize += this.layoutControlUC_Resize;

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

            this.barBtnAccountInfo.ItemClick += this.barBtnAccountInfo_ItemClick;

            this.navBarProjects.LinkClicked += this.navBarProjects_LinkClicked;
            this.navBarProjectCategories.LinkClicked += this.navBarProjectCategories_LinkClicked;
        }

        void navBarProjectCategories_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            var uc = (UC_ProjectCategories.GetUserControl(this.mainController.ProjectDataController));
            uc.Size = this.layoutControlUC.Size;
            this.layoutControlUC.Controls.Clear();
            this.layoutControlUC.Controls.Add(uc);
        }

        void navBarProjects_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            this.layoutControlUC.Controls.Clear();
            var uc = UC_Projects.GetUserControl(this.mainController.ProjectDataController);
            uc.Size = this.layoutControlUC.Size;
            this.layoutControlUC.Controls.Add(uc);
        }

        void barBtnAccountInfo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var employee = this.mainController.AccountController.GetEmbloyeeById(Global.CurrentUser.EmployeeId);
            if (employee == null)
            {
                throw new NullReferenceException("Missing Employee!");
            }

            this.mainController.AccountController.SetEmployee(employee);
            this.mainController.AccountController.SetUser(Global.CurrentUser);
            XF_AccountInfo.ShowForm(this.mainController.AccountController);
        }

        void AccountController_Changed(object sender, AccountChangedEventArgs e)
        {
            if (e.IsDirty && !this.barBtnSave.Enabled)
            {
                this.barBtnSave.Enabled = true;
                this.barBtnSaveAndClose.Enabled = true;
            }
            else if (!e.IsDirty && this.barBtnSave.Enabled)
            {
                this.barBtnSave.Enabled = false;
                this.barBtnSaveAndClose.Enabled = false;
            }
        }

        void navBarEmployees_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            if (this.ucAccountInfo != null)
            {
                if (this.ucAccountInfo.CheckAccountBeforeSave())
                {
                    this.ucAccountInfo = null;
                    this.ShowEmployees();
                }
            }
            else
            {
                this.ShowEmployees();
            }
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
                    Messages.DeleteRecordQuestion,
                    "Warning",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning))
            {
                if (this.mainController.AccountController.HasUsers())
                {
                    var focusedUser = (UserModel)this.ucUsers.gridViewUsers.GetFocusedRow();
                    if (focusedUser != null)
                    {
                        var result = this.mainController.AccountController.DeleteUser(focusedUser);
                        if (!result.Success)
                        {
                            var error = result.Details.FirstOrDefault();
                            if (error != null)
                            {
                                MessageBox.Show(
                                error.Message,
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                else if (this.mainController.AccountController.HasEmployees())
                {
                    var focusedEmployee = (EmployeeModel)this.ucEmployees.advBandedGridViewEmployees.GetFocusedRow();
                    if (focusedEmployee != null)
                    {
                        var result = this.mainController.AccountController.DeleteEmployee(focusedEmployee);
                        if (!result.Success)
                        {
                            var error = result.Details.FirstOrDefault();
                            if (error != null)
                            {
                                MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                    }
                }
            }
        }

        void barBtnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.ucUsers != null)
            {
                var focusedUser = this.ucUsers.GetFocusedItem();
                if (focusedUser != null)
                {
                    this.LoadUser(focusedUser);
                }
            }
            else if (this.ucEmployees != null)
            {
                var focusedEmployee = this.ucEmployees.GetFocusedItem();
                if (focusedEmployee != null)
                {
                    this.LoadEmployee(focusedEmployee);
                }
            }
        }

        void barBtnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.ucUsers != null)
            {
                this.LoadUser(UserModel.Create(), true);
            }
            else if (this.ucEmployees != null)
            {
                this.LoadEmployee(EmployeeModel.Create());
            }
        }

        void barBtnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.mainController.AccountController.HasUsers())
            {
                this.ucUsers.LoadUsers();
            }
            else if (this.mainController.AccountController.HasEmployees())
            {
                this.ucEmployees.LoadEmployees();
            }
        }

        #endregion Group CRUD

        #region Group Main

        void barBtnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.ucAccountInfo != null)
            {
                if (this.ucAccountInfo.CheckAccountBeforeSave())
                {
                    this.CloseAccount();
                }
            }
        }

        void barBtnSaveAndClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.ucAccountInfo != null)
            {
                if (this.ucAccountInfo.Save())
                {
                    this.CloseAccount();
                }
            }
        }

        void barBtnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.ucAccountInfo != null)
            {
                if (this.ucAccountInfo.Save())
                {
                    this.barBtnSave.Enabled = false;
                    this.barBtnSaveAndClose.Enabled = false;
                }
            }
        }

        #endregion Group Main

        #region UC_Users

        void navBarUsers_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (this.ucAccountInfo != null)
            {
                if (this.ucAccountInfo.CheckAccountBeforeSave())
                {
                    this.ucAccountInfo = null;
                    this.ShowUsers();
                }
            }
            else
            {
                this.ShowUsers();
            }
        }

        void gridViewUsers_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            int rowCount = this.ucUsers.gridViewUsers.RowCount;
            this.SetNavigationBar(e.FocusedRowHandle, rowCount);
        }

        void gridViewUsers_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            if (e.Clicks == 2)
            {
                var focusedUser = this.ucUsers.GetFocusedItem();
                if (focusedUser != null)
                {
                    this.LoadUser(focusedUser);
                }
            }
        }

        private void LoadUser(UserModel model, bool isNew = false)
        {
            this.mainController.AccountController.SetUser(model);

            if (isNew)
            {
                this.mainController.AccountController.SetEmployee(EmployeeModel.Create());
            }
            else
            {
                var employee = this.mainController.AccountController.GetEmbloyeeById(model.EmployeeId);
                this.mainController.AccountController.SetEmployee(employee);
            }

            this.usersLastFocusedRowHandle = this.ucUsers.gridViewUsers.FocusedRowHandle;
            this.SetControlsForEdit();
            this.barBtnList.Caption = "Users List";
            this.ShowAccountInfo(AccountType.User);
        }

        private void ShowUsers()
        {
            this.layoutControlUC.Controls.Clear();

            if (this.ucUsers == null)
            {
                this.ucUsers = UC_Users.GetUserControl(this.mainController.AccountController);
                this.ucUsers.Size = this.layoutControlUC.Size;
                this.ucUsers.gridViewUsers.FocusedRowChanged += this.gridViewUsers_FocusedRowChanged;
                this.ucUsers.gridViewUsers.RowCellClick += this.gridViewUsers_RowCellClick;
            }

            if (!this.mainController.AccountController.HasUsers())
            {
                this.ucUsers.LoadUsers();
            }

            this.layoutControlUC.Controls.Add(this.ucUsers);

            this.ribbonPageGroupCRUD.Text = "Users Management";
            this.ribbonPageGroupCRUD.Visible = true;

            this.ribbonPageGroupNavigation.Visible = true;

            this.ribbonPageGroupHome.Visible = false;

            this.ribbonPageGroupMain.Visible = false;

            if (this.mainController.AccountController.Users.Count == 0)
            {
                this.barBtnNavUp.Enabled = false;
                this.barBtnNavDown.Enabled = false;
            }

            this.mainController.AccountController.Employees.Clear();
            this.ribbon.Minimized = false;
            this.ucUsers.gridViewUsers.FocusedRowHandle = this.usersLastFocusedRowHandle;
        }

        #endregion UC_Users

        #region UC_Employees

        void advBandedGridViewEmployees_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            if (e.Clicks == 2)
            {
                var focusedEmployee = this.ucEmployees.GetFocusedItem();
                if (focusedEmployee != null)
                {
                    this.LoadEmployee(focusedEmployee);
                }
            }
        }

        void advBandedGridViewEmployees_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            int rowCount = this.ucEmployees.advBandedGridViewEmployees.RowCount;
            this.SetNavigationBar(e.FocusedRowHandle, rowCount);
        }

        private void ShowEmployees()
        {
            this.layoutControlUC.Controls.Clear();

            if (this.ucEmployees == null)
            {
                this.ucEmployees = UC_Employees.GetUserControl(this.mainController.AccountController);
                this.ucEmployees.Size = this.layoutControlUC.Size;
                this.ucEmployees.advBandedGridViewEmployees.FocusedRowChanged += this.advBandedGridViewEmployees_FocusedRowChanged;
                this.ucEmployees.advBandedGridViewEmployees.RowCellClick += this.advBandedGridViewEmployees_RowCellClick;
            }

            if (!this.mainController.AccountController.HasEmployees())
            {
                this.ucEmployees.LoadEmployees();
            }

            this.layoutControlUC.Controls.Add(this.ucEmployees);

            this.ribbonPageGroupCRUD.Text = "Employees Management";
            this.ribbonPageGroupCRUD.Visible = true;

            this.ribbonPageGroupNavigation.Visible = true;

            this.ribbonPageGroupHome.Visible = false;

            this.ribbonPageGroupMain.Visible = false;

            if (this.mainController.AccountController.Employees.Count == 0)
            {
                this.barBtnNavUp.Enabled = false;
                this.barBtnNavDown.Enabled = false;
            }

            this.ribbon.Minimized = false;
            this.ucEmployees.advBandedGridViewEmployees.FocusedRowHandle = this.employeesLastFocusedRowHandle;
            this.mainController.AccountController.Users.Clear();
        }

        private void LoadEmployee(EmployeeModel model)
        {
            var user = this.mainController.AccountController.GetUserByEmployeeId(model.Id);
            this.mainController.AccountController.SetUser(user);
            this.mainController.AccountController.SetEmployee(model);
            this.employeesLastFocusedRowHandle = this.ucEmployees.advBandedGridViewEmployees.FocusedRowHandle;
            this.SetControlsForEdit();
            this.barBtnList.Caption = "Employees List";
            this.ShowAccountInfo(AccountType.Employee);
        }

        #endregion UC_Employees

        #region UC_AccountInfo

        private void CloseAccount()
        {
            if (this.mainController.AccountController.HasUsers())
            {
                this.ucAccountInfo = null;
                this.ShowUsers();
            }
            else if (this.mainController.AccountController.HasEmployees())
            {
                this.ucAccountInfo = null;
                this.ShowEmployees();
            }
        }

        private void ShowAccountInfo(AccountType type)
        {
            this.ucAccountInfo = UC_AccountInfo.GetUserControl(this.mainController.AccountController);
            this.ucAccountInfo.Size = this.layoutControlUC.Size;
            this.ucAccountInfo.SetSelectedTabPage(type);
            this.layoutControlUC.Controls.Clear();
            this.layoutControlUC.Controls.Add(this.ucAccountInfo);

            this.mainController.AccountController.Changed += this.AccountController_Changed;
        }

        #endregion UC_AccountInfo

        #region Navigation

        void barBtnNavDown_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.ucUsers != null)
            {
                this.ucUsers.gridViewUsers.FocusedRowHandle++;
            }

            if (this.ucEmployees != null)
            {
                this.ucEmployees.advBandedGridViewEmployees.FocusedRowHandle++;
            }
        }

        void barBtnNavUp_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.ucUsers != null)
            {
                this.ucUsers.gridViewUsers.FocusedRowHandle--;
            }

            if (this.ucEmployees != null)
            {
                this.ucEmployees.advBandedGridViewEmployees.FocusedRowHandle--;
            }
        }

        private void SetNavigationBar(int focusedRowHandle, int rowCount)
        {
            if (rowCount <= 1)
            {
                this.barBtnNavUp.Enabled = false;
                this.barBtnNavDown.Enabled = false;
            }
            else
            {
                if (focusedRowHandle == 0)
                {
                    this.barBtnNavDown.Enabled = true;
                    this.barBtnNavUp.Enabled = false;
                }
                else if (focusedRowHandle == rowCount - 1)
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

        #endregion Navigation

        private void SetControlsForEdit()
        {
            this.ribbonPageGroupCRUD.Visible = false;
            this.ribbonPageGroupNavigation.Visible = false;
            this.ribbonPageGroupHome.Visible = true;
            this.ribbonPageGroupMain.Visible = true;
            if (this.mainController.AccountController.CurentEmployeeIsDirty()
                || this.mainController.AccountController.CurentUserIsDirty())
            {
                this.barBtnSave.Enabled = true;
                this.barBtnSaveAndClose.Enabled = true;
            }
            else
            {
                this.barBtnSave.Enabled = false;
                this.barBtnSaveAndClose.Enabled = false;
            }
        }

        void barBtnList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.ucAccountInfo.CheckAccountBeforeSave())
            {
                this.CloseAccount();
            }
        }

        void layoutControlUC_Resize(object sender, System.EventArgs e)
        {
            if (this.ucUsers != null)
            {
                this.ucUsers.Size = this.layoutControlUC.Size;
            }

            if (this.ucEmployees != null)
            {
                this.ucEmployees.Size = this.layoutControlUC.Size;
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