using System;
namespace JMZHPos.Model
{
	/// <summary>
	/// IntegralRecord:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class IntegralRecord
	{
		public IntegralRecord()
		{}
		#region Model
		private int _ir_id;
		private string _ir_meid;
		private DateTime? _ir_date;
		private string _ir_record;
		private string _ir_reason;
		private string _ir_remark;
		private decimal? _ir_resin;
		private string _ir_peo;
		private string _ir_refmark;
		/// <summary>
		/// 
		/// </summary>
		public int IR_ID
		{
			set{ _ir_id=value;}
			get{return _ir_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string IR_MeID
		{
			set{ _ir_meid=value;}
			get{return _ir_meid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? IR_Date
		{
			set{ _ir_date=value;}
			get{return _ir_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string IR_Record
		{
			set{ _ir_record=value;}
			get{return _ir_record;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string IR_Reason
		{
			set{ _ir_reason=value;}
			get{return _ir_reason;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string IR_Remark
		{
			set{ _ir_remark=value;}
			get{return _ir_remark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? IR_ResIn
		{
			set{ _ir_resin=value;}
			get{return _ir_resin;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string IR_Peo
		{
			set{ _ir_peo=value;}
			get{return _ir_peo;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string IR_RefMark
		{
			set{ _ir_refmark=value;}
			get{return _ir_refmark;}
		}
		#endregion Model

	}
}

