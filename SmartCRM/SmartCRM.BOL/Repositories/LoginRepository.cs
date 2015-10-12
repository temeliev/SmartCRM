namespace SmartCRM.BOL.Repositories
{
    using System.Linq;

    using AutoMapper;

    using SmartCRM.BOL.Models;
    using SmartCRM.BOL.Utilities;
    using SmartCRM.DAL;

    public class LoginRepository
    {
        public User GetUser(LoginModel model, SmartCRMEntitiesModel context)
        {
            User user = context.Users.FirstOrDefault(x => x.Username == model.Username && x.Password == model.Password && x.IsEnabled);

            return user;
        }
    }
}
