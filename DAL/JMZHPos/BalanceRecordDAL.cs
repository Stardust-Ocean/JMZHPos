using System;
using System.Data;
using System.Text;
using System.Data.SQLite;
using Maticsoft.DBUtility;//Please add references
using JMZHPos.Model;

namespace JMZHPos.DAL.JMZHPos
{
	/// <summary>
	/// 数据访问类:BalanceRecord
	/// </summary>
	public partial class BalanceRecordDAL
	{
		public BalanceRecordDAL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQLite.GetMaxID("BR_ID", "BalanceRecord"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int BR_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from BalanceRecord");
			strSql.Append(" where BR_ID=@BR_ID");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@BR_ID", DbType.Int32,4)
			};
			parameters[0].Value = BR_ID;

			return DbHelperSQLite.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(BalanceRecord model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into BalanceRecord(");
			strSql.Append("Me_Id,BR_Date,BR_Balance,BR_Reson,BR_Numer,BR_SurBalance,BR_Peo)");
			strSql.Append(" values (");
			strSql.Append("@Me_Id,@BR_Date,@BR_Balance,@BR_Reson,@BR_Numer,@BR_SurBalance,@BR_Peo)");
			strSql.Append(";select LAST_INSERT_ROWID()");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@Me_Id", DbType.String,50),
					new SQLiteParameter("@BR_Date", DbType.DateTime),
					new SQLiteParameter("@BR_Balance", DbType.Decimal,8),
					new SQLiteParameter("@BR_Reson", DbType.String,50),
					new SQLiteParameter("@BR_Numer", DbType.String,50),
					new SQLiteParameter("@BR_SurBalance", DbType.Decimal,8),
					new SQLiteParameter("@BR_Peo", DbType.String,50)};
			parameters[0].Value = model.Me_Id;
			parameters[1].Value = model.BR_Date;
			parameters[2].Value = model.BR_Balance;
			parameters[3].Value = model.BR_Reson;
			parameters[4].Value = model.BR_Numer;
			parameters[5].Value = model.BR_SurBalance;
			parameters[6].Value = model.BR_Peo;

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
		public bool Update(BalanceRecord model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update BalanceRecord set ");
			strSql.Append("Me_Id=@Me_Id,");
			strSql.Append("BR_Date=@BR_Date,");
			strSql.Append("BR_Balance=@BR_Balance,");
			strSql.Append("BR_Reson=@BR_Reson,");
			strSql.Append("BR_Numer=@BR_Numer,");
			strSql.Append("BR_SurBalance=@BR_SurBalance,");
			strSql.Append("BR_Peo=@BR_Peo");
			strSql.Append(" where BR_ID=@BR_ID");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@Me_Id", DbType.String,50),
					new SQLiteParameter("@BR_Date", DbType.DateTime),
					new SQLiteParameter("@BR_Balance", DbType.Decimal,8),
					new SQLiteParameter("@BR_Reson", DbType.String,50),
					new SQLiteParameter("@BR_Numer", DbType.String,50),
					new SQLiteParameter("@BR_SurBalance", DbType.Decimal,8),
					new SQLiteParameter("@BR_Peo", DbType.String,50),
					new SQLiteParameter("@BR_ID", DbType.Int32,8)};
			parameters[0].Value = model.Me_Id;
			parameters[1].Value = model.BR_Date;
			parameters[2].Value = model.BR_Balance;
			parameters[3].Value = model.BR_Reson;
			parameters[4].Value = model.BR_Numer;
			parameters[5].Value = model.BR_SurBalance;
			parameters[6].Value = model.BR_Peo;
			parameters[7].Value = model.BR_ID;

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
		public bool Delete(int BR_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from BalanceRecord ");
			strSql.Append(" where BR_ID=@BR_ID");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@BR_ID", DbType.Int32,4)
			};
			parameters[0].Value = BR_ID;

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
		public bool DeleteList(string BR_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from BalanceRecord ");
			strSql.Append(" where BR_ID in ("+BR_IDlist + ")  ");
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
		public BalanceRecord GetModel(int BR_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select BR_ID,Me_Id,BR_Date,BR_Balance,BR_Reson,BR_Numer,BR_SurBalance,BR_Peo from BalanceRecord ");
			strSql.Append(" where BR_ID=@BR_ID");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@BR_ID", DbType.Int32,4)
			};
			parameters[0].Value = BR_ID;

			BalanceRecord model=new BalanceRecord();
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
		public BalanceRecord DataRowToModel(DataRow row)
		{
			BalanceRecord model=new BalanceRecord();
			if (row != null)
			{
				if(row["BR_ID"]!=null && row["BR_ID"].ToString()!="")
				{
					model.BR_ID=int.Parse(row["BR_ID"].ToString());
				}
				if(row["Me_Id"]!=null)
				{
					model.Me_Id=row["Me_Id"].ToString();
				}
				if(row["BR_Date"]!=null && row["BR_Date"].ToString()!="")
				{
					model.BR_Date=DateTime.Parse(row["BR_Date"].ToString());
				}
				if(row["BR_Balance"]!=null && row["BR_Balance"].ToString()!="")
				{
					model.BR_Balance=decimal.Parse(row["BR_Balance"].ToString());
				}
				if(row["BR_Reson"]!=null)
				{
					model.BR_Reson=row["BR_Reson"].ToString();
				}
				if(row["BR_Numer"]!=null)
				{
					model.BR_Numer=row["BR_Numer"].ToString();
				}
				if(row["BR_SurBalance"]!=null && row["BR_SurBalance"].ToString()!="")
				{
					model.BR_SurBalance=decimal.Parse(row["BR_SurBalance"].ToString());
				}
				if(row["BR_Peo"]!=null)
				{
					model.BR_Peo=row["BR_Peo"].ToString();
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
			strSql.Append("select BR_ID,Me_Id,BR_Date,BR_Balance,BR_Reson,BR_Numer,BR_SurBalance,BR_Peo ");
			strSql.Append(" FROM BalanceRecord ");
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
			strSql.Append("select count(1) FROM BalanceRecord ");
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
				strSql.Append("order by T.BR_ID desc");
			}
			strSql.Append(")AS Row, T.*  from BalanceRecord T ");
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
			parameters[0].Value = "BalanceRecord";
			parameters[1].Value = "BR_ID";
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

