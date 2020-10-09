using System;
using System.Data;
using System.Text;
using System.Data.SQLite;
using Maticsoft.DBUtility;//Please add references
using JMZHPos.Model;
namespace JMZHPos.DAL.JMZHPos
{
	/// <summary>
	/// 数据访问类:MeSubCard
	/// </summary>
	public partial class MeSubCardDAL
	{
		public MeSubCardDAL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQLite.GetMaxID("Me_Id", "MeSubCard"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Me_Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from MeSubCard");
			strSql.Append(" where Me_Id=@Me_Id");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@Me_Id", DbType.Int32,4)
			};
			parameters[0].Value = Me_Id;

			return DbHelperSQLite.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(MeSubCard model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into MeSubCard(");
			strSql.Append("MC_MEID,MC_CID,MC_CreateTime,MC_Pay)");
			strSql.Append(" values (");
			strSql.Append("@MC_MEID,@MC_CID,@MC_CreateTime,@MC_Pay)");
			strSql.Append(";select LAST_INSERT_ROWID()");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@MC_MEID", DbType.String,50),
					new SQLiteParameter("@MC_CID", DbType.String,50),
					new SQLiteParameter("@MC_CreateTime", DbType.DateTime),
					new SQLiteParameter("@MC_Pay", DbType.String,50)};
			parameters[0].Value = model.MC_MEID;
			parameters[1].Value = model.MC_CID;
			parameters[2].Value = model.MC_CreateTime;
			parameters[3].Value = model.MC_Pay;

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
		public bool Update(MeSubCard model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update MeSubCard set ");
			strSql.Append("MC_MEID=@MC_MEID,");
			strSql.Append("MC_CID=@MC_CID,");
			strSql.Append("MC_CreateTime=@MC_CreateTime,");
			strSql.Append("MC_Pay=@MC_Pay");
			strSql.Append(" where Me_Id=@Me_Id");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@MC_MEID", DbType.String,50),
					new SQLiteParameter("@MC_CID", DbType.String,50),
					new SQLiteParameter("@MC_CreateTime", DbType.DateTime),
					new SQLiteParameter("@MC_Pay", DbType.String,50),
					new SQLiteParameter("@Me_Id", DbType.Int32,8)};
			parameters[0].Value = model.MC_MEID;
			parameters[1].Value = model.MC_CID;
			parameters[2].Value = model.MC_CreateTime;
			parameters[3].Value = model.MC_Pay;
			parameters[4].Value = model.Me_Id;

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
		public bool Delete(int Me_Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from MeSubCard ");
			strSql.Append(" where Me_Id=@Me_Id");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@Me_Id", DbType.Int32,4)
			};
			parameters[0].Value = Me_Id;

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
		public bool DeleteList(string Me_Idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from MeSubCard ");
			strSql.Append(" where Me_Id in ("+Me_Idlist + ")  ");
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
		public MeSubCard GetModel(int Me_Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Me_Id,MC_MEID,MC_CID,MC_CreateTime,MC_Pay from MeSubCard ");
			strSql.Append(" where Me_Id=@Me_Id");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@Me_Id", DbType.Int32,4)
			};
			parameters[0].Value = Me_Id;

			MeSubCard model=new MeSubCard();
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
		public MeSubCard DataRowToModel(DataRow row)
		{
			MeSubCard model=new MeSubCard();
			if (row != null)
			{
				if(row["Me_Id"]!=null && row["Me_Id"].ToString()!="")
				{
					model.Me_Id=int.Parse(row["Me_Id"].ToString());
				}
				if(row["MC_MEID"]!=null)
				{
					model.MC_MEID=row["MC_MEID"].ToString();
				}
				if(row["MC_CID"]!=null)
				{
					model.MC_CID=row["MC_CID"].ToString();
				}
				if(row["MC_CreateTime"]!=null && row["MC_CreateTime"].ToString()!="")
				{
					model.MC_CreateTime=DateTime.Parse(row["MC_CreateTime"].ToString());
				}
				if(row["MC_Pay"]!=null)
				{
					model.MC_Pay=row["MC_Pay"].ToString();
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
			strSql.Append("select Me_Id,MC_MEID,MC_CID,MC_CreateTime,MC_Pay ");
			strSql.Append(" FROM MeSubCard ");
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
			strSql.Append("select count(1) FROM MeSubCard ");
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
				strSql.Append("order by T.Me_Id desc");
			}
			strSql.Append(")AS Row, T.*  from MeSubCard T ");
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
			parameters[0].Value = "MeSubCard";
			parameters[1].Value = "Me_Id";
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

