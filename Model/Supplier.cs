using System;
namespace JMZHPos.Model
{
	/// <summary>
	/// Supplier:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Supplier
	{
		public Supplier()
		{}
		#region Model
		private int _sp_id;
		private string _commo_id;
		private string _sp_name;
		private string _sp_prople;
		private string _sp_tele;
		private string _sp_tel;
		private string _sp_email;
		private string _sp_adress;
		private string _sp_mark;
		/// <summary>
		/// 
		/// </summary>
		public int SP_ID
		{
			set{ _sp_id=value;}
			get{return _sp_id;}
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
		public string SP_Name
		{
			set{ _sp_name=value;}
			get{return _sp_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SP_Prople
		{
			set{ _sp_prople=value;}
			get{return _sp_prople;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SP_Tele
		{
			set{ _sp_tele=value;}
			get{return _sp_tele;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SP_Tel
		{
			set{ _sp_tel=value;}
			get{return _sp_tel;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SP_Email
		{
			set{ _sp_email=value;}
			get{return _sp_email;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SP_Adress
		{
			set{ _sp_adress=value;}
			get{return _sp_adress;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SP_Mark
		{
			set{ _sp_mark=value;}
			get{return _sp_mark;}
		}
		#endregion Model

	}
}

