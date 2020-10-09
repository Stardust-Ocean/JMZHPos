using System;
namespace JMZHPos.Model
{
	/// <summary>
	/// PowerTable:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class PowerTable
	{
		public PowerTable()
		{}
		#region Model
		private int _powerid;
		private string _powername;
		private string _funcid;
		private int? _userid;
		/// <summary>
		/// 
		/// </summary>
		public int PowerID
		{
			set{ _powerid=value;}
			get{return _powerid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PowerName
		{
			set{ _powername=value;}
			get{return _powername;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FuncId
		{
			set{ _funcid=value;}
			get{return _funcid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? UserId
		{
			set{ _userid=value;}
			get{return _userid;}
		}
		#endregion Model

	}
}

