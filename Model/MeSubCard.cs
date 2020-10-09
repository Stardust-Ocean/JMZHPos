using System;
namespace JMZHPos.Model
{
	/// <summary>
	/// MeSubCard:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class MeSubCard
	{
		public MeSubCard()
		{}
		#region Model
		private int _me_id;
		private string _mc_meid;
		private string _mc_cid;
		private DateTime? _mc_createtime;
		private string _mc_pay;
		/// <summary>
		/// 
		/// </summary>
		public int Me_Id
		{
			set{ _me_id=value;}
			get{return _me_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MC_MEID
		{
			set{ _mc_meid=value;}
			get{return _mc_meid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MC_CID
		{
			set{ _mc_cid=value;}
			get{return _mc_cid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? MC_CreateTime
		{
			set{ _mc_createtime=value;}
			get{return _mc_createtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MC_Pay
		{
			set{ _mc_pay=value;}
			get{return _mc_pay;}
		}
		#endregion Model

	}
}

