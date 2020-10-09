using System;
namespace JMZHPos.Model
{
	/// <summary>
	/// UserTable:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class UserTable
	{
		public UserTable()
		{}
		#region Model
		private int _userid;
		private int? _pow_powerid;
		private int? _hanid;
		private string _powerid;
		private string _username;
		private string _usertel;
		private DateTime? _usercreatetime;
		private string _userpeo;
		private string _useradress;
		private string _userpwd;
		/// <summary>
		/// 
		/// </summary>
		public int userID
		{
			set{ _userid=value;}
			get{return _userid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Pow_PowerID
		{
			set{ _pow_powerid=value;}
			get{return _pow_powerid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? HanId
		{
			set{ _hanid=value;}
			get{return _hanid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PowerId
		{
			set{ _powerid=value;}
			get{return _powerid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UserName
		{
			set{ _username=value;}
			get{return _username;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UserTel
		{
			set{ _usertel=value;}
			get{return _usertel;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? UserCreateTIme
		{
			set{ _usercreatetime=value;}
			get{return _usercreatetime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UserPeo
		{
			set{ _userpeo=value;}
			get{return _userpeo;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UserAdress
		{
			set{ _useradress=value;}
			get{return _useradress;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UserPwd
		{
			set{ _userpwd=value;}
			get{return _userpwd;}
		}
		#endregion Model

	}
}

