namespace SmartCRM.BOL.Validators
{
    using SmartCRM.BOL.Models;
    using SmartCRM.BOL.Utilities;

    public class ProjectValidator
    {
        public CheckResult ValidateProject(ProjectModel model)
        {
            CheckResult result = CheckResult.Default;

            if (string.IsNullOrWhiteSpace(model.Name))
            {
                result.Details.Add(
                    new CheckResultDetail(
                        CheckResultDetail.ErrorType.Error,
                        StaticReflection.GetMemberName<ProjectModel>(x => x.Name),
                        "Enter name of the project!"));
            }

            return result;
        }
    }
}
