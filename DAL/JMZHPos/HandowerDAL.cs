using System;
using System.Data;
using System.Text;
using System.Data.SQLite;
using Maticsoft.DBUtility;//Please add references
using JMZHPos.Model;
namespace JMZHPos.DAL.JMZHPos
{
	/// <summary>
	/// 数据访问类:Handower
	/// </summary>
	public partial class HandowerDAL
	{
		public HandowerDAL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQLite.GetMaxID("HanId", "Handower"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int HanId)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Handower");
			strSql.Append(" where HanId=@HanId");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@HanId", DbType.Int32,4)
			};
			parameters[0].Value = HanId;

			return DbHelperSQLite.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Handower model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Handower(");
			strSql.Append("HanTime,HanDate,HanPeo,HanMark)");
			strSql.Append(" values (");
			strSql.Append("@HanTime,@HanDate,@HanPeo,@HanMark)");
			strSql.Append(";select LAST_INSERT_ROWID()");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@HanTime", DbType.DateTime),
					new SQLiteParameter("@HanDate", DbType.DateTime),
					new SQLiteParameter("@HanPeo", DbType.String),
					new SQLiteParameter("@HanMark", DbType.String)};
			parameters[0].Value = model.HanTime;
			parameters[1].Value = model.HanDate;
			parameters[2].Value = model.HanPeo;
			parameters[3].Value = model.HanMark;

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
		public bool Update(Handower model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Handower set ");
			strSql.Append("HanTime=@HanTime,");
			strSql.Append("HanDate=@HanDate,");
			strSql.Append("HanPeo=@HanPeo,");
			strSql.Append("HanMark=@HanMark");
			strSql.Append(" where HanId=@HanId");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@HanTime", DbType.DateTime),
					new SQLiteParameter("@HanDate", DbType.DateTime),
					new SQLiteParameter("@HanPeo", DbType.String),
					new SQLiteParameter("@HanMark", DbType.String),
					new SQLiteParameter("@HanId", DbType.Int32,8)};
			parameters[0].Value = model.HanTime;
			parameters[1].Value = model.HanDate;
			parameters[2].Value = model.HanPeo;
			parameters[3].Value = model.HanMark;
			parameters[4].Value = model.HanId;

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
		public bool Delete(int HanId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Handower ");
			strSql.Append(" where HanId=@HanId");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@HanId", DbType.Int32,4)
			};
			parameters[0].Value = HanId;

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
		public bool DeleteList(string HanIdlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Handower ");
			strSql.Append(" where HanId in ("+HanIdlist + ")  ");
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
		public Handower GetModel(int HanId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select HanId,HanTime,HanDate,HanPeo,HanMark from Handower ");
			strSql.Append(" where HanId=@HanId");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@HanId", DbType.Int32,4)
			};
			parameters[0].Value = HanId;

			Handower model=new Handower();
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
		public Handower DataRowToModel(DataRow row)
		{
			Handower model=new Handower();
			if (row != null)
			{
				if(row["HanId"]!=null && row["HanId"].ToString()!="")
				{
					model.HanId=int.Parse(row["HanId"].ToString());
				}
				if(row["HanTime"]!=null && row["HanTime"].ToString()!="")
				{
					model.HanTime=DateTime.Parse(row["HanTime"].ToString());
				}
				if(row["HanDate"]!=null && row["HanDate"].ToString()!="")
				{
					model.HanDate=DateTime.Parse(row["HanDate"].ToString());
				}
				if(row["HanPeo"]!=null)
				{
					model.HanPeo=row["HanPeo"].ToString();
				}
				if(row["HanMark"]!=null)
				{
					model.HanMark=row["HanMark"].ToString();
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
			strSql.Append("select HanId,HanTime,HanDate,HanPeo,HanMark ");
			strSql.Append(" FROM Handower ");
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
			strSql.Append("select count(1) FROM Handower ");
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
				strSql.Append("order by T.HanId desc");
			}
			strSql.Append(")AS Row, T.*  from Handower T ");
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
			parameters[0].Value = "Handower";
			parameters[1].Value = "HanId";
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

