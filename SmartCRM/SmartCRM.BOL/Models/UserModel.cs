namespace SmartCRM.BOL.Models
{
    using BLToolkit.EditableObjects;

    public abstract class UserModel : EditableObject<UserModel>
    {
        public abstract uint UserId { get; set; }

        public abstract string Username { get; set; }

        public abstract string Password { get; set; }

        public abstract bool IsEnabled { get; set; }

        public abstract bool IsAdmin { get; set; }

        public abstract uint EmployeeId { get; set; }

        public EmployeeModel Employee { get; set; }

        public bool IsNew
        {
            get
            {
                return this.UserId == 0;
            }
        }

        public static UserModel Create()
        {
            var model = UserModel.CreateInstance();
            model.IsEnabled = true;
            return model;
        }
    }
}
