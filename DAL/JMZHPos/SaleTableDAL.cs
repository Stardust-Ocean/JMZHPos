using System;
using System.Data;
using System.Text;
using System.Data.SQLite;
using Maticsoft.DBUtility;//Please add references
using JMZHPos.Model;

namespace JMZHPos.DAL.JMZHPos
{
	/// <summary>
	/// 数据访问类:SaleTable
	/// </summary>
	public partial class SaleTableDAL
    {
		public SaleTableDAL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQLite.GetMaxID("SaleId", "SaleTable"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int SaleId)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from SaleTable");
			strSql.Append(" where SaleId=@SaleId");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@SaleId", DbType.Int32,4)
			};
			parameters[0].Value = SaleId;

			return DbHelperSQLite.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(SaleTable model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into SaleTable(");
			strSql.Append("SaleNum,SaleName,SaleComm,SaleTel,SalePrice,SaleAderss,SaleDate,SalePeo,SaleQuota,SaleQuotaSum,SaleQuotaNum,SaleCommSouce)");
			strSql.Append(" values (");
			strSql.Append("@SaleNum,@SaleName,@SaleComm,@SaleTel,@SalePrice,@SaleAderss,@SaleDate,@SalePeo,@SaleQuota,@SaleQuotaSum,@SaleQuotaNum,@SaleCommSouce)");
			strSql.Append(";select LAST_INSERT_ROWID()");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@SaleNum", DbType.String,50),
					new SQLiteParameter("@SaleName", DbType.String,50),
					new SQLiteParameter("@SaleComm", DbType.Decimal,8),
					new SQLiteParameter("@SaleTel", DbType.String,50),
					new SQLiteParameter("@SalePrice", DbType.Decimal,8),
					new SQLiteParameter("@SaleAderss", DbType.String,50),
					new SQLiteParameter("@SaleDate", DbType.DateTime),
					new SQLiteParameter("@SalePeo", DbType.String,50),
					new SQLiteParameter("@SaleQuota", DbType.String,50),
					new SQLiteParameter("@SaleQuotaSum", DbType.String,50),
					new SQLiteParameter("@SaleQuotaNum", DbType.Decimal,8),
					new SQLiteParameter("@SaleCommSouce", DbType.String,50)};
			parameters[0].Value = model.SaleNum;
			parameters[1].Value = model.SaleName;
			parameters[2].Value = model.SaleComm;
			parameters[3].Value = model.SaleTel;
			parameters[4].Value = model.SalePrice;
			parameters[5].Value = model.SaleAderss;
			parameters[6].Value = model.SaleDate;
			parameters[7].Value = model.SalePeo;
			parameters[8].Value = model.SaleQuota;
			parameters[9].Value = model.SaleQuotaSum;
			parameters[10].Value = model.SaleQuotaNum;
			parameters[11].Value = model.SaleCommSouce;

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
		public bool Update(SaleTable model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update SaleTable set ");
			strSql.Append("SaleNum=@SaleNum,");
			strSql.Append("SaleName=@SaleName,");
			strSql.Append("SaleComm=@SaleComm,");
			strSql.Append("SaleTel=@SaleTel,");
			strSql.Append("SalePrice=@SalePrice,");
			strSql.Append("SaleAderss=@SaleAderss,");
			strSql.Append("SaleDate=@SaleDate,");
			strSql.Append("SalePeo=@SalePeo,");
			strSql.Append("SaleQuota=@SaleQuota,");
			strSql.Append("SaleQuotaSum=@SaleQuotaSum,");
			strSql.Append("SaleQuotaNum=@SaleQuotaNum,");
			strSql.Append("SaleCommSouce=@SaleCommSouce");
			strSql.Append(" where SaleId=@SaleId");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@SaleNum", DbType.String,50),
					new SQLiteParameter("@SaleName", DbType.String,50),
					new SQLiteParameter("@SaleComm", DbType.Decimal,8),
					new SQLiteParameter("@SaleTel", DbType.String,50),
					new SQLiteParameter("@SalePrice", DbType.Decimal,8),
					new SQLiteParameter("@SaleAderss", DbType.String,50),
					new SQLiteParameter("@SaleDate", DbType.DateTime),
					new SQLiteParameter("@SalePeo", DbType.String,50),
					new SQLiteParameter("@SaleQuota", DbType.String,50),
					new SQLiteParameter("@SaleQuotaSum", DbType.String,50),
					new SQLiteParameter("@SaleQuotaNum", DbType.Decimal,8),
					new SQLiteParameter("@SaleCommSouce", DbType.String,50),
					new SQLiteParameter("@SaleId", DbType.Int32,8)};
			parameters[0].Value = model.SaleNum;
			parameters[1].Value = model.SaleName;
			parameters[2].Value = model.SaleComm;
			parameters[3].Value = model.SaleTel;
			parameters[4].Value = model.SalePrice;
			parameters[5].Value = model.SaleAderss;
			parameters[6].Value = model.SaleDate;
			parameters[7].Value = model.SalePeo;
			parameters[8].Value = model.SaleQuota;
			parameters[9].Value = model.SaleQuotaSum;
			parameters[10].Value = model.SaleQuotaNum;
			parameters[11].Value = model.SaleCommSouce;
			parameters[12].Value = model.SaleId;

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
		public bool Delete(int SaleId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from SaleTable ");
			strSql.Append(" where SaleId=@SaleId");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@SaleId", DbType.Int32,4)
			};
			parameters[0].Value = SaleId;

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
		public bool DeleteList(string SaleIdlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from SaleTable ");
			strSql.Append(" where SaleId in ("+SaleIdlist + ")  ");
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
		public SaleTable GetModel(int SaleId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select SaleId,SaleNum,SaleName,SaleComm,SaleTel,SalePrice,SaleAderss,SaleDate,SalePeo,SaleQuota,SaleQuotaSum,SaleQuotaNum,SaleCommSouce from SaleTable ");
			strSql.Append(" where SaleId=@SaleId");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@SaleId", DbType.Int32,4)
			};
			parameters[0].Value = SaleId;

			SaleTable model=new SaleTable();
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
		public SaleTable DataRowToModel(DataRow row)
		{
			SaleTable model=new SaleTable();
			if (row != null)
			{
				if(row["SaleId"]!=null && row["SaleId"].ToString()!="")
				{
					model.SaleId=int.Parse(row["SaleId"].ToString());
				}
				if(row["SaleNum"]!=null)
				{
					model.SaleNum=row["SaleNum"].ToString();
				}
				if(row["SaleName"]!=null)
				{
					model.SaleName=row["SaleName"].ToString();
				}
				if(row["SaleComm"]!=null && row["SaleComm"].ToString()!="")
				{
					model.SaleComm=decimal.Parse(row["SaleComm"].ToString());
				}
				if(row["SaleTel"]!=null)
				{
					model.SaleTel=row["SaleTel"].ToString();
				}
				if(row["SalePrice"]!=null && row["SalePrice"].ToString()!="")
				{
					model.SalePrice=decimal.Parse(row["SalePrice"].ToString());
				}
				if(row["SaleAderss"]!=null)
				{
					model.SaleAderss=row["SaleAderss"].ToString();
				}
				if(row["SaleDate"]!=null && row["SaleDate"].ToString()!="")
				{
					model.SaleDate=DateTime.Parse(row["SaleDate"].ToString());
				}
				if(row["SalePeo"]!=null)
				{
					model.SalePeo=row["SalePeo"].ToString();
				}
				if(row["SaleQuota"]!=null)
				{
					model.SaleQuota=row["SaleQuota"].ToString();
				}
				if(row["SaleQuotaSum"]!=null)
				{
					model.SaleQuotaSum=row["SaleQuotaSum"].ToString();
				}
				if(row["SaleQuotaNum"]!=null && row["SaleQuotaNum"].ToString()!="")
				{
					model.SaleQuotaNum=decimal.Parse(row["SaleQuotaNum"].ToString());
				}
				if(row["SaleCommSouce"]!=null)
				{
					model.SaleCommSouce=row["SaleCommSouce"].ToString();
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
			strSql.Append("select SaleId,SaleNum,SaleName,SaleComm,SaleTel,SalePrice,SaleAderss,SaleDate,SalePeo,SaleQuota,SaleQuotaSum,SaleQuotaNum,SaleCommSouce ");
			strSql.Append(" FROM SaleTable ");
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
			strSql.Append("select count(1) FROM SaleTable ");
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
				strSql.Append("order by T.SaleId desc");
			}
			strSql.Append(")AS Row, T.*  from SaleTable T ");
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
			parameters[0].Value = "SaleTable";
			parameters[1].Value = "SaleId";
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

