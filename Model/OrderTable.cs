using System;
namespace JMZHPos.Model
{
	/// <summary>
	/// OrderTable:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class OrderTable
	{
		public OrderTable()
		{}
		#region Model
		private string _ordermunber;
		private string _oemun;
		private string _orname;
		private decimal? _orpec;
		private decimal? _ordiscount;
		private decimal? _orpresion;
		private decimal? _orsum;
		private decimal? _ortatol;
		private decimal? _orstock;
		private DateTime? _orcreatetime;
		private string _orpeo;
		private int? _orbool;
		private string _orpayitem;
		private string _ormename;
		private int? _orintegral;
		private decimal? _orpayment;
		private decimal? _orchange;
		private string _ormark;
		private string _payitem;
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
		public string OeMun
		{
			set{ _oemun=value;}
			get{return _oemun;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OrName
		{
			set{ _orname=value;}
			get{return _orname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? OrPec
		{
			set{ _orpec=value;}
			get{return _orpec;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? OrDiscount
		{
			set{ _ordiscount=value;}
			get{return _ordiscount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Orpresion
		{
			set{ _orpresion=value;}
			get{return _orpresion;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? OrSum
		{
			set{ _orsum=value;}
			get{return _orsum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? OrTatol
		{
			set{ _ortatol=value;}
			get{return _ortatol;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? OrStock
		{
			set{ _orstock=value;}
			get{return _orstock;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? OrCreateTIme
		{
			set{ _orcreatetime=value;}
			get{return _orcreatetime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OrPeo
		{
			set{ _orpeo=value;}
			get{return _orpeo;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Orbool
		{
			set{ _orbool=value;}
			get{return _orbool;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OrPayItem
		{
			set{ _orpayitem=value;}
			get{return _orpayitem;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OrMeName
		{
			set{ _ormename=value;}
			get{return _ormename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? OrIntegral
		{
			set{ _orintegral=value;}
			get{return _orintegral;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? OrPayMent
		{
			set{ _orpayment=value;}
			get{return _orpayment;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? OrChange
		{
			set{ _orchange=value;}
			get{return _orchange;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OrMark
		{
			set{ _ormark=value;}
			get{return _ormark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PayItem
		{
			set{ _payitem=value;}
			get{return _payitem;}
		}
		#endregion Model

	}
}

