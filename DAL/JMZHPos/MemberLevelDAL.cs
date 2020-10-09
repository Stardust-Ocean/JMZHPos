using System;
using System.Data;
using System.Text;
using System.Data.SQLite;
using Maticsoft.DBUtility;//Please add references
using JMZHPos.Model;
namespace JMZHPos.DAL.JMZHPos
{
	/// <summary>
	/// 数据访问类:MemberLevel
	/// </summary>
	public partial class MemberLevelDAL
	{
		public MemberLevelDAL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQLite.GetMaxID("LivelId", "MemberLevel"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int LivelId)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from MemberLevel");
			strSql.Append(" where LivelId=@LivelId");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@LivelId", DbType.Int32,4)
			};
			parameters[0].Value = LivelId;

			return DbHelperSQLite.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(MemberLevel model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into MemberLevel(");
			strSql.Append("MemberLivel,Me_Discount,Me_Num,Me_Part,Me_date,Me_Peo,Me_Remark)");
			strSql.Append(" values (");
			strSql.Append("@MemberLivel,@Me_Discount,@Me_Num,@Me_Part,@Me_date,@Me_Peo,@Me_Remark)");
			strSql.Append(";select LAST_INSERT_ROWID()");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@MemberLivel", DbType.String,50),
					new SQLiteParameter("@Me_Discount", DbType.Double,8),
					new SQLiteParameter("@Me_Num", DbType.Double,8),
					new SQLiteParameter("@Me_Part", DbType.Int32,8),
					new SQLiteParameter("@Me_date", DbType.DateTime),
					new SQLiteParameter("@Me_Peo", DbType.String,50),
					new SQLiteParameter("@Me_Remark", DbType.String,50)};
			parameters[0].Value = model.MemberLivel;
			parameters[1].Value = model.Me_Discount;
			parameters[2].Value = model.Me_Num;
			parameters[3].Value = model.Me_Part;
			parameters[4].Value = model.Me_date;
			parameters[5].Value = model.Me_Peo;
			parameters[6].Value = model.Me_Remark;

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
		public bool Update(MemberLevel model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update MemberLevel set ");
			strSql.Append("MemberLivel=@MemberLivel,");
			strSql.Append("Me_Discount=@Me_Discount,");
			strSql.Append("Me_Num=@Me_Num,");
			strSql.Append("Me_Part=@Me_Part,");
			strSql.Append("Me_date=@Me_date,");
			strSql.Append("Me_Peo=@Me_Peo,");
			strSql.Append("Me_Remark=@Me_Remark");
			strSql.Append(" where LivelId=@LivelId");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@MemberLivel", DbType.String,50),
					new SQLiteParameter("@Me_Discount", DbType.Double,8),
					new SQLiteParameter("@Me_Num", DbType.Double,8),
					new SQLiteParameter("@Me_Part", DbType.Int32,8),
					new SQLiteParameter("@Me_date", DbType.DateTime),
					new SQLiteParameter("@Me_Peo", DbType.String,50),
					new SQLiteParameter("@Me_Remark", DbType.String,50),
					new SQLiteParameter("@LivelId", DbType.Int32,8)};
			parameters[0].Value = model.MemberLivel;
			parameters[1].Value = model.Me_Discount;
			parameters[2].Value = model.Me_Num;
			parameters[3].Value = model.Me_Part;
			parameters[4].Value = model.Me_date;
			parameters[5].Value = model.Me_Peo;
			parameters[6].Value = model.Me_Remark;
			parameters[7].Value = model.LivelId;

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
		public bool Delete(int LivelId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from MemberLevel ");
			strSql.Append(" where LivelId=@LivelId");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@LivelId", DbType.Int32,4)
			};
			parameters[0].Value = LivelId;

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
		public bool DeleteList(string LivelIdlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from MemberLevel ");
			strSql.Append(" where LivelId in ("+LivelIdlist + ")  ");
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
		public MemberLevel GetModel(int LivelId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select LivelId,MemberLivel,Me_Discount,Me_Num,Me_Part,Me_date,Me_Peo,Me_Remark from MemberLevel ");
			strSql.Append(" where LivelId=@LivelId");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@LivelId", DbType.Int32,4)
			};
			parameters[0].Value = LivelId;

			MemberLevel model=new MemberLevel();
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
		public MemberLevel DataRowToModel(DataRow row)
		{
			MemberLevel model=new MemberLevel();
			if (row != null)
			{
				if(row["LivelId"]!=null && row["LivelId"].ToString()!="")
				{
					model.LivelId=int.Parse(row["LivelId"].ToString());
				}
				if(row["MemberLivel"]!=null)
				{
					model.MemberLivel=row["MemberLivel"].ToString();
				}
					//model.Me_Discount=row["Me_Discount"].ToString();
					//model.Me_Num=row["Me_Num"].ToString();
				if(row["Me_Part"]!=null && row["Me_Part"].ToString()!="")
				{
					model.Me_Part=int.Parse(row["Me_Part"].ToString());
				}
				if(row["Me_date"]!=null && row["Me_date"].ToString()!="")
				{
					model.Me_date=DateTime.Parse(row["Me_date"].ToString());
				}
				if(row["Me_Peo"]!=null)
				{
					model.Me_Peo=row["Me_Peo"].ToString();
				}
				if(row["Me_Remark"]!=null)
				{
					model.Me_Remark=row["Me_Remark"].ToString();
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
			strSql.Append("select LivelId,MemberLivel,Me_Discount,Me_Num,Me_Part,Me_date,Me_Peo,Me_Remark ");
			strSql.Append(" FROM MemberLevel ");
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
			strSql.Append("select count(1) FROM MemberLevel ");
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
				strSql.Append("order by T.LivelId desc");
			}
			strSql.Append(")AS Row, T.*  from MemberLevel T ");
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
			parameters[0].Value = "MemberLevel";
			parameters[1].Value = "LivelId";
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

