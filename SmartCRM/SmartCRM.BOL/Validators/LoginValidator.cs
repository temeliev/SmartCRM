namespace SmartCRM.BOL.Validators
{
    using SmartCRM.BOL.Models;
    using SmartCRM.BOL.Repositories;
    using SmartCRM.BOL.Utilities;
    using SmartCRM.DAL;

    public class LoginValidator
    {
        public CheckResult ValidateLogin(LoginModel model, SmartCRMEntitiesModel context)
        {
            CheckResult result = CheckResult.Default;
            //if (model.Username.Length < 3)
            //{
            //    result.Errors.Add(new CheckResultDetail(CheckResultDetail.ErrorType.Error, "Username", "The username must be at least 3 symbols!"));
            //}

            //if (model.Username.Length > 10)
            //{
            //    result.Errors.Add(new CheckResultDetail(CheckResultDetail.ErrorType.Error, "Username", "The maximum length of the username is 10 symbols!"));
            //}

            if (string.IsNullOrWhiteSpace(model.Username))
            {
                result.Details.Add(new CheckResultDetail(CheckResultDetail.ErrorType.Error, StaticReflection.GetMemberName<LoginModel>(x => x.Username), "Enter username!"));
            }

            if (string.IsNullOrWhiteSpace(model.Password))
            {
                result.Details.Add(new CheckResultDetail(CheckResultDetail.ErrorType.Error, StaticReflection.GetMemberName<LoginModel>(x => x.Password), "Enter password!"));
            }

            if (!result.Success)
            {
                return result;
            }

            //if (model.Username.Length > 10)
            //{
            //    result.Errors.Add(new CheckResultDetail(CheckResultDetail.ErrorType.Error, "Username", "The maximum length of the username is 10 symbols!"));
            //}

            LoginRepository repository = new LoginRepository();
            var user = repository.GetUser(model, context);
            if (user == null)
            {
                result.Details.Add(new CheckResultDetail(CheckResultDetail.ErrorType.Error, "NoUser", "The username or password is incorect!"));
            }

            return result;
        }
    }
}
