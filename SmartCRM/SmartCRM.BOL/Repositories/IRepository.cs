namespace SmartCRM.BOL.Repositories
{
    using SmartCRM.BOL.Utilities;

    public interface IRepository
    {
        CheckResult Save();

        void Insert();

        void Update();

        CheckResult Delete();
    }
}
