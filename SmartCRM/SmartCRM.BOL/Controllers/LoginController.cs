namespace SmartCRM.BOL.Controllers
{
    using SmartCRM.BOL.Models;
    using SmartCRM.BOL.Repositories;
    using SmartCRM.BOL.Utilities;
    using SmartCRM.BOL.Validators;
    using SmartCRM.DAL;

    public class LoginController : IController
    {
        private LoginController()
        {
            this.Model = LoginModel.CreateInstance();
        }

        public LoginModel Model { get; set; }

        public static LoginController CreateIntance()
        {
            return new LoginController();
        }

        public CheckResult Login()
        {
            using (var db = DbManager.CreateInstance())
            {
                LoginValidator validator = new LoginValidator();
                var result = validator.ValidateLogin(this.Model, db);

                return result;
            }
        }
    }
}