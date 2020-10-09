using System;
using System.Data;
using System.Text;
using System.Data.SQLite;
using Maticsoft.DBUtility;//Please add references
using JMZHPos.Model;
namespace JMZHPos.DAL.JMZHPos
{
	/// <summary>
	/// 数据访问类:IntegralRecord
	/// </summary>
	public partial class IntegralRecordDAL
	{
		public IntegralRecordDAL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQLite.GetMaxID("IR_ID", "IntegralRecord"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int IR_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from IntegralRecord");
			strSql.Append(" where IR_ID=@IR_ID");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@IR_ID", DbType.Int32,4)
			};
			parameters[0].Value = IR_ID;

			return DbHelperSQLite.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(IntegralRecord model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into IntegralRecord(");
			strSql.Append("IR_MeID,IR_Date,IR_Record,IR_Reason,IR_Remark,IR_ResIn,IR_Peo,IR_RefMark)");
			strSql.Append(" values (");
			strSql.Append("@IR_MeID,@IR_Date,@IR_Record,@IR_Reason,@IR_Remark,@IR_ResIn,@IR_Peo,@IR_RefMark)");
			strSql.Append(";select LAST_INSERT_ROWID()");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@IR_MeID", DbType.String,50),
					new SQLiteParameter("@IR_Date", DbType.DateTime),
					new SQLiteParameter("@IR_Record", DbType.String,50),
					new SQLiteParameter("@IR_Reason", DbType.String,50),
					new SQLiteParameter("@IR_Remark", DbType.String,50),
					new SQLiteParameter("@IR_ResIn", DbType.Decimal,8),
					new SQLiteParameter("@IR_Peo", DbType.String,50),
					new SQLiteParameter("@IR_RefMark", DbType.String,50)};
			parameters[0].Value = model.IR_MeID;
			parameters[1].Value = model.IR_Date;
			parameters[2].Value = model.IR_Record;
			parameters[3].Value = model.IR_Reason;
			parameters[4].Value = model.IR_Remark;
			parameters[5].Value = model.IR_ResIn;
			parameters[6].Value = model.IR_Peo;
			parameters[7].Value = model.IR_RefMark;

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
		public bool Update(IntegralRecord model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update IntegralRecord set ");
			strSql.Append("IR_MeID=@IR_MeID,");
			strSql.Append("IR_Date=@IR_Date,");
			strSql.Append("IR_Record=@IR_Record,");
			strSql.Append("IR_Reason=@IR_Reason,");
			strSql.Append("IR_Remark=@IR_Remark,");
			strSql.Append("IR_ResIn=@IR_ResIn,");
			strSql.Append("IR_Peo=@IR_Peo,");
			strSql.Append("IR_RefMark=@IR_RefMark");
			strSql.Append(" where IR_ID=@IR_ID");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@IR_MeID", DbType.String,50),
					new SQLiteParameter("@IR_Date", DbType.DateTime),
					new SQLiteParameter("@IR_Record", DbType.String,50),
					new SQLiteParameter("@IR_Reason", DbType.String,50),
					new SQLiteParameter("@IR_Remark", DbType.String,50),
					new SQLiteParameter("@IR_ResIn", DbType.Decimal,8),
					new SQLiteParameter("@IR_Peo", DbType.String,50),
					new SQLiteParameter("@IR_RefMark", DbType.String,50),
					new SQLiteParameter("@IR_ID", DbType.Int32,8)};
			parameters[0].Value = model.IR_MeID;
			parameters[1].Value = model.IR_Date;
			parameters[2].Value = model.IR_Record;
			parameters[3].Value = model.IR_Reason;
			parameters[4].Value = model.IR_Remark;
			parameters[5].Value = model.IR_ResIn;
			parameters[6].Value = model.IR_Peo;
			parameters[7].Value = model.IR_RefMark;
			parameters[8].Value = model.IR_ID;

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
		public bool Delete(int IR_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from IntegralRecord ");
			strSql.Append(" where IR_ID=@IR_ID");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@IR_ID", DbType.Int32,4)
			};
			parameters[0].Value = IR_ID;

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
		public bool DeleteList(string IR_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from IntegralRecord ");
			strSql.Append(" where IR_ID in ("+IR_IDlist + ")  ");
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
		public IntegralRecord GetModel(int IR_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select IR_ID,IR_MeID,IR_Date,IR_Record,IR_Reason,IR_Remark,IR_ResIn,IR_Peo,IR_RefMark from IntegralRecord ");
			strSql.Append(" where IR_ID=@IR_ID");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@IR_ID", DbType.Int32,4)
			};
			parameters[0].Value = IR_ID;

			IntegralRecord model=new IntegralRecord();
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
		public IntegralRecord DataRowToModel(DataRow row)
		{
			IntegralRecord model=new IntegralRecord();
			if (row != null)
			{
				if(row["IR_ID"]!=null && row["IR_ID"].ToString()!="")
				{
					model.IR_ID=int.Parse(row["IR_ID"].ToString());
				}
				if(row["IR_MeID"]!=null)
				{
					model.IR_MeID=row["IR_MeID"].ToString();
				}
				if(row["IR_Date"]!=null && row["IR_Date"].ToString()!="")
				{
					model.IR_Date=DateTime.Parse(row["IR_Date"].ToString());
				}
				if(row["IR_Record"]!=null)
				{
					model.IR_Record=row["IR_Record"].ToString();
				}
				if(row["IR_Reason"]!=null)
				{
					model.IR_Reason=row["IR_Reason"].ToString();
				}
				if(row["IR_Remark"]!=null)
				{
					model.IR_Remark=row["IR_Remark"].ToString();
				}
				if(row["IR_ResIn"]!=null && row["IR_ResIn"].ToString()!="")
				{
					model.IR_ResIn=decimal.Parse(row["IR_ResIn"].ToString());
				}
				if(row["IR_Peo"]!=null)
				{
					model.IR_Peo=row["IR_Peo"].ToString();
				}
				if(row["IR_RefMark"]!=null)
				{
					model.IR_RefMark=row["IR_RefMark"].ToString();
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
			strSql.Append("select IR_ID,IR_MeID,IR_Date,IR_Record,IR_Reason,IR_Remark,IR_ResIn,IR_Peo,IR_RefMark ");
			strSql.Append(" FROM IntegralRecord ");
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
			strSql.Append("select count(1) FROM IntegralRecord ");
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
				strSql.Append("order by T.IR_ID desc");
			}
			strSql.Append(")AS Row, T.*  from IntegralRecord T ");
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
			parameters[0].Value = "IntegralRecord";
			parameters[1].Value = "IR_ID";
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

