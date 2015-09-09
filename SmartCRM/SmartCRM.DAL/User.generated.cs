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
using SmartCRM.DAL;

namespace SmartCRM.DAL	
{
	[Table("users")]
	[ConcurrencyControl(OptimisticConcurrencyControlStrategy.Changed)]
	[KeyGenerator(KeyGenerator.Autoinc)]
	public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
	{
		private string _userPassword;
		[Column("UserPassword", OpenAccessType = OpenAccessType.UnicodeStringVariableLength, Length = 30, Scale = 0, SqlType = "nvarchar")]
		[Storage("_userPassword")]
		public virtual string UserPassword
		{
			get
			{
				return this._userPassword;
			}
			set
			{
				if(this._userPassword != value)
				{
					this.OnPropertyChanging("UserPassword");
					this._userPassword = value;
					this.OnPropertyChanged("UserPassword");
				}
			}
		}
		
		private string _userName;
		[Column("UserName", OpenAccessType = OpenAccessType.UnicodeStringVariableLength, Length = 50, Scale = 0, SqlType = "nvarchar")]
		[Storage("_userName")]
		public virtual string UserName
		{
			get
			{
				return this._userName;
			}
			set
			{
				if(this._userName != value)
				{
					this.OnPropertyChanging("UserName");
					this._userName = value;
					this.OnPropertyChanged("UserName");
				}
			}
		}
		
		private uint _userID;
		[Column("UserID", OpenAccessType = OpenAccessType.Int32, IsBackendCalculated = true, IsPrimaryKey = true, Length = 0, Scale = 0, SqlType = "integer unsigned")]
		[Storage("_userID")]
		public virtual uint UserID
		{
			get
			{
				return this._userID;
			}
			set
			{
				if(this._userID != value)
				{
					this.OnPropertyChanging("UserID");
					this._userID = value;
					this.OnPropertyChanged("UserID");
				}
			}
		}
		
		private uint _personID;
		[Column("PersonID", OpenAccessType = OpenAccessType.Int32, Length = 0, Scale = 0, SqlType = "integer unsigned")]
		[Storage("_personID")]
		public virtual uint PersonID
		{
			get
			{
				return this._personID;
			}
			set
			{
				if(this._personID != value)
				{
					this.OnPropertyChanging("PersonID");
					this._personID = value;
					this.OnPropertyChanged("PersonID");
				}
			}
		}
		
		private bool _isEnabled;
		[Column("IsEnabled", OpenAccessType = OpenAccessType.Bit, Length = 0, Scale = 0, SqlType = "bit")]
		[Storage("_isEnabled")]
		public virtual bool IsEnabled
		{
			get
			{
				return this._isEnabled;
			}
			set
			{
				if(this._isEnabled != value)
				{
					this.OnPropertyChanging("IsEnabled");
					this._isEnabled = value;
					this.OnPropertyChanged("IsEnabled");
				}
			}
		}
		
		private bool _isAdmin;
		[Column("IsAdmin", OpenAccessType = OpenAccessType.Bit, Length = 0, Scale = 0, SqlType = "bit")]
		[Storage("_isAdmin")]
		public virtual bool IsAdmin
		{
			get
			{
				return this._isAdmin;
			}
			set
			{
				if(this._isAdmin != value)
				{
					this.OnPropertyChanging("IsAdmin");
					this._isAdmin = value;
					this.OnPropertyChanged("IsAdmin");
				}
			}
		}
		
		private Person _person;
		[ForeignKeyAssociation(ConstraintName = "FK_users_persons_PersonID", SharedFields = "PersonID", TargetFields = "PersonID")]
		[Storage("_person")]
		public virtual Person Person
		{
			get
			{
				return this._person;
			}
			set
			{
				if(this._person != value)
				{
					this.OnPropertyChanging("Person");
					this._person = value;
					this.OnPropertyChanged("Person");
				}
			}
		}
		
		private IList<Log> _logs = new List<Log>();
		[Collection(InverseProperty = "User")]
		[Storage("_logs")]
		public virtual IList<Log> Logs
		{
			get
			{
				return this._logs;
			}
		}
		
		private IList<Company> _companies = new List<Company>();
		[Collection(InverseProperty = "User")]
		[Storage("_companies")]
		public virtual IList<Company> Companies
		{
			get
			{
				return this._companies;
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
