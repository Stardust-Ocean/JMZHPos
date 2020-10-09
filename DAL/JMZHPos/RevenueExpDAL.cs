using System;
using System.Data;
using System.Text;
using System.Data.SQLite;
using Maticsoft.DBUtility;//Please add references
using JMZHPos.Model;
namespace JMZHPos.DAL.JMZHPos
{
	/// <summary>
	/// 数据访问类:RevenueExp
	/// </summary>
	public partial class RevenueExpDAL
	{
		public RevenueExpDAL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQLite.GetMaxID("ReId", "RevenueExp"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ReId)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from RevenueExp");
			strSql.Append(" where ReId=@ReId");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@ReId", DbType.Int32,4)
			};
			parameters[0].Value = ReId;

			return DbHelperSQLite.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(RevenueExp model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into RevenueExp(");
			strSql.Append("ReTime,ReExp,ReCost,ReMark,RePeo,ReCreateTime)");
			strSql.Append(" values (");
			strSql.Append("@ReTime,@ReExp,@ReCost,@ReMark,@RePeo,@ReCreateTime)");
			strSql.Append(";select LAST_INSERT_ROWID()");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@ReTime", DbType.DateTime),
					new SQLiteParameter("@ReExp", DbType.String,50),
					new SQLiteParameter("@ReCost", DbType.String,50),
					new SQLiteParameter("@ReMark", DbType.String,50),
					new SQLiteParameter("@RePeo", DbType.String,50),
					new SQLiteParameter("@ReCreateTime", DbType.DateTime)};
			parameters[0].Value = model.ReTime;
			parameters[1].Value = model.ReExp;
			parameters[2].Value = model.ReCost;
			parameters[3].Value = model.ReMark;
			parameters[4].Value = model.RePeo;
			parameters[5].Value = model.ReCreateTime;

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
		public bool Update(RevenueExp model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update RevenueExp set ");
			strSql.Append("ReTime=@ReTime,");
			strSql.Append("ReExp=@ReExp,");
			strSql.Append("ReCost=@ReCost,");
			strSql.Append("ReMark=@ReMark,");
			strSql.Append("RePeo=@RePeo,");
			strSql.Append("ReCreateTime=@ReCreateTime");
			strSql.Append(" where ReId=@ReId");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@ReTime", DbType.DateTime),
					new SQLiteParameter("@ReExp", DbType.String,50),
					new SQLiteParameter("@ReCost", DbType.String,50),
					new SQLiteParameter("@ReMark", DbType.String,50),
					new SQLiteParameter("@RePeo", DbType.String,50),
					new SQLiteParameter("@ReCreateTime", DbType.DateTime),
					new SQLiteParameter("@ReId", DbType.Int32,8)};
			parameters[0].Value = model.ReTime;
			parameters[1].Value = model.ReExp;
			parameters[2].Value = model.ReCost;
			parameters[3].Value = model.ReMark;
			parameters[4].Value = model.RePeo;
			parameters[5].Value = model.ReCreateTime;
			parameters[6].Value = model.ReId;

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
		public bool Delete(int ReId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from RevenueExp ");
			strSql.Append(" where ReId=@ReId");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@ReId", DbType.Int32,4)
			};
			parameters[0].Value = ReId;

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
		public bool DeleteList(string ReIdlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from RevenueExp ");
			strSql.Append(" where ReId in ("+ReIdlist + ")  ");
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
		public RevenueExp GetModel(int ReId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ReId,ReTime,ReExp,ReCost,ReMark,RePeo,ReCreateTime from RevenueExp ");
			strSql.Append(" where ReId=@ReId");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@ReId", DbType.Int32,4)
			};
			parameters[0].Value = ReId;

			RevenueExp model=new RevenueExp();
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
		public RevenueExp DataRowToModel(DataRow row)
		{
			RevenueExp model=new RevenueExp();
			if (row != null)
			{
				if(row["ReId"]!=null && row["ReId"].ToString()!="")
				{
					model.ReId=int.Parse(row["ReId"].ToString());
				}
				if(row["ReTime"]!=null && row["ReTime"].ToString()!="")
				{
					model.ReTime=DateTime.Parse(row["ReTime"].ToString());
				}
				if(row["ReExp"]!=null)
				{
					model.ReExp=row["ReExp"].ToString();
				}
				if(row["ReCost"]!=null)
				{
					model.ReCost=row["ReCost"].ToString();
				}
				if(row["ReMark"]!=null)
				{
					model.ReMark=row["ReMark"].ToString();
				}
				if(row["RePeo"]!=null)
				{
					model.RePeo=row["RePeo"].ToString();
				}
				if(row["ReCreateTime"]!=null && row["ReCreateTime"].ToString()!="")
				{
					model.ReCreateTime=DateTime.Parse(row["ReCreateTime"].ToString());
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
			strSql.Append("select ReId,ReTime,ReExp,ReCost,ReMark,RePeo,ReCreateTime ");
			strSql.Append(" FROM RevenueExp ");
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
			strSql.Append("select count(1) FROM RevenueExp ");
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
				strSql.Append("order by T.ReId desc");
			}
			strSql.Append(")AS Row, T.*  from RevenueExp T ");
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
			parameters[0].Value = "RevenueExp";
			parameters[1].Value = "ReId";
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

