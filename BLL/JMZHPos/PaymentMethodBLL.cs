using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using JMZHPos.Model; using JMZHPos.DAL.JMZHPos;
namespace JMZHPos.BLL.JMZHPos
{
	/// <summary>
	/// PaymentMethod
	/// </summary>
	public partial class PaymentMethodBLL
    {
		private readonly PaymentMethodDAL dal =new PaymentMethodDAL();
		public PaymentMethodBLL()
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
		public bool Exists(int PayId)
		{
			return dal.Exists(PayId);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(PaymentMethod model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(PaymentMethod model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int PayId)
		{
			
			return dal.Delete(PayId);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string PayIdlist )
		{
			return dal.DeleteList(PayIdlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public PaymentMethod GetModel(int PayId)
		{
			
			return dal.GetModel(PayId);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public PaymentMethod GetModelByCache(int PayId)
		{
			
			string CacheKey = "PaymentMethodModel-" + PayId;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(PayId);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (PaymentMethod)objModel;
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
		public List<PaymentMethod> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<PaymentMethod> DataTableToList(DataTable dt)
		{
			List<PaymentMethod> modelList = new List<PaymentMethod>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				PaymentMethod model;
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

