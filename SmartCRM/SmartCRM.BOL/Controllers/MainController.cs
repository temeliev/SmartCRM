namespace SmartCRM.BOL.Controllers
{
    public class MainController
    {
        private MainController()
        {
            this.UserController = UserController.CreateIntance();
        }

        public UserController UserController { get; private set; }

        public static MainController CreateInstance()
        {
            return new MainController();
        }
    }
}
