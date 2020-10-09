using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using JMZHPos.Model; using JMZHPos.DAL.JMZHPos;
namespace JMZHPos.BLL.JMZHPos
{
	/// <summary>
	/// PreferentialItems
	/// </summary>
	public partial class PreferentialItemsBLL
    {
		private readonly PreferentialItemsDAL dal =new PreferentialItemsDAL();
		public PreferentialItemsBLL()
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
		public bool Exists(int PrefId)
		{
			return dal.Exists(PrefId);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(PreferentialItems model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(PreferentialItems model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int PrefId)
		{
			
			return dal.Delete(PrefId);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string PrefIdlist )
		{
			return dal.DeleteList(PrefIdlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public PreferentialItems GetModel(int PrefId)
		{
			
			return dal.GetModel(PrefId);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public PreferentialItems GetModelByCache(int PrefId)
		{
			
			string CacheKey = "PreferentialItemsModel-" + PrefId;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(PrefId);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (PreferentialItems)objModel;
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
		public List<PreferentialItems> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<PreferentialItems> DataTableToList(DataTable dt)
		{
			List<PreferentialItems> modelList = new List<PreferentialItems>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				PreferentialItems model;
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

