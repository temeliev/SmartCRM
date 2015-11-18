namespace SmartCRM.BOL.Controllers
{
    public class MainController
    {
        private MainController()
        {
            this.AccountController = AccountController.CreateIntance();
        }

        public AccountController AccountController { get; private set; }

        public static MainController CreateInstance()
        {
            return new MainController();
        }
    }
}
