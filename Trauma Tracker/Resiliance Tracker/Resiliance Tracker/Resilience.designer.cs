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

namespace Resiliance_Tracker
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="ResilienceTracker")]
	public partial class ResilienceDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertMasterClientTable(MasterClientTable instance);
    partial void UpdateMasterClientTable(MasterClientTable instance);
    partial void DeleteMasterClientTable(MasterClientTable instance);
    #endregion
		
		public ResilienceDataContext() : 
				base(global::Resiliance_Tracker.Properties.Settings.Default.ResilienceTrackerConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public ResilienceDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ResilienceDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ResilienceDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ResilienceDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<MasterClientTable> MasterClientTables
		{
			get
			{
				return this.GetTable<MasterClientTable>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.MasterClientTable")]
	public partial class MasterClientTable : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Client_Number;
		
		private System.Nullable<int> _Week_1;
		
		private System.Nullable<int> _Week_2;
		
		private System.Nullable<int> _Week_3;
		
		private System.Nullable<int> _Week_4;
		
		private System.Nullable<int> _Week_5;
		
		private System.Nullable<int> _Week_6;
		
		private System.Nullable<int> _Week_7;
		
		private System.Nullable<int> _Week_8;
		
		private System.Nullable<int> _Week_9;
		
		private System.Nullable<int> _Week_10;
		
		private System.Nullable<int> _Week_11;
		
		private System.Nullable<int> _Week_12;
		
		private System.Nullable<int> _Week_13;
		
		private System.Nullable<int> _Week_14;
		
		private System.Nullable<int> _Week_15;
		
		private System.Nullable<int> _Week_16;
		
		private System.Nullable<int> _Week_17;
		
		private System.Nullable<int> _Week_18;
		
		private System.Nullable<int> _Week_19;
		
		private System.Nullable<int> _Week_20;
		
		private System.Nullable<int> _Week_21;
		
		private System.Nullable<int> _Week_22;
		
		private System.Nullable<int> _Week_23;
		
		private System.Nullable<int> _Week_24;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnClient_NumberChanging(int value);
    partial void OnClient_NumberChanged();
    partial void OnWeek_1Changing(System.Nullable<int> value);
    partial void OnWeek_1Changed();
    partial void OnWeek_2Changing(System.Nullable<int> value);
    partial void OnWeek_2Changed();
    partial void OnWeek_3Changing(System.Nullable<int> value);
    partial void OnWeek_3Changed();
    partial void OnWeek_4Changing(System.Nullable<int> value);
    partial void OnWeek_4Changed();
    partial void OnWeek_5Changing(System.Nullable<int> value);
    partial void OnWeek_5Changed();
    partial void OnWeek_6Changing(System.Nullable<int> value);
    partial void OnWeek_6Changed();
    partial void OnWeek_7Changing(System.Nullable<int> value);
    partial void OnWeek_7Changed();
    partial void OnWeek_8Changing(System.Nullable<int> value);
    partial void OnWeek_8Changed();
    partial void OnWeek_9Changing(System.Nullable<int> value);
    partial void OnWeek_9Changed();
    partial void OnWeek_10Changing(System.Nullable<int> value);
    partial void OnWeek_10Changed();
    partial void OnWeek_11Changing(System.Nullable<int> value);
    partial void OnWeek_11Changed();
    partial void OnWeek_12Changing(System.Nullable<int> value);
    partial void OnWeek_12Changed();
    partial void OnWeek_13Changing(System.Nullable<int> value);
    partial void OnWeek_13Changed();
    partial void OnWeek_14Changing(System.Nullable<int> value);
    partial void OnWeek_14Changed();
    partial void OnWeek_15Changing(System.Nullable<int> value);
    partial void OnWeek_15Changed();
    partial void OnWeek_16Changing(System.Nullable<int> value);
    partial void OnWeek_16Changed();
    partial void OnWeek_17Changing(System.Nullable<int> value);
    partial void OnWeek_17Changed();
    partial void OnWeek_18Changing(System.Nullable<int> value);
    partial void OnWeek_18Changed();
    partial void OnWeek_19Changing(System.Nullable<int> value);
    partial void OnWeek_19Changed();
    partial void OnWeek_20Changing(System.Nullable<int> value);
    partial void OnWeek_20Changed();
    partial void OnWeek_21Changing(System.Nullable<int> value);
    partial void OnWeek_21Changed();
    partial void OnWeek_22Changing(System.Nullable<int> value);
    partial void OnWeek_22Changed();
    partial void OnWeek_23Changing(System.Nullable<int> value);
    partial void OnWeek_23Changed();
    partial void OnWeek_24Changing(System.Nullable<int> value);
    partial void OnWeek_24Changed();
    #endregion
		
		public MasterClientTable()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Client Number]", Storage="_Client_Number", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Client_Number
		{
			get
			{
				return this._Client_Number;
			}
			set
			{
				if ((this._Client_Number != value))
				{
					this.OnClient_NumberChanging(value);
					this.SendPropertyChanging();
					this._Client_Number = value;
					this.SendPropertyChanged("Client_Number");
					this.OnClient_NumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Week 1]", Storage="_Week_1", DbType="Int")]
		public System.Nullable<int> Week_1
		{
			get
			{
				return this._Week_1;
			}
			set
			{
				if ((this._Week_1 != value))
				{
					this.OnWeek_1Changing(value);
					this.SendPropertyChanging();
					this._Week_1 = value;
					this.SendPropertyChanged("Week_1");
					this.OnWeek_1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Week 2]", Storage="_Week_2", DbType="Int")]
		public System.Nullable<int> Week_2
		{
			get
			{
				return this._Week_2;
			}
			set
			{
				if ((this._Week_2 != value))
				{
					this.OnWeek_2Changing(value);
					this.SendPropertyChanging();
					this._Week_2 = value;
					this.SendPropertyChanged("Week_2");
					this.OnWeek_2Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Week 3]", Storage="_Week_3", DbType="Int")]
		public System.Nullable<int> Week_3
		{
			get
			{
				return this._Week_3;
			}
			set
			{
				if ((this._Week_3 != value))
				{
					this.OnWeek_3Changing(value);
					this.SendPropertyChanging();
					this._Week_3 = value;
					this.SendPropertyChanged("Week_3");
					this.OnWeek_3Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Week 4]", Storage="_Week_4", DbType="Int")]
		public System.Nullable<int> Week_4
		{
			get
			{
				return this._Week_4;
			}
			set
			{
				if ((this._Week_4 != value))
				{
					this.OnWeek_4Changing(value);
					this.SendPropertyChanging();
					this._Week_4 = value;
					this.SendPropertyChanged("Week_4");
					this.OnWeek_4Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Week 5]", Storage="_Week_5", DbType="Int")]
		public System.Nullable<int> Week_5
		{
			get
			{
				return this._Week_5;
			}
			set
			{
				if ((this._Week_5 != value))
				{
					this.OnWeek_5Changing(value);
					this.SendPropertyChanging();
					this._Week_5 = value;
					this.SendPropertyChanged("Week_5");
					this.OnWeek_5Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Week 6]", Storage="_Week_6", DbType="Int")]
		public System.Nullable<int> Week_6
		{
			get
			{
				return this._Week_6;
			}
			set
			{
				if ((this._Week_6 != value))
				{
					this.OnWeek_6Changing(value);
					this.SendPropertyChanging();
					this._Week_6 = value;
					this.SendPropertyChanged("Week_6");
					this.OnWeek_6Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Week 7]", Storage="_Week_7", DbType="Int")]
		public System.Nullable<int> Week_7
		{
			get
			{
				return this._Week_7;
			}
			set
			{
				if ((this._Week_7 != value))
				{
					this.OnWeek_7Changing(value);
					this.SendPropertyChanging();
					this._Week_7 = value;
					this.SendPropertyChanged("Week_7");
					this.OnWeek_7Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Week 8]", Storage="_Week_8", DbType="Int")]
		public System.Nullable<int> Week_8
		{
			get
			{
				return this._Week_8;
			}
			set
			{
				if ((this._Week_8 != value))
				{
					this.OnWeek_8Changing(value);
					this.SendPropertyChanging();
					this._Week_8 = value;
					this.SendPropertyChanged("Week_8");
					this.OnWeek_8Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Week 9]", Storage="_Week_9", DbType="Int")]
		public System.Nullable<int> Week_9
		{
			get
			{
				return this._Week_9;
			}
			set
			{
				if ((this._Week_9 != value))
				{
					this.OnWeek_9Changing(value);
					this.SendPropertyChanging();
					this._Week_9 = value;
					this.SendPropertyChanged("Week_9");
					this.OnWeek_9Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Week 10]", Storage="_Week_10", DbType="Int")]
		public System.Nullable<int> Week_10
		{
			get
			{
				return this._Week_10;
			}
			set
			{
				if ((this._Week_10 != value))
				{
					this.OnWeek_10Changing(value);
					this.SendPropertyChanging();
					this._Week_10 = value;
					this.SendPropertyChanged("Week_10");
					this.OnWeek_10Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Week 11]", Storage="_Week_11", DbType="Int")]
		public System.Nullable<int> Week_11
		{
			get
			{
				return this._Week_11;
			}
			set
			{
				if ((this._Week_11 != value))
				{
					this.OnWeek_11Changing(value);
					this.SendPropertyChanging();
					this._Week_11 = value;
					this.SendPropertyChanged("Week_11");
					this.OnWeek_11Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Week 12]", Storage="_Week_12", DbType="Int")]
		public System.Nullable<int> Week_12
		{
			get
			{
				return this._Week_12;
			}
			set
			{
				if ((this._Week_12 != value))
				{
					this.OnWeek_12Changing(value);
					this.SendPropertyChanging();
					this._Week_12 = value;
					this.SendPropertyChanged("Week_12");
					this.OnWeek_12Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Week 13]", Storage="_Week_13", DbType="Int")]
		public System.Nullable<int> Week_13
		{
			get
			{
				return this._Week_13;
			}
			set
			{
				if ((this._Week_13 != value))
				{
					this.OnWeek_13Changing(value);
					this.SendPropertyChanging();
					this._Week_13 = value;
					this.SendPropertyChanged("Week_13");
					this.OnWeek_13Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Week 14]", Storage="_Week_14", DbType="Int")]
		public System.Nullable<int> Week_14
		{
			get
			{
				return this._Week_14;
			}
			set
			{
				if ((this._Week_14 != value))
				{
					this.OnWeek_14Changing(value);
					this.SendPropertyChanging();
					this._Week_14 = value;
					this.SendPropertyChanged("Week_14");
					this.OnWeek_14Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Week 15]", Storage="_Week_15", DbType="Int")]
		public System.Nullable<int> Week_15
		{
			get
			{
				return this._Week_15;
			}
			set
			{
				if ((this._Week_15 != value))
				{
					this.OnWeek_15Changing(value);
					this.SendPropertyChanging();
					this._Week_15 = value;
					this.SendPropertyChanged("Week_15");
					this.OnWeek_15Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Week 16]", Storage="_Week_16", DbType="Int")]
		public System.Nullable<int> Week_16
		{
			get
			{
				return this._Week_16;
			}
			set
			{
				if ((this._Week_16 != value))
				{
					this.OnWeek_16Changing(value);
					this.SendPropertyChanging();
					this._Week_16 = value;
					this.SendPropertyChanged("Week_16");
					this.OnWeek_16Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Week 17]", Storage="_Week_17", DbType="Int")]
		public System.Nullable<int> Week_17
		{
			get
			{
				return this._Week_17;
			}
			set
			{
				if ((this._Week_17 != value))
				{
					this.OnWeek_17Changing(value);
					this.SendPropertyChanging();
					this._Week_17 = value;
					this.SendPropertyChanged("Week_17");
					this.OnWeek_17Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Week 18]", Storage="_Week_18", DbType="Int")]
		public System.Nullable<int> Week_18
		{
			get
			{
				return this._Week_18;
			}
			set
			{
				if ((this._Week_18 != value))
				{
					this.OnWeek_18Changing(value);
					this.SendPropertyChanging();
					this._Week_18 = value;
					this.SendPropertyChanged("Week_18");
					this.OnWeek_18Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Week 19]", Storage="_Week_19", DbType="Int")]
		public System.Nullable<int> Week_19
		{
			get
			{
				return this._Week_19;
			}
			set
			{
				if ((this._Week_19 != value))
				{
					this.OnWeek_19Changing(value);
					this.SendPropertyChanging();
					this._Week_19 = value;
					this.SendPropertyChanged("Week_19");
					this.OnWeek_19Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Week 20]", Storage="_Week_20", DbType="Int")]
		public System.Nullable<int> Week_20
		{
			get
			{
				return this._Week_20;
			}
			set
			{
				if ((this._Week_20 != value))
				{
					this.OnWeek_20Changing(value);
					this.SendPropertyChanging();
					this._Week_20 = value;
					this.SendPropertyChanged("Week_20");
					this.OnWeek_20Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Week 21]", Storage="_Week_21", DbType="Int")]
		public System.Nullable<int> Week_21
		{
			get
			{
				return this._Week_21;
			}
			set
			{
				if ((this._Week_21 != value))
				{
					this.OnWeek_21Changing(value);
					this.SendPropertyChanging();
					this._Week_21 = value;
					this.SendPropertyChanged("Week_21");
					this.OnWeek_21Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Week 22]", Storage="_Week_22", DbType="Int")]
		public System.Nullable<int> Week_22
		{
			get
			{
				return this._Week_22;
			}
			set
			{
				if ((this._Week_22 != value))
				{
					this.OnWeek_22Changing(value);
					this.SendPropertyChanging();
					this._Week_22 = value;
					this.SendPropertyChanged("Week_22");
					this.OnWeek_22Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Week 23]", Storage="_Week_23", DbType="Int")]
		public System.Nullable<int> Week_23
		{
			get
			{
				return this._Week_23;
			}
			set
			{
				if ((this._Week_23 != value))
				{
					this.OnWeek_23Changing(value);
					this.SendPropertyChanging();
					this._Week_23 = value;
					this.SendPropertyChanged("Week_23");
					this.OnWeek_23Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Week 24]", Storage="_Week_24", DbType="Int")]
		public System.Nullable<int> Week_24
		{
			get
			{
				return this._Week_24;
			}
			set
			{
				if ((this._Week_24 != value))
				{
					this.OnWeek_24Changing(value);
					this.SendPropertyChanging();
					this._Week_24 = value;
					this.SendPropertyChanged("Week_24");
					this.OnWeek_24Changed();
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