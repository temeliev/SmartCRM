namespace SmartCRM.BOL.Validators
{
    using System.Linq;

    using SmartCRM.BOL.Models;
    using SmartCRM.BOL.Utilities;
    using SmartCRM.DAL;

    public class UserValidator
    {
        private const int MinimumUsernameLength = 3;
        private const int MinimumPasswordLength = 6;

        public CheckResult ValidateUser(SmartCRMEntitiesModel context, UserModel model)
        {
            CheckResult result = CheckResult.Default;

            if (string.IsNullOrWhiteSpace(model.Username))
            {
                result.Details.Add(new CheckResultDetail(CheckResultDetail.ErrorType.Error, StaticReflection.GetMemberName<UserModel>(x => x.Username), "Enter username!"));
            }

            if (string.IsNullOrWhiteSpace(model.Password))
            {
                result.Details.Add(new CheckResultDetail(CheckResultDetail.ErrorType.Error, StaticReflection.GetMemberName<UserModel>(x => x.Password), "Enter password!"));
            }

            if (model.Username.Length < MinimumUsernameLength)
            {
                result.Details.Add(new CheckResultDetail(CheckResultDetail.ErrorType.Error, StaticReflection.GetMemberName<UserModel>(x => x.Username), "Minimum required length of the Username is 3 symbols!"));
            }

            if (model.Password.Length < MinimumPasswordLength)
            {
                result.Details.Add(new CheckResultDetail(CheckResultDetail.ErrorType.Error, StaticReflection.GetMemberName<UserModel>(x => x.Password), "Minimum required length of the Password is 6 symbols!"));
            }

            return result;
        }

        public CheckResult ValidateIfUserExistInDatabase(SmartCRMEntitiesModel context, UserModel model)
        {
            CheckResult result = CheckResult.Default;
            var userInDb = context.Users.FirstOrDefault(user => user.Username == model.Username);
            if (userInDb != null)
            {
                result.Details.Add(new CheckResultDetail(CheckResultDetail.ErrorType.Error, StaticReflection.GetMemberName<UserModel>(x => x.Username), "This username already exist! Please select another one."));
            }

            return result;
        }
    }
}
