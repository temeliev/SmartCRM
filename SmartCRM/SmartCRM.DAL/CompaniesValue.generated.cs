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
	[Table("companies_values")]
	[ConcurrencyControl(OptimisticConcurrencyControlStrategy.Changed)]
	[KeyGenerator(KeyGenerator.Autoinc)]
	public partial class CompaniesValue : INotifyPropertyChanging, INotifyPropertyChanged
	{
		private string _valueName;
		[Column("ValueName", OpenAccessType = OpenAccessType.UnicodeStringVariableLength, Length = 255, Scale = 0, SqlType = "nvarchar")]
		[Storage("_valueName")]
		public virtual string ValueName
		{
			get
			{
				return this._valueName;
			}
			set
			{
				if(this._valueName != value)
				{
					this.OnPropertyChanging("ValueName");
					this._valueName = value;
					this.OnPropertyChanged("ValueName");
				}
			}
		}
		
		private string _valueDescription;
		[Column("ValueDescription", OpenAccessType = OpenAccessType.UnicodeStringInfiniteLength, IsNullable = true, Length = 0, Scale = 0, SqlType = "text")]
		[Storage("_valueDescription")]
		public virtual string ValueDescription
		{
			get
			{
				return this._valueDescription;
			}
			set
			{
				if(this._valueDescription != value)
				{
					this.OnPropertyChanging("ValueDescription");
					this._valueDescription = value;
					this.OnPropertyChanged("ValueDescription");
				}
			}
		}
		
		private string _valueData;
		[Column("ValueData", OpenAccessType = OpenAccessType.UnicodeStringVariableLength, Length = 255, Scale = 0, SqlType = "nvarchar")]
		[Storage("_valueData")]
		public virtual string ValueData
		{
			get
			{
				return this._valueData;
			}
			set
			{
				if(this._valueData != value)
				{
					this.OnPropertyChanging("ValueData");
					this._valueData = value;
					this.OnPropertyChanged("ValueData");
				}
			}
		}
		
		private uint _keyValueID;
		[Column("KeyValueID", OpenAccessType = OpenAccessType.Int32, IsBackendCalculated = true, IsPrimaryKey = true, Length = 0, Scale = 0, SqlType = "integer unsigned")]
		[Storage("_keyValueID")]
		public virtual uint KeyValueID
		{
			get
			{
				return this._keyValueID;
			}
			set
			{
				if(this._keyValueID != value)
				{
					this.OnPropertyChanging("KeyValueID");
					this._keyValueID = value;
					this.OnPropertyChanged("KeyValueID");
				}
			}
		}
		
		private uint _valueTypeID;
		[Column("ValueTypeID", OpenAccessType = OpenAccessType.Int32, Length = 0, Scale = 0, SqlType = "integer unsigned")]
		[Storage("_valueTypeID")]
		public virtual uint ValueTypeID
		{
			get
			{
				return this._valueTypeID;
			}
			set
			{
				if(this._valueTypeID != value)
				{
					this.OnPropertyChanging("ValueTypeID");
					this._valueTypeID = value;
					this.OnPropertyChanged("ValueTypeID");
				}
			}
		}
		
		private uint _companyID;
		[Column("CompanyID", OpenAccessType = OpenAccessType.Int32, Length = 0, Scale = 0, SqlType = "integer unsigned")]
		[Storage("_companyID")]
		public virtual uint CompanyID
		{
			get
			{
				return this._companyID;
			}
			set
			{
				if(this._companyID != value)
				{
					this.OnPropertyChanging("CompanyID");
					this._companyID = value;
					this.OnPropertyChanged("CompanyID");
				}
			}
		}
		
		private ConstValueType _constValueType;
		[ForeignKeyAssociation(ConstraintName = "FK_companies_values_const_value_types_ValueTypeID", SharedFields = "ValueTypeID", TargetFields = "ValueTypeID")]
		[Storage("_constValueType")]
		public virtual ConstValueType ConstValueType
		{
			get
			{
				return this._constValueType;
			}
			set
			{
				if(this._constValueType != value)
				{
					this.OnPropertyChanging("ConstValueType");
					this._constValueType = value;
					this.OnPropertyChanged("ConstValueType");
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