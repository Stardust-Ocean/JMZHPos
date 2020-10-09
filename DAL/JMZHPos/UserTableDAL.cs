using System;
using System.Data;
using System.Text;
using System.Data.SQLite;
using Maticsoft.DBUtility;//Please add references
using JMZHPos.Model;

namespace JMZHPos.DAL.JMZHPos
{
	/// <summary>
	/// 数据访问类:UserTable
	/// </summary>
	public partial class UserTableDAL
	{
		public UserTableDAL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQLite.GetMaxID("userID", "UserTable"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int userID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from UserTable");
			strSql.Append(" where userID=@userID");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@userID", DbType.Int32,4)
			};
			parameters[0].Value = userID;

			return DbHelperSQLite.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(UserTable model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into UserTable(");
			strSql.Append("Pow_PowerID,HanId,PowerId,UserName,UserTel,UserCreateTIme,UserPeo,UserAdress,UserPwd)");
			strSql.Append(" values (");
			strSql.Append("@Pow_PowerID,@HanId,@PowerId,@UserName,@UserTel,@UserCreateTIme,@UserPeo,@UserAdress,@UserPwd)");
			strSql.Append(";select LAST_INSERT_ROWID()");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@Pow_PowerID", DbType.Int32,4),
					new SQLiteParameter("@HanId", DbType.Int32,4),
					new SQLiteParameter("@PowerId", DbType.String),
					new SQLiteParameter("@UserName", DbType.String),
					new SQLiteParameter("@UserTel", DbType.String),
					new SQLiteParameter("@UserCreateTIme", DbType.DateTime),
					new SQLiteParameter("@UserPeo", DbType.String),
					new SQLiteParameter("@UserAdress", DbType.String),
					new SQLiteParameter("@UserPwd", DbType.String)};
			parameters[0].Value = model.Pow_PowerID;
			parameters[1].Value = model.HanId;
			parameters[2].Value = model.PowerId;
			parameters[3].Value = model.UserName;
			parameters[4].Value = model.UserTel;
			parameters[5].Value = model.UserCreateTIme;
			parameters[6].Value = model.UserPeo;
			parameters[7].Value = model.UserAdress;
			parameters[8].Value = model.UserPwd;

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
		public bool Update(UserTable model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update UserTable set ");
			strSql.Append("Pow_PowerID=@Pow_PowerID,");
			strSql.Append("HanId=@HanId,");
			strSql.Append("PowerId=@PowerId,");
			strSql.Append("UserName=@UserName,");
			strSql.Append("UserTel=@UserTel,");
			strSql.Append("UserCreateTIme=@UserCreateTIme,");
			strSql.Append("UserPeo=@UserPeo,");
			strSql.Append("UserAdress=@UserAdress,");
			strSql.Append("UserPwd=@UserPwd");
			strSql.Append(" where userID=@userID");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@Pow_PowerID", DbType.Int32,4),
					new SQLiteParameter("@HanId", DbType.Int32,4),
					new SQLiteParameter("@PowerId", DbType.String),
					new SQLiteParameter("@UserName", DbType.String),
					new SQLiteParameter("@UserTel", DbType.String),
					new SQLiteParameter("@UserCreateTIme", DbType.DateTime),
					new SQLiteParameter("@UserPeo", DbType.String),
					new SQLiteParameter("@UserAdress", DbType.String),
					new SQLiteParameter("@UserPwd", DbType.String),
					new SQLiteParameter("@userID", DbType.Int32,8)};
			parameters[0].Value = model.Pow_PowerID;
			parameters[1].Value = model.HanId;
			parameters[2].Value = model.PowerId;
			parameters[3].Value = model.UserName;
			parameters[4].Value = model.UserTel;
			parameters[5].Value = model.UserCreateTIme;
			parameters[6].Value = model.UserPeo;
			parameters[7].Value = model.UserAdress;
			parameters[8].Value = model.UserPwd;
			parameters[9].Value = model.userID;

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
		public bool Delete(int userID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from UserTable ");
			strSql.Append(" where userID=@userID");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@userID", DbType.Int32,4)
			};
			parameters[0].Value = userID;

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
		public bool DeleteList(string userIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from UserTable ");
			strSql.Append(" where userID in ("+userIDlist + ")  ");
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
		public UserTable GetModel(int userID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select userID,Pow_PowerID,HanId,PowerId,UserName,UserTel,UserCreateTIme,UserPeo,UserAdress,UserPwd from UserTable ");
			strSql.Append(" where userID=@userID");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@userID", DbType.Int32,4)
			};
			parameters[0].Value = userID;

			UserTable model=new UserTable();
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
		public UserTable DataRowToModel(DataRow row)
		{
			UserTable model=new UserTable();
			if (row != null)
			{
				if(row["userID"]!=null && row["userID"].ToString()!="")
				{
					model.userID=int.Parse(row["userID"].ToString());
				}
				if(row["Pow_PowerID"]!=null && row["Pow_PowerID"].ToString()!="")
				{
					model.Pow_PowerID=int.Parse(row["Pow_PowerID"].ToString());
				}
				if(row["HanId"]!=null && row["HanId"].ToString()!="")
				{
					model.HanId=int.Parse(row["HanId"].ToString());
				}
				if(row["PowerId"]!=null)
				{
					model.PowerId=row["PowerId"].ToString();
				}
				if(row["UserName"]!=null)
				{
					model.UserName=row["UserName"].ToString();
				}
				if(row["UserTel"]!=null)
				{
					model.UserTel=row["UserTel"].ToString();
				}
				if(row["UserCreateTIme"]!=null && row["UserCreateTIme"].ToString()!="")
				{
					model.UserCreateTIme=DateTime.Parse(row["UserCreateTIme"].ToString());
				}
				if(row["UserPeo"]!=null)
				{
					model.UserPeo=row["UserPeo"].ToString();
				}
				if(row["UserAdress"]!=null)
				{
					model.UserAdress=row["UserAdress"].ToString();
				}
				if(row["UserPwd"]!=null)
				{
					model.UserPwd=row["UserPwd"].ToString();
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
			strSql.Append("select userID,Pow_PowerID,HanId,PowerId,UserName,UserTel,UserCreateTIme,UserPeo,UserAdress,UserPwd ");
			strSql.Append(" FROM UserTable ");
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
			strSql.Append("select count(1) FROM UserTable ");
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
				strSql.Append("order by T.userID desc");
			}
			strSql.Append(")AS Row, T.*  from UserTable T ");
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
			parameters[0].Value = "UserTable";
			parameters[1].Value = "userID";
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

