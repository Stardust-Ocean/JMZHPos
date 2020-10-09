using System;
using System.Data;
using System.Text;
using System.Data.SQLite;
using Maticsoft.DBUtility;//Please add references
using JMZHPos.Model;
namespace JMZHPos.DAL
{
    /// <summary>
    /// 数据访问类:Member
    /// </summary>
    public partial class MemberDAL
    {
        public MemberDAL()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQLite.GetMaxID("Me_Id", "Member");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int Me_Id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Member");
            strSql.Append(" where Me_Id=@Me_Id");
            SQLiteParameter[] parameters = {
                    new SQLiteParameter("@Me_Id", DbType.Int32,4)
            };
            parameters[0].Value = Me_Id;

            return DbHelperSQLite.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Member model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Member(");
            strSql.Append("Me_Number,Me_Password,Me_Item,Me_Name,Me_Tel,Me_Birthday,Me_adress,Me_NewDatetime,Me_EffectiveTime,Me_ExpirationTIme,Me_integral,Me_balance,Me_Remark,Me_Card,Me_Peo,Me_Date)");
            strSql.Append(" values (");
            strSql.Append("@Me_Number,@Me_Password,@Me_Item,@Me_Name,@Me_Tel,@Me_Birthday,@Me_adress,@Me_NewDatetime,@Me_EffectiveTime,@Me_ExpirationTIme,@Me_integral,@Me_balance,@Me_Remark,@Me_Card,@Me_Peo,@Me_Date)");
            strSql.Append(";select LAST_INSERT_ROWID()");
            SQLiteParameter[] parameters = {
                    new SQLiteParameter("@Me_Number", DbType.String,50),
                    new SQLiteParameter("@Me_Password", DbType.String,50),
                    new SQLiteParameter("@Me_Item", DbType.String,50),
                    new SQLiteParameter("@Me_Name", DbType.String,50),
                    new SQLiteParameter("@Me_Tel", DbType.String,50),
                    new SQLiteParameter("@Me_Birthday", DbType.DateTime),
                    new SQLiteParameter("@Me_adress", DbType.String,50),
                    new SQLiteParameter("@Me_NewDatetime", DbType.DateTime),
                    new SQLiteParameter("@Me_EffectiveTime", DbType.Int32,8),
                    new SQLiteParameter("@Me_ExpirationTIme", DbType.DateTime),
                    new SQLiteParameter("@Me_integral", DbType.Decimal,8),
                    new SQLiteParameter("@Me_balance", DbType.Decimal,8),
                    new SQLiteParameter("@Me_Remark", DbType.String,100),
                    new SQLiteParameter("@Me_Card", DbType.Int32,8),
                    new SQLiteParameter("@Me_Peo", DbType.String,50),
                    new SQLiteParameter("@Me_Date", DbType.DateTime)};
            parameters[0].Value = model.Me_Number;
            parameters[1].Value = model.Me_Password;
            parameters[2].Value = model.Me_Item;
            parameters[3].Value = model.Me_Name;
            parameters[4].Value = model.Me_Tel;
            parameters[5].Value = model.Me_Birthday;
            parameters[6].Value = model.Me_adress;
            parameters[7].Value = model.Me_NewDatetime;
            parameters[8].Value = model.Me_EffectiveTime;
            parameters[9].Value = model.Me_ExpirationTIme;
            parameters[10].Value = model.Me_integral;
            parameters[11].Value = model.Me_balance;
            parameters[12].Value = model.Me_Remark;
            parameters[13].Value = model.Me_Card;
            parameters[14].Value = model.Me_Peo;
            parameters[15].Value = model.Me_Date;

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
        public bool Update(Member model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Member set ");
            strSql.Append("Me_Number=@Me_Number,");
            strSql.Append("Me_Password=@Me_Password,");
            strSql.Append("Me_Item=@Me_Item,");
            strSql.Append("Me_Name=@Me_Name,");
            strSql.Append("Me_Tel=@Me_Tel,");
            strSql.Append("Me_Birthday=@Me_Birthday,");
            strSql.Append("Me_adress=@Me_adress,");
            strSql.Append("Me_NewDatetime=@Me_NewDatetime,");
            strSql.Append("Me_EffectiveTime=@Me_EffectiveTime,");
            strSql.Append("Me_ExpirationTIme=@Me_ExpirationTIme,");
            strSql.Append("Me_integral=@Me_integral,");
            strSql.Append("Me_balance=@Me_balance,");
            strSql.Append("Me_Remark=@Me_Remark,");
            strSql.Append("Me_Card=@Me_Card,");
            strSql.Append("Me_Peo=@Me_Peo,");
            strSql.Append("Me_Date=@Me_Date");
            strSql.Append(" where Me_Id=@Me_Id");
            SQLiteParameter[] parameters = {
                    new SQLiteParameter("@Me_Number", DbType.String,50),
                    new SQLiteParameter("@Me_Password", DbType.String,50),
                    new SQLiteParameter("@Me_Item", DbType.String,50),
                    new SQLiteParameter("@Me_Name", DbType.String,50),
                    new SQLiteParameter("@Me_Tel", DbType.String,50),
                    new SQLiteParameter("@Me_Birthday", DbType.DateTime),
                    new SQLiteParameter("@Me_adress", DbType.String,50),
                    new SQLiteParameter("@Me_NewDatetime", DbType.DateTime),
                    new SQLiteParameter("@Me_EffectiveTime", DbType.Int32,8),
                    new SQLiteParameter("@Me_ExpirationTIme", DbType.DateTime),
                    new SQLiteParameter("@Me_integral", DbType.Decimal,8),
                    new SQLiteParameter("@Me_balance", DbType.Decimal,8),
                    new SQLiteParameter("@Me_Remark", DbType.String,100),
                    new SQLiteParameter("@Me_Card", DbType.Int32,8),
                    new SQLiteParameter("@Me_Peo", DbType.String,50),
                    new SQLiteParameter("@Me_Date", DbType.DateTime),
                    new SQLiteParameter("@Me_Id", DbType.Int32,8)};
            parameters[0].Value = model.Me_Number;
            parameters[1].Value = model.Me_Password;
            parameters[2].Value = model.Me_Item;
            parameters[3].Value = model.Me_Name;
            parameters[4].Value = model.Me_Tel;
            parameters[5].Value = model.Me_Birthday;
            parameters[6].Value = model.Me_adress;
            parameters[7].Value = model.Me_NewDatetime;
            parameters[8].Value = model.Me_EffectiveTime;
            parameters[9].Value = model.Me_ExpirationTIme;
            parameters[10].Value = model.Me_integral;
            parameters[11].Value = model.Me_balance;
            parameters[12].Value = model.Me_Remark;
            parameters[13].Value = model.Me_Card;
            parameters[14].Value = model.Me_Peo;
            parameters[15].Value = model.Me_Date;
            parameters[16].Value = model.Me_Id;

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
        /// 删除一条数据
        /// </summary>
        public bool Delete(int Me_Id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Member ");
            strSql.Append(" where Me_Id=@Me_Id");
            SQLiteParameter[] parameters = {
                    new SQLiteParameter("@Me_Id", DbType.Int32,4)
            };
            parameters[0].Value = Me_Id;

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
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string Me_Idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Member ");
            strSql.Append(" where Me_Id in (" + Me_Idlist + ")  ");
            int rows = DbHelperSQLite.ExecuteSql(strSql.ToString());
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
        public Member GetModel(int Me_Id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Me_Id,Me_Number,Me_Password,Me_Item,Me_Name,Me_Tel,Me_Birthday,Me_adress,Me_NewDatetime,Me_EffectiveTime,Me_ExpirationTIme,Me_integral,Me_balance,Me_Remark,Me_Card,Me_Peo,Me_Date from Member ");
            strSql.Append(" where Me_Id=@Me_Id");
            SQLiteParameter[] parameters = {
                    new SQLiteParameter("@Me_Id", DbType.Int32,4)
            };
            parameters[0].Value = Me_Id;

            Member model = new Member();
            DataSet ds = DbHelperSQLite.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
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
        public Member DataRowToModel(DataRow row)
        {
            Member model = new Member();
            if (row != null)
            {
                if (row["Me_Id"] != null && row["Me_Id"].ToString() != "")
                {
                    model.Me_Id = int.Parse(row["Me_Id"].ToString());
                }
                if (row["Me_Number"] != null)
                {
                    model.Me_Number = row["Me_Number"].ToString();
                }
                if (row["Me_Password"] != null)
                {
                    model.Me_Password = row["Me_Password"].ToString();
                }
                if (row["Me_Item"] != null)
                {
                    model.Me_Item = row["Me_Item"].ToString();
                }
                if (row["Me_Name"] != null)
                {
                    model.Me_Name = row["Me_Name"].ToString();
                }
                if (row["Me_Tel"] != null)
                {
                    model.Me_Tel = row["Me_Tel"].ToString();
                }
                if (row["Me_Birthday"] != null && row["Me_Birthday"].ToString() != "")
                {
                    model.Me_Birthday = DateTime.Parse(row["Me_Birthday"].ToString());
                }
                if (row["Me_adress"] != null)
                {
                    model.Me_adress = row["Me_adress"].ToString();
                }
                if (row["Me_NewDatetime"] != null && row["Me_NewDatetime"].ToString() != "")
                {
                    model.Me_NewDatetime = DateTime.Parse(row["Me_NewDatetime"].ToString());
                }
                if (row["Me_EffectiveTime"] != null && row["Me_EffectiveTime"].ToString() != "")
                {
                    model.Me_EffectiveTime = int.Parse(row["Me_EffectiveTime"].ToString());
                }
                if (row["Me_ExpirationTIme"] != null && row["Me_ExpirationTIme"].ToString() != "")
                {
                    model.Me_ExpirationTIme = DateTime.Parse(row["Me_ExpirationTIme"].ToString());
                }
                if (row["Me_integral"] != null && row["Me_integral"].ToString() != "")
                {
                    model.Me_integral = decimal.Parse(row["Me_integral"].ToString());
                }
                if (row["Me_balance"] != null && row["Me_balance"].ToString() != "")
                {
                    model.Me_balance = decimal.Parse(row["Me_balance"].ToString());
                }
                if (row["Me_Remark"] != null)
                {
                    model.Me_Remark = row["Me_Remark"].ToString();
                }
                if (row["Me_Card"] != null && row["Me_Card"].ToString() != "")
                {
                    model.Me_Card = int.Parse(row["Me_Card"].ToString());
                }
                if (row["Me_Peo"] != null)
                {
                    model.Me_Peo = row["Me_Peo"].ToString();
                }
                if (row["Me_Date"] != null && row["Me_Date"].ToString() != "")
                {
                    model.Me_Date = DateTime.Parse(row["Me_Date"].ToString());
                }
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Me_Id,Me_Number,Me_Password,Me_Item,Me_Name,Me_Tel,Me_Birthday,Me_adress,Me_NewDatetime,Me_EffectiveTime,Me_ExpirationTIme,Me_integral,Me_balance,Me_Remark,Me_Card,Me_Peo,Me_Date ");
            strSql.Append(" FROM Member ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQLite.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM Member ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
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
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by T." + orderby);
            }
            else
            {
                strSql.Append("order by T.Me_Id desc");
            }
            strSql.Append(")AS Row, T.*  from Member T ");
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
			parameters[0].Value = "Member";
			parameters[1].Value = "Me_Id";
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

