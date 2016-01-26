namespace SmartCRM.Presentation.Employees
{
    using System;
    using System.Windows.Forms;

    using DevExpress.XtraEditors.Controls;
    using DevExpress.XtraEditors.Repository;

    using SmartCRM.BOL.Controllers;
    using SmartCRM.BOL.Models;
    using SmartCRM.BOL.Models.Enums;
    using SmartCRM.Resources;

    public partial class UC_Employees : UserControl, INavigateable, IGridInfo, IMainView
    {
        private AccountController controller;

        private int lastFocusedRowHandle = 0;

        public UC_Employees()
        {
            this.InitializeComponent();
            this.Load += this.UC_Employees_Load;
            this.advBandedGridViewEmployees.RowCellClick += this.advBandedGridViewEmployees_RowCellClick;
            this.advBandedGridViewEmployees.FocusedRowChanged += this.advBandedGridViewEmployees_FocusedRowChanged;
        }

        void advBandedGridViewEmployees_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle >= 0 && e.FocusedRowHandle != e.PrevFocusedRowHandle)
            {
                var form = this.FindForm() as RF_Main;
                if (form != null)
                {
                    form.SetNavigationBar(e.FocusedRowHandle, this.advBandedGridViewEmployees.DataRowCount);
                }
            }
        }

        void advBandedGridViewEmployees_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (e.Clicks == 2)
            {
                this.EditFocusedItem();
            }
        }

        void UC_Employees_Load(object sender, System.EventArgs e)
        {
            this.CreateGenderRepository();
            this.LoadEmployees();
           


            //var form = this.FindForm() as RF_Main;
            //if (form != null)
            //{
            //    form.SetEditItemControls("Employees List");
            //}

        }

        public void LoadEmployees()
        {
            if (this.checkAllEmployees.CheckState == CheckState.Checked)
            {
                this.controller.LoadAllEmployees();
            }
            else
            {
                this.controller.LoadAllActiveEmployees();
            }

            this.gridControlEmployees.DataSource = this.controller.Employees;
        }

        private void CreateGenderRepository()
        {
            RepositoryItemImageComboBox imageCombo = this.gridControlEmployees.RepositoryItems.Add("ImageComboBoxEdit") as RepositoryItemImageComboBox;

            DevExpress.Utils.ImageCollection images = ImagesHelper.Current.GenderTypeImages;

            Array arr = Enum.GetValues(typeof(GenderType));
            imageCombo.Items.Clear();
            foreach (GenderType gender in arr)
            {
                imageCombo.Items.Add(new ImageComboBoxItem(gender.ToString(), gender, (int)gender));
            }

            imageCombo.SmallImages = images;
            imageCombo.GlyphAlignment = DevExpress.Utils.HorzAlignment.Near;

            this.advBandedGridViewEmployees.Columns["Gender"].ColumnEdit = imageCombo;
        }

        public static UC_Employees GetUserControl(AccountController accountController)
        {
            UC_Employees uc = new UC_Employees();
            uc.controller = accountController;
            return uc;
        }

        public EmployeeModel GetFocusedItem()
        {
            var focusedEmployee = (EmployeeModel)this.advBandedGridViewEmployees.GetFocusedRow();
            return focusedEmployee;
        }


        //TODO InProgress
        public void IncreaseRow()
        {
            this.advBandedGridViewEmployees.FocusedRowHandle++;
        }

        public void DecreaseRow()
        {
            this.advBandedGridViewEmployees.FocusedRowHandle--;
        }

        public void InitializeControls()
        {
            var form = this.FindForm() as RF_Main;
            if (form != null)
            {
                form.SetEditCollectionControls("Employees Management");
                this.advBandedGridViewEmployees.FocusedRowHandle = this.lastFocusedRowHandle;
            }
        }

        public void EditFocusedItem()
        {
            var model = this.GetFocusedItem();
            this.controller.SetEmployee(model);

            var user = this.controller.GetUserByEmployeeId(model.Id);
            this.controller.SetUser(user);

            this.lastFocusedRowHandle = this.advBandedGridViewEmployees.FocusedRowHandle;

            this.ShowAccountInfo(AccountType.Employee);
        }

        public void AddItem()
        {
            this.controller.SetEmployee(EmployeeModel.Create());
            this.ShowAccountInfo(AccountType.Employee);
        }

        public void RefreshDataSource()
        {
            this.LoadEmployees();
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
                form.SetEditItemControls("Employee List");
            }
        }
    }
}
