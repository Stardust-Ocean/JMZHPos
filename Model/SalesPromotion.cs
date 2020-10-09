using System;
namespace JMZHPos.Model
{
	/// <summary>
	/// SalesPromotion:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class SalesPromotion
	{
		public SalesPromotion()
		{}
		#region Model
		private int _sapr_id;
		private DateTime? _sap_datetime;
		private string _sapprename;
		private int? _sapbool;
		private string _participant;
		private string _sappeo;
		private DateTime? _sapcreatetime;
		private string _sapmark;
		/// <summary>
		/// 
		/// </summary>
		public int SaPr_Id
		{
			set{ _sapr_id=value;}
			get{return _sapr_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? Sap_Datetime
		{
			set{ _sap_datetime=value;}
			get{return _sap_datetime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SapPreName
		{
			set{ _sapprename=value;}
			get{return _sapprename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Sapbool
		{
			set{ _sapbool=value;}
			get{return _sapbool;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Participant
		{
			set{ _participant=value;}
			get{return _participant;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SapPeo
		{
			set{ _sappeo=value;}
			get{return _sappeo;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? SapCreateTIme
		{
			set{ _sapcreatetime=value;}
			get{return _sapcreatetime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SapMark
		{
			set{ _sapmark=value;}
			get{return _sapmark;}
		}
		#endregion Model

	}
}

