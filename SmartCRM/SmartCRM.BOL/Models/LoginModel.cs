namespace SmartCRM.BOL.Models
{
    public class LoginModel
    {
        private LoginModel()
        {

        }

        public string Username { get; set; }

        public string Password { get; set; }

        public static LoginModel CreateInstance()
        {
            return new LoginModel();
        }
    }
}
