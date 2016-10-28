using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL.NewPort
{
	/// <summary>
	/// 数据访问类:Table_noticeReceiveRecord
	/// </summary>
	public partial class Table_noticeReceiveRecord
	{
		public Table_noticeReceiveRecord()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string user_id,string notice_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Table_noticeReceiveRecord");
			strSql.Append(" where user_id=@user_id and notice_id=@notice_id ");
			SqlParameter[] parameters = {
					new SqlParameter("@user_id", SqlDbType.Char,8),
					new SqlParameter("@notice_id", SqlDbType.Char,10)			};
			parameters[0].Value = user_id;
			parameters[1].Value = notice_id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Maticsoft.Model.NewPort.Table_noticeReceiveRecord model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Table_noticeReceiveRecord(");
			strSql.Append("user_id,notice_id,noticeReceiveRecord_readTime)");
			strSql.Append(" values (");
			strSql.Append("@user_id,@notice_id,@noticeReceiveRecord_readTime)");
			SqlParameter[] parameters = {
					new SqlParameter("@user_id", SqlDbType.Char,8),
					new SqlParameter("@notice_id", SqlDbType.Char,10),
					new SqlParameter("@noticeReceiveRecord_readTime", SqlDbType.DateTime)};
			parameters[0].Value = model.user_id;
			parameters[1].Value = model.notice_id;
			parameters[2].Value = model.noticeReceiveRecord_readTime;

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
		public bool Update(Maticsoft.Model.NewPort.Table_noticeReceiveRecord model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Table_noticeReceiveRecord set ");
			strSql.Append("noticeReceiveRecord_readTime=@noticeReceiveRecord_readTime");
			strSql.Append(" where user_id=@user_id and notice_id=@notice_id ");
			SqlParameter[] parameters = {
					new SqlParameter("@noticeReceiveRecord_readTime", SqlDbType.DateTime),
					new SqlParameter("@user_id", SqlDbType.Char,8),
					new SqlParameter("@notice_id", SqlDbType.Char,10)};
			parameters[0].Value = model.noticeReceiveRecord_readTime;
			parameters[1].Value = model.user_id;
			parameters[2].Value = model.notice_id;

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
		public bool Delete(string user_id,string notice_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Table_noticeReceiveRecord ");
			strSql.Append(" where user_id=@user_id and notice_id=@notice_id ");
			SqlParameter[] parameters = {
					new SqlParameter("@user_id", SqlDbType.Char,8),
					new SqlParameter("@notice_id", SqlDbType.Char,10)			};
			parameters[0].Value = user_id;
			parameters[1].Value = notice_id;

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
		/// 得到一个对象实体
		/// </summary>
		public Maticsoft.Model.NewPort.Table_noticeReceiveRecord GetModel(string user_id,string notice_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 user_id,notice_id,noticeReceiveRecord_readTime from Table_noticeReceiveRecord ");
			strSql.Append(" where user_id=@user_id and notice_id=@notice_id ");
			SqlParameter[] parameters = {
					new SqlParameter("@user_id", SqlDbType.Char,8),
					new SqlParameter("@notice_id", SqlDbType.Char,10)			};
			parameters[0].Value = user_id;
			parameters[1].Value = notice_id;

			Maticsoft.Model.NewPort.Table_noticeReceiveRecord model=new Maticsoft.Model.NewPort.Table_noticeReceiveRecord();
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
		public Maticsoft.Model.NewPort.Table_noticeReceiveRecord DataRowToModel(DataRow row)
		{
			Maticsoft.Model.NewPort.Table_noticeReceiveRecord model=new Maticsoft.Model.NewPort.Table_noticeReceiveRecord();
			if (row != null)
			{
				if(row["user_id"]!=null)
				{
					model.user_id=row["user_id"].ToString();
				}
				if(row["notice_id"]!=null)
				{
					model.notice_id=row["notice_id"].ToString();
				}
				if(row["noticeReceiveRecord_readTime"]!=null && row["noticeReceiveRecord_readTime"].ToString()!="")
				{
					model.noticeReceiveRecord_readTime=DateTime.Parse(row["noticeReceiveRecord_readTime"].ToString());
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
			strSql.Append("select user_id,notice_id,noticeReceiveRecord_readTime ");
			strSql.Append(" FROM Table_noticeReceiveRecord ");
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
			strSql.Append(" user_id,notice_id,noticeReceiveRecord_readTime ");
			strSql.Append(" FROM Table_noticeReceiveRecord ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM Table_noticeReceiveRecord ");
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
				strSql.Append("order by T.notice_id desc");
			}
			strSql.Append(")AS Row, T.*  from Table_noticeReceiveRecord T ");
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
			parameters[0].Value = "Table_noticeReceiveRecord";
			parameters[1].Value = "notice_id";
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

