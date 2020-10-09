using System;
using System.Data;
using System.Text;
using System.Data.SQLite;
using Maticsoft.DBUtility;//Please add references
using JMZHPos.Model;

namespace JMZHPos.DAL.JMZHPos
{
	/// <summary>
	/// 数据访问类:FunctionTable
	/// </summary>
	public partial class FunctionTableDAL
	{
		public FunctionTableDAL()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(FunctionTable model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into FunctionTable(");
			strSql.Append("FunId,PowerId,FunName)");
			strSql.Append(" values (");
			strSql.Append("@FunId,@PowerId,@FunName)");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@FunId", DbType.String),
					new SQLiteParameter("@PowerId", DbType.String),
					new SQLiteParameter("@FunName", DbType.String)};
			parameters[0].Value = model.FunId;
			parameters[1].Value = model.PowerId;
			parameters[2].Value = model.FunName;

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
		/// 更新一条数据
		/// </summary>
		public bool Update(FunctionTable model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update FunctionTable set ");
			strSql.Append("FunId=@FunId,");
			strSql.Append("PowerId=@PowerId,");
			strSql.Append("FunName=@FunName");
			strSql.Append(" where ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@FunId", DbType.String),
					new SQLiteParameter("@PowerId", DbType.String),
					new SQLiteParameter("@FunName", DbType.String)};
			parameters[0].Value = model.FunId;
			parameters[1].Value = model.PowerId;
			parameters[2].Value = model.FunName;

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
		public bool Delete()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from FunctionTable ");
			strSql.Append(" where ");
			SQLiteParameter[] parameters = {
			};

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
		/// 得到一个对象实体
		/// </summary>
		public FunctionTable GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select FunId,PowerId,FunName from FunctionTable ");
			strSql.Append(" where ");
			SQLiteParameter[] parameters = {
			};

			FunctionTable model=new FunctionTable();
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
		public FunctionTable DataRowToModel(DataRow row)
		{
			FunctionTable model=new FunctionTable();
			if (row != null)
			{
				if(row["FunId"]!=null)
				{
					model.FunId=row["FunId"].ToString();
				}
				if(row["PowerId"]!=null)
				{
					model.PowerId=row["PowerId"].ToString();
				}
				if(row["FunName"]!=null)
				{
					model.FunName=row["FunName"].ToString();
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
			strSql.Append("select FunId,PowerId,FunName ");
			strSql.Append(" FROM FunctionTable ");
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
			strSql.Append("select count(1) FROM FunctionTable ");
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
				strSql.Append("order by T.CartID desc");
			}
			strSql.Append(")AS Row, T.*  from FunctionTable T ");
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
			parameters[0].Value = "FunctionTable";
			parameters[1].Value = "CartID";
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

