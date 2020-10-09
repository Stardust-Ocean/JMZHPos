using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using JMZHPos.Model; using JMZHPos.DAL.JMZHPos;
namespace JMZHPos.BLL.JMZHPos
{
	/// <summary>
	/// InventoryRecord
	/// </summary>
	public partial class InventoryRecordBLL
    {
		private readonly InventoryRecordDAL dal =new InventoryRecordDAL();
		public InventoryRecordBLL()
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
		public bool Exists(int IR_ID)
		{
			return dal.Exists(IR_ID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(InventoryRecord model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(InventoryRecord model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int IR_ID)
		{
			
			return dal.Delete(IR_ID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string IR_IDlist )
		{
			return dal.DeleteList(IR_IDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public InventoryRecord GetModel(int IR_ID)
		{
			
			return dal.GetModel(IR_ID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public InventoryRecord GetModelByCache(int IR_ID)
		{
			
			string CacheKey = "InventoryRecordModel-" + IR_ID;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(IR_ID);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (InventoryRecord)objModel;
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
		public List<InventoryRecord> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<InventoryRecord> DataTableToList(DataTable dt)
		{
			List<InventoryRecord> modelList = new List<InventoryRecord>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				InventoryRecord model;
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

