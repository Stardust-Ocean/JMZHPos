using System;
namespace JMZHPos.Model
{
	/// <summary>
	/// RevenueExp:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class RevenueExp
	{
		public RevenueExp()
		{}
		#region Model
		private int _reid;
		private DateTime? _retime;
		private string _reexp;
		private string _recost;
		private string _remark;
		private string _repeo;
		private DateTime? _recreatetime;
		/// <summary>
		/// 
		/// </summary>
		public int ReId
		{
			set{ _reid=value;}
			get{return _reid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? ReTime
		{
			set{ _retime=value;}
			get{return _retime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ReExp
		{
			set{ _reexp=value;}
			get{return _reexp;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ReCost
		{
			set{ _recost=value;}
			get{return _recost;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ReMark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RePeo
		{
			set{ _repeo=value;}
			get{return _repeo;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? ReCreateTime
		{
			set{ _recreatetime=value;}
			get{return _recreatetime;}
		}
		#endregion Model

	}
}

