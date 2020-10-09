using System;
using System.Text;
using Maticsoft.DBUtility;//Please add references
using JMZHPos.Model;
using System.Data.SQLite;
using System.Data;

namespace JMZHPos.DAL.JMZHPos
{
    /// <summary>
    /// 数据访问类:CardTable
    /// </summary>
    public partial class CardTableDAL
	{
		public CardTableDAL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQLite.GetMaxID("CartID", "CardTable"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int CartID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from CardTable");
			strSql.Append(" where CartID=@CartID");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@CartID", DbType.Int32,4)
			};
			parameters[0].Value = CartID;

			return DbHelperSQLite.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(CardTable model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into CardTable(");
			strSql.Append("Me_Id,CardNum,CardName,CardPrice,CardSUm,CardShu,CardDateNow,CardNowTime,CardOldTime,CardCreateDate,CardPeo)");
			strSql.Append(" values (");
			strSql.Append("@Me_Id,@CardNum,@CardName,@CardPrice,@CardSUm,@CardShu,@CardDateNow,@CardNowTime,@CardOldTime,@CardCreateDate,@CardPeo)");
			strSql.Append(";select LAST_INSERT_ROWID()");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@Me_Id", DbType.Int32,8),
					new SQLiteParameter("@CardNum", DbType.String,50),
					new SQLiteParameter("@CardName", DbType.String,50),
					new SQLiteParameter("@CardPrice", DbType.Decimal,8),
					new SQLiteParameter("@CardSUm", DbType.Int32,8),
					new SQLiteParameter("@CardShu", DbType.Int32,8),
					new SQLiteParameter("@CardDateNow", DbType.Int32,8),
					new SQLiteParameter("@CardNowTime", DbType.DateTime),
					new SQLiteParameter("@CardOldTime", DbType.DateTime),
					new SQLiteParameter("@CardCreateDate", DbType.DateTime),
					new SQLiteParameter("@CardPeo", DbType.String,50)};
			parameters[0].Value = model.Me_Id;
			parameters[1].Value = model.CardNum;
			parameters[2].Value = model.CardName;
			parameters[3].Value = model.CardPrice;
			parameters[4].Value = model.CardSUm;
			parameters[5].Value = model.CardShu;
			parameters[6].Value = model.CardDateNow;
			parameters[7].Value = model.CardNowTime;
			parameters[8].Value = model.CardOldTime;
			parameters[9].Value = model.CardCreateDate;
			parameters[10].Value = model.CardPeo;

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
		public bool Update(CardTable model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update CardTable set ");
			strSql.Append("Me_Id=@Me_Id,");
			strSql.Append("CardNum=@CardNum,");
			strSql.Append("CardName=@CardName,");
			strSql.Append("CardPrice=@CardPrice,");
			strSql.Append("CardSUm=@CardSUm,");
			strSql.Append("CardShu=@CardShu,");
			strSql.Append("CardDateNow=@CardDateNow,");
			strSql.Append("CardNowTime=@CardNowTime,");
			strSql.Append("CardOldTime=@CardOldTime,");
			strSql.Append("CardCreateDate=@CardCreateDate,");
			strSql.Append("CardPeo=@CardPeo");
			strSql.Append(" where CartID=@CartID");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@Me_Id", DbType.Int32,8),
					new SQLiteParameter("@CardNum", DbType.String,50),
					new SQLiteParameter("@CardName", DbType.String,50),
					new SQLiteParameter("@CardPrice", DbType.Decimal,8),
					new SQLiteParameter("@CardSUm", DbType.Int32,8),
					new SQLiteParameter("@CardShu", DbType.Int32,8),
					new SQLiteParameter("@CardDateNow", DbType.Int32,8),
					new SQLiteParameter("@CardNowTime", DbType.DateTime),
					new SQLiteParameter("@CardOldTime", DbType.DateTime),
					new SQLiteParameter("@CardCreateDate", DbType.DateTime),
					new SQLiteParameter("@CardPeo", DbType.String,50),
					new SQLiteParameter("@CartID", DbType.Int32,8)};
			parameters[0].Value = model.Me_Id;
			parameters[1].Value = model.CardNum;
			parameters[2].Value = model.CardName;
			parameters[3].Value = model.CardPrice;
			parameters[4].Value = model.CardSUm;
			parameters[5].Value = model.CardShu;
			parameters[6].Value = model.CardDateNow;
			parameters[7].Value = model.CardNowTime;
			parameters[8].Value = model.CardOldTime;
			parameters[9].Value = model.CardCreateDate;
			parameters[10].Value = model.CardPeo;
			parameters[11].Value = model.CartID;

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
		public bool Delete(int CartID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from CardTable ");
			strSql.Append(" where CartID=@CartID");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@CartID", DbType.Int32,4)
			};
			parameters[0].Value = CartID;

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
		public bool DeleteList(string CartIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from CardTable ");
			strSql.Append(" where CartID in ("+CartIDlist + ")  ");
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
		public CardTable GetModel(int CartID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select CartID,Me_Id,CardNum,CardName,CardPrice,CardSUm,CardShu,CardDateNow,CardNowTime,CardOldTime,CardCreateDate,CardPeo from CardTable ");
			strSql.Append(" where CartID=@CartID");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@CartID", DbType.Int32,4)
			};
			parameters[0].Value = CartID;

			CardTable model=new CardTable();
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
		public CardTable DataRowToModel(DataRow row)
		{
			CardTable model=new CardTable();
			if (row != null)
			{
				if(row["CartID"]!=null && row["CartID"].ToString()!="")
				{
					model.CartID=int.Parse(row["CartID"].ToString());
				}
				if(row["Me_Id"]!=null && row["Me_Id"].ToString()!="")
				{
					model.Me_Id=int.Parse(row["Me_Id"].ToString());
				}
				if(row["CardNum"]!=null)
				{
					model.CardNum=row["CardNum"].ToString();
				}
				if(row["CardName"]!=null)
				{
					model.CardName=row["CardName"].ToString();
				}
				if(row["CardPrice"]!=null && row["CardPrice"].ToString()!="")
				{
					model.CardPrice=decimal.Parse(row["CardPrice"].ToString());
				}
				if(row["CardSUm"]!=null && row["CardSUm"].ToString()!="")
				{
					model.CardSUm=int.Parse(row["CardSUm"].ToString());
				}
				if(row["CardShu"]!=null && row["CardShu"].ToString()!="")
				{
					model.CardShu=int.Parse(row["CardShu"].ToString());
				}
				if(row["CardDateNow"]!=null && row["CardDateNow"].ToString()!="")
				{
					model.CardDateNow=int.Parse(row["CardDateNow"].ToString());
				}
				if(row["CardNowTime"]!=null && row["CardNowTime"].ToString()!="")
				{
					model.CardNowTime=DateTime.Parse(row["CardNowTime"].ToString());
				}
				if(row["CardOldTime"]!=null && row["CardOldTime"].ToString()!="")
				{
					model.CardOldTime=DateTime.Parse(row["CardOldTime"].ToString());
				}
				if(row["CardCreateDate"]!=null && row["CardCreateDate"].ToString()!="")
				{
					model.CardCreateDate=DateTime.Parse(row["CardCreateDate"].ToString());
				}
				if(row["CardPeo"]!=null)
				{
					model.CardPeo=row["CardPeo"].ToString();
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
			strSql.Append("select CartID,Me_Id,CardNum,CardName,CardPrice,CardSUm,CardShu,CardDateNow,CardNowTime,CardOldTime,CardCreateDate,CardPeo ");
			strSql.Append(" FROM CardTable ");
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
			strSql.Append("select count(1) FROM CardTable ");
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
			strSql.Append(")AS Row, T.*  from CardTable T ");
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
			parameters[0].Value = "CardTable";
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

