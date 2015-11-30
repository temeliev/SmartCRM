namespace SmartCRM.BOL.Controllers
{
    using System.ComponentModel;

    using SmartCRM.BOL.Models;
    using SmartCRM.BOL.Repositories;
    using SmartCRM.BOL.Validators;
    using SmartCRM.DAL;

    public class ProjectDataController
    {
        public BindingList<ProjectModel> Projects { get; private set; }
        public BindingList<ProjectCategoryModel> ProjectCategories { get; private set; }
        public ProjectModel CurrentProject { get; private set; }

        private ProjectDataController()
        {
            this.Projects = new BindingList<ProjectModel>();
            this.ProjectCategories = new BindingList<ProjectCategoryModel>();
            this.SetProjectCategories();
        }

        public static ProjectDataController Create()
        {
            return new ProjectDataController();
        }

        public void SetProjects()
        {
            using (var db = DbManager.CreateInstance())
            {
                ProjectRepository rep = new ProjectRepository();
                this.Projects = rep.LoadProjects(db);
            }
        }

        public void SetProjectCategories()
        {
            using (var db = DbManager.CreateInstance())
            {
                ProjectRepository rep = new ProjectRepository();
                this.ProjectCategories = rep.LoadProjectCategories(db);
            }
        }
    }
}
