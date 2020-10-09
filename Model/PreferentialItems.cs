using System;
namespace JMZHPos.Model
{
	/// <summary>
	/// PreferentialItems:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class PreferentialItems
	{
		public PreferentialItems()
		{}
		#region Model
		private int _prefid;
		private string _prename;
		private string _predetal;
		private string _precontact;
		private string _prepatike;
		private string _prepeo;
		private DateTime? _predatetime;
		/// <summary>
		/// 
		/// </summary>
		public int PrefId
		{
			set{ _prefid=value;}
			get{return _prefid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PreName
		{
			set{ _prename=value;}
			get{return _prename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PreDetal
		{
			set{ _predetal=value;}
			get{return _predetal;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PreContact
		{
			set{ _precontact=value;}
			get{return _precontact;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PrePatike
		{
			set{ _prepatike=value;}
			get{return _prepatike;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PrePeo
		{
			set{ _prepeo=value;}
			get{return _prepeo;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? PreDatetime
		{
			set{ _predatetime=value;}
			get{return _predatetime;}
		}
		#endregion Model

	}
}

