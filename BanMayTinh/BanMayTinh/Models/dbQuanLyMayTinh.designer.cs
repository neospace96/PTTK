﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BanMayTinh.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="QLMayTinh")]
	public partial class dbQuanLyMayTinhDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insert__MigrationHistory(__MigrationHistory instance);
    partial void Update__MigrationHistory(__MigrationHistory instance);
    partial void Delete__MigrationHistory(__MigrationHistory instance);
    partial void InsertAspNetRole(AspNetRole instance);
    partial void UpdateAspNetRole(AspNetRole instance);
    partial void DeleteAspNetRole(AspNetRole instance);
    partial void InsertAspNetUserClaim(AspNetUserClaim instance);
    partial void UpdateAspNetUserClaim(AspNetUserClaim instance);
    partial void DeleteAspNetUserClaim(AspNetUserClaim instance);
    partial void InsertAspNetUserLogin(AspNetUserLogin instance);
    partial void UpdateAspNetUserLogin(AspNetUserLogin instance);
    partial void DeleteAspNetUserLogin(AspNetUserLogin instance);
    partial void InsertAspNetUserRole(AspNetUserRole instance);
    partial void UpdateAspNetUserRole(AspNetUserRole instance);
    partial void DeleteAspNetUserRole(AspNetUserRole instance);
    partial void InsertAspNetUser(AspNetUser instance);
    partial void UpdateAspNetUser(AspNetUser instance);
    partial void DeleteAspNetUser(AspNetUser instance);
    #endregion
		
		public dbQuanLyMayTinhDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public dbQuanLyMayTinhDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dbQuanLyMayTinhDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dbQuanLyMayTinhDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dbQuanLyMayTinhDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<@__MigrationHistory> @__MigrationHistories
		{
			get
			{
				return this.GetTable<@__MigrationHistory>();
			}
		}
		
		public System.Data.Linq.Table<SanPham> SanPhams
		{
			get
			{
				return this.GetTable<SanPham>();
			}
		}
		
		public System.Data.Linq.Table<AspNetRole> AspNetRoles
		{
			get
			{
				return this.GetTable<AspNetRole>();
			}
		}
		
		public System.Data.Linq.Table<AspNetUserClaim> AspNetUserClaims
		{
			get
			{
				return this.GetTable<AspNetUserClaim>();
			}
		}
		
		public System.Data.Linq.Table<AspNetUserLogin> AspNetUserLogins
		{
			get
			{
				return this.GetTable<AspNetUserLogin>();
			}
		}
		
		public System.Data.Linq.Table<AspNetUserRole> AspNetUserRoles
		{
			get
			{
				return this.GetTable<AspNetUserRole>();
			}
		}
		
		public System.Data.Linq.Table<AspNetUser> AspNetUsers
		{
			get
			{
				return this.GetTable<AspNetUser>();
			}
		}
		
		public System.Data.Linq.Table<LoaiSanPham> LoaiSanPhams
		{
			get
			{
				return this.GetTable<LoaiSanPham>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[__MigrationHistory]")]
	public partial class @__MigrationHistory : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MigrationId;
		
		private string _ContextKey;
		
		private System.Data.Linq.Binary _Model;
		
		private string _ProductVersion;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMigrationIdChanging(string value);
    partial void OnMigrationIdChanged();
    partial void OnContextKeyChanging(string value);
    partial void OnContextKeyChanged();
    partial void OnModelChanging(System.Data.Linq.Binary value);
    partial void OnModelChanged();
    partial void OnProductVersionChanging(string value);
    partial void OnProductVersionChanged();
    #endregion
		
		public @__MigrationHistory()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MigrationId", DbType="NVarChar(150) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MigrationId
		{
			get
			{
				return this._MigrationId;
			}
			set
			{
				if ((this._MigrationId != value))
				{
					this.OnMigrationIdChanging(value);
					this.SendPropertyChanging();
					this._MigrationId = value;
					this.SendPropertyChanged("MigrationId");
					this.OnMigrationIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ContextKey", DbType="NVarChar(300) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string ContextKey
		{
			get
			{
				return this._ContextKey;
			}
			set
			{
				if ((this._ContextKey != value))
				{
					this.OnContextKeyChanging(value);
					this.SendPropertyChanging();
					this._ContextKey = value;
					this.SendPropertyChanged("ContextKey");
					this.OnContextKeyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Model", DbType="VarBinary(MAX) NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary Model
		{
			get
			{
				return this._Model;
			}
			set
			{
				if ((this._Model != value))
				{
					this.OnModelChanging(value);
					this.SendPropertyChanging();
					this._Model = value;
					this.SendPropertyChanged("Model");
					this.OnModelChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductVersion", DbType="NVarChar(32) NOT NULL", CanBeNull=false)]
		public string ProductVersion
		{
			get
			{
				return this._ProductVersion;
			}
			set
			{
				if ((this._ProductVersion != value))
				{
					this.OnProductVersionChanging(value);
					this.SendPropertyChanging();
					this._ProductVersion = value;
					this.SendPropertyChanged("ProductVersion");
					this.OnProductVersionChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.SanPham")]
	public partial class SanPham
	{
		
		private string _MaSanPham;
		
		private string _TenSanPham;
		
		private string _MaNhaSanXuat;
		
		private string _MaLoai;
		
		private string _Thongtin;
		
		private System.Nullable<double> _GiaBan;
		
		private string _Hinh1;
		
		private string _Hinh2;
		
		private string _Hinh3;
		
		private string _Hinh4;
		
		public SanPham()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaSanPham", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string MaSanPham
		{
			get
			{
				return this._MaSanPham;
			}
			set
			{
				if ((this._MaSanPham != value))
				{
					this._MaSanPham = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenSanPham", DbType="NVarChar(100)")]
		public string TenSanPham
		{
			get
			{
				return this._TenSanPham;
			}
			set
			{
				if ((this._TenSanPham != value))
				{
					this._TenSanPham = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaNhaSanXuat", DbType="VarChar(50)")]
		public string MaNhaSanXuat
		{
			get
			{
				return this._MaNhaSanXuat;
			}
			set
			{
				if ((this._MaNhaSanXuat != value))
				{
					this._MaNhaSanXuat = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaLoai", DbType="VarChar(50)")]
		public string MaLoai
		{
			get
			{
				return this._MaLoai;
			}
			set
			{
				if ((this._MaLoai != value))
				{
					this._MaLoai = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Thongtin", DbType="NVarChar(200)")]
		public string Thongtin
		{
			get
			{
				return this._Thongtin;
			}
			set
			{
				if ((this._Thongtin != value))
				{
					this._Thongtin = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GiaBan", DbType="Float")]
		public System.Nullable<double> GiaBan
		{
			get
			{
				return this._GiaBan;
			}
			set
			{
				if ((this._GiaBan != value))
				{
					this._GiaBan = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Hinh1", DbType="VarChar(100)")]
		public string Hinh1
		{
			get
			{
				return this._Hinh1;
			}
			set
			{
				if ((this._Hinh1 != value))
				{
					this._Hinh1 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Hinh2", DbType="VarChar(100)")]
		public string Hinh2
		{
			get
			{
				return this._Hinh2;
			}
			set
			{
				if ((this._Hinh2 != value))
				{
					this._Hinh2 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Hinh3", DbType="VarChar(100)")]
		public string Hinh3
		{
			get
			{
				return this._Hinh3;
			}
			set
			{
				if ((this._Hinh3 != value))
				{
					this._Hinh3 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Hinh4", DbType="VarChar(100)")]
		public string Hinh4
		{
			get
			{
				return this._Hinh4;
			}
			set
			{
				if ((this._Hinh4 != value))
				{
					this._Hinh4 = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.AspNetRoles")]
	public partial class AspNetRole : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Id;
		
		private string _Name;
		
		private EntitySet<AspNetUserRole> _AspNetUserRoles;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(string value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    #endregion
		
		public AspNetRole()
		{
			this._AspNetUserRoles = new EntitySet<AspNetUserRole>(new Action<AspNetUserRole>(this.attach_AspNetUserRoles), new Action<AspNetUserRole>(this.detach_AspNetUserRoles));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="NVarChar(128) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(256) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="AspNetRole_AspNetUserRole", Storage="_AspNetUserRoles", ThisKey="Id", OtherKey="RoleId")]
		public EntitySet<AspNetUserRole> AspNetUserRoles
		{
			get
			{
				return this._AspNetUserRoles;
			}
			set
			{
				this._AspNetUserRoles.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_AspNetUserRoles(AspNetUserRole entity)
		{
			this.SendPropertyChanging();
			entity.AspNetRole = this;
		}
		
		private void detach_AspNetUserRoles(AspNetUserRole entity)
		{
			this.SendPropertyChanging();
			entity.AspNetRole = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.AspNetUserClaims")]
	public partial class AspNetUserClaim : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _UserId;
		
		private string _ClaimType;
		
		private string _ClaimValue;
		
		private EntityRef<AspNetUser> _AspNetUser;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnUserIdChanging(string value);
    partial void OnUserIdChanged();
    partial void OnClaimTypeChanging(string value);
    partial void OnClaimTypeChanged();
    partial void OnClaimValueChanging(string value);
    partial void OnClaimValueChanged();
    #endregion
		
		public AspNetUserClaim()
		{
			this._AspNetUser = default(EntityRef<AspNetUser>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserId", DbType="NVarChar(128) NOT NULL", CanBeNull=false)]
		public string UserId
		{
			get
			{
				return this._UserId;
			}
			set
			{
				if ((this._UserId != value))
				{
					if (this._AspNetUser.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnUserIdChanging(value);
					this.SendPropertyChanging();
					this._UserId = value;
					this.SendPropertyChanged("UserId");
					this.OnUserIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ClaimType", DbType="NVarChar(MAX)")]
		public string ClaimType
		{
			get
			{
				return this._ClaimType;
			}
			set
			{
				if ((this._ClaimType != value))
				{
					this.OnClaimTypeChanging(value);
					this.SendPropertyChanging();
					this._ClaimType = value;
					this.SendPropertyChanged("ClaimType");
					this.OnClaimTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ClaimValue", DbType="NVarChar(MAX)")]
		public string ClaimValue
		{
			get
			{
				return this._ClaimValue;
			}
			set
			{
				if ((this._ClaimValue != value))
				{
					this.OnClaimValueChanging(value);
					this.SendPropertyChanging();
					this._ClaimValue = value;
					this.SendPropertyChanged("ClaimValue");
					this.OnClaimValueChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="AspNetUser_AspNetUserClaim", Storage="_AspNetUser", ThisKey="UserId", OtherKey="Id", IsForeignKey=true, DeleteOnNull=true, DeleteRule="CASCADE")]
		public AspNetUser AspNetUser
		{
			get
			{
				return this._AspNetUser.Entity;
			}
			set
			{
				AspNetUser previousValue = this._AspNetUser.Entity;
				if (((previousValue != value) 
							|| (this._AspNetUser.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._AspNetUser.Entity = null;
						previousValue.AspNetUserClaims.Remove(this);
					}
					this._AspNetUser.Entity = value;
					if ((value != null))
					{
						value.AspNetUserClaims.Add(this);
						this._UserId = value.Id;
					}
					else
					{
						this._UserId = default(string);
					}
					this.SendPropertyChanged("AspNetUser");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.AspNetUserLogins")]
	public partial class AspNetUserLogin : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _LoginProvider;
		
		private string _ProviderKey;
		
		private string _UserId;
		
		private EntityRef<AspNetUser> _AspNetUser;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnLoginProviderChanging(string value);
    partial void OnLoginProviderChanged();
    partial void OnProviderKeyChanging(string value);
    partial void OnProviderKeyChanged();
    partial void OnUserIdChanging(string value);
    partial void OnUserIdChanged();
    #endregion
		
		public AspNetUserLogin()
		{
			this._AspNetUser = default(EntityRef<AspNetUser>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LoginProvider", DbType="NVarChar(128) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string LoginProvider
		{
			get
			{
				return this._LoginProvider;
			}
			set
			{
				if ((this._LoginProvider != value))
				{
					this.OnLoginProviderChanging(value);
					this.SendPropertyChanging();
					this._LoginProvider = value;
					this.SendPropertyChanged("LoginProvider");
					this.OnLoginProviderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProviderKey", DbType="NVarChar(128) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string ProviderKey
		{
			get
			{
				return this._ProviderKey;
			}
			set
			{
				if ((this._ProviderKey != value))
				{
					this.OnProviderKeyChanging(value);
					this.SendPropertyChanging();
					this._ProviderKey = value;
					this.SendPropertyChanged("ProviderKey");
					this.OnProviderKeyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserId", DbType="NVarChar(128) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string UserId
		{
			get
			{
				return this._UserId;
			}
			set
			{
				if ((this._UserId != value))
				{
					if (this._AspNetUser.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnUserIdChanging(value);
					this.SendPropertyChanging();
					this._UserId = value;
					this.SendPropertyChanged("UserId");
					this.OnUserIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="AspNetUser_AspNetUserLogin", Storage="_AspNetUser", ThisKey="UserId", OtherKey="Id", IsForeignKey=true, DeleteOnNull=true, DeleteRule="CASCADE")]
		public AspNetUser AspNetUser
		{
			get
			{
				return this._AspNetUser.Entity;
			}
			set
			{
				AspNetUser previousValue = this._AspNetUser.Entity;
				if (((previousValue != value) 
							|| (this._AspNetUser.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._AspNetUser.Entity = null;
						previousValue.AspNetUserLogins.Remove(this);
					}
					this._AspNetUser.Entity = value;
					if ((value != null))
					{
						value.AspNetUserLogins.Add(this);
						this._UserId = value.Id;
					}
					else
					{
						this._UserId = default(string);
					}
					this.SendPropertyChanged("AspNetUser");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.AspNetUserRoles")]
	public partial class AspNetUserRole : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _UserId;
		
		private string _RoleId;
		
		private EntityRef<AspNetRole> _AspNetRole;
		
		private EntityRef<AspNetUser> _AspNetUser;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUserIdChanging(string value);
    partial void OnUserIdChanged();
    partial void OnRoleIdChanging(string value);
    partial void OnRoleIdChanged();
    #endregion
		
		public AspNetUserRole()
		{
			this._AspNetRole = default(EntityRef<AspNetRole>);
			this._AspNetUser = default(EntityRef<AspNetUser>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserId", DbType="NVarChar(128) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string UserId
		{
			get
			{
				return this._UserId;
			}
			set
			{
				if ((this._UserId != value))
				{
					if (this._AspNetUser.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnUserIdChanging(value);
					this.SendPropertyChanging();
					this._UserId = value;
					this.SendPropertyChanged("UserId");
					this.OnUserIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RoleId", DbType="NVarChar(128) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string RoleId
		{
			get
			{
				return this._RoleId;
			}
			set
			{
				if ((this._RoleId != value))
				{
					if (this._AspNetRole.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnRoleIdChanging(value);
					this.SendPropertyChanging();
					this._RoleId = value;
					this.SendPropertyChanged("RoleId");
					this.OnRoleIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="AspNetRole_AspNetUserRole", Storage="_AspNetRole", ThisKey="RoleId", OtherKey="Id", IsForeignKey=true, DeleteOnNull=true, DeleteRule="CASCADE")]
		public AspNetRole AspNetRole
		{
			get
			{
				return this._AspNetRole.Entity;
			}
			set
			{
				AspNetRole previousValue = this._AspNetRole.Entity;
				if (((previousValue != value) 
							|| (this._AspNetRole.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._AspNetRole.Entity = null;
						previousValue.AspNetUserRoles.Remove(this);
					}
					this._AspNetRole.Entity = value;
					if ((value != null))
					{
						value.AspNetUserRoles.Add(this);
						this._RoleId = value.Id;
					}
					else
					{
						this._RoleId = default(string);
					}
					this.SendPropertyChanged("AspNetRole");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="AspNetUser_AspNetUserRole", Storage="_AspNetUser", ThisKey="UserId", OtherKey="Id", IsForeignKey=true, DeleteOnNull=true, DeleteRule="CASCADE")]
		public AspNetUser AspNetUser
		{
			get
			{
				return this._AspNetUser.Entity;
			}
			set
			{
				AspNetUser previousValue = this._AspNetUser.Entity;
				if (((previousValue != value) 
							|| (this._AspNetUser.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._AspNetUser.Entity = null;
						previousValue.AspNetUserRoles.Remove(this);
					}
					this._AspNetUser.Entity = value;
					if ((value != null))
					{
						value.AspNetUserRoles.Add(this);
						this._UserId = value.Id;
					}
					else
					{
						this._UserId = default(string);
					}
					this.SendPropertyChanged("AspNetUser");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.AspNetUsers")]
	public partial class AspNetUser : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Id;
		
		private string _Email;
		
		private bool _EmailConfirmed;
		
		private string _PasswordHash;
		
		private string _SecurityStamp;
		
		private string _PhoneNumber;
		
		private bool _PhoneNumberConfirmed;
		
		private bool _TwoFactorEnabled;
		
		private System.Nullable<System.DateTime> _LockoutEndDateUtc;
		
		private bool _LockoutEnabled;
		
		private int _AccessFailedCount;
		
		private string _UserName;
		
		private EntitySet<AspNetUserClaim> _AspNetUserClaims;
		
		private EntitySet<AspNetUserLogin> _AspNetUserLogins;
		
		private EntitySet<AspNetUserRole> _AspNetUserRoles;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(string value);
    partial void OnIdChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnEmailConfirmedChanging(bool value);
    partial void OnEmailConfirmedChanged();
    partial void OnPasswordHashChanging(string value);
    partial void OnPasswordHashChanged();
    partial void OnSecurityStampChanging(string value);
    partial void OnSecurityStampChanged();
    partial void OnPhoneNumberChanging(string value);
    partial void OnPhoneNumberChanged();
    partial void OnPhoneNumberConfirmedChanging(bool value);
    partial void OnPhoneNumberConfirmedChanged();
    partial void OnTwoFactorEnabledChanging(bool value);
    partial void OnTwoFactorEnabledChanged();
    partial void OnLockoutEndDateUtcChanging(System.Nullable<System.DateTime> value);
    partial void OnLockoutEndDateUtcChanged();
    partial void OnLockoutEnabledChanging(bool value);
    partial void OnLockoutEnabledChanged();
    partial void OnAccessFailedCountChanging(int value);
    partial void OnAccessFailedCountChanged();
    partial void OnUserNameChanging(string value);
    partial void OnUserNameChanged();
    #endregion
		
		public AspNetUser()
		{
			this._AspNetUserClaims = new EntitySet<AspNetUserClaim>(new Action<AspNetUserClaim>(this.attach_AspNetUserClaims), new Action<AspNetUserClaim>(this.detach_AspNetUserClaims));
			this._AspNetUserLogins = new EntitySet<AspNetUserLogin>(new Action<AspNetUserLogin>(this.attach_AspNetUserLogins), new Action<AspNetUserLogin>(this.detach_AspNetUserLogins));
			this._AspNetUserRoles = new EntitySet<AspNetUserRole>(new Action<AspNetUserRole>(this.attach_AspNetUserRoles), new Action<AspNetUserRole>(this.detach_AspNetUserRoles));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="NVarChar(128) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NVarChar(256)")]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmailConfirmed", DbType="Bit NOT NULL")]
		public bool EmailConfirmed
		{
			get
			{
				return this._EmailConfirmed;
			}
			set
			{
				if ((this._EmailConfirmed != value))
				{
					this.OnEmailConfirmedChanging(value);
					this.SendPropertyChanging();
					this._EmailConfirmed = value;
					this.SendPropertyChanged("EmailConfirmed");
					this.OnEmailConfirmedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PasswordHash", DbType="NVarChar(MAX)")]
		public string PasswordHash
		{
			get
			{
				return this._PasswordHash;
			}
			set
			{
				if ((this._PasswordHash != value))
				{
					this.OnPasswordHashChanging(value);
					this.SendPropertyChanging();
					this._PasswordHash = value;
					this.SendPropertyChanged("PasswordHash");
					this.OnPasswordHashChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SecurityStamp", DbType="NVarChar(MAX)")]
		public string SecurityStamp
		{
			get
			{
				return this._SecurityStamp;
			}
			set
			{
				if ((this._SecurityStamp != value))
				{
					this.OnSecurityStampChanging(value);
					this.SendPropertyChanging();
					this._SecurityStamp = value;
					this.SendPropertyChanged("SecurityStamp");
					this.OnSecurityStampChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PhoneNumber", DbType="NVarChar(MAX)")]
		public string PhoneNumber
		{
			get
			{
				return this._PhoneNumber;
			}
			set
			{
				if ((this._PhoneNumber != value))
				{
					this.OnPhoneNumberChanging(value);
					this.SendPropertyChanging();
					this._PhoneNumber = value;
					this.SendPropertyChanged("PhoneNumber");
					this.OnPhoneNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PhoneNumberConfirmed", DbType="Bit NOT NULL")]
		public bool PhoneNumberConfirmed
		{
			get
			{
				return this._PhoneNumberConfirmed;
			}
			set
			{
				if ((this._PhoneNumberConfirmed != value))
				{
					this.OnPhoneNumberConfirmedChanging(value);
					this.SendPropertyChanging();
					this._PhoneNumberConfirmed = value;
					this.SendPropertyChanged("PhoneNumberConfirmed");
					this.OnPhoneNumberConfirmedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TwoFactorEnabled", DbType="Bit NOT NULL")]
		public bool TwoFactorEnabled
		{
			get
			{
				return this._TwoFactorEnabled;
			}
			set
			{
				if ((this._TwoFactorEnabled != value))
				{
					this.OnTwoFactorEnabledChanging(value);
					this.SendPropertyChanging();
					this._TwoFactorEnabled = value;
					this.SendPropertyChanged("TwoFactorEnabled");
					this.OnTwoFactorEnabledChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LockoutEndDateUtc", DbType="DateTime")]
		public System.Nullable<System.DateTime> LockoutEndDateUtc
		{
			get
			{
				return this._LockoutEndDateUtc;
			}
			set
			{
				if ((this._LockoutEndDateUtc != value))
				{
					this.OnLockoutEndDateUtcChanging(value);
					this.SendPropertyChanging();
					this._LockoutEndDateUtc = value;
					this.SendPropertyChanged("LockoutEndDateUtc");
					this.OnLockoutEndDateUtcChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LockoutEnabled", DbType="Bit NOT NULL")]
		public bool LockoutEnabled
		{
			get
			{
				return this._LockoutEnabled;
			}
			set
			{
				if ((this._LockoutEnabled != value))
				{
					this.OnLockoutEnabledChanging(value);
					this.SendPropertyChanging();
					this._LockoutEnabled = value;
					this.SendPropertyChanged("LockoutEnabled");
					this.OnLockoutEnabledChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AccessFailedCount", DbType="Int NOT NULL")]
		public int AccessFailedCount
		{
			get
			{
				return this._AccessFailedCount;
			}
			set
			{
				if ((this._AccessFailedCount != value))
				{
					this.OnAccessFailedCountChanging(value);
					this.SendPropertyChanging();
					this._AccessFailedCount = value;
					this.SendPropertyChanged("AccessFailedCount");
					this.OnAccessFailedCountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserName", DbType="NVarChar(256) NOT NULL", CanBeNull=false)]
		public string UserName
		{
			get
			{
				return this._UserName;
			}
			set
			{
				if ((this._UserName != value))
				{
					this.OnUserNameChanging(value);
					this.SendPropertyChanging();
					this._UserName = value;
					this.SendPropertyChanged("UserName");
					this.OnUserNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="AspNetUser_AspNetUserClaim", Storage="_AspNetUserClaims", ThisKey="Id", OtherKey="UserId")]
		public EntitySet<AspNetUserClaim> AspNetUserClaims
		{
			get
			{
				return this._AspNetUserClaims;
			}
			set
			{
				this._AspNetUserClaims.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="AspNetUser_AspNetUserLogin", Storage="_AspNetUserLogins", ThisKey="Id", OtherKey="UserId")]
		public EntitySet<AspNetUserLogin> AspNetUserLogins
		{
			get
			{
				return this._AspNetUserLogins;
			}
			set
			{
				this._AspNetUserLogins.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="AspNetUser_AspNetUserRole", Storage="_AspNetUserRoles", ThisKey="Id", OtherKey="UserId")]
		public EntitySet<AspNetUserRole> AspNetUserRoles
		{
			get
			{
				return this._AspNetUserRoles;
			}
			set
			{
				this._AspNetUserRoles.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_AspNetUserClaims(AspNetUserClaim entity)
		{
			this.SendPropertyChanging();
			entity.AspNetUser = this;
		}
		
		private void detach_AspNetUserClaims(AspNetUserClaim entity)
		{
			this.SendPropertyChanging();
			entity.AspNetUser = null;
		}
		
		private void attach_AspNetUserLogins(AspNetUserLogin entity)
		{
			this.SendPropertyChanging();
			entity.AspNetUser = this;
		}
		
		private void detach_AspNetUserLogins(AspNetUserLogin entity)
		{
			this.SendPropertyChanging();
			entity.AspNetUser = null;
		}
		
		private void attach_AspNetUserRoles(AspNetUserRole entity)
		{
			this.SendPropertyChanging();
			entity.AspNetUser = this;
		}
		
		private void detach_AspNetUserRoles(AspNetUserRole entity)
		{
			this.SendPropertyChanging();
			entity.AspNetUser = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.LoaiSanPham")]
	public partial class LoaiSanPham
	{
		
		private string _MaLoai;
		
		private string _TenLoai;
		
		private string _MaLoaiCha;
		
		public LoaiSanPham()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaLoai", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string MaLoai
		{
			get
			{
				return this._MaLoai;
			}
			set
			{
				if ((this._MaLoai != value))
				{
					this._MaLoai = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenLoai", DbType="NVarChar(50)")]
		public string TenLoai
		{
			get
			{
				return this._TenLoai;
			}
			set
			{
				if ((this._TenLoai != value))
				{
					this._TenLoai = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaLoaiCha", DbType="VarChar(50)")]
		public string MaLoaiCha
		{
			get
			{
				return this._MaLoaiCha;
			}
			set
			{
				if ((this._MaLoaiCha != value))
				{
					this._MaLoaiCha = value;
				}
			}
		}
	}
}
#pragma warning restore 1591