using System;
using System.Data;
using System.Text;
using System.Data.SQLite;
using Maticsoft.DBUtility;//Please add references
using JMZHPos.Model;

namespace JMZHPos.DAL.JMZHPos
{
	/// <summary>
	/// 数据访问类:Supplier
	/// </summary>
	public partial class SupplierDAL
	{
		public SupplierDAL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQLite.GetMaxID("SP_ID", "Supplier"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int SP_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Supplier");
			strSql.Append(" where SP_ID=@SP_ID");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@SP_ID", DbType.Int32,4)
			};
			parameters[0].Value = SP_ID;

			return DbHelperSQLite.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Supplier model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Supplier(");
			strSql.Append("Commo_Id,SP_Name,SP_Prople,SP_Tele,SP_Tel,SP_Email,SP_Adress,SP_Mark)");
			strSql.Append(" values (");
			strSql.Append("@Commo_Id,@SP_Name,@SP_Prople,@SP_Tele,@SP_Tel,@SP_Email,@SP_Adress,@SP_Mark)");
			strSql.Append(";select LAST_INSERT_ROWID()");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@Commo_Id", DbType.String,50),
					new SQLiteParameter("@SP_Name", DbType.String,50),
					new SQLiteParameter("@SP_Prople", DbType.String,50),
					new SQLiteParameter("@SP_Tele", DbType.String,50),
					new SQLiteParameter("@SP_Tel", DbType.String,50),
					new SQLiteParameter("@SP_Email", DbType.String,50),
					new SQLiteParameter("@SP_Adress", DbType.String,50),
					new SQLiteParameter("@SP_Mark", DbType.String,100)};
			parameters[0].Value = model.Commo_Id;
			parameters[1].Value = model.SP_Name;
			parameters[2].Value = model.SP_Prople;
			parameters[3].Value = model.SP_Tele;
			parameters[4].Value = model.SP_Tel;
			parameters[5].Value = model.SP_Email;
			parameters[6].Value = model.SP_Adress;
			parameters[7].Value = model.SP_Mark;

            int rows = DbHelperSQLite.ExecuteSql(strSql.ToString(), parameters);
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
		public bool Update(Supplier model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Supplier set ");
			strSql.Append("Commo_Id=@Commo_Id,");
			strSql.Append("SP_Name=@SP_Name,");
			strSql.Append("SP_Prople=@SP_Prople,");
			strSql.Append("SP_Tele=@SP_Tele,");
			strSql.Append("SP_Tel=@SP_Tel,");
			strSql.Append("SP_Email=@SP_Email,");
			strSql.Append("SP_Adress=@SP_Adress,");
			strSql.Append("SP_Mark=@SP_Mark");
			strSql.Append(" where SP_ID=@SP_ID");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@Commo_Id", DbType.String,50),
					new SQLiteParameter("@SP_Name", DbType.String,50),
					new SQLiteParameter("@SP_Prople", DbType.String,50),
					new SQLiteParameter("@SP_Tele", DbType.String,50),
					new SQLiteParameter("@SP_Tel", DbType.String,50),
					new SQLiteParameter("@SP_Email", DbType.String,50),
					new SQLiteParameter("@SP_Adress", DbType.String,50),
					new SQLiteParameter("@SP_Mark", DbType.String,100),
					new SQLiteParameter("@SP_ID", DbType.Int32,8)};
			parameters[0].Value = model.Commo_Id;
			parameters[1].Value = model.SP_Name;
			parameters[2].Value = model.SP_Prople;
			parameters[3].Value = model.SP_Tele;
			parameters[4].Value = model.SP_Tel;
			parameters[5].Value = model.SP_Email;
			parameters[6].Value = model.SP_Adress;
			parameters[7].Value = model.SP_Mark;
			parameters[8].Value = model.SP_ID;

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
		public bool Delete(int SP_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Supplier ");
			strSql.Append(" where SP_ID=@SP_ID");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@SP_ID", DbType.Int32,4)
			};
			parameters[0].Value = SP_ID;

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
		public bool DeleteList(string SP_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Supplier ");
			strSql.Append(" where SP_ID in ("+SP_IDlist + ")  ");
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
		public Supplier GetModel(string SP_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select SP_ID,Commo_Id,SP_Name,SP_Prople,SP_Tele,SP_Tel,SP_Email,SP_Adress,SP_Mark from Supplier ");
			strSql.Append(" where SP_ID=@SP_ID");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@SP_ID", DbType.Int32,4)
			};
			parameters[0].Value = SP_ID;

			Supplier model=new Supplier();
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
		public Supplier DataRowToModel(DataRow row)
		{
			Supplier model=new Supplier();
			if (row != null)
			{
				if(row["SP_ID"]!=null && row["SP_ID"].ToString()!="")
				{
					model.SP_ID=int.Parse(row["SP_ID"].ToString());
				}
				if(row["Commo_Id"]!=null)
				{
					model.Commo_Id=row["Commo_Id"].ToString();
				}
				if(row["SP_Name"]!=null)
				{
					model.SP_Name=row["SP_Name"].ToString();
				}
				if(row["SP_Prople"]!=null)
				{
					model.SP_Prople=row["SP_Prople"].ToString();
				}
				if(row["SP_Tele"]!=null)
				{
					model.SP_Tele=row["SP_Tele"].ToString();
				}
				if(row["SP_Tel"]!=null)
				{
					model.SP_Tel=row["SP_Tel"].ToString();
				}
				if(row["SP_Email"]!=null)
				{
					model.SP_Email=row["SP_Email"].ToString();
				}
				if(row["SP_Adress"]!=null)
				{
					model.SP_Adress=row["SP_Adress"].ToString();
				}
				if(row["SP_Mark"]!=null)
				{
					model.SP_Mark=row["SP_Mark"].ToString();
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
			strSql.Append("select SP_ID,Commo_Id,SP_Name,SP_Prople,SP_Tele,SP_Tel,SP_Email,SP_Adress,SP_Mark ");
			strSql.Append(" FROM Supplier ");
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
			strSql.Append("select count(1) FROM Supplier ");
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
				strSql.Append("order by T.SP_ID desc");
			}
			strSql.Append(")AS Row, T.*  from Supplier T ");
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
			parameters[0].Value = "Supplier";
			parameters[1].Value = "SP_ID";
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

