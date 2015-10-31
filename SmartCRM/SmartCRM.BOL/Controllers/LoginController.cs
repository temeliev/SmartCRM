namespace SmartCRM.BOL.Controllers
{
    using AutoMapper;

    using SmartCRM.BOL.Models;
    using SmartCRM.BOL.Repositories;
    using SmartCRM.BOL.Utilities;
    using SmartCRM.BOL.Validators;
    using SmartCRM.DAL;

    public class LoginController : IController
    {
        private LoginController()
        {
            this.CurrentLogin = UserModel.CreateInstance();
            this.CurrentLogin.Username = "admin";
            this.CurrentLogin.Password = "admin";
            this.InitializeMapper();
        }

        private void InitializeMapper()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<User, UserModel>();
                cfg.CreateMap<UserModel, User>();
                //cfg.AddProfile<FooProfile>();
            });
        }

        public UserModel CurrentLogin { get; set; }

        public static LoginController CreateIntance()
        {
            return new LoginController();
        }

        public CheckResult Login()
        {
            using (var db = DbManager.CreateInstance())
            {
                LoginValidator validator = new LoginValidator();
                var result = validator.ValidateLogin(this.CurrentLogin, db);
                if (result.Success)
                {
                    Global.CurrentUser = this.CurrentLogin;
                }

                return result;
            }
        }
    }
}