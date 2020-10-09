using System;
namespace JMZHPos.Model
{
	/// <summary>
	/// MemberLevel:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class MemberLevel
	{
		public MemberLevel()
		{}
		#region Model
		private int _livelid;
		private string _memberlivel;
		private double? _me_discount;
		private double? _me_num;
		private int? _me_part;
		private DateTime? _me_date;
		private string _me_peo;
		private string _me_remark;
		/// <summary>
		/// 
		/// </summary>
		public int LivelId
		{
			set{ _livelid=value;}
			get{return _livelid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MemberLivel
		{
			set{ _memberlivel=value;}
			get{return _memberlivel;}
		}
		/// <summary>
		/// 
		/// </summary>
		public double? Me_Discount
		{
			set{ _me_discount=value;}
			get{return _me_discount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public double? Me_Num
		{
			set{ _me_num=value;}
			get{return _me_num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Me_Part
		{
			set{ _me_part=value;}
			get{return _me_part;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? Me_date
		{
			set{ _me_date=value;}
			get{return _me_date;}
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
		public string Me_Remark
		{
			set{ _me_remark=value;}
			get{return _me_remark;}
		}
		#endregion Model

	}
}

