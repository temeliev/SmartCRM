namespace SmartCRM.BOL.Repositories
{
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;

    using SmartCRM.BOL.Models;
    using SmartCRM.BOL.Utilities;
    using SmartCRM.DAL;

    public class ProjectRepository
    {
        public BindingList<ProjectModel> LoadProjects(SmartCRMEntitiesModel db)
        {
            List<Project> pocoProjects = db.Projects.ToList();
            var projects = new BindingList<ProjectModel>();
            foreach (var poco in pocoProjects)
            {
                ProjectModel model = ProjectModel.Create();
                MapHelper.Map(poco, model);
                foreach (var emp in poco.Employees)
                {
                    EmployeeModel empModel = EmployeeModel.Create();
                    //MapHelper.Map(emp, empModel);
                    //empModel.AcceptChanges();
                    empModel.FirstName = emp.FirstName;
                    empModel.SecondName = emp.SecondName;
                    empModel.LastName = emp.LastName;
                    model.Employees.Add(empModel);
                }
                model.AcceptChanges();
                projects.Add(model);

            }

            return projects;
        }

        public BindingList<ProjectCategoryModel> LoadProjectCategories(SmartCRMEntitiesModel db)
        {
            var pocoCategories = db.ConstProjectCategories;
            var categories = new BindingList<ProjectCategoryModel>();
            MapHelper.Map(pocoCategories, categories);
            return categories;
        }
    }
}
