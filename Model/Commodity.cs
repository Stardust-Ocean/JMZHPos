using System;
namespace JMZHPos.Model
{
	/// <summary>
	/// Commodity:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Commodity
	{
		public Commodity()
		{}
		#region Model
		private string _commo_id;
		private string _co_number;
		private string _co_name;
		private decimal _co_price;
		private decimal _co_purchase;
		private decimal? _co_member;
		private decimal _co_instock;
		private decimal? _co_instockpre;
		private decimal? _co_sales;
		private string _co_unitpre;
		private string _co_specification;
		private string _co_item;
		private string _co_categories;
		private string _co_id;
		private DateTime? _co_creatdate;
		private int? _co_shelf;
		private string _co_shelflife;
		private string _co_b_nunber;
		private decimal? _co_jifen;
		private string _co_remark;
		private DateTime? _co_r_datetime;
		private string _co_peo;
		private string _co_name_pinyin;
		/// <summary>
		/// 
		/// </summary>
		public string Commo_Id
		{
			set{ _commo_id=value;}
			get{return _commo_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Co_Number
		{
			set{ _co_number=value;}
			get{return _co_number;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Co_Name
		{
			set{ _co_name=value;}
			get{return _co_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal Co_Price
		{
			set{ _co_price=value;}
			get{return _co_price;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal Co_Purchase
		{
			set{ _co_purchase=value;}
			get{return _co_purchase;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Co_Member
		{
			set{ _co_member=value;}
			get{return _co_member;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal Co_Instock
		{
			set{ _co_instock=value;}
			get{return _co_instock;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Co_InstockPre
		{
			set{ _co_instockpre=value;}
			get{return _co_instockpre;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Co_Sales
		{
			set{ _co_sales=value;}
			get{return _co_sales;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Co_UnitPre
		{
			set{ _co_unitpre=value;}
			get{return _co_unitpre;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Co_Specification
		{
			set{ _co_specification=value;}
			get{return _co_specification;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Co_Item
		{
			set{ _co_item=value;}
			get{return _co_item;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Co_Categories
		{
			set{ _co_categories=value;}
			get{return _co_categories;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Co_Id
		{
			set{ _co_id=value;}
			get{return _co_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? Co_creatDate
		{
			set{ _co_creatdate=value;}
			get{return _co_creatdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Co_Shelf
		{
			set{ _co_shelf=value;}
			get{return _co_shelf;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Co_ShelfLife
		{
			set{ _co_shelflife=value;}
			get{return _co_shelflife;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Co_b_Nunber
		{
			set{ _co_b_nunber=value;}
			get{return _co_b_nunber;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Co_JIfen
		{
			set{ _co_jifen=value;}
			get{return _co_jifen;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Co_Remark
		{
			set{ _co_remark=value;}
			get{return _co_remark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? Co_R_Datetime
		{
			set{ _co_r_datetime=value;}
			get{return _co_r_datetime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Co_Peo
		{
			set{ _co_peo=value;}
			get{return _co_peo;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Co_Name_PinYin
		{
			set{ _co_name_pinyin=value;}
			get{return _co_name_pinyin;}
		}
		#endregion Model

	}
}

