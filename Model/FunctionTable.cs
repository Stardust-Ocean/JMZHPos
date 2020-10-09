using System;
namespace JMZHPos.Model
{
	/// <summary>
	/// FunctionTable:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class FunctionTable
	{
		public FunctionTable()
		{}
		#region Model
		private string _funid;
		private string _powerid;
		private string _funname;
		/// <summary>
		/// 
		/// </summary>
		public string FunId
		{
			set{ _funid=value;}
			get{return _funid;}
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
		public string FunName
		{
			set{ _funname=value;}
			get{return _funname;}
		}
		#endregion Model

	}
}

