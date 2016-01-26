namespace SmartCRM.Presentation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;

    using DevExpress.Data.PLinq.Helpers;
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

        public Stack<Control> StackControls;

        public RF_Main()
        {
            this.InitializeComponent();

            this.StackControls = new Stack<Control>();

            this.navBarUsers.LinkClicked += this.navBarUsers_LinkClicked;
            this.navBarEmployees.LinkClicked += this.navBarEmployees_LinkClicked;

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

            this.layoutControlUC.ControlAdded += layoutControlUC_ControlAdded;
        }

        void layoutControlUC_ControlAdded(object sender, ControlEventArgs e)
        {
            if (e.Control is IMainView)
            {
                (e.Control as IMainView).InitializeControls();
            }
        }

        private void navBarProjectCategories_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            var uc = (UC_ProjectCategories.GetUserControl(this.mainController.ProjectDataController));
            uc.Size = this.layoutControlUC.Size;
            this.layoutControlUC.Controls.Clear();
            this.layoutControlUC.Controls.Add(uc);
            this.StackControls.Push(uc);
            // this.currentControlName = uc.Name;
            this.ribbon.Minimized = false;
            this.ribbonPageGroupMain.Visible = true;
            this.barBtnSave.Enabled = true;
        }

        void navBarProjects_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            var uc = UC_Projects.GetUserControl(this.mainController.ProjectDataController);
            this.AddControlToLayout(uc);
            this.ribbon.Minimized = false;
            this.ribbonPageGroupMain.Visible = true;
            this.ribbonPageGroupNavigation.Visible = true;
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

        void navBarEmployees_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            if (this.StackControls.Count > 0)
            {
                var ctrl = this.StackControls.Peek() as ISavable;
                if (ctrl != null)
                {
                    if (ctrl.CheckBeforeSave())
                    {
                        this.StackControls.Clear();
                        this.ShowEmployees();
                    }
                }
                else
                {
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
                    //var focusedUser = (UserModel)this.ucUsers.gridViewUsers.GetFocusedRow();
                    //if (focusedUser != null)
                    //{
                    //    var result = this.mainController.AccountController.DeleteUser(focusedUser);
                    //    if (!result.Success)
                    //    {
                    //        var error = result.Details.FirstOrDefault();
                    //        if (error != null)
                    //        {
                    //            MessageBox.Show(
                    //            error.Message,
                    //            "Error",
                    //            MessageBoxButtons.OK,
                    //            MessageBoxIcon.Error);
                    //        }
                    //    }
                    //}
                }
                else if (this.mainController.AccountController.HasEmployees())
                {
                    //var focusedEmployee = (EmployeeModel)this.ucEmployees.advBandedGridViewEmployees.GetFocusedRow();
                    //if (focusedEmployee != null)
                    //{
                    //    var result = this.mainController.AccountController.DeleteEmployee(focusedEmployee);
                    //    if (!result.Success)
                    //    {
                    //        var error = result.Details.FirstOrDefault();
                    //        if (error != null)
                    //        {
                    //            MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //        }
                    //    }

                    //}
                }
            }
        }

        void barBtnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var ctrl = this.StackControls.Peek();
            var control = this.layoutControlUC.GetControlByName(ctrl.Name) as IGridInfo;
            if (control != null)
            {
                control.EditFocusedItem();
            }
        }

        void barBtnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var ctrl = this.StackControls.Peek();
            var control = this.layoutControlUC.GetControlByName(ctrl.Name) as IGridInfo;
            if (control != null)
            {
                control.AddItem();
            }
        }

        void barBtnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var ctrl = this.StackControls.Peek();
            var control = this.layoutControlUC.GetControlByName(ctrl.Name) as IGridInfo;
            if (control != null)
            {
                control.RefreshDataSource();
            }
        }

        #endregion Group CRUD

        #region Group Main

        void barBtnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           this.CheckForChanges();
        }

        void barBtnSaveAndClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var ctrl = this.StackControls.Peek();
            var control = this.layoutControlUC.GetControlByName(ctrl.Name) as ISavable;
            if (control != null)
            {
                if (control.Save())
                {
                    this.StackControls.Pop();
                    var currentControl = this.StackControls.Peek();
                    if (currentControl != null)
                    {
                        this.AddControlToLayout(currentControl);
                    }
                }
            }
        }

        void barBtnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var ctrl = this.StackControls.Peek();
            var control = this.layoutControlUC.GetControlByName(ctrl.Name) as ISavable;
            if (control != null)
            {
                if (control.Save())
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
            if (this.StackControls.Count > 0)
            {
                var ctrl = this.StackControls.Peek() as ISavable;
                if (ctrl != null)
                {
                    if (ctrl.CheckBeforeSave())
                    {
                        this.StackControls.Clear();
                        this.ShowUsers();
                    }
                }
                else
                {
                    this.ShowUsers();
                }
            }
            else
            {
                this.ShowUsers();
            }
        }

        private void ShowUsers()
        {
            var control = UC_Users.GetUserControl(this.mainController.AccountController);
            this.AddControlToLayout(control);
        }

        public void SetEditCollectionControls(string text)
        {
            this.ribbonPageGroupCRUD.Text = text;
            this.ribbonPageGroupCRUD.Visible = true;

            this.ribbonPageGroupNavigation.Visible = true;

            this.ribbonPageGroupHome.Visible = false;

            this.ribbonPageGroupMain.Visible = false;

            this.ribbon.Minimized = false;
        }

        #endregion UC_Users

        #region UC_Employees

        private void ShowEmployees()
        {
            var control = UC_Employees.GetUserControl(this.mainController.AccountController);
            this.AddControlToLayout(control);
        }

        #endregion UC_Employees

        #region UC_AccountInfo

        #endregion UC_AccountInfo

        #region Navigation

        void barBtnNavDown_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var ctrl = this.StackControls.Peek();
            var control = this.layoutControlUC.GetControlByName(ctrl.Name) as INavigateable;
            if (control != null)
            {
                control.IncreaseRow();
            }
        }

        void barBtnNavUp_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var ctrl = this.StackControls.Peek();
            var control = this.layoutControlUC.GetControlByName(ctrl.Name) as INavigateable;
            if (control != null)
            {
                control.DecreaseRow();
            }
        }

        public void SetNavigationBar(int focusedRowHandle, int rowCount)
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

        //TODO InProgress
        public void AddControlToLayout(Control control)
        {
            this.layoutControlUC.Controls.Clear();
            control.Size = this.layoutControlUC.Size;
            this.layoutControlUC.Controls.Add(control);
            if (!this.StackControls.Contains(control))
            {
                this.StackControls.Push(control);
            }
        }

        public void SetEditItemControls(string text)
        {
            this.ribbonPageGroupCRUD.Visible = false;
            this.ribbonPageGroupNavigation.Visible = false;
            this.ribbonPageGroupHome.Visible = true;
            this.ribbonPageGroupMain.Visible = true;
            this.barBtnList.Caption = text;

        }

        void barBtnList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.CheckForChanges();
        }

        private void CheckForChanges()
        {
            var ctrl = this.StackControls.Peek();
            var control = this.layoutControlUC.GetControlByName(ctrl.Name) as ISavable;
            if (control != null)
            {
                if (control.CheckBeforeSave())
                {
                    this.StackControls.Pop();
                    var currentControl = this.StackControls.Peek();
                    if (currentControl != null)
                    {
                        this.AddControlToLayout(currentControl);
                    }
                }
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

        public void SetSaveButtons(bool isDirty)
        {
            if (isDirty && !this.barBtnSave.Enabled)
            {
                this.barBtnSave.Enabled = true;
                this.barBtnSaveAndClose.Enabled = true;
            }
            else if (!isDirty && this.barBtnSave.Enabled)
            {
                this.barBtnSave.Enabled = false;
                this.barBtnSaveAndClose.Enabled = false;
            }
        }
    }
}