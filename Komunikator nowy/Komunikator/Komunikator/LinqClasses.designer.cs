﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Komunikator
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Communicator")]
	public partial class LinqClassesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertImage(Image instance);
    partial void UpdateImage(Image instance);
    partial void DeleteImage(Image instance);
    partial void InsertInterest(Interest instance);
    partial void UpdateInterest(Interest instance);
    partial void DeleteInterest(Interest instance);
    partial void InsertUser_info(User_info instance);
    partial void UpdateUser_info(User_info instance);
    partial void DeleteUser_info(User_info instance);
    partial void InsertUserInterest(UserInterest instance);
    partial void UpdateUserInterest(UserInterest instance);
    partial void DeleteUserInterest(UserInterest instance);
    partial void InsertInterestImage(InterestImage instance);
    partial void UpdateInterestImage(InterestImage instance);
    partial void DeleteInterestImage(InterestImage instance);
    #endregion
		
		public LinqClassesDataContext() : 
				base(global::Komunikator.Properties.Settings.Default.CommunicatorConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public LinqClassesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LinqClassesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LinqClassesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LinqClassesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Contact> Contacts
		{
			get
			{
				return this.GetTable<Contact>();
			}
		}
		
		public System.Data.Linq.Table<Image> Images
		{
			get
			{
				return this.GetTable<Image>();
			}
		}
		
		public System.Data.Linq.Table<Interest> Interests
		{
			get
			{
				return this.GetTable<Interest>();
			}
		}
		
		public System.Data.Linq.Table<User_info> User_infos
		{
			get
			{
				return this.GetTable<User_info>();
			}
		}
		
		public System.Data.Linq.Table<UserInterest> UserInterests
		{
			get
			{
				return this.GetTable<UserInterest>();
			}
		}
		
		public System.Data.Linq.Table<InterestImage> InterestImages
		{
			get
			{
				return this.GetTable<InterestImage>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Contacts")]
	public partial class Contact
	{
		
		private int _hostID;
		
		private System.Nullable<int> _contactID;
		
		public Contact()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_hostID", DbType="Int NOT NULL")]
		public int hostID
		{
			get
			{
				return this._hostID;
			}
			set
			{
				if ((this._hostID != value))
				{
					this._hostID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_contactID", DbType="Int")]
		public System.Nullable<int> contactID
		{
			get
			{
				return this._contactID;
			}
			set
			{
				if ((this._contactID != value))
				{
					this._contactID = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Images")]
	public partial class Image : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private System.Data.Linq.Binary _image1;
		
		private EntitySet<InterestImage> _InterestImages;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void Onimage1Changing(System.Data.Linq.Binary value);
    partial void Onimage1Changed();
    #endregion
		
		public Image()
		{
			this._InterestImages = new EntitySet<InterestImage>(new Action<InterestImage>(this.attach_InterestImages), new Action<InterestImage>(this.detach_InterestImages));
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="image", Storage="_image1", DbType="Image NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary image1
		{
			get
			{
				return this._image1;
			}
			set
			{
				if ((this._image1 != value))
				{
					this.Onimage1Changing(value);
					this.SendPropertyChanging();
					this._image1 = value;
					this.SendPropertyChanged("image1");
					this.Onimage1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Image_InterestImage", Storage="_InterestImages", ThisKey="Id", OtherKey="imageID")]
		public EntitySet<InterestImage> InterestImages
		{
			get
			{
				return this._InterestImages;
			}
			set
			{
				this._InterestImages.Assign(value);
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
		
		private void attach_InterestImages(InterestImage entity)
		{
			this.SendPropertyChanging();
			entity.Image = this;
		}
		
		private void detach_InterestImages(InterestImage entity)
		{
			this.SendPropertyChanging();
			entity.Image = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Interests")]
	public partial class Interest : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Interest1;
		
		private EntitySet<UserInterest> _UserInterests;
		
		private EntitySet<InterestImage> _InterestImages;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnInterest1Changing(string value);
    partial void OnInterest1Changed();
    #endregion
		
		public Interest()
		{
			this._UserInterests = new EntitySet<UserInterest>(new Action<UserInterest>(this.attach_UserInterests), new Action<UserInterest>(this.detach_UserInterests));
			this._InterestImages = new EntitySet<InterestImage>(new Action<InterestImage>(this.attach_InterestImages), new Action<InterestImage>(this.detach_InterestImages));
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="Interest", Storage="_Interest1", DbType="VarChar(50)")]
		public string Interest1
		{
			get
			{
				return this._Interest1;
			}
			set
			{
				if ((this._Interest1 != value))
				{
					this.OnInterest1Changing(value);
					this.SendPropertyChanging();
					this._Interest1 = value;
					this.SendPropertyChanged("Interest1");
					this.OnInterest1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Interest_UserInterest", Storage="_UserInterests", ThisKey="Id", OtherKey="interestID")]
		public EntitySet<UserInterest> UserInterests
		{
			get
			{
				return this._UserInterests;
			}
			set
			{
				this._UserInterests.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Interest_InterestImage", Storage="_InterestImages", ThisKey="Id", OtherKey="interestID")]
		public EntitySet<InterestImage> InterestImages
		{
			get
			{
				return this._InterestImages;
			}
			set
			{
				this._InterestImages.Assign(value);
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
		
		private void attach_UserInterests(UserInterest entity)
		{
			this.SendPropertyChanging();
			entity.Interest = this;
		}
		
		private void detach_UserInterests(UserInterest entity)
		{
			this.SendPropertyChanging();
			entity.Interest = null;
		}
		
		private void attach_InterestImages(InterestImage entity)
		{
			this.SendPropertyChanging();
			entity.Interest = this;
		}
		
		private void detach_InterestImages(InterestImage entity)
		{
			this.SendPropertyChanging();
			entity.Interest = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.User_info")]
	public partial class User_info : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Sex;
		
		private string _Localization;
		
		private string _Birthdate;
		
		private string _Name;
		
		private string _Surname;
		
		private string _City;
		
		private System.Data.Linq.Binary _Avatar;
		
		private string _Email;
		
		private string _Password;
		
		private bool _isBusy;
		
		private bool _isConnected;
		
		private EntitySet<UserInterest> _UserInterests;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnSexChanging(string value);
    partial void OnSexChanged();
    partial void OnLocalizationChanging(string value);
    partial void OnLocalizationChanged();
    partial void OnBirthdateChanging(string value);
    partial void OnBirthdateChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnSurnameChanging(string value);
    partial void OnSurnameChanged();
    partial void OnCityChanging(string value);
    partial void OnCityChanged();
    partial void OnAvatarChanging(System.Data.Linq.Binary value);
    partial void OnAvatarChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnisBusyChanging(bool value);
    partial void OnisBusyChanged();
    partial void OnisConnectedChanging(bool value);
    partial void OnisConnectedChanged();
    #endregion
		
		public User_info()
		{
			this._UserInterests = new EntitySet<UserInterest>(new Action<UserInterest>(this.attach_UserInterests), new Action<UserInterest>(this.detach_UserInterests));
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Sex", DbType="VarChar(10)")]
		public string Sex
		{
			get
			{
				return this._Sex;
			}
			set
			{
				if ((this._Sex != value))
				{
					this.OnSexChanging(value);
					this.SendPropertyChanging();
					this._Sex = value;
					this.SendPropertyChanged("Sex");
					this.OnSexChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Localization", DbType="VarChar(50)")]
		public string Localization
		{
			get
			{
				return this._Localization;
			}
			set
			{
				if ((this._Localization != value))
				{
					this.OnLocalizationChanging(value);
					this.SendPropertyChanging();
					this._Localization = value;
					this.SendPropertyChanged("Localization");
					this.OnLocalizationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Birthdate", DbType="VarChar(50)")]
		public string Birthdate
		{
			get
			{
				return this._Birthdate;
			}
			set
			{
				if ((this._Birthdate != value))
				{
					this.OnBirthdateChanging(value);
					this.SendPropertyChanging();
					this._Birthdate = value;
					this.SendPropertyChanged("Birthdate");
					this.OnBirthdateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(50)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Surname", DbType="VarChar(50)")]
		public string Surname
		{
			get
			{
				return this._Surname;
			}
			set
			{
				if ((this._Surname != value))
				{
					this.OnSurnameChanging(value);
					this.SendPropertyChanging();
					this._Surname = value;
					this.SendPropertyChanged("Surname");
					this.OnSurnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_City", DbType="VarChar(50)")]
		public string City
		{
			get
			{
				return this._City;
			}
			set
			{
				if ((this._City != value))
				{
					this.OnCityChanging(value);
					this.SendPropertyChanging();
					this._City = value;
					this.SendPropertyChanged("City");
					this.OnCityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Avatar", DbType="Image", UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary Avatar
		{
			get
			{
				return this._Avatar;
			}
			set
			{
				if ((this._Avatar != value))
				{
					this.OnAvatarChanging(value);
					this.SendPropertyChanging();
					this._Avatar = value;
					this.SendPropertyChanged("Avatar");
					this.OnAvatarChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_isBusy", DbType="Bit NOT NULL")]
		public bool isBusy
		{
			get
			{
				return this._isBusy;
			}
			set
			{
				if ((this._isBusy != value))
				{
					this.OnisBusyChanging(value);
					this.SendPropertyChanging();
					this._isBusy = value;
					this.SendPropertyChanged("isBusy");
					this.OnisBusyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_isConnected", DbType="Bit NOT NULL")]
		public bool isConnected
		{
			get
			{
				return this._isConnected;
			}
			set
			{
				if ((this._isConnected != value))
				{
					this.OnisConnectedChanging(value);
					this.SendPropertyChanging();
					this._isConnected = value;
					this.SendPropertyChanged("isConnected");
					this.OnisConnectedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_info_UserInterest", Storage="_UserInterests", ThisKey="Id", OtherKey="userID")]
		public EntitySet<UserInterest> UserInterests
		{
			get
			{
				return this._UserInterests;
			}
			set
			{
				this._UserInterests.Assign(value);
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
		
		private void attach_UserInterests(UserInterest entity)
		{
			this.SendPropertyChanging();
			entity.User_info = this;
		}
		
		private void detach_UserInterests(UserInterest entity)
		{
			this.SendPropertyChanging();
			entity.User_info = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.UserInterest")]
	public partial class UserInterest : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _interestID;
		
		private int _userID;
		
		private int _Id;
		
		private EntityRef<Interest> _Interest;
		
		private EntityRef<User_info> _User_info;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OninterestIDChanging(int value);
    partial void OninterestIDChanged();
    partial void OnuserIDChanging(int value);
    partial void OnuserIDChanged();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    #endregion
		
		public UserInterest()
		{
			this._Interest = default(EntityRef<Interest>);
			this._User_info = default(EntityRef<User_info>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_interestID", DbType="Int NOT NULL")]
		public int interestID
		{
			get
			{
				return this._interestID;
			}
			set
			{
				if ((this._interestID != value))
				{
					if (this._Interest.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OninterestIDChanging(value);
					this.SendPropertyChanging();
					this._interestID = value;
					this.SendPropertyChanged("interestID");
					this.OninterestIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_userID", DbType="Int NOT NULL")]
		public int userID
		{
			get
			{
				return this._userID;
			}
			set
			{
				if ((this._userID != value))
				{
					if (this._User_info.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnuserIDChanging(value);
					this.SendPropertyChanging();
					this._userID = value;
					this.SendPropertyChanged("userID");
					this.OnuserIDChanged();
				}
			}
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Interest_UserInterest", Storage="_Interest", ThisKey="interestID", OtherKey="Id", IsForeignKey=true)]
		public Interest Interest
		{
			get
			{
				return this._Interest.Entity;
			}
			set
			{
				Interest previousValue = this._Interest.Entity;
				if (((previousValue != value) 
							|| (this._Interest.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Interest.Entity = null;
						previousValue.UserInterests.Remove(this);
					}
					this._Interest.Entity = value;
					if ((value != null))
					{
						value.UserInterests.Add(this);
						this._interestID = value.Id;
					}
					else
					{
						this._interestID = default(int);
					}
					this.SendPropertyChanged("Interest");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_info_UserInterest", Storage="_User_info", ThisKey="userID", OtherKey="Id", IsForeignKey=true)]
		public User_info User_info
		{
			get
			{
				return this._User_info.Entity;
			}
			set
			{
				User_info previousValue = this._User_info.Entity;
				if (((previousValue != value) 
							|| (this._User_info.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._User_info.Entity = null;
						previousValue.UserInterests.Remove(this);
					}
					this._User_info.Entity = value;
					if ((value != null))
					{
						value.UserInterests.Add(this);
						this._userID = value.Id;
					}
					else
					{
						this._userID = default(int);
					}
					this.SendPropertyChanged("User_info");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.InterestImage")]
	public partial class InterestImage : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _interestID;
		
		private int _imageID;
		
		private int _Id;
		
		private EntityRef<Image> _Image;
		
		private EntityRef<Interest> _Interest;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OninterestIDChanging(int value);
    partial void OninterestIDChanged();
    partial void OnimageIDChanging(int value);
    partial void OnimageIDChanged();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    #endregion
		
		public InterestImage()
		{
			this._Image = default(EntityRef<Image>);
			this._Interest = default(EntityRef<Interest>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_interestID", DbType="Int NOT NULL")]
		public int interestID
		{
			get
			{
				return this._interestID;
			}
			set
			{
				if ((this._interestID != value))
				{
					if (this._Interest.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OninterestIDChanging(value);
					this.SendPropertyChanging();
					this._interestID = value;
					this.SendPropertyChanged("interestID");
					this.OninterestIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_imageID", DbType="Int NOT NULL")]
		public int imageID
		{
			get
			{
				return this._imageID;
			}
			set
			{
				if ((this._imageID != value))
				{
					if (this._Image.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnimageIDChanging(value);
					this.SendPropertyChanging();
					this._imageID = value;
					this.SendPropertyChanged("imageID");
					this.OnimageIDChanged();
				}
			}
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Image_InterestImage", Storage="_Image", ThisKey="imageID", OtherKey="Id", IsForeignKey=true)]
		public Image Image
		{
			get
			{
				return this._Image.Entity;
			}
			set
			{
				Image previousValue = this._Image.Entity;
				if (((previousValue != value) 
							|| (this._Image.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Image.Entity = null;
						previousValue.InterestImages.Remove(this);
					}
					this._Image.Entity = value;
					if ((value != null))
					{
						value.InterestImages.Add(this);
						this._imageID = value.Id;
					}
					else
					{
						this._imageID = default(int);
					}
					this.SendPropertyChanged("Image");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Interest_InterestImage", Storage="_Interest", ThisKey="interestID", OtherKey="Id", IsForeignKey=true)]
		public Interest Interest
		{
			get
			{
				return this._Interest.Entity;
			}
			set
			{
				Interest previousValue = this._Interest.Entity;
				if (((previousValue != value) 
							|| (this._Interest.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Interest.Entity = null;
						previousValue.InterestImages.Remove(this);
					}
					this._Interest.Entity = value;
					if ((value != null))
					{
						value.InterestImages.Add(this);
						this._interestID = value.Id;
					}
					else
					{
						this._interestID = default(int);
					}
					this.SendPropertyChanged("Interest");
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
}
#pragma warning restore 1591
