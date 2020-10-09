using System;
using System.Data;
using System.Text;
using System.Data.SQLite;
using Maticsoft.DBUtility;//Please add references
using JMZHPos.Model;
namespace JMZHPos.DAL.JMZHPos
{
	/// <summary>
	/// 数据访问类:InventoryChanges
	/// </summary>
	public partial class InventoryChangesDAL
	{
		public InventoryChangesDAL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQLite.GetMaxID("IC_ID", "InventoryChanges"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int IC_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from InventoryChanges");
			strSql.Append(" where IC_ID=@IC_ID");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@IC_ID", DbType.Int32,4)
			};
			parameters[0].Value = IC_ID;

			return DbHelperSQLite.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(InventoryChanges model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into InventoryChanges(");
			strSql.Append("Commo_Id,ID_Cord,IC_Nmae,IC_Num,IC_Company,IC_Specification,IC_Reason,IC_Remark,IC_Date,IC_Peo)");
			strSql.Append(" values (");
			strSql.Append("@Commo_Id,@ID_Cord,@IC_Nmae,@IC_Num,@IC_Company,@IC_Specification,@IC_Reason,@IC_Remark,@IC_Date,@IC_Peo)");
			strSql.Append(";select LAST_INSERT_ROWID()");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@Commo_Id", DbType.String,50),
					new SQLiteParameter("@ID_Cord", DbType.String,50),
					new SQLiteParameter("@IC_Nmae", DbType.String,50),
					new SQLiteParameter("@IC_Num", DbType.Decimal,8),
					new SQLiteParameter("@IC_Company", DbType.Decimal,8),
					new SQLiteParameter("@IC_Specification", DbType.String,50),
					new SQLiteParameter("@IC_Reason", DbType.String,50),
					new SQLiteParameter("@IC_Remark", DbType.String,50),
					new SQLiteParameter("@IC_Date", DbType.DateTime),
					new SQLiteParameter("@IC_Peo", DbType.String,50)};
			parameters[0].Value = model.Commo_Id;
			parameters[1].Value = model.ID_Cord;
			parameters[2].Value = model.IC_Nmae;
			parameters[3].Value = model.IC_Num;
			parameters[4].Value = model.IC_Company;
			parameters[5].Value = model.IC_Specification;
			parameters[6].Value = model.IC_Reason;
			parameters[7].Value = model.IC_Remark;
			parameters[8].Value = model.IC_Date;
			parameters[9].Value = model.IC_Peo;

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
		public bool Update(InventoryChanges model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update InventoryChanges set ");
			strSql.Append("Commo_Id=@Commo_Id,");
			strSql.Append("ID_Cord=@ID_Cord,");
			strSql.Append("IC_Nmae=@IC_Nmae,");
			strSql.Append("IC_Num=@IC_Num,");
			strSql.Append("IC_Company=@IC_Company,");
			strSql.Append("IC_Specification=@IC_Specification,");
			strSql.Append("IC_Reason=@IC_Reason,");
			strSql.Append("IC_Remark=@IC_Remark,");
			strSql.Append("IC_Date=@IC_Date,");
			strSql.Append("IC_Peo=@IC_Peo");
			strSql.Append(" where IC_ID=@IC_ID");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@Commo_Id", DbType.String,50),
					new SQLiteParameter("@ID_Cord", DbType.String,50),
					new SQLiteParameter("@IC_Nmae", DbType.String,50),
					new SQLiteParameter("@IC_Num", DbType.Decimal,8),
					new SQLiteParameter("@IC_Company", DbType.Decimal,8),
					new SQLiteParameter("@IC_Specification", DbType.String,50),
					new SQLiteParameter("@IC_Reason", DbType.String,50),
					new SQLiteParameter("@IC_Remark", DbType.String,50),
					new SQLiteParameter("@IC_Date", DbType.DateTime),
					new SQLiteParameter("@IC_Peo", DbType.String,50),
					new SQLiteParameter("@IC_ID", DbType.Int32,8)};
			parameters[0].Value = model.Commo_Id;
			parameters[1].Value = model.ID_Cord;
			parameters[2].Value = model.IC_Nmae;
			parameters[3].Value = model.IC_Num;
			parameters[4].Value = model.IC_Company;
			parameters[5].Value = model.IC_Specification;
			parameters[6].Value = model.IC_Reason;
			parameters[7].Value = model.IC_Remark;
			parameters[8].Value = model.IC_Date;
			parameters[9].Value = model.IC_Peo;
			parameters[10].Value = model.IC_ID;

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
		public bool Delete(int IC_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from InventoryChanges ");
			strSql.Append(" where IC_ID=@IC_ID");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@IC_ID", DbType.Int32,4)
			};
			parameters[0].Value = IC_ID;

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
		public bool DeleteList(string IC_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from InventoryChanges ");
			strSql.Append(" where IC_ID in ("+IC_IDlist + ")  ");
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
		public InventoryChanges GetModel(int IC_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select IC_ID,Commo_Id,ID_Cord,IC_Nmae,IC_Num,IC_Company,IC_Specification,IC_Reason,IC_Remark,IC_Date,IC_Peo from InventoryChanges ");
			strSql.Append(" where IC_ID=@IC_ID");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@IC_ID", DbType.Int32,4)
			};
			parameters[0].Value = IC_ID;

			InventoryChanges model=new InventoryChanges();
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
		public InventoryChanges DataRowToModel(DataRow row)
		{
			InventoryChanges model=new InventoryChanges();
			if (row != null)
			{
				if(row["IC_ID"]!=null && row["IC_ID"].ToString()!="")
				{
					model.IC_ID=int.Parse(row["IC_ID"].ToString());
				}
				if(row["Commo_Id"]!=null)
				{
					model.Commo_Id=row["Commo_Id"].ToString();
				}
				if(row["ID_Cord"]!=null)
				{
					model.ID_Cord=row["ID_Cord"].ToString();
				}
				if(row["IC_Nmae"]!=null)
				{
					model.IC_Nmae=row["IC_Nmae"].ToString();
				}
				if(row["IC_Num"]!=null && row["IC_Num"].ToString()!="")
				{
					model.IC_Num=decimal.Parse(row["IC_Num"].ToString());
				}
				if(row["IC_Company"]!=null && row["IC_Company"].ToString()!="")
				{
					model.IC_Company=decimal.Parse(row["IC_Company"].ToString());
				}
				if(row["IC_Specification"]!=null)
				{
					model.IC_Specification=row["IC_Specification"].ToString();
				}
				if(row["IC_Reason"]!=null)
				{
					model.IC_Reason=row["IC_Reason"].ToString();
				}
				if(row["IC_Remark"]!=null)
				{
					model.IC_Remark=row["IC_Remark"].ToString();
				}
				if(row["IC_Date"]!=null && row["IC_Date"].ToString()!="")
				{
					model.IC_Date=DateTime.Parse(row["IC_Date"].ToString());
				}
				if(row["IC_Peo"]!=null)
				{
					model.IC_Peo=row["IC_Peo"].ToString();
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
			strSql.Append("select IC_ID,Commo_Id,ID_Cord,IC_Nmae,IC_Num,IC_Company,IC_Specification,IC_Reason,IC_Remark,IC_Date,IC_Peo ");
			strSql.Append(" FROM InventoryChanges ");
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
			strSql.Append("select count(1) FROM InventoryChanges ");
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
				strSql.Append("order by T.IC_ID desc");
			}
			strSql.Append(")AS Row, T.*  from InventoryChanges T ");
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
			parameters[0].Value = "InventoryChanges";
			parameters[1].Value = "IC_ID";
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

