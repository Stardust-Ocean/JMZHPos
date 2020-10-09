using System;
namespace JMZHPos.Model
{
	/// <summary>
	/// Handower:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Handower
	{
		public Handower()
		{}
		#region Model
		private int _hanid;
		private DateTime? _hantime;
		private DateTime? _handate;
		private string _hanpeo;
		private string _hanmark;
		/// <summary>
		/// 
		/// </summary>
		public int HanId
		{
			set{ _hanid=value;}
			get{return _hanid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? HanTime
		{
			set{ _hantime=value;}
			get{return _hantime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? HanDate
		{
			set{ _handate=value;}
			get{return _handate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string HanPeo
		{
			set{ _hanpeo=value;}
			get{return _hanpeo;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string HanMark
		{
			set{ _hanmark=value;}
			get{return _hanmark;}
		}
		#endregion Model

	}
}

