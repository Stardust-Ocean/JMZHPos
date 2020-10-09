using System;
namespace JMZHPos.Model
{
	/// <summary>
	/// CardTable:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class CardTable
	{
		public CardTable()
		{}
		#region Model
		private int _cartid;
		private int? _me_id;
		private string _cardnum;
		private string _cardname;
		private decimal? _cardprice;
		private int? _cardsum;
		private int? _cardshu;
		private int? _carddatenow;
		private DateTime? _cardnowtime;
		private DateTime? _cardoldtime;
		private DateTime? _cardcreatedate;
		private string _cardpeo;
		/// <summary>
		/// 
		/// </summary>
		public int CartID
		{
			set{ _cartid=value;}
			get{return _cartid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Me_Id
		{
			set{ _me_id=value;}
			get{return _me_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CardNum
		{
			set{ _cardnum=value;}
			get{return _cardnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CardName
		{
			set{ _cardname=value;}
			get{return _cardname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? CardPrice
		{
			set{ _cardprice=value;}
			get{return _cardprice;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? CardSUm
		{
			set{ _cardsum=value;}
			get{return _cardsum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? CardShu
		{
			set{ _cardshu=value;}
			get{return _cardshu;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? CardDateNow
		{
			set{ _carddatenow=value;}
			get{return _carddatenow;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? CardNowTime
		{
			set{ _cardnowtime=value;}
			get{return _cardnowtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? CardOldTime
		{
			set{ _cardoldtime=value;}
			get{return _cardoldtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? CardCreateDate
		{
			set{ _cardcreatedate=value;}
			get{return _cardcreatedate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CardPeo
		{
			set{ _cardpeo=value;}
			get{return _cardpeo;}
		}
		#endregion Model

	}
}

