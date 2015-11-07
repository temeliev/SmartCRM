namespace SmartCRM.Presentation.Employees
{
    using System.Windows.Forms;

    using SmartCRM.BOL.Controllers;

    public partial class UC_Employees : UserControl
    {
        private EmployeeController controller;

        public UC_Employees()
        {
            this.InitializeComponent();
            this.Load += this.UC_Employees_Load;
        }

        void UC_Employees_Load(object sender, System.EventArgs e)
        {
             this.LoadEmployees();
        }

        public void LoadEmployees()
        {
            if (this.checkAllEmployees.CheckState == CheckState.Checked)
            {
                this.controller.LoadAllUsers();
            }
            else
            {
                this.controller.LoadAllActiveUsers();
            }

            this.gridControlEmployees.DataSource = this.controller.Employees;
        }

        public static UC_Employees GetUserControl(EmployeeController employeeController)
        {
            UC_Employees uc = new UC_Employees();
            uc.controller = employeeController;
            return uc;
        }
    }
}
