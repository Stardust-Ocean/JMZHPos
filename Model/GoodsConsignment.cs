using System;
namespace JMZHPos.Model
{
	/// <summary>
	/// GoodsConsignment:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class GoodsConsignment
	{
		public GoodsConsignment()
		{}
		#region Model
		private int _id;
		private string _me_id;
		private DateTime? _gc_date;
		private string _gc_number;
		private string _gc_shop;
		private string _gc_num;
		private string _gc_remark;
		private DateTime? _gc_newdate;
		private string _gc_peo;
		private string _gc_meid;
		/// <summary>
		/// 
		/// </summary>
		public int id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Me_Id
		{
			set{ _me_id=value;}
			get{return _me_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? GC_Date
		{
			set{ _gc_date=value;}
			get{return _gc_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GC_Number
		{
			set{ _gc_number=value;}
			get{return _gc_number;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GC_Shop
		{
			set{ _gc_shop=value;}
			get{return _gc_shop;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GC_Num
		{
			set{ _gc_num=value;}
			get{return _gc_num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GC_Remark
		{
			set{ _gc_remark=value;}
			get{return _gc_remark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? GC_NewDate
		{
			set{ _gc_newdate=value;}
			get{return _gc_newdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GC_Peo
		{
			set{ _gc_peo=value;}
			get{return _gc_peo;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GC_MeId
		{
			set{ _gc_meid=value;}
			get{return _gc_meid;}
		}
		#endregion Model

	}
}

