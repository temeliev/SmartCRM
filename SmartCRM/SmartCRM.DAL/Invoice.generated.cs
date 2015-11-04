#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the ClassGenerator.ttinclude code generation file.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Common;
using System.Collections.Generic;
using Telerik.OpenAccess;
using Telerik.OpenAccess.Metadata;
using Telerik.OpenAccess.Data.Common;
using Telerik.OpenAccess.Metadata.Fluent;
using Telerik.OpenAccess.Metadata.Fluent.Advanced;
using System.ComponentModel;

namespace SmartCRM.DAL	
{
	[Table("invoices")]
	[ConcurrencyControl(OptimisticConcurrencyControlStrategy.Changed)]
	[KeyGenerator(KeyGenerator.Autoinc)]
	public partial class Invoice : INotifyPropertyChanging, INotifyPropertyChanged
	{
		private uint _invoiceId;
		[Column("InvoiceId", OpenAccessType = OpenAccessType.Int32, IsBackendCalculated = true, IsPrimaryKey = true, Length = 0, Scale = 0, SqlType = "integer unsigned")]
		[Storage("_invoiceId")]
		public virtual uint InvoiceId
		{
			get
			{
				return this._invoiceId;
			}
			set
			{
				if(this._invoiceId != value)
				{
					this.OnPropertyChanging("InvoiceId");
					this._invoiceId = value;
					this.OnPropertyChanged("InvoiceId");
				}
			}
		}
		
		private ulong _invoiceNumber;
		[Column("InvoiceNumber", OpenAccessType = OpenAccessType.UInt64, Length = 0, Scale = 0, SqlType = "bigint unsigned")]
		[Storage("_invoiceNumber")]
		public virtual ulong InvoiceNumber
		{
			get
			{
				return this._invoiceNumber;
			}
			set
			{
				if(this._invoiceNumber != value)
				{
					this.OnPropertyChanging("InvoiceNumber");
					this._invoiceNumber = value;
					this.OnPropertyChanged("InvoiceNumber");
				}
			}
		}
		
		private uint _personId;
		[Column("PersonId", OpenAccessType = OpenAccessType.Int32, Length = 0, Scale = 0, SqlType = "integer unsigned")]
		[Storage("_personId")]
		public virtual uint PersonId
		{
			get
			{
				return this._personId;
			}
			set
			{
				if(this._personId != value)
				{
					this.OnPropertyChanging("PersonId");
					this._personId = value;
					this.OnPropertyChanged("PersonId");
				}
			}
		}
		
		private uint _fromCompanyId;
		[Column("FromCompanyId", OpenAccessType = OpenAccessType.Int32, Length = 0, Scale = 0, SqlType = "integer unsigned")]
		[Storage("_fromCompanyId")]
		public virtual uint FromCompanyId
		{
			get
			{
				return this._fromCompanyId;
			}
			set
			{
				if(this._fromCompanyId != value)
				{
					this.OnPropertyChanging("FromCompanyId");
					this._fromCompanyId = value;
					this.OnPropertyChanged("FromCompanyId");
				}
			}
		}
		
		#region INotifyPropertyChanging members
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		protected virtual void OnPropertyChanging(string propertyName)
		{
			if(this.PropertyChanging != null)
			{
				this.PropertyChanging(this, new PropertyChangingEventArgs(propertyName));
			}
		}
		
		#endregion
		
		#region INotifyPropertyChanged members
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void OnPropertyChanged(string propertyName)
		{
			if(this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		#endregion
		
	}
}
#pragma warning restore 1591
