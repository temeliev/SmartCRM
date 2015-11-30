namespace SmartCRM.Presentation.Projects
{
    using System.Windows.Forms;

    using SmartCRM.BOL.Controllers;
    using SmartCRM.BOL.Models;

    public partial class UC_Projects : UserControl
    {
        private ProjectDataController controller;

        private UC_Projects()
        {
            this.InitializeComponent();
            this.Load += this.UC_Projects_Load;
            this.gridViewProjects.FocusedRowChanged += this.gridViewProjects_FocusedRowChanged;
        }

        void gridViewProjects_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle >= 0 && e.FocusedRowHandle != e.PrevFocusedRowHandle)
            {
                var project = (ProjectModel)this.gridViewProjects.GetFocusedRow();
                if (project != null)
                {
                    this.LoadEmployees(project.Employees);
                }
            }
        }

        private void LoadEmployees(System.ComponentModel.BindingList<EmployeeModel> bindingList)
        {
            this.rep_ProjectCategories.DataSource = this.controller.ProjectCategories;
            this.gridControlEmployees.DataSource = bindingList;
        }

        void UC_Projects_Load(object sender, System.EventArgs e)
        {
            this.controller.SetProjects();
            this.gridControlProjects.DataSource = this.controller.Projects;
            this.gridViewProjects.FocusedRowHandle = 0;
        }

        public static UC_Projects GetUserControl(ProjectDataController projectController)
        {
            UC_Projects uc = new UC_Projects();
            uc.controller = projectController;
            return uc;
        }
    }
}
