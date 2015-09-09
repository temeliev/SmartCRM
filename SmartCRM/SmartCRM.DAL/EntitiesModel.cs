﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the ContextGenerator.ttinclude code generation file.
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
using SmartCRM.DAL;

namespace SmartCRM.DAL	
{
	[NamingSettings(SourceStrategy = NamingSourceStrategy.Property, RemoveLeadingUnderscores = true, ResolveReservedWords = true, UseDelimitedSQL = true, WordBreak = "_")]
	public partial class SmartCRMEntitiesModel : OpenAccessContext, ISmartCRMEntitiesModelUnitOfWork
	{
		private static string connectionStringName = @"SmartCRMConnection";
			
		private static BackendConfiguration backend = GetBackendConfiguration();
				
		private static MetadataSource metadataSource = AttributesMetadataSource.FromContext(typeof(SmartCRMEntitiesModel));
		
		public SmartCRMEntitiesModel()
			:base(connectionStringName, backend, metadataSource)
		{ }
		
		public SmartCRMEntitiesModel(string connection)
			:base(connection, backend, metadataSource)
		{ }
		
		public SmartCRMEntitiesModel(BackendConfiguration backendConfiguration)
			:base(connectionStringName, backendConfiguration, metadataSource)
		{ }
			
		public SmartCRMEntitiesModel(string connection, MetadataSource metadataSource)
			:base(connection, backend, metadataSource)
		{ }
		
		public SmartCRMEntitiesModel(string connection, BackendConfiguration backendConfiguration, MetadataSource metadataSource)
			:base(connection, backendConfiguration, metadataSource)
		{ }
			
		public IQueryable<User> Users 
		{
			get
			{
				return this.GetAll<User>();
			}
		}
		
		public IQueryable<Report> Reports 
		{
			get
			{
				return this.GetAll<Report>();
			}
		}
		
		public IQueryable<Product> Products 
		{
			get
			{
				return this.GetAll<Product>();
			}
		}
		
		public IQueryable<Person> People 
		{
			get
			{
				return this.GetAll<Person>();
			}
		}
		
		public IQueryable<Log> Logs 
		{
			get
			{
				return this.GetAll<Log>();
			}
		}
		
		public IQueryable<Invoice> Invoices 
		{
			get
			{
				return this.GetAll<Invoice>();
			}
		}
		
		public IQueryable<GlobalSetting> GlobalSettings 
		{
			get
			{
				return this.GetAll<GlobalSetting>();
			}
		}
		
		public IQueryable<ContsProductsType> ContsProductsTypes 
		{
			get
			{
				return this.GetAll<ContsProductsType>();
			}
		}
		
		public IQueryable<ConstValueType> ConstValueTypes 
		{
			get
			{
				return this.GetAll<ConstValueType>();
			}
		}
		
		public IQueryable<ConstPaymentType> ConstPaymentTypes 
		{
			get
			{
				return this.GetAll<ConstPaymentType>();
			}
		}
		
		public IQueryable<CompanyFile> CompanyFiles 
		{
			get
			{
				return this.GetAll<CompanyFile>();
			}
		}
		
		public IQueryable<CompaniesValue> CompaniesValues 
		{
			get
			{
				return this.GetAll<CompaniesValue>();
			}
		}
		
		public IQueryable<Company> Companies 
		{
			get
			{
				return this.GetAll<Company>();
			}
		}
		
		public static BackendConfiguration GetBackendConfiguration()
		{
			BackendConfiguration backend = new BackendConfiguration();
			backend.Backend = "MySql";
			backend.ProviderName = "MySql.Data.MySqlClient";
		
			CustomizeBackendConfiguration(ref backend);
		
			return backend;
		}
		
		/// <summary>
		/// Allows you to customize the BackendConfiguration of SmartCRMEntitiesModel.
		/// </summary>
		/// <param name="config">The BackendConfiguration of SmartCRMEntitiesModel.</param>
		static partial void CustomizeBackendConfiguration(ref BackendConfiguration config);
		
	}
	
	public interface ISmartCRMEntitiesModelUnitOfWork : IUnitOfWork
	{
		IQueryable<User> Users
		{
			get;
		}
		IQueryable<Report> Reports
		{
			get;
		}
		IQueryable<Product> Products
		{
			get;
		}
		IQueryable<Person> People
		{
			get;
		}
		IQueryable<Log> Logs
		{
			get;
		}
		IQueryable<Invoice> Invoices
		{
			get;
		}
		IQueryable<GlobalSetting> GlobalSettings
		{
			get;
		}
		IQueryable<ContsProductsType> ContsProductsTypes
		{
			get;
		}
		IQueryable<ConstValueType> ConstValueTypes
		{
			get;
		}
		IQueryable<ConstPaymentType> ConstPaymentTypes
		{
			get;
		}
		IQueryable<CompanyFile> CompanyFiles
		{
			get;
		}
		IQueryable<CompaniesValue> CompaniesValues
		{
			get;
		}
		IQueryable<Company> Companies
		{
			get;
		}
	}
}
#pragma warning restore 1591
