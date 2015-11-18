namespace SmartCRM.BOL.Validators
{
    using SmartCRM.BOL.Models;
    using SmartCRM.BOL.Utilities;
    using SmartCRM.DAL;

    public class EmployeeValidator
    {
        //TODO
        public CheckResult ValidateEmployee(SmartCRMEntitiesModel context, EmployeeModel model)
        {
            CheckResult result = CheckResult.Default;

            if (string.IsNullOrWhiteSpace(model.FirstName))
            {
                result.Details.Add(new CheckResultDetail(CheckResultDetail.ErrorType.Error, StaticReflection.GetMemberName<EmployeeModel>(x => x.FirstName), "Enter First Name!"));
            }

            if (string.IsNullOrWhiteSpace(model.LastName))
            {
                result.Details.Add(new CheckResultDetail(CheckResultDetail.ErrorType.Error, StaticReflection.GetMemberName<EmployeeModel>(x => x.LastName), "Enter Last Name!"));
            }

            //if (model.Username.Length < MinimumUsernameLength)
            //{
            //    result.Details.Add(new CheckResultDetail(CheckResultDetail.ErrorType.Error, StaticReflection.GetMemberName<UserModel>(x => x.Username), "Minimum required length of the Username is 3 symbols!"));
            //}

            //if (model.Password.Length < MinimumPasswordLength)
            //{
            //    result.Details.Add(new CheckResultDetail(CheckResultDetail.ErrorType.Error, StaticReflection.GetMemberName<UserModel>(x => x.Password), "Minimum required length of the Password is 6 symbols!"));
            //}

            return result;
        }
    }
}
