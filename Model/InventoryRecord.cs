using System;
namespace JMZHPos.Model
{
	/// <summary>
	/// InventoryRecord:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class InventoryRecord
	{
		public InventoryRecord()
		{}
		#region Model
		private int _ir_id;
		private string _commo_id;
		private DateTime? _id_date;
		private string _ir_type;
		private decimal? _ir_num;
		private string _ir_comid;
		private string _ir_nmae;
		private string _ir_pie;
		private decimal? _ir_sum;
		private decimal? _ir_amy;
		private string _ir_sp;
		private string _ir_remark;
		private string _ir_peo;
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
		public string Commo_Id
		{
			set{ _commo_id=value;}
			get{return _commo_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? ID_Date
		{
			set{ _id_date=value;}
			get{return _id_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string IR_Type
		{
			set{ _ir_type=value;}
			get{return _ir_type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? IR_Num
		{
			set{ _ir_num=value;}
			get{return _ir_num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string IR_CoMID
		{
			set{ _ir_comid=value;}
			get{return _ir_comid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string IR_Nmae
		{
			set{ _ir_nmae=value;}
			get{return _ir_nmae;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string IR_Pie
		{
			set{ _ir_pie=value;}
			get{return _ir_pie;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? IR_Sum
		{
			set{ _ir_sum=value;}
			get{return _ir_sum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? IR_Amy
		{
			set{ _ir_amy=value;}
			get{return _ir_amy;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string IR_SP
		{
			set{ _ir_sp=value;}
			get{return _ir_sp;}
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
		public string IR_Peo
		{
			set{ _ir_peo=value;}
			get{return _ir_peo;}
		}
		#endregion Model

	}
}

