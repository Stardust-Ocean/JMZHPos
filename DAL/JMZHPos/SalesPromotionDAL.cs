using System;
using System.Data;
using System.Text;
using System.Data.SQLite;
using Maticsoft.DBUtility;//Please add references
using JMZHPos.Model;

namespace JMZHPos.DAL.JMZHPos
{
	/// <summary>
	/// 数据访问类:SalesPromotion
	/// </summary>
	public partial class SalesPromotionDAL
	{
		public SalesPromotionDAL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQLite.GetMaxID("SaPr_Id", "SalesPromotion"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int SaPr_Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from SalesPromotion");
			strSql.Append(" where SaPr_Id=@SaPr_Id");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@SaPr_Id", DbType.Int32,4)
			};
			parameters[0].Value = SaPr_Id;

			return DbHelperSQLite.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(SalesPromotion model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into SalesPromotion(");
			strSql.Append("Sap_Datetime,SapPreName,Sapbool,Participant,SapPeo,SapCreateTIme,SapMark)");
			strSql.Append(" values (");
			strSql.Append("@Sap_Datetime,@SapPreName,@Sapbool,@Participant,@SapPeo,@SapCreateTIme,@SapMark)");
			strSql.Append(";select LAST_INSERT_ROWID()");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@Sap_Datetime", DbType.DateTime),
					new SQLiteParameter("@SapPreName", DbType.String,50),
					new SQLiteParameter("@Sapbool", DbType.Int32,8),
					new SQLiteParameter("@Participant", DbType.String,50),
					new SQLiteParameter("@SapPeo", DbType.String,50),
					new SQLiteParameter("@SapCreateTIme", DbType.DateTime),
					new SQLiteParameter("@SapMark", DbType.String,100)};
			parameters[0].Value = model.Sap_Datetime;
			parameters[1].Value = model.SapPreName;
			parameters[2].Value = model.Sapbool;
			parameters[3].Value = model.Participant;
			parameters[4].Value = model.SapPeo;
			parameters[5].Value = model.SapCreateTIme;
			parameters[6].Value = model.SapMark;

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
		public bool Update(SalesPromotion model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update SalesPromotion set ");
			strSql.Append("Sap_Datetime=@Sap_Datetime,");
			strSql.Append("SapPreName=@SapPreName,");
			strSql.Append("Sapbool=@Sapbool,");
			strSql.Append("Participant=@Participant,");
			strSql.Append("SapPeo=@SapPeo,");
			strSql.Append("SapCreateTIme=@SapCreateTIme,");
			strSql.Append("SapMark=@SapMark");
			strSql.Append(" where SaPr_Id=@SaPr_Id");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@Sap_Datetime", DbType.DateTime),
					new SQLiteParameter("@SapPreName", DbType.String,50),
					new SQLiteParameter("@Sapbool", DbType.Int32,8),
					new SQLiteParameter("@Participant", DbType.String,50),
					new SQLiteParameter("@SapPeo", DbType.String,50),
					new SQLiteParameter("@SapCreateTIme", DbType.DateTime),
					new SQLiteParameter("@SapMark", DbType.String,100),
					new SQLiteParameter("@SaPr_Id", DbType.Int32,8)};
			parameters[0].Value = model.Sap_Datetime;
			parameters[1].Value = model.SapPreName;
			parameters[2].Value = model.Sapbool;
			parameters[3].Value = model.Participant;
			parameters[4].Value = model.SapPeo;
			parameters[5].Value = model.SapCreateTIme;
			parameters[6].Value = model.SapMark;
			parameters[7].Value = model.SaPr_Id;

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
		public bool Delete(int SaPr_Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from SalesPromotion ");
			strSql.Append(" where SaPr_Id=@SaPr_Id");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@SaPr_Id", DbType.Int32,4)
			};
			parameters[0].Value = SaPr_Id;

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
		public bool DeleteList(string SaPr_Idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from SalesPromotion ");
			strSql.Append(" where SaPr_Id in ("+SaPr_Idlist + ")  ");
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
		public SalesPromotion GetModel(int SaPr_Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select SaPr_Id,Sap_Datetime,SapPreName,Sapbool,Participant,SapPeo,SapCreateTIme,SapMark from SalesPromotion ");
			strSql.Append(" where SaPr_Id=@SaPr_Id");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@SaPr_Id", DbType.Int32,4)
			};
			parameters[0].Value = SaPr_Id;

			SalesPromotion model=new SalesPromotion();
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
		public SalesPromotion DataRowToModel(DataRow row)
		{
			SalesPromotion model=new SalesPromotion();
			if (row != null)
			{
				if(row["SaPr_Id"]!=null && row["SaPr_Id"].ToString()!="")
				{
					model.SaPr_Id=int.Parse(row["SaPr_Id"].ToString());
				}
				if(row["Sap_Datetime"]!=null && row["Sap_Datetime"].ToString()!="")
				{
					model.Sap_Datetime=DateTime.Parse(row["Sap_Datetime"].ToString());
				}
				if(row["SapPreName"]!=null)
				{
					model.SapPreName=row["SapPreName"].ToString();
				}
				if(row["Sapbool"]!=null && row["Sapbool"].ToString()!="")
				{
					model.Sapbool=int.Parse(row["Sapbool"].ToString());
				}
				if(row["Participant"]!=null)
				{
					model.Participant=row["Participant"].ToString();
				}
				if(row["SapPeo"]!=null)
				{
					model.SapPeo=row["SapPeo"].ToString();
				}
				if(row["SapCreateTIme"]!=null && row["SapCreateTIme"].ToString()!="")
				{
					model.SapCreateTIme=DateTime.Parse(row["SapCreateTIme"].ToString());
				}
				if(row["SapMark"]!=null)
				{
					model.SapMark=row["SapMark"].ToString();
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
			strSql.Append("select SaPr_Id,Sap_Datetime,SapPreName,Sapbool,Participant,SapPeo,SapCreateTIme,SapMark ");
			strSql.Append(" FROM SalesPromotion ");
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
			strSql.Append("select count(1) FROM SalesPromotion ");
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
				strSql.Append("order by T.SaPr_Id desc");
			}
			strSql.Append(")AS Row, T.*  from SalesPromotion T ");
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
			parameters[0].Value = "SalesPromotion";
			parameters[1].Value = "SaPr_Id";
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

