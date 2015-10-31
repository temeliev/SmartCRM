namespace SmartCRM.BOL.Models
{
    public class UserModel
    {
        private UserModel() { }

        public uint UserId { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public bool IsEnabled { get; set; }

        public bool IsAdmin { get; set; }

        public static UserModel CreateInstance()
        {
            return new UserModel();
        }
    }
}
