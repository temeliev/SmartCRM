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

    public partial class UC_Employees : UserControl
    {
        private AccountController controller;

        public UC_Employees()
        {
            this.InitializeComponent();
            this.Load += this.UC_Employees_Load;
        }

        void UC_Employees_Load(object sender, System.EventArgs e)
        {
            //TODO For deletion
            //Dictionary<int, string> colorEnums = Enum.GetValues(typeof(GenderType))
            //    .Cast<GenderType>().ToDictionary(x => (int)x, x => x.ToString());

            this.CreateGenderRepository();
            this.LoadEmployees();
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

        internal EmployeeModel GetFocusedItem()
        {
            var focusedEmployee = (EmployeeModel)this.advBandedGridViewEmployees.GetFocusedRow();
            return focusedEmployee;
        }
    }
}
