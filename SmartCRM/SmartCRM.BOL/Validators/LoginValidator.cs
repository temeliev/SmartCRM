namespace SmartCRM.BOL.Validators
{
    using SmartCRM.BOL.Models;
    using SmartCRM.BOL.Repositories;
    using SmartCRM.BOL.Utilities;
    using SmartCRM.DAL;

    public class LoginValidator
    {
        public CheckResult ValidateLogin(UserModel model, SmartCRMEntitiesModel context)
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

            if (!result.Success)
            {
                return result;
            }

            CheckIfExistUser(model, context, result);

            return result;
        }

        private static void CheckIfExistUser(UserModel model, SmartCRMEntitiesModel db, CheckResult result)
        {
            UserRepository repository = new UserRepository();
            var user = repository.GetUserByModel(db, model);
            if (user == null)
            {
                result.Details.Add(
                    new CheckResultDetail(CheckResultDetail.ErrorType.Error, "NoUser", "The username or password is incorect!"));
            }
        }

        public CheckResult ValidateCreateEditUser(UserModel model, SmartCRMEntitiesModel context)
        {
            CheckResult result = CheckResult.Default;

            if (model.Username.Length < 3)
            {
                result.Details.Add(new CheckResultDetail(CheckResultDetail.ErrorType.Error, "Username", "The username must be at least 3 symbols!"));
            }

            CheckIfExistUser(model, context, result);

            return result;
        }
    }
}
