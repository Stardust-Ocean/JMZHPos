using System;
namespace JMZHPos.Model
{
	/// <summary>
	/// GoodsDepositRecord:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class GoodsDepositRecord
	{
		public GoodsDepositRecord()
		{}
		#region Model
		private int _gd_id;
		private int? _id;
		private DateTime? _gd_date;
		private string _gd_number;
		private string _gd_shop;
		private string _gd_access;
		private int? _gd_sum;
		private string _gd_remark;
		private string _gd_peo;
		/// <summary>
		/// 
		/// </summary>
		public int GD_ID
		{
			set{ _gd_id=value;}
			get{return _gd_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? GD_Date
		{
			set{ _gd_date=value;}
			get{return _gd_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GD_Number
		{
			set{ _gd_number=value;}
			get{return _gd_number;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GD_Shop
		{
			set{ _gd_shop=value;}
			get{return _gd_shop;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GD_Access
		{
			set{ _gd_access=value;}
			get{return _gd_access;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? GD_Sum
		{
			set{ _gd_sum=value;}
			get{return _gd_sum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GD_Remark
		{
			set{ _gd_remark=value;}
			get{return _gd_remark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GD_Peo
		{
			set{ _gd_peo=value;}
			get{return _gd_peo;}
		}
		#endregion Model

	}
}

