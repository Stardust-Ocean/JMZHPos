using System;
using System.Data;
using System.Text;
using System.Data.SQLite;
using Maticsoft.DBUtility;//Please add references
using JMZHPos.Model;
namespace JMZHPos.DAL.JMZHPos
{
	/// <summary>
	/// 数据访问类:PowerTable
	/// </summary>
	public partial class PowerTableDAL
	{
		public PowerTableDAL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQLite.GetMaxID("PowerID", "PowerTable"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int PowerID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from PowerTable");
			strSql.Append(" where PowerID=@PowerID");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@PowerID", DbType.Int32,4)
			};
			parameters[0].Value = PowerID;

			return DbHelperSQLite.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(PowerTable model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into PowerTable(");
			strSql.Append("PowerName,FuncId,UserId)");
			strSql.Append(" values (");
			strSql.Append("@PowerName,@FuncId,@UserId)");
			strSql.Append(";select LAST_INSERT_ROWID()");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@PowerName", DbType.String),
					new SQLiteParameter("@FuncId", DbType.String),
					new SQLiteParameter("@UserId", DbType.Int32,4)};
			parameters[0].Value = model.PowerName;
			parameters[1].Value = model.FuncId;
			parameters[2].Value = model.UserId;

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
		public bool Update(PowerTable model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update PowerTable set ");
			strSql.Append("PowerName=@PowerName,");
			strSql.Append("FuncId=@FuncId,");
			strSql.Append("UserId=@UserId");
			strSql.Append(" where PowerID=@PowerID");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@PowerName", DbType.String),
					new SQLiteParameter("@FuncId", DbType.String),
					new SQLiteParameter("@UserId", DbType.Int32,4),
					new SQLiteParameter("@PowerID", DbType.Int32,8)};
			parameters[0].Value = model.PowerName;
			parameters[1].Value = model.FuncId;
			parameters[2].Value = model.UserId;
			parameters[3].Value = model.PowerID;

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
		public bool Delete(int PowerID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from PowerTable ");
			strSql.Append(" where PowerID=@PowerID");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@PowerID", DbType.Int32,4)
			};
			parameters[0].Value = PowerID;

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
		public bool DeleteList(string PowerIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from PowerTable ");
			strSql.Append(" where PowerID in ("+PowerIDlist + ")  ");
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
		public PowerTable GetModel(int PowerID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select PowerID,PowerName,FuncId,UserId from PowerTable ");
			strSql.Append(" where PowerID=@PowerID");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@PowerID", DbType.Int32,4)
			};
			parameters[0].Value = PowerID;

			PowerTable model=new PowerTable();
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
		public PowerTable DataRowToModel(DataRow row)
		{
			PowerTable model=new PowerTable();
			if (row != null)
			{
				if(row["PowerID"]!=null && row["PowerID"].ToString()!="")
				{
					model.PowerID=int.Parse(row["PowerID"].ToString());
				}
				if(row["PowerName"]!=null)
				{
					model.PowerName=row["PowerName"].ToString();
				}
				if(row["FuncId"]!=null)
				{
					model.FuncId=row["FuncId"].ToString();
				}
				if(row["UserId"]!=null && row["UserId"].ToString()!="")
				{
					model.UserId=int.Parse(row["UserId"].ToString());
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
			strSql.Append("select PowerID,PowerName,FuncId,UserId ");
			strSql.Append(" FROM PowerTable ");
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
			strSql.Append("select count(1) FROM PowerTable ");
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
				strSql.Append("order by T.PowerID desc");
			}
			strSql.Append(")AS Row, T.*  from PowerTable T ");
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
			parameters[0].Value = "PowerTable";
			parameters[1].Value = "PowerID";
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

