using System;
namespace JMZHPos.Model
{
	/// <summary>
	/// BalanceRecord:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class BalanceRecord
	{
		public BalanceRecord()
		{}
		#region Model
		private int _br_id;
		private string _me_id;
		private DateTime? _br_date;
		private decimal? _br_balance;
		private string _br_reson;
		private string _br_numer;
		private decimal? _br_surbalance;
		private string _br_peo;
		/// <summary>
		/// 
		/// </summary>
		public int BR_ID
		{
			set{ _br_id=value;}
			get{return _br_id;}
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
		public DateTime? BR_Date
		{
			set{ _br_date=value;}
			get{return _br_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? BR_Balance
		{
			set{ _br_balance=value;}
			get{return _br_balance;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BR_Reson
		{
			set{ _br_reson=value;}
			get{return _br_reson;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BR_Numer
		{
			set{ _br_numer=value;}
			get{return _br_numer;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? BR_SurBalance
		{
			set{ _br_surbalance=value;}
			get{return _br_surbalance;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BR_Peo
		{
			set{ _br_peo=value;}
			get{return _br_peo;}
		}
		#endregion Model

	}
}

