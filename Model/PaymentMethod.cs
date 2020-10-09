using System;
namespace JMZHPos.Model
{
	/// <summary>
	/// PaymentMethod:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class PaymentMethod
	{
		public PaymentMethod()
		{}
		#region Model
		private int _payid;
		private string _ordermunber;
		private string _payname;
		private string _payquick;
		private string _paymark;
		private int? _paybool;
		private decimal? _paynumid;
		private DateTime? _paydate;
		private string _paypeo;
		/// <summary>
		/// 
		/// </summary>
		public int PayId
		{
			set{ _payid=value;}
			get{return _payid;}
		}
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
		public string PayName
		{
			set{ _payname=value;}
			get{return _payname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PayQuick
		{
			set{ _payquick=value;}
			get{return _payquick;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PayMark
		{
			set{ _paymark=value;}
			get{return _paymark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Paybool
		{
			set{ _paybool=value;}
			get{return _paybool;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? PayNumId
		{
			set{ _paynumid=value;}
			get{return _paynumid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? PayDate
		{
			set{ _paydate=value;}
			get{return _paydate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PayPeo
		{
			set{ _paypeo=value;}
			get{return _paypeo;}
		}
		#endregion Model

	}
}

