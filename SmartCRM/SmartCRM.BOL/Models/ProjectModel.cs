namespace SmartCRM.BOL.Models
{
    using System;
    using System.ComponentModel;

    using BLToolkit.EditableObjects;

    using SmartCRM.BOL.Models.Enums;

    public abstract class ProjectModel : EditableObject<ProjectModel>
    {
        protected ProjectModel()
        {
            this.Employees = new BindingList<EmployeeModel>();
        }

        public uint Id { get; set; }
        public string Name { get; set; }
        public uint ProjectCategoryId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public ProjectStatus Status { get; set; }
        public BindingList<EmployeeModel> Employees { get; private set; }

        public static ProjectModel Create()
        {
            var model = ProjectModel.CreateInstance();
            
            return model;
        }
    }
}
