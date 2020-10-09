using System;
using System.Data;
using System.Text;
using System.Data.SQLite;
using Maticsoft.DBUtility;//Please add references
using JMZHPos.Model;
namespace JMZHPos.DAL.JMZHPos
{
	/// <summary>
	/// 数据访问类:InventoryRecord
	/// </summary>
	public partial class InventoryRecordDAL
	{
		public InventoryRecordDAL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQLite.GetMaxID("IR_ID", "InventoryRecord"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int IR_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from InventoryRecord");
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
		public int Add(InventoryRecord model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into InventoryRecord(");
			strSql.Append("Commo_Id,ID_Date,IR_Type,IR_Num,IR_CoMID,IR_Nmae,IR_Pie,IR_Sum,IR_Amy,IR_SP,IR_Remark,IR_Peo)");
			strSql.Append(" values (");
			strSql.Append("@Commo_Id,@ID_Date,@IR_Type,@IR_Num,@IR_CoMID,@IR_Nmae,@IR_Pie,@IR_Sum,@IR_Amy,@IR_SP,@IR_Remark,@IR_Peo)");
			strSql.Append(";select LAST_INSERT_ROWID()");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@Commo_Id", DbType.String,50),
					new SQLiteParameter("@ID_Date", DbType.DateTime),
					new SQLiteParameter("@IR_Type", DbType.String,50),
					new SQLiteParameter("@IR_Num", DbType.Decimal,8),
					new SQLiteParameter("@IR_CoMID", DbType.String,50),
					new SQLiteParameter("@IR_Nmae", DbType.String,50),
					new SQLiteParameter("@IR_Pie", DbType.String,50),
					new SQLiteParameter("@IR_Sum", DbType.Decimal,8),
					new SQLiteParameter("@IR_Amy", DbType.Decimal,8),
					new SQLiteParameter("@IR_SP", DbType.String,50),
					new SQLiteParameter("@IR_Remark", DbType.String,50),
					new SQLiteParameter("@IR_Peo", DbType.String,50)};
			parameters[0].Value = model.Commo_Id;
			parameters[1].Value = model.ID_Date;
			parameters[2].Value = model.IR_Type;
			parameters[3].Value = model.IR_Num;
			parameters[4].Value = model.IR_CoMID;
			parameters[5].Value = model.IR_Nmae;
			parameters[6].Value = model.IR_Pie;
			parameters[7].Value = model.IR_Sum;
			parameters[8].Value = model.IR_Amy;
			parameters[9].Value = model.IR_SP;
			parameters[10].Value = model.IR_Remark;
			parameters[11].Value = model.IR_Peo;

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
		public bool Update(InventoryRecord model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update InventoryRecord set ");
			strSql.Append("Commo_Id=@Commo_Id,");
			strSql.Append("ID_Date=@ID_Date,");
			strSql.Append("IR_Type=@IR_Type,");
			strSql.Append("IR_Num=@IR_Num,");
			strSql.Append("IR_CoMID=@IR_CoMID,");
			strSql.Append("IR_Nmae=@IR_Nmae,");
			strSql.Append("IR_Pie=@IR_Pie,");
			strSql.Append("IR_Sum=@IR_Sum,");
			strSql.Append("IR_Amy=@IR_Amy,");
			strSql.Append("IR_SP=@IR_SP,");
			strSql.Append("IR_Remark=@IR_Remark,");
			strSql.Append("IR_Peo=@IR_Peo");
			strSql.Append(" where IR_ID=@IR_ID");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@Commo_Id", DbType.String,50),
					new SQLiteParameter("@ID_Date", DbType.DateTime),
					new SQLiteParameter("@IR_Type", DbType.String,50),
					new SQLiteParameter("@IR_Num", DbType.Decimal,8),
					new SQLiteParameter("@IR_CoMID", DbType.String,50),
					new SQLiteParameter("@IR_Nmae", DbType.String,50),
					new SQLiteParameter("@IR_Pie", DbType.String,50),
					new SQLiteParameter("@IR_Sum", DbType.Decimal,8),
					new SQLiteParameter("@IR_Amy", DbType.Decimal,8),
					new SQLiteParameter("@IR_SP", DbType.String,50),
					new SQLiteParameter("@IR_Remark", DbType.String,50),
					new SQLiteParameter("@IR_Peo", DbType.String,50),
					new SQLiteParameter("@IR_ID", DbType.Int32,8)};
			parameters[0].Value = model.Commo_Id;
			parameters[1].Value = model.ID_Date;
			parameters[2].Value = model.IR_Type;
			parameters[3].Value = model.IR_Num;
			parameters[4].Value = model.IR_CoMID;
			parameters[5].Value = model.IR_Nmae;
			parameters[6].Value = model.IR_Pie;
			parameters[7].Value = model.IR_Sum;
			parameters[8].Value = model.IR_Amy;
			parameters[9].Value = model.IR_SP;
			parameters[10].Value = model.IR_Remark;
			parameters[11].Value = model.IR_Peo;
			parameters[12].Value = model.IR_ID;

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
			strSql.Append("delete from InventoryRecord ");
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
			strSql.Append("delete from InventoryRecord ");
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
		public InventoryRecord GetModel(int IR_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select IR_ID,Commo_Id,ID_Date,IR_Type,IR_Num,IR_CoMID,IR_Nmae,IR_Pie,IR_Sum,IR_Amy,IR_SP,IR_Remark,IR_Peo from InventoryRecord ");
			strSql.Append(" where IR_ID=@IR_ID");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@IR_ID", DbType.Int32,4)
			};
			parameters[0].Value = IR_ID;

			InventoryRecord model=new InventoryRecord();
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
		public InventoryRecord DataRowToModel(DataRow row)
		{
			InventoryRecord model=new InventoryRecord();
			if (row != null)
			{
				if(row["IR_ID"]!=null && row["IR_ID"].ToString()!="")
				{
					model.IR_ID=int.Parse(row["IR_ID"].ToString());
				}
				if(row["Commo_Id"]!=null)
				{
					model.Commo_Id=row["Commo_Id"].ToString();
				}
				if(row["ID_Date"]!=null && row["ID_Date"].ToString()!="")
				{
					model.ID_Date=DateTime.Parse(row["ID_Date"].ToString());
				}
				if(row["IR_Type"]!=null)
				{
					model.IR_Type=row["IR_Type"].ToString();
				}
				if(row["IR_Num"]!=null && row["IR_Num"].ToString()!="")
				{
					model.IR_Num=decimal.Parse(row["IR_Num"].ToString());
				}
				if(row["IR_CoMID"]!=null)
				{
					model.IR_CoMID=row["IR_CoMID"].ToString();
				}
				if(row["IR_Nmae"]!=null)
				{
					model.IR_Nmae=row["IR_Nmae"].ToString();
				}
				if(row["IR_Pie"]!=null)
				{
					model.IR_Pie=row["IR_Pie"].ToString();
				}
				if(row["IR_Sum"]!=null && row["IR_Sum"].ToString()!="")
				{
					model.IR_Sum=decimal.Parse(row["IR_Sum"].ToString());
				}
				if(row["IR_Amy"]!=null && row["IR_Amy"].ToString()!="")
				{
					model.IR_Amy=decimal.Parse(row["IR_Amy"].ToString());
				}
				if(row["IR_SP"]!=null)
				{
					model.IR_SP=row["IR_SP"].ToString();
				}
				if(row["IR_Remark"]!=null)
				{
					model.IR_Remark=row["IR_Remark"].ToString();
				}
				if(row["IR_Peo"]!=null)
				{
					model.IR_Peo=row["IR_Peo"].ToString();
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
			strSql.Append("select IR_ID,Commo_Id,ID_Date,IR_Type,IR_Num,IR_CoMID,IR_Nmae,IR_Pie,IR_Sum,IR_Amy,IR_SP,IR_Remark,IR_Peo ");
			strSql.Append(" FROM InventoryRecord ");
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
			strSql.Append("select count(1) FROM InventoryRecord ");
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
			strSql.Append(")AS Row, T.*  from InventoryRecord T ");
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
			parameters[0].Value = "InventoryRecord";
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

