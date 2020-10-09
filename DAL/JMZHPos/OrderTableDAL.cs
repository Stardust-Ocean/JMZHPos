using System;
using System.Data;
using System.Text;
using System.Data.SQLite;
using Maticsoft.DBUtility;//Please add references
using JMZHPos.Model;
namespace JMZHPos.DAL.JMZHPos
{
	/// <summary>
	/// 数据访问类:OrderTable
	/// </summary>
	public partial class OrderTableDAL
	{
		public OrderTableDAL()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(OrderTable model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into OrderTable(");
			strSql.Append("OrderMunber,OeMun,OrName,OrPec,OrDiscount,Orpresion,OrSum,OrTatol,OrStock,OrCreateTIme,OrPeo,Orbool,OrPayItem,OrMeName,OrIntegral,OrPayMent,OrChange,OrMark,PayItem)");
			strSql.Append(" values (");
			strSql.Append("@OrderMunber,@OeMun,@OrName,@OrPec,@OrDiscount,@Orpresion,@OrSum,@OrTatol,@OrStock,@OrCreateTIme,@OrPeo,@Orbool,@OrPayItem,@OrMeName,@OrIntegral,@OrPayMent,@OrChange,@OrMark,@PayItem)");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@OrderMunber", DbType.String,50),
					new SQLiteParameter("@OeMun", DbType.String,50),
					new SQLiteParameter("@OrName", DbType.String,50),
					new SQLiteParameter("@OrPec", DbType.Decimal,8),
					new SQLiteParameter("@OrDiscount", DbType.Decimal,8),
					new SQLiteParameter("@Orpresion", DbType.Decimal,8),
					new SQLiteParameter("@OrSum", DbType.Decimal,8),
					new SQLiteParameter("@OrTatol", DbType.Decimal,8),
					new SQLiteParameter("@OrStock", DbType.Decimal,8),
					new SQLiteParameter("@OrCreateTIme", DbType.DateTime),
					new SQLiteParameter("@OrPeo", DbType.String,50),
					new SQLiteParameter("@Orbool", DbType.Int32,8),
					new SQLiteParameter("@OrPayItem", DbType.String,50),
					new SQLiteParameter("@OrMeName", DbType.String,50),
					new SQLiteParameter("@OrIntegral", DbType.Int32,8),
					new SQLiteParameter("@OrPayMent", DbType.Decimal,8),
					new SQLiteParameter("@OrChange", DbType.Decimal,8),
					new SQLiteParameter("@OrMark", DbType.String,50),
					new SQLiteParameter("@PayItem", DbType.String,50)};
			parameters[0].Value = model.OrderMunber;
			parameters[1].Value = model.OeMun;
			parameters[2].Value = model.OrName;
			parameters[3].Value = model.OrPec;
			parameters[4].Value = model.OrDiscount;
			parameters[5].Value = model.Orpresion;
			parameters[6].Value = model.OrSum;
			parameters[7].Value = model.OrTatol;
			parameters[8].Value = model.OrStock;
			parameters[9].Value = model.OrCreateTIme;
			parameters[10].Value = model.OrPeo;
			parameters[11].Value = model.Orbool;
			parameters[12].Value = model.OrPayItem;
			parameters[13].Value = model.OrMeName;
			parameters[14].Value = model.OrIntegral;
			parameters[15].Value = model.OrPayMent;
			parameters[16].Value = model.OrChange;
			parameters[17].Value = model.OrMark;
			parameters[18].Value = model.PayItem;

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
		public bool Update(OrderTable model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update OrderTable set ");
			strSql.Append("OrderMunber=@OrderMunber,");
			strSql.Append("OeMun=@OeMun,");
			strSql.Append("OrName=@OrName,");
			strSql.Append("OrPec=@OrPec,");
			strSql.Append("OrDiscount=@OrDiscount,");
			strSql.Append("Orpresion=@Orpresion,");
			strSql.Append("OrSum=@OrSum,");
			strSql.Append("OrTatol=@OrTatol,");
			strSql.Append("OrStock=@OrStock,");
			strSql.Append("OrCreateTIme=@OrCreateTIme,");
			strSql.Append("OrPeo=@OrPeo,");
			strSql.Append("Orbool=@Orbool,");
			strSql.Append("OrPayItem=@OrPayItem,");
			strSql.Append("OrMeName=@OrMeName,");
			strSql.Append("OrIntegral=@OrIntegral,");
			strSql.Append("OrPayMent=@OrPayMent,");
			strSql.Append("OrChange=@OrChange,");
			strSql.Append("OrMark=@OrMark,");
			strSql.Append("PayItem=@PayItem");
			strSql.Append(" where ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@OrderMunber", DbType.String,50),
					new SQLiteParameter("@OeMun", DbType.String,50),
					new SQLiteParameter("@OrName", DbType.String,50),
					new SQLiteParameter("@OrPec", DbType.Decimal,8),
					new SQLiteParameter("@OrDiscount", DbType.Decimal,8),
					new SQLiteParameter("@Orpresion", DbType.Decimal,8),
					new SQLiteParameter("@OrSum", DbType.Decimal,8),
					new SQLiteParameter("@OrTatol", DbType.Decimal,8),
					new SQLiteParameter("@OrStock", DbType.Decimal,8),
					new SQLiteParameter("@OrCreateTIme", DbType.DateTime),
					new SQLiteParameter("@OrPeo", DbType.String,50),
					new SQLiteParameter("@Orbool", DbType.Int32,8),
					new SQLiteParameter("@OrPayItem", DbType.String,50),
					new SQLiteParameter("@OrMeName", DbType.String,50),
					new SQLiteParameter("@OrIntegral", DbType.Int32,8),
					new SQLiteParameter("@OrPayMent", DbType.Decimal,8),
					new SQLiteParameter("@OrChange", DbType.Decimal,8),
					new SQLiteParameter("@OrMark", DbType.String,50),
					new SQLiteParameter("@PayItem", DbType.String,50)};
			parameters[0].Value = model.OrderMunber;
			parameters[1].Value = model.OeMun;
			parameters[2].Value = model.OrName;
			parameters[3].Value = model.OrPec;
			parameters[4].Value = model.OrDiscount;
			parameters[5].Value = model.Orpresion;
			parameters[6].Value = model.OrSum;
			parameters[7].Value = model.OrTatol;
			parameters[8].Value = model.OrStock;
			parameters[9].Value = model.OrCreateTIme;
			parameters[10].Value = model.OrPeo;
			parameters[11].Value = model.Orbool;
			parameters[12].Value = model.OrPayItem;
			parameters[13].Value = model.OrMeName;
			parameters[14].Value = model.OrIntegral;
			parameters[15].Value = model.OrPayMent;
			parameters[16].Value = model.OrChange;
			parameters[17].Value = model.OrMark;
			parameters[18].Value = model.PayItem;

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
			strSql.Append("delete from OrderTable ");
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
		public OrderTable GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select OrderMunber,OeMun,OrName,OrPec,OrDiscount,Orpresion,OrSum,OrTatol,OrStock,OrCreateTIme,OrPeo,Orbool,OrPayItem,OrMeName,OrIntegral,OrPayMent,OrChange,OrMark,PayItem from OrderTable ");
			strSql.Append(" where ");
			SQLiteParameter[] parameters = {
			};

			OrderTable model=new OrderTable();
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
		public OrderTable DataRowToModel(DataRow row)
		{
			OrderTable model=new OrderTable();
			if (row != null)
			{
				if(row["OrderMunber"]!=null)
				{
					model.OrderMunber=row["OrderMunber"].ToString();
				}
				if(row["OeMun"]!=null)
				{
					model.OeMun=row["OeMun"].ToString();
				}
				if(row["OrName"]!=null)
				{
					model.OrName=row["OrName"].ToString();
				}
				if(row["OrPec"]!=null && row["OrPec"].ToString()!="")
				{
					model.OrPec=decimal.Parse(row["OrPec"].ToString());
				}
				if(row["OrDiscount"]!=null && row["OrDiscount"].ToString()!="")
				{
					model.OrDiscount=decimal.Parse(row["OrDiscount"].ToString());
				}
				if(row["Orpresion"]!=null && row["Orpresion"].ToString()!="")
				{
					model.Orpresion=decimal.Parse(row["Orpresion"].ToString());
				}
				if(row["OrSum"]!=null && row["OrSum"].ToString()!="")
				{
					model.OrSum=decimal.Parse(row["OrSum"].ToString());
				}
				if(row["OrTatol"]!=null && row["OrTatol"].ToString()!="")
				{
					model.OrTatol=decimal.Parse(row["OrTatol"].ToString());
				}
				if(row["OrStock"]!=null && row["OrStock"].ToString()!="")
				{
					model.OrStock=decimal.Parse(row["OrStock"].ToString());
				}
				if(row["OrCreateTIme"]!=null && row["OrCreateTIme"].ToString()!="")
				{
					model.OrCreateTIme=DateTime.Parse(row["OrCreateTIme"].ToString());
				}
				if(row["OrPeo"]!=null)
				{
					model.OrPeo=row["OrPeo"].ToString();
				}
				if(row["Orbool"]!=null && row["Orbool"].ToString()!="")
				{
					model.Orbool=int.Parse(row["Orbool"].ToString());
				}
				if(row["OrPayItem"]!=null)
				{
					model.OrPayItem=row["OrPayItem"].ToString();
				}
				if(row["OrMeName"]!=null)
				{
					model.OrMeName=row["OrMeName"].ToString();
				}
				if(row["OrIntegral"]!=null && row["OrIntegral"].ToString()!="")
				{
					model.OrIntegral=int.Parse(row["OrIntegral"].ToString());
				}
				if(row["OrPayMent"]!=null && row["OrPayMent"].ToString()!="")
				{
					model.OrPayMent=decimal.Parse(row["OrPayMent"].ToString());
				}
				if(row["OrChange"]!=null && row["OrChange"].ToString()!="")
				{
					model.OrChange=decimal.Parse(row["OrChange"].ToString());
				}
				if(row["OrMark"]!=null)
				{
					model.OrMark=row["OrMark"].ToString();
				}
				if(row["PayItem"]!=null)
				{
					model.PayItem=row["PayItem"].ToString();
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
			strSql.Append("select OrderMunber,OeMun,OrName,OrPec,OrDiscount,Orpresion,OrSum,OrTatol,OrStock,OrCreateTIme,OrPeo,Orbool,OrPayItem,OrMeName,OrIntegral,OrPayMent,OrChange,OrMark,PayItem ");
			strSql.Append(" FROM OrderTable ");
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
			strSql.Append("select count(1) FROM OrderTable ");
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
			strSql.Append(")AS Row, T.*  from OrderTable T ");
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
			parameters[0].Value = "OrderTable";
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

