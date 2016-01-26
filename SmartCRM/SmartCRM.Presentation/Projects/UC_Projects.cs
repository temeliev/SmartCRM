namespace SmartCRM.Presentation.Projects
{
    using System;
    using System.Reflection;
    using System.Windows.Forms;

    using SmartCRM.BOL.Controllers;
    using SmartCRM.BOL.Models;

    public partial class UC_Projects : UserControl, INavigateable
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

                var form = this.FindForm() as RF_Main;
                if (form != null)
                {
                    form.SetNavigationBar(e.FocusedRowHandle, this.gridViewProjects.DataRowCount);
                }
            }
        }

        //private static void Test(int rowHandle, int rowCount)
        //{
        //    var type = typeof(RF_Main);
        //    MethodInfo methodInfo = type.GetMethod("SetNavigationBar");
        //    if (methodInfo != null)
        //    {
        //        object result = null;
        //        ParameterInfo[] parameters = methodInfo.GetParameters();
        //        object classInstance = Activator.CreateInstance(type, null);
        //        if (parameters.Length == 0)
        //        {
        //            //This works fine
        //            result = methodInfo.Invoke(classInstance, null);
        //        }
        //        else
        //        {
        //            object[] parametersArray = new object[] { rowHandle, rowCount };
        //            result = methodInfo.Invoke(classInstance, parametersArray);
        //        }
        //    }
        //}

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

        public void IncreaseRow()
        {
            this.gridViewProjects.FocusedRowHandle++;
        }

        public void DecreaseRow()
        {
            this.gridViewProjects.FocusedRowHandle--;
        }

        public static UC_Projects GetUserControl(ProjectDataController projectController)
        {
            UC_Projects uc = new UC_Projects();
            uc.controller = projectController;
            return uc;
        }
    }
}
