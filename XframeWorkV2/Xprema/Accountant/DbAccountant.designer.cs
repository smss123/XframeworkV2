﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Xprema.Accountant
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="XpremaAccountantData")]
	public partial class DbAccountantDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public DbAccountantDataContext() : 
				base(global::Xprema.Properties.Settings.Default.XpremaAccountantDataConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DbAccountantDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DbAccountantDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DbAccountantDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DbAccountantDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Account> Accounts
		{
			get
			{
				return this.GetTable<Account>();
			}
		}
		
		public System.Data.Linq.Table<AccountCategory> AccountCategories
		{
			get
			{
				return this.GetTable<AccountCategory>();
			}
		}
		
		public System.Data.Linq.Table<AccountDaily> AccountDailies
		{
			get
			{
				return this.GetTable<AccountDaily>();
			}
		}
		
		public System.Data.Linq.Table<Expenss> Expensses
		{
			get
			{
				return this.GetTable<Expenss>();
			}
		}
		
		public System.Data.Linq.Table<ExpenssesMovment> ExpenssesMovments
		{
			get
			{
				return this.GetTable<ExpenssesMovment>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="Accountant.Account")]
	public partial class Account
	{
		
		private int _ID;
		
		private string _AccountName;
		
		private string _Description;
		
		private System.Nullable<int> _CategoryID;
		
		private System.Nullable<System.Guid> _SerialNumber;
		
		public Account()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL")]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this._ID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AccountName", DbType="NVarChar(50)")]
		public string AccountName
		{
			get
			{
				return this._AccountName;
			}
			set
			{
				if ((this._AccountName != value))
				{
					this._AccountName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="NVarChar(MAX)")]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this._Description = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CategoryID", DbType="Int")]
		public System.Nullable<int> CategoryID
		{
			get
			{
				return this._CategoryID;
			}
			set
			{
				if ((this._CategoryID != value))
				{
					this._CategoryID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SerialNumber", DbType="UniqueIdentifier")]
		public System.Nullable<System.Guid> SerialNumber
		{
			get
			{
				return this._SerialNumber;
			}
			set
			{
				if ((this._SerialNumber != value))
				{
					this._SerialNumber = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="Accountant.AccountCategory")]
	public partial class AccountCategory
	{
		
		private int _ID;
		
		private string _AccountCategoryName;
		
		private string _Description;
		
		private System.Nullable<System.Guid> _SerialNumber;
		
		public AccountCategory()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL")]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this._ID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AccountCategoryName", DbType="NVarChar(50)")]
		public string AccountCategoryName
		{
			get
			{
				return this._AccountCategoryName;
			}
			set
			{
				if ((this._AccountCategoryName != value))
				{
					this._AccountCategoryName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="NVarChar(50)")]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this._Description = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SerialNumber", DbType="UniqueIdentifier")]
		public System.Nullable<System.Guid> SerialNumber
		{
			get
			{
				return this._SerialNumber;
			}
			set
			{
				if ((this._SerialNumber != value))
				{
					this._SerialNumber = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="Accountant.AccountDaily")]
	public partial class AccountDaily
	{
		
		private int _ID;
		
		private System.Nullable<int> _AccountID;
		
		private System.Nullable<double> _TotalIn;
		
		private System.Nullable<double> _TotalOut;
		
		private System.Nullable<System.DateTime> _DateOfProcess;
		
		private string _Description;
		
		private string _CommandArg;
		
		public AccountDaily()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL")]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this._ID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AccountID", DbType="Int")]
		public System.Nullable<int> AccountID
		{
			get
			{
				return this._AccountID;
			}
			set
			{
				if ((this._AccountID != value))
				{
					this._AccountID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TotalIn", DbType="Float")]
		public System.Nullable<double> TotalIn
		{
			get
			{
				return this._TotalIn;
			}
			set
			{
				if ((this._TotalIn != value))
				{
					this._TotalIn = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TotalOut", DbType="Float")]
		public System.Nullable<double> TotalOut
		{
			get
			{
				return this._TotalOut;
			}
			set
			{
				if ((this._TotalOut != value))
				{
					this._TotalOut = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateOfProcess", DbType="DateTime")]
		public System.Nullable<System.DateTime> DateOfProcess
		{
			get
			{
				return this._DateOfProcess;
			}
			set
			{
				if ((this._DateOfProcess != value))
				{
					this._DateOfProcess = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="NVarChar(4000)")]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this._Description = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CommandArg", DbType="NVarChar(50)")]
		public string CommandArg
		{
			get
			{
				return this._CommandArg;
			}
			set
			{
				if ((this._CommandArg != value))
				{
					this._CommandArg = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="Accountant.Expensses")]
	public partial class Expenss
	{
		
		private int _ID;
		
		private string _ExpenssesName;
		
		private string _Description;
		
		private System.Nullable<int> _AccountID;
		
		private System.Nullable<System.Guid> _SerialNumber;
		
		public Expenss()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL")]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this._ID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ExpenssesName", DbType="NVarChar(50)")]
		public string ExpenssesName
		{
			get
			{
				return this._ExpenssesName;
			}
			set
			{
				if ((this._ExpenssesName != value))
				{
					this._ExpenssesName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="NVarChar(4000)")]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this._Description = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AccountID", DbType="Int")]
		public System.Nullable<int> AccountID
		{
			get
			{
				return this._AccountID;
			}
			set
			{
				if ((this._AccountID != value))
				{
					this._AccountID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SerialNumber", DbType="UniqueIdentifier")]
		public System.Nullable<System.Guid> SerialNumber
		{
			get
			{
				return this._SerialNumber;
			}
			set
			{
				if ((this._SerialNumber != value))
				{
					this._SerialNumber = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="Accountant.ExpenssesMovment")]
	public partial class ExpenssesMovment
	{
		
		private int _ID;
		
		private System.Nullable<int> _ExpenssesID;
		
		private System.Nullable<double> _Amount;
		
		private System.Nullable<System.DateTime> _DateOfProcess;
		
		private string _Description;
		
		private System.Nullable<System.Guid> _SerialNumber;
		
		public ExpenssesMovment()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL")]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this._ID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ExpenssesID", DbType="Int")]
		public System.Nullable<int> ExpenssesID
		{
			get
			{
				return this._ExpenssesID;
			}
			set
			{
				if ((this._ExpenssesID != value))
				{
					this._ExpenssesID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Amount", DbType="Float")]
		public System.Nullable<double> Amount
		{
			get
			{
				return this._Amount;
			}
			set
			{
				if ((this._Amount != value))
				{
					this._Amount = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateOfProcess", DbType="DateTime")]
		public System.Nullable<System.DateTime> DateOfProcess
		{
			get
			{
				return this._DateOfProcess;
			}
			set
			{
				if ((this._DateOfProcess != value))
				{
					this._DateOfProcess = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="NVarChar(MAX)")]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this._Description = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SerialNumber", DbType="UniqueIdentifier")]
		public System.Nullable<System.Guid> SerialNumber
		{
			get
			{
				return this._SerialNumber;
			}
			set
			{
				if ((this._SerialNumber != value))
				{
					this._SerialNumber = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
