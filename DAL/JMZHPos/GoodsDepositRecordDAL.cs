using System;
using System.Data;
using System.Text;
using System.Data.SQLite;
using Maticsoft.DBUtility;//Please add references
using JMZHPos.Model;

namespace JMZHPos.DAL.JMZHPos
{
	/// <summary>
	/// 数据访问类:GoodsDepositRecord
	/// </summary>
	public partial class GoodsDepositRecordDAL
	{
		public GoodsDepositRecordDAL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQLite.GetMaxID("GD_ID", "GoodsDepositRecord"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int GD_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from GoodsDepositRecord");
			strSql.Append(" where GD_ID=@GD_ID");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@GD_ID", DbType.Int32,4)
			};
			parameters[0].Value = GD_ID;

			return DbHelperSQLite.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(GoodsDepositRecord model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into GoodsDepositRecord(");
			strSql.Append("id,GD_Date,GD_Number,GD_Shop,GD_Access,GD_Sum,GD_Remark,GD_Peo)");
			strSql.Append(" values (");
			strSql.Append("@id,@GD_Date,@GD_Number,@GD_Shop,@GD_Access,@GD_Sum,@GD_Remark,@GD_Peo)");
			strSql.Append(";select LAST_INSERT_ROWID()");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@id", DbType.Int32,8),
					new SQLiteParameter("@GD_Date", DbType.DateTime),
					new SQLiteParameter("@GD_Number", DbType.String,50),
					new SQLiteParameter("@GD_Shop", DbType.String,50),
					new SQLiteParameter("@GD_Access", DbType.String,50),
					new SQLiteParameter("@GD_Sum", DbType.Int32,8),
					new SQLiteParameter("@GD_Remark", DbType.String,50),
					new SQLiteParameter("@GD_Peo", DbType.String,50)};
			parameters[0].Value = model.id;
			parameters[1].Value = model.GD_Date;
			parameters[2].Value = model.GD_Number;
			parameters[3].Value = model.GD_Shop;
			parameters[4].Value = model.GD_Access;
			parameters[5].Value = model.GD_Sum;
			parameters[6].Value = model.GD_Remark;
			parameters[7].Value = model.GD_Peo;

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
		public bool Update(GoodsDepositRecord model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update GoodsDepositRecord set ");
			strSql.Append("id=@id,");
			strSql.Append("GD_Date=@GD_Date,");
			strSql.Append("GD_Number=@GD_Number,");
			strSql.Append("GD_Shop=@GD_Shop,");
			strSql.Append("GD_Access=@GD_Access,");
			strSql.Append("GD_Sum=@GD_Sum,");
			strSql.Append("GD_Remark=@GD_Remark,");
			strSql.Append("GD_Peo=@GD_Peo");
			strSql.Append(" where GD_ID=@GD_ID");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@id", DbType.Int32,8),
					new SQLiteParameter("@GD_Date", DbType.DateTime),
					new SQLiteParameter("@GD_Number", DbType.String,50),
					new SQLiteParameter("@GD_Shop", DbType.String,50),
					new SQLiteParameter("@GD_Access", DbType.String,50),
					new SQLiteParameter("@GD_Sum", DbType.Int32,8),
					new SQLiteParameter("@GD_Remark", DbType.String,50),
					new SQLiteParameter("@GD_Peo", DbType.String,50),
					new SQLiteParameter("@GD_ID", DbType.Int32,8)};
			parameters[0].Value = model.id;
			parameters[1].Value = model.GD_Date;
			parameters[2].Value = model.GD_Number;
			parameters[3].Value = model.GD_Shop;
			parameters[4].Value = model.GD_Access;
			parameters[5].Value = model.GD_Sum;
			parameters[6].Value = model.GD_Remark;
			parameters[7].Value = model.GD_Peo;
			parameters[8].Value = model.GD_ID;

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
		public bool Delete(int GD_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from GoodsDepositRecord ");
			strSql.Append(" where GD_ID=@GD_ID");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@GD_ID", DbType.Int32,4)
			};
			parameters[0].Value = GD_ID;

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
		public bool DeleteList(string GD_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from GoodsDepositRecord ");
			strSql.Append(" where GD_ID in ("+GD_IDlist + ")  ");
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
		public GoodsDepositRecord GetModel(int GD_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select GD_ID,id,GD_Date,GD_Number,GD_Shop,GD_Access,GD_Sum,GD_Remark,GD_Peo from GoodsDepositRecord ");
			strSql.Append(" where GD_ID=@GD_ID");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@GD_ID", DbType.Int32,4)
			};
			parameters[0].Value = GD_ID;

			GoodsDepositRecord model=new GoodsDepositRecord();
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
		public GoodsDepositRecord DataRowToModel(DataRow row)
		{
			GoodsDepositRecord model=new GoodsDepositRecord();
			if (row != null)
			{
				if(row["GD_ID"]!=null && row["GD_ID"].ToString()!="")
				{
					model.GD_ID=int.Parse(row["GD_ID"].ToString());
				}
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=int.Parse(row["id"].ToString());
				}
				if(row["GD_Date"]!=null && row["GD_Date"].ToString()!="")
				{
					model.GD_Date=DateTime.Parse(row["GD_Date"].ToString());
				}
				if(row["GD_Number"]!=null)
				{
					model.GD_Number=row["GD_Number"].ToString();
				}
				if(row["GD_Shop"]!=null)
				{
					model.GD_Shop=row["GD_Shop"].ToString();
				}
				if(row["GD_Access"]!=null)
				{
					model.GD_Access=row["GD_Access"].ToString();
				}
				if(row["GD_Sum"]!=null && row["GD_Sum"].ToString()!="")
				{
					model.GD_Sum=int.Parse(row["GD_Sum"].ToString());
				}
				if(row["GD_Remark"]!=null)
				{
					model.GD_Remark=row["GD_Remark"].ToString();
				}
				if(row["GD_Peo"]!=null)
				{
					model.GD_Peo=row["GD_Peo"].ToString();
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
			strSql.Append("select GD_ID,id,GD_Date,GD_Number,GD_Shop,GD_Access,GD_Sum,GD_Remark,GD_Peo ");
			strSql.Append(" FROM GoodsDepositRecord ");
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
			strSql.Append("select count(1) FROM GoodsDepositRecord ");
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
				strSql.Append("order by T.GD_ID desc");
			}
			strSql.Append(")AS Row, T.*  from GoodsDepositRecord T ");
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
			parameters[0].Value = "GoodsDepositRecord";
			parameters[1].Value = "GD_ID";
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

