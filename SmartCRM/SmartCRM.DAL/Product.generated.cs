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
	[Table("products")]
	[ConcurrencyControl(OptimisticConcurrencyControlStrategy.Changed)]
	[KeyGenerator(KeyGenerator.Autoinc)]
	public partial class Product : INotifyPropertyChanging, INotifyPropertyChanged
	{
		private uint _productPosition;
		[Column("ProductPosition", OpenAccessType = OpenAccessType.Int32, Length = 0, Scale = 0, SqlType = "integer unsigned")]
		[Storage("_productPosition")]
		public virtual uint ProductPosition
		{
			get
			{
				return this._productPosition;
			}
			set
			{
				if(this._productPosition != value)
				{
					this.OnPropertyChanging("ProductPosition");
					this._productPosition = value;
					this.OnPropertyChanged("ProductPosition");
				}
			}
		}
		
		private string _productName;
		[Column("ProductName", OpenAccessType = OpenAccessType.UnicodeStringVariableLength, Length = 255, Scale = 0, SqlType = "nvarchar")]
		[Storage("_productName")]
		public virtual string ProductName
		{
			get
			{
				return this._productName;
			}
			set
			{
				if(this._productName != value)
				{
					this.OnPropertyChanging("ProductName");
					this._productName = value;
					this.OnPropertyChanged("ProductName");
				}
			}
		}
		
		private uint _productID;
		[Column("ProductID", OpenAccessType = OpenAccessType.Int32, IsBackendCalculated = true, IsPrimaryKey = true, Length = 0, Scale = 0, SqlType = "integer unsigned")]
		[Storage("_productID")]
		public virtual uint ProductID
		{
			get
			{
				return this._productID;
			}
			set
			{
				if(this._productID != value)
				{
					this.OnPropertyChanging("ProductID");
					this._productID = value;
					this.OnPropertyChanged("ProductID");
				}
			}
		}
		
		private uint _productTypeID;
		[Column("ProductTypeID", OpenAccessType = OpenAccessType.Int32, Length = 0, Scale = 0, SqlType = "integer unsigned")]
		[Storage("_productTypeID")]
		public virtual uint ProductTypeID
		{
			get
			{
				return this._productTypeID;
			}
			set
			{
				if(this._productTypeID != value)
				{
					this.OnPropertyChanging("ProductTypeID");
					this._productTypeID = value;
					this.OnPropertyChanged("ProductTypeID");
				}
			}
		}
		
		private ContsProductsType _contsProductsType;
		[ForeignKeyAssociation(ConstraintName = "FK_products_conts_products_types_ProductTypeID", SharedFields = "ProductTypeID", TargetFields = "ProductTypeID")]
		[Storage("_contsProductsType")]
		public virtual ContsProductsType ContsProductsType
		{
			get
			{
				return this._contsProductsType;
			}
			set
			{
				if(this._contsProductsType != value)
				{
					this.OnPropertyChanging("ContsProductsType");
					this._contsProductsType = value;
					this.OnPropertyChanged("ContsProductsType");
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
