using System;
namespace JMZHPos.Model
{
	/// <summary>
	/// Member:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Member
	{
		public Member()
		{}
		#region Model
		private int _me_id;
		private string _me_number;
		private string _me_password;
		private string _me_item;
		private string _me_name;
		private string _me_tel;
		private DateTime? _me_birthday;
		private string _me_adress;
		private DateTime? _me_newdatetime;
		private int? _me_effectivetime;
		private DateTime? _me_expirationtime;
		private decimal? _me_integral;
		private decimal? _me_balance;
		private string _me_remark;
		private int? _me_card;
		private string _me_peo;
		private DateTime? _me_date;
		/// <summary>
		/// 
		/// </summary>
		public int Me_Id
		{
			set{ _me_id=value;}
			get{return _me_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Me_Number
		{
			set{ _me_number=value;}
			get{return _me_number;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Me_Password
		{
			set{ _me_password=value;}
			get{return _me_password;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Me_Item
		{
			set{ _me_item=value;}
			get{return _me_item;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Me_Name
		{
			set{ _me_name=value;}
			get{return _me_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Me_Tel
		{
			set{ _me_tel=value;}
			get{return _me_tel;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? Me_Birthday
		{
			set{ _me_birthday=value;}
			get{return _me_birthday;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Me_adress
		{
			set{ _me_adress=value;}
			get{return _me_adress;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? Me_NewDatetime
		{
			set{ _me_newdatetime=value;}
			get{return _me_newdatetime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Me_EffectiveTime
		{
			set{ _me_effectivetime=value;}
			get{return _me_effectivetime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? Me_ExpirationTIme
		{
			set{ _me_expirationtime=value;}
			get{return _me_expirationtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Me_integral
		{
			set{ _me_integral=value;}
			get{return _me_integral;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Me_balance
		{
			set{ _me_balance=value;}
			get{return _me_balance;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Me_Remark
		{
			set{ _me_remark=value;}
			get{return _me_remark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Me_Card
		{
			set{ _me_card=value;}
			get{return _me_card;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Me_Peo
		{
			set{ _me_peo=value;}
			get{return _me_peo;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? Me_Date
		{
			set{ _me_date=value;}
			get{return _me_date;}
		}
		#endregion Model

	}
}

