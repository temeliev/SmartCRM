namespace SmartCRM.BOL.Models.Enums
{
    public static class Messages
    {
        public static string ObjectIsDirty
        {
            get
            {
                return "Changes were made! Do You want to save?";
            }
        }
       
        public static string DeleteRecordQuestion
        {
            get
            {
                return "Are You sure that you want to delete this record?";
            }
        }

        public static string CannotDeleteLinkedItem
        {
            get
            {
                return "Cannot delete this record because is linked to activity!";
            }
        }
    }
}
