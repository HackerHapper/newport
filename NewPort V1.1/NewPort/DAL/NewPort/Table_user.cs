using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL.NewPort
{
	/// <summary>
	/// 数据访问类:Table_user
	/// </summary>
	public partial class Table_user
	{
		public Table_user()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string user_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Table_user");
			strSql.Append(" where user_id=@user_id ");
			SqlParameter[] parameters = {
					new SqlParameter("@user_id", SqlDbType.Char,8)			};
			parameters[0].Value = user_id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Maticsoft.Model.NewPort.Table_user model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Table_user(");
			strSql.Append("user_id,user_name,user_dept,user_liablePerson,user_contacterInfo,user_authority,user_password)");
			strSql.Append(" values (");
			strSql.Append("@user_id,@user_name,@user_dept,@user_liablePerson,@user_contacterInfo,@user_authority,@user_password)");
			SqlParameter[] parameters = {
					new SqlParameter("@user_id", SqlDbType.Char,8),
					new SqlParameter("@user_name", SqlDbType.NVarChar,20),
					new SqlParameter("@user_dept", SqlDbType.NVarChar,20),
					new SqlParameter("@user_liablePerson", SqlDbType.NVarChar,20),
					new SqlParameter("@user_contacterInfo", SqlDbType.VarChar,20),
					new SqlParameter("@user_authority", SqlDbType.Int,4),
					new SqlParameter("@user_password", SqlDbType.VarChar,20)};
			parameters[0].Value = model.user_id;
			parameters[1].Value = model.user_name;
			parameters[2].Value = model.user_dept;
			parameters[3].Value = model.user_liablePerson;
			parameters[4].Value = model.user_contacterInfo;
			parameters[5].Value = model.user_authority;
			parameters[6].Value = model.user_password;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
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
		public bool Update(Maticsoft.Model.NewPort.Table_user model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Table_user set ");
			strSql.Append("user_name=@user_name,");
			strSql.Append("user_dept=@user_dept,");
			strSql.Append("user_liablePerson=@user_liablePerson,");
			strSql.Append("user_contacterInfo=@user_contacterInfo,");
			strSql.Append("user_authority=@user_authority,");
			strSql.Append("user_password=@user_password");
			strSql.Append(" where user_id=@user_id ");
			SqlParameter[] parameters = {
					new SqlParameter("@user_name", SqlDbType.NVarChar,20),
					new SqlParameter("@user_dept", SqlDbType.NVarChar,20),
					new SqlParameter("@user_liablePerson", SqlDbType.NVarChar,20),
					new SqlParameter("@user_contacterInfo", SqlDbType.VarChar,20),
					new SqlParameter("@user_authority", SqlDbType.Int,4),
					new SqlParameter("@user_password", SqlDbType.VarChar,20),
					new SqlParameter("@user_id", SqlDbType.Char,8)};
			parameters[0].Value = model.user_name;
			parameters[1].Value = model.user_dept;
			parameters[2].Value = model.user_liablePerson;
			parameters[3].Value = model.user_contacterInfo;
			parameters[4].Value = model.user_authority;
			parameters[5].Value = model.user_password;
			parameters[6].Value = model.user_id;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
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
		public bool Delete(string user_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Table_user ");
			strSql.Append(" where user_id=@user_id ");
			SqlParameter[] parameters = {
					new SqlParameter("@user_id", SqlDbType.Char,8)			};
			parameters[0].Value = user_id;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
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
		public bool DeleteList(string user_idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Table_user ");
			strSql.Append(" where user_id in ("+user_idlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
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
		public Maticsoft.Model.NewPort.Table_user GetModel(string user_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 user_id,user_name,user_dept,user_liablePerson,user_contacterInfo,user_authority,user_password from Table_user ");
			strSql.Append(" where user_id=@user_id ");
			SqlParameter[] parameters = {
					new SqlParameter("@user_id", SqlDbType.Char,8)			};
			parameters[0].Value = user_id;

			Maticsoft.Model.NewPort.Table_user model=new Maticsoft.Model.NewPort.Table_user();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
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
		public Maticsoft.Model.NewPort.Table_user DataRowToModel(DataRow row)
		{
			Maticsoft.Model.NewPort.Table_user model=new Maticsoft.Model.NewPort.Table_user();
			if (row != null)
			{
				if(row["user_id"]!=null)
				{
					model.user_id=row["user_id"].ToString();
				}
				if(row["user_name"]!=null)
				{
					model.user_name=row["user_name"].ToString();
				}
				if(row["user_dept"]!=null)
				{
					model.user_dept=row["user_dept"].ToString();
				}
				if(row["user_liablePerson"]!=null)
				{
					model.user_liablePerson=row["user_liablePerson"].ToString();
				}
				if(row["user_contacterInfo"]!=null)
				{
					model.user_contacterInfo=row["user_contacterInfo"].ToString();
				}
				if(row["user_authority"]!=null && row["user_authority"].ToString()!="")
				{
					model.user_authority=int.Parse(row["user_authority"].ToString());
				}
				if(row["user_password"]!=null)
				{
					model.user_password=row["user_password"].ToString();
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
			strSql.Append("select user_id,user_name,user_dept,user_liablePerson,user_contacterInfo,user_authority,user_password ");
			strSql.Append(" FROM Table_user ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" user_id,user_name,user_dept,user_liablePerson,user_contacterInfo,user_authority,user_password ");
			strSql.Append(" FROM Table_user ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

        public DataSet GetListNoOrder(int Top, string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" user_id,user_name,user_dept,user_liablePerson,user_contacterInfo,user_authority,user_password ");
            strSql.Append(" FROM Table_user ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM Table_user ");
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
				strSql.Append("order by T.user_id desc");
			}
			strSql.Append(")AS Row, T.*  from Table_user T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "Table_user";
			parameters[1].Value = "user_id";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

