using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using JMZHPos.Model; using JMZHPos.DAL.JMZHPos;

namespace JMZHPos.BLL.JMZHPos
{
	/// <summary>
	/// CardTable
	/// </summary>
	public partial class CardTableBLL
	{
		private readonly CardTableDAL dal=new CardTableDAL();
		public CardTableBLL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
			return dal.GetMaxId();
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int CartID)
		{
			return dal.Exists(CartID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(CardTable model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(CardTable model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int CartID)
		{
			
			return dal.Delete(CartID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string CartIDlist )
		{
			return dal.DeleteList(CartIDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public CardTable GetModel(int CartID)
		{
			
			return dal.GetModel(CartID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public CardTable GetModelByCache(int CartID)
		{
			
			string CacheKey = "CardTableModel-" + CartID;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(CartID);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (CardTable)objModel;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<CardTable> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<CardTable> DataTableToList(DataTable dt)
		{
			List<CardTable> modelList = new List<CardTable>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				CardTable model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = dal.DataRowToModel(dt.Rows[n]);
					if (model != null)
					{
						modelList.Add(model);
					}
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			return dal.GetRecordCount(strWhere);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			return dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

