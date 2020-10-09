using System;
using System.Data;
using System.Text;
using System.Data.SQLite;
using Maticsoft.DBUtility;//Please add references
using JMZHPos.Model;

namespace JMZHPos.DAL.JMZHPos
{
    /// <summary>
    /// 数据访问类:Commodity
    /// </summary>
    public partial class CommodityDAL
    {
        public CommodityDAL()
        { }
        #region  BasicMethod



        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Commodity model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Commodity(");
            strSql.Append("Commo_Id,Co_Number,Co_Name,Co_Price,Co_Purchase,Co_Member,Co_Instock,Co_InstockPre,Co_Sales,Co_UnitPre,Co_Specification,Co_Item,Co_Categories,Co_Id,Co_creatDate,Co_Shelf,Co_ShelfLife,Co_b_Nunber,Co_JIfen,Co_Remark,Co_R_Datetime,Co_Peo,Co_Name_PinYin)");
            strSql.Append(" values (");
            strSql.Append("@Commo_Id,@Co_Number,@Co_Name,@Co_Price,@Co_Purchase,@Co_Member,@Co_Instock,@Co_InstockPre,@Co_Sales,@Co_UnitPre,@Co_Specification,@Co_Item,@Co_Categories,@Co_Id,@Co_creatDate,@Co_Shelf,@Co_ShelfLife,@Co_b_Nunber,@Co_JIfen,@Co_Remark,@Co_R_Datetime,@Co_Peo,@Co_Name_PinYin)");
            SQLiteParameter[] parameters = {
                    new SQLiteParameter("@Commo_Id", DbType.String,50),
                    new SQLiteParameter("@Co_Number", DbType.String,50),
                    new SQLiteParameter("@Co_Name", DbType.String,50),
                    new SQLiteParameter("@Co_Price", DbType.Decimal,8),
                    new SQLiteParameter("@Co_Purchase", DbType.Decimal,8),
                    new SQLiteParameter("@Co_Member", DbType.Decimal,8),
                    new SQLiteParameter("@Co_Instock", DbType.Decimal,8),
                    new SQLiteParameter("@Co_InstockPre", DbType.Decimal,8),
                    new SQLiteParameter("@Co_Sales", DbType.Decimal,8),
                    new SQLiteParameter("@Co_UnitPre", DbType.String,50),
                    new SQLiteParameter("@Co_Specification", DbType.String,50),
                    new SQLiteParameter("@Co_Item", DbType.String,50),
                    new SQLiteParameter("@Co_Categories", DbType.String,50),
                    new SQLiteParameter("@Co_Id", DbType.String,50),
                    new SQLiteParameter("@Co_creatDate", DbType.DateTime),
                    new SQLiteParameter("@Co_Shelf", DbType.Int32,8),
                    new SQLiteParameter("@Co_ShelfLife", DbType.String,50),
                    new SQLiteParameter("@Co_b_Nunber", DbType.String,50),
                    new SQLiteParameter("@Co_JIfen", DbType.Decimal,8),
                    new SQLiteParameter("@Co_Remark", DbType.String,100),
                    new SQLiteParameter("@Co_R_Datetime", DbType.DateTime),
                    new SQLiteParameter("@Co_Peo", DbType.String,50),
                    new SQLiteParameter("@Co_Name_PinYin", DbType.String,100)};
            parameters[0].Value = model.Commo_Id;
            parameters[1].Value = model.Co_Number;
            parameters[2].Value = model.Co_Name;
            parameters[3].Value = model.Co_Price;
            parameters[4].Value = model.Co_Purchase;
            parameters[5].Value = model.Co_Member;
            parameters[6].Value = model.Co_Instock;
            parameters[7].Value = model.Co_InstockPre;
            parameters[8].Value = model.Co_Sales;
            parameters[9].Value = model.Co_UnitPre;
            parameters[10].Value = model.Co_Specification;
            parameters[11].Value = model.Co_Item;
            parameters[12].Value = model.Co_Categories;
            parameters[13].Value = model.Co_Id;
            parameters[14].Value = model.Co_creatDate;
            parameters[15].Value = model.Co_Shelf;
            parameters[16].Value = model.Co_ShelfLife;
            parameters[17].Value = model.Co_b_Nunber;
            parameters[18].Value = model.Co_JIfen;
            parameters[19].Value = model.Co_Remark;
            parameters[20].Value = model.Co_R_Datetime;
            parameters[21].Value = model.Co_Peo;
            parameters[22].Value = model.Co_Name_PinYin;

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
        public bool Update(Commodity model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Commodity set ");
            strSql.Append("Commo_Id=@Commo_Id,");
            strSql.Append("Co_Number=@Co_Number,");
            strSql.Append("Co_Name=@Co_Name,");
            strSql.Append("Co_Price=@Co_Price,");
            strSql.Append("Co_Purchase=@Co_Purchase,");
            strSql.Append("Co_Member=@Co_Member,");
            strSql.Append("Co_Instock=@Co_Instock,");
            strSql.Append("Co_InstockPre=@Co_InstockPre,");
            strSql.Append("Co_Sales=@Co_Sales,");
            strSql.Append("Co_UnitPre=@Co_UnitPre,");
            strSql.Append("Co_Specification=@Co_Specification,");
            strSql.Append("Co_Item=@Co_Item,");
            strSql.Append("Co_Categories=@Co_Categories,");
            strSql.Append("Co_Id=@Co_Id,");
            strSql.Append("Co_creatDate=@Co_creatDate,");
            strSql.Append("Co_Shelf=@Co_Shelf,");
            strSql.Append("Co_ShelfLife=@Co_ShelfLife,");
            strSql.Append("Co_b_Nunber=@Co_b_Nunber,");
            strSql.Append("Co_JIfen=@Co_JIfen,");
            strSql.Append("Co_Remark=@Co_Remark,");
            strSql.Append("Co_R_Datetime=@Co_R_Datetime,");
            strSql.Append("Co_Peo=@Co_Peo,");
            strSql.Append("Co_Name_PinYin=@Co_Name_PinYin");
            strSql.Append(" where Commo_Id=@Commo_Id");
            SQLiteParameter[] parameters = {
                    new SQLiteParameter("@Commo_Id", DbType.String,50),
                    new SQLiteParameter("@Co_Number", DbType.String,50),
                    new SQLiteParameter("@Co_Name", DbType.String,50),
                    new SQLiteParameter("@Co_Price", DbType.Decimal,8),
                    new SQLiteParameter("@Co_Purchase", DbType.Decimal,8),
                    new SQLiteParameter("@Co_Member", DbType.Decimal,8),
                    new SQLiteParameter("@Co_Instock", DbType.Decimal,8),
                    new SQLiteParameter("@Co_InstockPre", DbType.Decimal,8),
                    new SQLiteParameter("@Co_Sales", DbType.Decimal,8),
                    new SQLiteParameter("@Co_UnitPre", DbType.String,50),
                    new SQLiteParameter("@Co_Specification", DbType.String,50),
                    new SQLiteParameter("@Co_Item", DbType.String,50),
                    new SQLiteParameter("@Co_Categories", DbType.String,50),
                    new SQLiteParameter("@Co_Id", DbType.String,50),
                    new SQLiteParameter("@Co_creatDate", DbType.DateTime),
                    new SQLiteParameter("@Co_Shelf", DbType.Int32,8),
                    new SQLiteParameter("@Co_ShelfLife", DbType.String,50),
                    new SQLiteParameter("@Co_b_Nunber", DbType.String,50),
                    new SQLiteParameter("@Co_JIfen", DbType.Decimal,8),
                    new SQLiteParameter("@Co_Remark", DbType.String,100),
                    new SQLiteParameter("@Co_R_Datetime", DbType.DateTime),
                    new SQLiteParameter("@Co_Peo", DbType.String,50),
                    new SQLiteParameter("@Co_Name_PinYin", DbType.String,100)};
            parameters[0].Value = model.Commo_Id;
            parameters[1].Value = model.Co_Number;
            parameters[2].Value = model.Co_Name;
            parameters[3].Value = model.Co_Price;
            parameters[4].Value = model.Co_Purchase;
            parameters[5].Value = model.Co_Member;
            parameters[6].Value = model.Co_Instock;
            parameters[7].Value = model.Co_InstockPre;
            parameters[8].Value = model.Co_Sales;
            parameters[9].Value = model.Co_UnitPre;
            parameters[10].Value = model.Co_Specification;
            parameters[11].Value = model.Co_Item;
            parameters[12].Value = model.Co_Categories;
            parameters[13].Value = model.Co_Id;
            parameters[14].Value = model.Co_creatDate;
            parameters[15].Value = model.Co_Shelf;
            parameters[16].Value = model.Co_ShelfLife;
            parameters[17].Value = model.Co_b_Nunber;
            parameters[18].Value = model.Co_JIfen;
            parameters[19].Value = model.Co_Remark;
            parameters[20].Value = model.Co_R_Datetime;
            parameters[21].Value = model.Co_Peo;
            parameters[22].Value = model.Co_Name_PinYin;

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
        public bool Delete()
        {
            //该表无主键信息，请自定义主键/条件字段
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Commodity ");
            strSql.Append(" where ");
            SQLiteParameter[] parameters = {
            };

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
        /// 得到一个对象实体
        /// </summary>
        public Commodity GetModel(string Code)
        {
            //该表无主键信息，请自定义主键/条件字段
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Commo_Id,Co_Number,Co_Name,Co_Price,Co_Purchase,Co_Member,Co_Instock,Co_InstockPre,Co_Sales,Co_UnitPre,Co_Specification,Co_Item,Co_Categories,Co_Id,Co_creatDate,Co_Shelf,Co_ShelfLife,Co_b_Nunber,Co_JIfen,Co_Remark,Co_R_Datetime,Co_Peo,Co_Name_PinYin from Commodity ");
            strSql.Append(" where Commo_Id=@Commo_Id ");
            SQLiteParameter[] parameters = {
                    new SQLiteParameter("@Commo_Id", DbType.String,50)
            };
            parameters[0].Value = Code;
            Commodity model = new Commodity();
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
        public Commodity DataRowToModel(DataRow row)
        {
            Commodity model = new Commodity();
            if (row != null)
            {
                if (row["Commo_Id"] != null)
                {
                    model.Commo_Id = row["Commo_Id"].ToString();
                }
                if (row["Co_Number"] != null)
                {
                    model.Co_Number = row["Co_Number"].ToString();
                }
                if (row["Co_Name"] != null)
                {
                    model.Co_Name = row["Co_Name"].ToString();
                }
                if (row["Co_Price"] != null && row["Co_Price"].ToString() != "")
                {
                    model.Co_Price = decimal.Parse(row["Co_Price"].ToString());
                }
                if (row["Co_Purchase"] != null && row["Co_Purchase"].ToString() != "")
                {
                    model.Co_Purchase = decimal.Parse(row["Co_Purchase"].ToString());
                }
                if (row["Co_Member"] != null && row["Co_Member"].ToString() != "")
                {
                    model.Co_Member = decimal.Parse(row["Co_Member"].ToString());
                }
                if (row["Co_Instock"] != null && row["Co_Instock"].ToString() != "")
                {
                    model.Co_Instock = decimal.Parse(row["Co_Instock"].ToString());
                }
                if (row["Co_InstockPre"] != null && row["Co_InstockPre"].ToString() != "")
                {
                    model.Co_InstockPre = decimal.Parse(row["Co_InstockPre"].ToString());
                }
                if (row["Co_Sales"] != null && row["Co_Sales"].ToString() != "")
                {
                    model.Co_Sales = decimal.Parse(row["Co_Sales"].ToString());
                }
                if (row["Co_UnitPre"] != null && row["Co_UnitPre"].ToString() != "")
                {
                    model.Co_UnitPre = row["Co_UnitPre"].ToString();
                }
                if (row["Co_Specification"] != null)
                {
                    model.Co_Specification = row["Co_Specification"].ToString();
                }
                if (row["Co_Item"] != null)
                {
                    model.Co_Item = row["Co_Item"].ToString();
                }
                if (row["Co_Categories"] != null)
                {
                    model.Co_Categories = row["Co_Categories"].ToString();
                }
                if (row["Co_Id"] != null)
                {
                    model.Co_Id = row["Co_Id"].ToString();
                }
                if (row["Co_creatDate"] != null && row["Co_creatDate"].ToString() != "")
                {
                    model.Co_creatDate = DateTime.Parse(row["Co_creatDate"].ToString());
                }
                if (row["Co_Shelf"] != null && row["Co_Shelf"].ToString() != "")
                {
                    model.Co_Shelf = int.Parse(row["Co_Shelf"].ToString());
                }
                if (row["Co_ShelfLife"] != null)
                {
                    model.Co_ShelfLife = row["Co_ShelfLife"].ToString();
                }
                if (row["Co_b_Nunber"] != null)
                {
                    model.Co_b_Nunber = row["Co_b_Nunber"].ToString();
                }
                if (row["Co_JIfen"] != null && row["Co_JIfen"].ToString() != "")
                {
                    model.Co_JIfen = decimal.Parse(row["Co_JIfen"].ToString());
                }
                if (row["Co_Remark"] != null)
                {
                    model.Co_Remark = row["Co_Remark"].ToString();
                }
                if (row["Co_R_Datetime"] != null && row["Co_R_Datetime"].ToString() != "")
                {
                    model.Co_R_Datetime = DateTime.Parse(row["Co_R_Datetime"].ToString());
                }
                if (row["Co_Peo"] != null)
                {
                    model.Co_Peo = row["Co_Peo"].ToString();
                }
                if (row["Co_Name_PinYin"] != null)
                {
                    model.Co_Name_PinYin = row["Co_Name_PinYin"].ToString();
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
            strSql.Append("select Commo_Id,Co_Number,Co_Name,Co_Price,Co_Purchase,Co_Member,Co_Instock,Co_InstockPre,Co_Sales,Co_UnitPre,Co_Specification,Co_Item,Co_Categories,Co_Id,Co_creatDate,Co_Shelf,Co_ShelfLife,Co_b_Nunber,Co_JIfen,Co_Remark,Co_R_Datetime,Co_Peo,Co_Name_PinYin ");
            strSql.Append(" FROM Commodity ");
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
            strSql.Append("select count(1) FROM Commodity ");
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
                strSql.Append("order by T. desc");
            }
            strSql.Append(")AS Row, T.*  from Commodity T ");
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
			parameters[0].Value = "Commodity";
			parameters[1].Value = "";
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