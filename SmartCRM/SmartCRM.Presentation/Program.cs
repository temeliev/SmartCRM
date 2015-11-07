namespace SmartCRM.Presentation
{
    using System;
    using System.Windows.Forms;
    using DevExpress.LookAndFeel;

    using SmartCRM.BOL.Controllers;
    using SmartCRM.Presentation.Users;

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.UserSkins.BonusSkins.Register();
            UserLookAndFeel.Default.SetSkinStyle("DevExpress Style");
            XF_Login.ShowForm(LoginController.CreateIntance());
        }
    }
}