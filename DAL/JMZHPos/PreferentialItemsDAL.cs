using System;
using System.Data;
using System.Text;
using System.Data.SQLite;
using Maticsoft.DBUtility;//Please add references
using JMZHPos.Model;
namespace JMZHPos.DAL.JMZHPos
{
	/// <summary>
	/// 数据访问类:PreferentialItems
	/// </summary>
	public partial class PreferentialItemsDAL
	{
		public PreferentialItemsDAL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQLite.GetMaxID("PrefId", "PreferentialItems"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int PrefId)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from PreferentialItems");
			strSql.Append(" where PrefId=@PrefId");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@PrefId", DbType.Int32,4)
			};
			parameters[0].Value = PrefId;

			return DbHelperSQLite.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(PreferentialItems model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into PreferentialItems(");
			strSql.Append("PreName,PreDetal,PreContact,PrePatike,PrePeo,PreDatetime)");
			strSql.Append(" values (");
			strSql.Append("@PreName,@PreDetal,@PreContact,@PrePatike,@PrePeo,@PreDatetime)");
			strSql.Append(";select LAST_INSERT_ROWID()");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@PreName", DbType.String,50),
					new SQLiteParameter("@PreDetal", DbType.String,50),
					new SQLiteParameter("@PreContact", DbType.String,50),
					new SQLiteParameter("@PrePatike", DbType.String,50),
					new SQLiteParameter("@PrePeo", DbType.String,50),
					new SQLiteParameter("@PreDatetime", DbType.DateTime)};
			parameters[0].Value = model.PreName;
			parameters[1].Value = model.PreDetal;
			parameters[2].Value = model.PreContact;
			parameters[3].Value = model.PrePatike;
			parameters[4].Value = model.PrePeo;
			parameters[5].Value = model.PreDatetime;

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
		public bool Update(PreferentialItems model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update PreferentialItems set ");
			strSql.Append("PreName=@PreName,");
			strSql.Append("PreDetal=@PreDetal,");
			strSql.Append("PreContact=@PreContact,");
			strSql.Append("PrePatike=@PrePatike,");
			strSql.Append("PrePeo=@PrePeo,");
			strSql.Append("PreDatetime=@PreDatetime");
			strSql.Append(" where PrefId=@PrefId");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@PreName", DbType.String,50),
					new SQLiteParameter("@PreDetal", DbType.String,50),
					new SQLiteParameter("@PreContact", DbType.String,50),
					new SQLiteParameter("@PrePatike", DbType.String,50),
					new SQLiteParameter("@PrePeo", DbType.String,50),
					new SQLiteParameter("@PreDatetime", DbType.DateTime),
					new SQLiteParameter("@PrefId", DbType.Int32,8)};
			parameters[0].Value = model.PreName;
			parameters[1].Value = model.PreDetal;
			parameters[2].Value = model.PreContact;
			parameters[3].Value = model.PrePatike;
			parameters[4].Value = model.PrePeo;
			parameters[5].Value = model.PreDatetime;
			parameters[6].Value = model.PrefId;

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
		public bool Delete(int PrefId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from PreferentialItems ");
			strSql.Append(" where PrefId=@PrefId");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@PrefId", DbType.Int32,4)
			};
			parameters[0].Value = PrefId;

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
		public bool DeleteList(string PrefIdlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from PreferentialItems ");
			strSql.Append(" where PrefId in ("+PrefIdlist + ")  ");
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
		public PreferentialItems GetModel(int PrefId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select PrefId,PreName,PreDetal,PreContact,PrePatike,PrePeo,PreDatetime from PreferentialItems ");
			strSql.Append(" where PrefId=@PrefId");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@PrefId", DbType.Int32,4)
			};
			parameters[0].Value = PrefId;

			PreferentialItems model=new PreferentialItems();
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
		public PreferentialItems DataRowToModel(DataRow row)
		{
			PreferentialItems model=new PreferentialItems();
			if (row != null)
			{
				if(row["PrefId"]!=null && row["PrefId"].ToString()!="")
				{
					model.PrefId=int.Parse(row["PrefId"].ToString());
				}
				if(row["PreName"]!=null)
				{
					model.PreName=row["PreName"].ToString();
				}
				if(row["PreDetal"]!=null)
				{
					model.PreDetal=row["PreDetal"].ToString();
				}
				if(row["PreContact"]!=null)
				{
					model.PreContact=row["PreContact"].ToString();
				}
				if(row["PrePatike"]!=null)
				{
					model.PrePatike=row["PrePatike"].ToString();
				}
				if(row["PrePeo"]!=null)
				{
					model.PrePeo=row["PrePeo"].ToString();
				}
				if(row["PreDatetime"]!=null && row["PreDatetime"].ToString()!="")
				{
					model.PreDatetime=DateTime.Parse(row["PreDatetime"].ToString());
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
			strSql.Append("select PrefId,PreName,PreDetal,PreContact,PrePatike,PrePeo,PreDatetime ");
			strSql.Append(" FROM PreferentialItems ");
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
			strSql.Append("select count(1) FROM PreferentialItems ");
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
				strSql.Append("order by T.PrefId desc");
			}
			strSql.Append(")AS Row, T.*  from PreferentialItems T ");
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
			parameters[0].Value = "PreferentialItems";
			parameters[1].Value = "PrefId";
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

