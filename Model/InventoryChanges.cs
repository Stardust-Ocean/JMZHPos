using System;
namespace JMZHPos.Model
{
	/// <summary>
	/// InventoryChanges:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class InventoryChanges
	{
		public InventoryChanges()
		{}
		#region Model
		private int _ic_id;
		private string _commo_id;
		private string _id_cord;
		private string _ic_nmae;
		private decimal? _ic_num;
		private decimal? _ic_company;
		private string _ic_specification;
		private string _ic_reason;
		private string _ic_remark;
		private DateTime? _ic_date;
		private string _ic_peo;
		/// <summary>
		/// 
		/// </summary>
		public int IC_ID
		{
			set{ _ic_id=value;}
			get{return _ic_id;}
		}
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
		public string ID_Cord
		{
			set{ _id_cord=value;}
			get{return _id_cord;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string IC_Nmae
		{
			set{ _ic_nmae=value;}
			get{return _ic_nmae;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? IC_Num
		{
			set{ _ic_num=value;}
			get{return _ic_num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? IC_Company
		{
			set{ _ic_company=value;}
			get{return _ic_company;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string IC_Specification
		{
			set{ _ic_specification=value;}
			get{return _ic_specification;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string IC_Reason
		{
			set{ _ic_reason=value;}
			get{return _ic_reason;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string IC_Remark
		{
			set{ _ic_remark=value;}
			get{return _ic_remark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? IC_Date
		{
			set{ _ic_date=value;}
			get{return _ic_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string IC_Peo
		{
			set{ _ic_peo=value;}
			get{return _ic_peo;}
		}
		#endregion Model

	}
}

