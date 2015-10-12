namespace SmartCRM.BOL.Utilities
{
    using System;

    public class CheckResultDetail
    {
        public CheckResultDetail(ErrorType type, String propertyName, String message)
        {
            this.Type = type;
            this.PropertyName = propertyName;
            this.Message = message;
        }
       
        public ErrorType Type { get; set; }

        public string PropertyName { get; set; }

        public string Message { get; set; }

        public enum ErrorType { None = 0, Warning = 1, Error = 2 }
    }
}
