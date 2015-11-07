namespace SmartCRM.BOL.Models
{
    using System;
    using System.Drawing;

    using BLToolkit.EditableObjects;

    using SmartCRM.BOL.Models.Enums;

    public abstract class EmployeeModel : EditableObject<EmployeeModel>
    {
        public abstract uint Id { get; set; }

        public abstract string FirstName { get; set; }

        public abstract string SecondName { get; set; }

        public abstract string LastName { get; set; }

        public abstract string Email { get; set; }

        public abstract string Address { get; set; }

        public abstract string Phone { get; set; }

        public abstract string Comments { get; set; }

        public abstract DateTime Birthday { get; set; }

        public abstract GenderType Gender { get; set; }
    
        public Image Photo { get; set; }

        public abstract bool IsDeleted { get; set; }

        public string FullName
        {
            get
            {
                return string.Concat(this.FirstName, " ", this.LastName ?? string.Empty, " ", this.LastName);
            }
        }

        public static EmployeeModel Create()
        {
            return EmployeeModel.CreateInstance();
        }
    }
}
