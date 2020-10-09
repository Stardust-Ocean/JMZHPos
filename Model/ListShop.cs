using System;
namespace JMZHPos.Model
{
	/// <summary>
	/// ListShop:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ListShop
	{
		public ListShop()
		{}
		#region Model
		private string _ordermunber;
		private DateTime? _l_time;
		private decimal? _l_amo;
		private string _l_mecard;
		private string _l_mark;
		/// <summary>
		/// 
		/// </summary>
		public string OrderMunber
		{
			set{ _ordermunber=value;}
			get{return _ordermunber;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? L_Time
		{
			set{ _l_time=value;}
			get{return _l_time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? L_Amo
		{
			set{ _l_amo=value;}
			get{return _l_amo;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string L_MeCard
		{
			set{ _l_mecard=value;}
			get{return _l_mecard;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string L_Mark
		{
			set{ _l_mark=value;}
			get{return _l_mark;}
		}
		#endregion Model

	}
}

