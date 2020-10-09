using System;
using System.Data;
using System.Text;
using System.Data.SQLite;
using Maticsoft.DBUtility;//Please add references
using JMZHPos.Model;
namespace JMZHPos.DAL.JMZHPos
{
	/// <summary>
	/// 数据访问类:PaymentMethod
	/// </summary>
	public partial class PaymentMethodDAL
	{
		public PaymentMethodDAL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQLite.GetMaxID("PayId", "PaymentMethod"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int PayId)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from PaymentMethod");
			strSql.Append(" where PayId=@PayId");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@PayId", DbType.Int32,4)
			};
			parameters[0].Value = PayId;

			return DbHelperSQLite.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(PaymentMethod model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into PaymentMethod(");
			strSql.Append("OrderMunber,PayName,PayQuick,PayMark,Paybool,PayNumId,PayDate,PayPeo)");
			strSql.Append(" values (");
			strSql.Append("@OrderMunber,@PayName,@PayQuick,@PayMark,@Paybool,@PayNumId,@PayDate,@PayPeo)");
			strSql.Append(";select LAST_INSERT_ROWID()");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@OrderMunber", DbType.String,50),
					new SQLiteParameter("@PayName", DbType.String,50),
					new SQLiteParameter("@PayQuick", DbType.String,50),
					new SQLiteParameter("@PayMark", DbType.String,50),
					new SQLiteParameter("@Paybool", DbType.Int32,8),
					new SQLiteParameter("@PayNumId", DbType.Decimal,8),
					new SQLiteParameter("@PayDate", DbType.DateTime),
					new SQLiteParameter("@PayPeo", DbType.String,50)};
			parameters[0].Value = model.OrderMunber;
			parameters[1].Value = model.PayName;
			parameters[2].Value = model.PayQuick;
			parameters[3].Value = model.PayMark;
			parameters[4].Value = model.Paybool;
			parameters[5].Value = model.PayNumId;
			parameters[6].Value = model.PayDate;
			parameters[7].Value = model.PayPeo;

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
		public bool Update(PaymentMethod model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update PaymentMethod set ");
			strSql.Append("OrderMunber=@OrderMunber,");
			strSql.Append("PayName=@PayName,");
			strSql.Append("PayQuick=@PayQuick,");
			strSql.Append("PayMark=@PayMark,");
			strSql.Append("Paybool=@Paybool,");
			strSql.Append("PayNumId=@PayNumId,");
			strSql.Append("PayDate=@PayDate,");
			strSql.Append("PayPeo=@PayPeo");
			strSql.Append(" where PayId=@PayId");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@OrderMunber", DbType.String,50),
					new SQLiteParameter("@PayName", DbType.String,50),
					new SQLiteParameter("@PayQuick", DbType.String,50),
					new SQLiteParameter("@PayMark", DbType.String,50),
					new SQLiteParameter("@Paybool", DbType.Int32,8),
					new SQLiteParameter("@PayNumId", DbType.Decimal,8),
					new SQLiteParameter("@PayDate", DbType.DateTime),
					new SQLiteParameter("@PayPeo", DbType.String,50),
					new SQLiteParameter("@PayId", DbType.Int32,8)};
			parameters[0].Value = model.OrderMunber;
			parameters[1].Value = model.PayName;
			parameters[2].Value = model.PayQuick;
			parameters[3].Value = model.PayMark;
			parameters[4].Value = model.Paybool;
			parameters[5].Value = model.PayNumId;
			parameters[6].Value = model.PayDate;
			parameters[7].Value = model.PayPeo;
			parameters[8].Value = model.PayId;

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
		public bool Delete(int PayId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from PaymentMethod ");
			strSql.Append(" where PayId=@PayId");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@PayId", DbType.Int32,4)
			};
			parameters[0].Value = PayId;

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
		public bool DeleteList(string PayIdlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from PaymentMethod ");
			strSql.Append(" where PayId in ("+PayIdlist + ")  ");
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
		public PaymentMethod GetModel(int PayId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select PayId,OrderMunber,PayName,PayQuick,PayMark,Paybool,PayNumId,PayDate,PayPeo from PaymentMethod ");
			strSql.Append(" where PayId=@PayId");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@PayId", DbType.Int32,4)
			};
			parameters[0].Value = PayId;

			PaymentMethod model=new PaymentMethod();
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
		public PaymentMethod DataRowToModel(DataRow row)
		{
			PaymentMethod model=new PaymentMethod();
			if (row != null)
			{
				if(row["PayId"]!=null && row["PayId"].ToString()!="")
				{
					model.PayId=int.Parse(row["PayId"].ToString());
				}
				if(row["OrderMunber"]!=null)
				{
					model.OrderMunber=row["OrderMunber"].ToString();
				}
				if(row["PayName"]!=null)
				{
					model.PayName=row["PayName"].ToString();
				}
				if(row["PayQuick"]!=null)
				{
					model.PayQuick=row["PayQuick"].ToString();
				}
				if(row["PayMark"]!=null)
				{
					model.PayMark=row["PayMark"].ToString();
				}
				if(row["Paybool"]!=null && row["Paybool"].ToString()!="")
				{
					model.Paybool=int.Parse(row["Paybool"].ToString());
				}
				if(row["PayNumId"]!=null && row["PayNumId"].ToString()!="")
				{
					model.PayNumId=decimal.Parse(row["PayNumId"].ToString());
				}
				if(row["PayDate"]!=null && row["PayDate"].ToString()!="")
				{
					model.PayDate=DateTime.Parse(row["PayDate"].ToString());
				}
				if(row["PayPeo"]!=null)
				{
					model.PayPeo=row["PayPeo"].ToString();
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
			strSql.Append("select PayId,OrderMunber,PayName,PayQuick,PayMark,Paybool,PayNumId,PayDate,PayPeo ");
			strSql.Append(" FROM PaymentMethod ");
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
			strSql.Append("select count(1) FROM PaymentMethod ");
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
				strSql.Append("order by T.PayId desc");
			}
			strSql.Append(")AS Row, T.*  from PaymentMethod T ");
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
			parameters[0].Value = "PaymentMethod";
			parameters[1].Value = "PayId";
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

