namespace SmartCRM.BOL.Controllers.Events
{
    using System;

    public class AccountChangedEventArgs : EventArgs
    {
        private bool isDirty;

        public AccountChangedEventArgs(bool isDirty)
        {
            this.isDirty = isDirty;
        }


        public bool IsDirty
        {
            get
            {
                return this.isDirty;
            }
        }
    }
}
