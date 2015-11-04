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
	[Table("users")]
	[ConcurrencyControl(OptimisticConcurrencyControlStrategy.Changed)]
	[KeyGenerator(KeyGenerator.Autoinc)]
	public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
	{
		private uint _userId;
		[Column("UserId", OpenAccessType = OpenAccessType.Int32, IsBackendCalculated = true, IsPrimaryKey = true, Length = 0, Scale = 0, SqlType = "integer unsigned")]
		[Storage("_userId")]
		public virtual uint UserId
		{
			get
			{
				return this._userId;
			}
			set
			{
				if(this._userId != value)
				{
					this.OnPropertyChanging("UserId");
					this._userId = value;
					this.OnPropertyChanged("UserId");
				}
			}
		}
		
		private string _username;
		[Column("Username", OpenAccessType = OpenAccessType.UnicodeStringVariableLength, Length = 50, Scale = 0, SqlType = "nvarchar")]
		[Storage("_username")]
		public virtual string Username
		{
			get
			{
				return this._username;
			}
			set
			{
				if(this._username != value)
				{
					this.OnPropertyChanging("Username");
					this._username = value;
					this.OnPropertyChanged("Username");
				}
			}
		}
		
		private string _password;
		[Column("Password", OpenAccessType = OpenAccessType.UnicodeStringVariableLength, Length = 30, Scale = 0, SqlType = "nvarchar")]
		[Storage("_password")]
		public virtual string Password
		{
			get
			{
				return this._password;
			}
			set
			{
				if(this._password != value)
				{
					this.OnPropertyChanging("Password");
					this._password = value;
					this.OnPropertyChanged("Password");
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