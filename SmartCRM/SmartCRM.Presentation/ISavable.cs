namespace SmartCRM.Presentation
{
    public interface ISavable
    {
        bool Save();

        bool CheckBeforeSave();
    }
}
