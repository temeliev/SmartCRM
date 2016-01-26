namespace SmartCRM.Presentation
{
    using System;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;

    using DevExpress.XtraTab;

    using SmartCRM.BOL.Controllers;
    using SmartCRM.BOL.Models;
    using SmartCRM.BOL.Models.Enums;
    using SmartCRM.Presentation.Employees;
    using SmartCRM.Presentation.Users;

    public partial class UC_AccountInfo : UserControl, ISavable
    {
        private AccountController controller;

        public UC_User UCUser { get; private set; }

        public UC_Employee UCEmployee { get; private set; }

        public UC_AccountInfo()
        {
            this.InitializeComponent();
            this.Load += this.UC_AccountInfo_Load;
            this.tabControlAccountInfo.SelectedPageChanged += this.tabControlAccountInfo_SelectedPageChanged;
            this.layoutControlEmployeeInfo.Resize += this.layoutControlEmployeeInfo_Resize;
        }

        void controller_AccountChanged(object sender, BOL.Controllers.Events.AccountChangedEventArgs e)
        {
            var control = this.FindForm() as RF_Main;
            if (control != null)
            {
                control.SetSaveButtons(e.IsDirty);
            }
        }

        void layoutControlEmployeeInfo_Resize(object sender, EventArgs e)
        {
            if (this.tabControlAccountInfo.SelectedTabPage == this.tabPageEmployeeInfo)
            {
                this.UCEmployee.Size = this.tabPageEmployeeInfo.Size;
            }
        }

        void UC_AccountInfo_Load(object sender, System.EventArgs e)
        {
            if (this.controller.CurrentUser == null)
            {
                this.tabPageUserInfo.Image = Resources.ImagesHelper.Current.AddIcon;
            }
            else
            {
                this.tabPageUserInfo.Text = "User Info";
            }

            this.controller.AccountChanged += this.controller_AccountChanged;
        }

        void tabControlAccountInfo_SelectedPageChanged(object sender, TabPageChangedEventArgs e)
        {
            if (e.Page == this.tabPageEmployeeInfo)
            {
                if (this.UCEmployee == null && this.controller.CurrentEmployee != null)
                {
                    this.LoadEmployee();
                }
                else
                {
                    this.UCEmployee.Size = this.tabPageEmployeeInfo.Size;
                }
            }
            else if (e.Page == this.tabPageUserInfo)
            {
                if (this.UCUser == null && this.controller.CurrentUser != null)
                {
                    this.LoadUser();
                }
                else if (this.controller.CurrentUser == null)
                {
                    if (DialogResult.Yes == MessageBox.Show(
                        "Do You want to create login?",
                        "Attention",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question))
                    {
                        this.controller.SetUser(UserModel.Create());
                        if (this.UCUser == null)
                        {
                            this.LoadUser();
                        }
                    }
                }
            }
        }

        public void SetTabPageErrorIcon(AccountType type, bool setImage = true)
        {
            if (setImage)
            {
                this.tabControlAccountInfo.TabPages[(int)type].Image = Resources.ImagesHelper.Current.ErrorIcon;
            }
            else
            {
                this.tabControlAccountInfo.TabPages[(int)type].Image = null;
            }
        }

        public bool CheckBeforeSave()
        {
            var changes = this.CheckAccountForChanges();
            if (changes == DialogResult.Yes)
            {
                if (!this.Save())
                {
                    return false;
                }
            }
            else if (changes == DialogResult.No)
            {
                if (this.controller.CurrentUser != null)
                {
                    this.controller.CurrentUser.RejectChanges();
                }

                this.controller.CurrentEmployee.RejectChanges();
            }
            else if (changes == DialogResult.Cancel)
            {
                return false;
            }

            return true;
        }

        public bool Save()
        {
            if (this.controller.CurrentUser != null)
            {
                if (!this.SaveAccount())
                {
                    return false;
                }
            }
            else
            {
                if (!this.SaveEmployee())
                {
                    return false;
                }
            }

            return true;
        }

        public void SetSelectedTabPage(AccountType type)
        {
            this.tabControlAccountInfo.SelectedTabPage = this.tabControlAccountInfo.TabPages[(int)type];
            if (AccountType.Employee == type)
            {
                this.LoadEmployee();
            }
            //switch (type)
            //{
            //    case AccountType.Employee:
            //        this.LoadEmployee();
            //        break;
            //    case AccountType.User:
            //        this.LoadUser();
            //        break;
            //    default:
            //        throw new InvalidOperationException("Invalid tab page");
            //}
        }

        private void LoadUser()
        {
            this.UCUser = UC_User.GetUserControl(this.controller.CurrentUser);
            this.layoutControlUserInfo.Controls.Clear();
            this.layoutControlUserInfo.Controls.Add(this.UCUser);
            this.tabPageUserInfo.Text = "User Info";
            this.tabPageUserInfo.Image = null;
            this.tabPageUserInfo.Tooltip = "Login";
        }

        private void LoadEmployee()
        {
            this.UCEmployee = UC_Employee.GetUserControl(this.controller.CurrentEmployee);
            this.UCEmployee.Size = this.layoutControlEmployeeInfo.Size;
            this.layoutControlEmployeeInfo.Controls.Clear();
            this.layoutControlEmployeeInfo.Controls.Add(this.UCEmployee);
        }

        private DialogResult CheckAccountForChanges()
        {
            if (this.controller.CurentUserIsDirty()
                || this.controller.CurentEmployeeIsDirty())
            {
                return MessageBox.Show(
                    Messages.ObjectIsDirty,
                    "Attention",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question);
            }

            return DialogResult.No;
        }

        private bool SaveEmployee()
        {
            this.UCEmployee.ClearErrors();
            var check = this.controller.SaveEmployee();
            if (!check.Success)
            {
                var result = check.Details.FirstOrDefault(x => x.PropertyName == "MessageBox");
                if (result != null)
                {
                    MessageBox.Show(result.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    this.UCEmployee.ShowErrors(check);
                }

                return false;
            }

            this.controller.AddCurrentEmployeeToEmployees();

            return true;
        }

        private bool SaveAccount()
        {
            if (this.UCUser != null)
            {
                this.UCUser.ClearErrors();
            }

            if (this.UCEmployee != null)
            {
                this.UCEmployee.ClearErrors();
            }

            this.SetTabPageErrorIcon(AccountType.Employee, false);
            this.SetTabPageErrorIcon(AccountType.User, false);
            var check = this.controller.SaveAccount();
            if (!check.Success)
            {
                var result = check.Details.FirstOrDefault(x => x.PropertyName == "MessageBox");
                if (result != null)
                {
                    MessageBox.Show(result.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (this.UCUser.ShowErrors(check))
                    {
                        this.SetTabPageErrorIcon(AccountType.User);
                    }

                    if (this.UCEmployee.ShowErrors(check))
                    {
                        this.SetTabPageErrorIcon(AccountType.Employee);
                    }
                }

                return false;
            }

            if (this.controller.HasUsers())
            {
                this.controller.AddCurrentUserToUsers();
            }
            else if (this.controller.HasEmployees())
            {
                this.controller.AddCurrentEmployeeToEmployees();
            }

            return true;
        }

        internal void SetSize(Size size)
        {
            this.tabControlAccountInfo.Size = new Size(size.Width, size.Height);
        }

        public static UC_AccountInfo GetUserControl(AccountController accountController)
        {
            UC_AccountInfo uc = new UC_AccountInfo();
            uc.controller = accountController;
            return uc;
        }
    }
}
