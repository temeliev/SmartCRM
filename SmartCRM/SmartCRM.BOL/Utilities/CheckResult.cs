namespace SmartCRM.BOL.Utilities
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CheckResult
    {
        public CheckResult(object entity)
        {
            this.ObjectInstance = entity;
            this.Details = new List<CheckResultDetail>();

        }

        public CheckResult(object entity, Exception ex)
            : this(entity)
        {
            this.Details.Add(new CheckResultDetail(CheckResultDetail.ErrorType.Error, string.Empty, ex.ToString()));
        }

        public bool Success
        {
            get
            {
                return !this.Details.Any(s => s.Type == CheckResultDetail.ErrorType.Error);
            }
        }

        public Object ObjectInstance { get; set; }

        public List<CheckResultDetail> Details { get; set; }

        public List<CheckResultDetail> Errors
        {
            get
            {
                return this.Details.Where(d => d.Type == CheckResultDetail.ErrorType.Error).ToList();
            }
        }

        public List<CheckResultDetail> Warnings
        {
            get
            {
                return this.Details.Where(d => d.Type == CheckResultDetail.ErrorType.Warning).ToList();
            }
        }

        public String Print(String separator = "\n")
        {
            return String.Join(separator, this.Details.Select(s => s.Message));

        }

        public static CheckResult Default
        {
            get
            {
                return new CheckResult(null);
            }
        }

        public static readonly CheckResult Empty = new CheckResult(null);
    }
}
