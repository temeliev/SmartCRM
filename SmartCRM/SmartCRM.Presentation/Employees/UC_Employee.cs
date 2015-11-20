namespace SmartCRM.Presentation.Employees
{
    using System;
    using System.Drawing;
    using System.IO;
    using System.Linq;
    using System.Windows.Forms;

    using DevExpress.XtraEditors.Controls;

    using SmartCRM.BOL.Controllers;
    using SmartCRM.BOL.Models;
    using SmartCRM.BOL.Models.Enums;
    using SmartCRM.BOL.Utilities;
    using SmartCRM.Resources;

    public partial class UC_Employee : UserControl
    {
        private EmployeeModel model;

        public UC_Employee()
        {
            this.InitializeComponent();
            this.Load += this.UC_Employee_Load;
            this.btnLoadImage.Click += this.btnLoadImage_Click;
            this.btnClearImage.Click += this.btnClearImage_Click;
        }

        void btnClearImage_Click(object sender, EventArgs e)
        {
            this.pictureEditPhoto.EditValue = null;
        }

        void btnLoadImage_Click(object sender, EventArgs e)
        {
            try
            {
                this.pictureEditPhoto.LoadImage();
            }
            catch (Exception)
            {
                MessageBox.Show("Error: Could not read file from disk.");
            }
        }

        void UC_Employee_Load(object sender, System.EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = this.model;

            Array arr = Enum.GetValues(typeof(GenderType));

            this.imgComboBoxGenderType.Properties.Items.Clear();
            foreach (GenderType gender in arr)
            {
                this.imgComboBoxGenderType.Properties.Items.Add(new ImageComboBoxItem(gender.ToString(), gender, (int)gender));
            }

            this.imgComboBoxGenderType.Properties.SmallImages = ImagesHelper.Current.GenderTypeImages;

            this.txtFirstName.DataBindings.Add("EditValue", bs, StaticReflection.GetMemberName<EmployeeModel>(x => x.FirstName), true, DataSourceUpdateMode.OnPropertyChanged);
            this.textSecondName.DataBindings.Add("EditValue", bs, StaticReflection.GetMemberName<EmployeeModel>(x => x.SecondName), true, DataSourceUpdateMode.OnPropertyChanged);
            this.txtLastName.DataBindings.Add("EditValue", bs, StaticReflection.GetMemberName<EmployeeModel>(x => x.LastName), true, DataSourceUpdateMode.OnPropertyChanged);
            this.txtPhone.DataBindings.Add("EditValue", bs, StaticReflection.GetMemberName<EmployeeModel>(x => x.Phone), true, DataSourceUpdateMode.OnPropertyChanged);
            this.memoAddress.DataBindings.Add("EditValue", bs, StaticReflection.GetMemberName<EmployeeModel>(x => x.Address), true, DataSourceUpdateMode.OnPropertyChanged);
            this.memoComments.DataBindings.Add("EditValue", bs, StaticReflection.GetMemberName<EmployeeModel>(x => x.Comments), true, DataSourceUpdateMode.OnPropertyChanged);
            this.imgComboBoxGenderType.DataBindings.Add("EditValue", bs, StaticReflection.GetMemberName<EmployeeModel>(x => x.Gender), true, DataSourceUpdateMode.OnPropertyChanged);
            this.dateBirthday.DataBindings.Add("EditValue", bs, StaticReflection.GetMemberName<EmployeeModel>(x => x.Birthday), true, DataSourceUpdateMode.OnPropertyChanged);
            this.btnEditEmail.DataBindings.Add("EditValue", bs, StaticReflection.GetMemberName<EmployeeModel>(x => x.Email), true, DataSourceUpdateMode.OnPropertyChanged);
            this.pictureEditPhoto.DataBindings.Add("EditValue", bs, StaticReflection.GetMemberName<EmployeeModel>(x => x.Photo), true, DataSourceUpdateMode.OnPropertyChanged);
        }

        public bool ShowErrors(CheckResult result)
        {
            bool hasErrors = false;
            var firstNameError = result.Details.FirstOrDefault(x => x.PropertyName == StaticReflection.GetMemberName<EmployeeModel>(e => e.FirstName).ToString());
            if (firstNameError != null)
            {
                this.dxErrorProvider1.SetError(this.txtFirstName, firstNameError.Message);
                hasErrors = true;
            }

            var lastNameError = result.Details.FirstOrDefault(x => x.PropertyName == StaticReflection.GetMemberName<EmployeeModel>(e => e.LastName).ToString());
            if (lastNameError != null)
            {
                this.dxErrorProvider1.SetError(this.txtLastName, lastNameError.Message);
                hasErrors = true;
            }

            return hasErrors;
        }

        public void ClearErrors()
        {
            this.dxErrorProvider1.ClearErrors();
        }

        public static UC_Employee GetUserControl(EmployeeModel employeeModel)
        {
            UC_Employee uc = new UC_Employee();
            uc.model = employeeModel;
            return uc;
        }
    }
}
