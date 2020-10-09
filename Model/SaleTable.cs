using System;
namespace JMZHPos.Model
{
	/// <summary>
	/// SaleTable:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class SaleTable
	{
		public SaleTable()
		{}
		#region Model
		private int _saleid;
		private string _salenum;
		private string _salename;
		private decimal? _salecomm;
		private string _saletel;
		private decimal? _saleprice;
		private string _saleaderss;
		private DateTime? _saledate;
		private string _salepeo;
		private string _salequota;
		private string _salequotasum;
		private decimal? _salequotanum;
		private string _salecommsouce;
		/// <summary>
		/// 
		/// </summary>
		public int SaleId
		{
			set{ _saleid=value;}
			get{return _saleid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SaleNum
		{
			set{ _salenum=value;}
			get{return _salenum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SaleName
		{
			set{ _salename=value;}
			get{return _salename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? SaleComm
		{
			set{ _salecomm=value;}
			get{return _salecomm;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SaleTel
		{
			set{ _saletel=value;}
			get{return _saletel;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? SalePrice
		{
			set{ _saleprice=value;}
			get{return _saleprice;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SaleAderss
		{
			set{ _saleaderss=value;}
			get{return _saleaderss;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? SaleDate
		{
			set{ _saledate=value;}
			get{return _saledate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SalePeo
		{
			set{ _salepeo=value;}
			get{return _salepeo;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SaleQuota
		{
			set{ _salequota=value;}
			get{return _salequota;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SaleQuotaSum
		{
			set{ _salequotasum=value;}
			get{return _salequotasum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? SaleQuotaNum
		{
			set{ _salequotanum=value;}
			get{return _salequotanum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SaleCommSouce
		{
			set{ _salecommsouce=value;}
			get{return _salecommsouce;}
		}
		#endregion Model

	}
}

