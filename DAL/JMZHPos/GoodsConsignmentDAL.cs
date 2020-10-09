using System;
using System.Data;
using System.Text;
using System.Data.SQLite;
using Maticsoft.DBUtility;//Please add references
using JMZHPos.Model;
namespace JMZHPos.DAL.JMZHPos
{
	/// <summary>
	/// 数据访问类:GoodsConsignment
	/// </summary>
	public partial class GoodsConsignmentDAL
	{
		public GoodsConsignmentDAL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQLite.GetMaxID("id", "GoodsConsignment"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from GoodsConsignment");
			strSql.Append(" where id=@id");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@id", DbType.Int32,4)
			};
			parameters[0].Value = id;

			return DbHelperSQLite.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(GoodsConsignment model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into GoodsConsignment(");
			strSql.Append("Me_Id,GC_Date,GC_Number,GC_Shop,GC_Num,GC_Remark,GC_NewDate,GC_Peo,GC_MeId)");
			strSql.Append(" values (");
			strSql.Append("@Me_Id,@GC_Date,@GC_Number,@GC_Shop,@GC_Num,@GC_Remark,@GC_NewDate,@GC_Peo,@GC_MeId)");
			strSql.Append(";select LAST_INSERT_ROWID()");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@Me_Id", DbType.String,50),
					new SQLiteParameter("@GC_Date", DbType.DateTime),
					new SQLiteParameter("@GC_Number", DbType.String,50),
					new SQLiteParameter("@GC_Shop", DbType.String,50),
					new SQLiteParameter("@GC_Num", DbType.String,50),
					new SQLiteParameter("@GC_Remark", DbType.String,100),
					new SQLiteParameter("@GC_NewDate", DbType.DateTime),
					new SQLiteParameter("@GC_Peo", DbType.String,50),
					new SQLiteParameter("@GC_MeId", DbType.String,50)};
			parameters[0].Value = model.Me_Id;
			parameters[1].Value = model.GC_Date;
			parameters[2].Value = model.GC_Number;
			parameters[3].Value = model.GC_Shop;
			parameters[4].Value = model.GC_Num;
			parameters[5].Value = model.GC_Remark;
			parameters[6].Value = model.GC_NewDate;
			parameters[7].Value = model.GC_Peo;
			parameters[8].Value = model.GC_MeId;

			object obj = DbHelperSQLite.GetSingle(strSql.ToString(),parameters);
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(GoodsConsignment model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update GoodsConsignment set ");
			strSql.Append("Me_Id=@Me_Id,");
			strSql.Append("GC_Date=@GC_Date,");
			strSql.Append("GC_Number=@GC_Number,");
			strSql.Append("GC_Shop=@GC_Shop,");
			strSql.Append("GC_Num=@GC_Num,");
			strSql.Append("GC_Remark=@GC_Remark,");
			strSql.Append("GC_NewDate=@GC_NewDate,");
			strSql.Append("GC_Peo=@GC_Peo,");
			strSql.Append("GC_MeId=@GC_MeId");
			strSql.Append(" where id=@id");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@Me_Id", DbType.String,50),
					new SQLiteParameter("@GC_Date", DbType.DateTime),
					new SQLiteParameter("@GC_Number", DbType.String,50),
					new SQLiteParameter("@GC_Shop", DbType.String,50),
					new SQLiteParameter("@GC_Num", DbType.String,50),
					new SQLiteParameter("@GC_Remark", DbType.String,100),
					new SQLiteParameter("@GC_NewDate", DbType.DateTime),
					new SQLiteParameter("@GC_Peo", DbType.String,50),
					new SQLiteParameter("@GC_MeId", DbType.String,50),
					new SQLiteParameter("@id", DbType.Int32,8)};
			parameters[0].Value = model.Me_Id;
			parameters[1].Value = model.GC_Date;
			parameters[2].Value = model.GC_Number;
			parameters[3].Value = model.GC_Shop;
			parameters[4].Value = model.GC_Num;
			parameters[5].Value = model.GC_Remark;
			parameters[6].Value = model.GC_NewDate;
			parameters[7].Value = model.GC_Peo;
			parameters[8].Value = model.GC_MeId;
			parameters[9].Value = model.id;

			int rows=DbHelperSQLite.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from GoodsConsignment ");
			strSql.Append(" where id=@id");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@id", DbType.Int32,4)
			};
			parameters[0].Value = id;

			int rows=DbHelperSQLite.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from GoodsConsignment ");
			strSql.Append(" where id in ("+idlist + ")  ");
			int rows=DbHelperSQLite.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public GoodsConsignment GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select id,Me_Id,GC_Date,GC_Number,GC_Shop,GC_Num,GC_Remark,GC_NewDate,GC_Peo,GC_MeId from GoodsConsignment ");
			strSql.Append(" where id=@id");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@id", DbType.Int32,4)
			};
			parameters[0].Value = id;

			GoodsConsignment model=new GoodsConsignment();
			DataSet ds=DbHelperSQLite.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public GoodsConsignment DataRowToModel(DataRow row)
		{
			GoodsConsignment model=new GoodsConsignment();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=int.Parse(row["id"].ToString());
				}
				if(row["Me_Id"]!=null)
				{
					model.Me_Id=row["Me_Id"].ToString();
				}
				if(row["GC_Date"]!=null && row["GC_Date"].ToString()!="")
				{
					model.GC_Date=DateTime.Parse(row["GC_Date"].ToString());
				}
				if(row["GC_Number"]!=null)
				{
					model.GC_Number=row["GC_Number"].ToString();
				}
				if(row["GC_Shop"]!=null)
				{
					model.GC_Shop=row["GC_Shop"].ToString();
				}
				if(row["GC_Num"]!=null)
				{
					model.GC_Num=row["GC_Num"].ToString();
				}
				if(row["GC_Remark"]!=null)
				{
					model.GC_Remark=row["GC_Remark"].ToString();
				}
				if(row["GC_NewDate"]!=null && row["GC_NewDate"].ToString()!="")
				{
					model.GC_NewDate=DateTime.Parse(row["GC_NewDate"].ToString());
				}
				if(row["GC_Peo"]!=null)
				{
					model.GC_Peo=row["GC_Peo"].ToString();
				}
				if(row["GC_MeId"]!=null)
				{
					model.GC_MeId=row["GC_MeId"].ToString();
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select id,Me_Id,GC_Date,GC_Number,GC_Shop,GC_Num,GC_Remark,GC_NewDate,GC_Peo,GC_MeId ");
			strSql.Append(" FROM GoodsConsignment ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQLite.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM GoodsConsignment ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.id desc");
			}
			strSql.Append(")AS Row, T.*  from GoodsConsignment T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQLite.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@tblName", DbType.VarChar, 255),
					new SQLiteParameter("@fldName", DbType.VarChar, 255),
					new SQLiteParameter("@PageSize", DbType.Int32),
					new SQLiteParameter("@PageIndex", DbType.Int32),
					new SQLiteParameter("@IsReCount", DbType.bit),
					new SQLiteParameter("@OrderType", DbType.bit),
					new SQLiteParameter("@strWhere", DbType.VarChar,1000),
					};
			parameters[0].Value = "GoodsConsignment";
			parameters[1].Value = "id";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQLite.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

