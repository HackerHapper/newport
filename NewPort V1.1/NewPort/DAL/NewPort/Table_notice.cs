using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL.NewPort
{
	/// <summary>
	/// 数据访问类:Table_notice
	/// </summary>
	public partial class Table_notice
	{
		public Table_notice()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string notice_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Table_notice");
			strSql.Append(" where notice_id=@notice_id ");
			SqlParameter[] parameters = {
					new SqlParameter("@notice_id", SqlDbType.Char,10)			};
			parameters[0].Value = notice_id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Maticsoft.Model.NewPort.Table_notice model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Table_notice(");
			strSql.Append("notice_id,notice_time,notice_topic,notice_content,notice_attachmentPath)");
			strSql.Append(" values (");
			strSql.Append("@notice_id,@notice_time,@notice_topic,@notice_content,@notice_attachmentPath)");
			SqlParameter[] parameters = {
					new SqlParameter("@notice_id", SqlDbType.Char,10),
					new SqlParameter("@notice_time", SqlDbType.DateTime),
					new SqlParameter("@notice_topic", SqlDbType.NVarChar,30),
					new SqlParameter("@notice_content", SqlDbType.NText),
					new SqlParameter("@notice_attachmentPath", SqlDbType.VarChar,255)};
			parameters[0].Value = model.notice_id;
			parameters[1].Value = model.notice_time;
			parameters[2].Value = model.notice_topic;
			parameters[3].Value = model.notice_content;
			parameters[4].Value = model.notice_attachmentPath;

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
		public bool Update(Maticsoft.Model.NewPort.Table_notice model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Table_notice set ");
			strSql.Append("notice_time=@notice_time,");
			strSql.Append("notice_topic=@notice_topic,");
			strSql.Append("notice_content=@notice_content,");
			strSql.Append("notice_attachmentPath=@notice_attachmentPath");
			strSql.Append(" where notice_id=@notice_id ");
			SqlParameter[] parameters = {
					new SqlParameter("@notice_time", SqlDbType.DateTime),
					new SqlParameter("@notice_topic", SqlDbType.NVarChar,30),
					new SqlParameter("@notice_content", SqlDbType.NText),
					new SqlParameter("@notice_attachmentPath", SqlDbType.VarChar,255),
					new SqlParameter("@notice_id", SqlDbType.Char,10)};
			parameters[0].Value = model.notice_time;
			parameters[1].Value = model.notice_topic;
			parameters[2].Value = model.notice_content;
			parameters[3].Value = model.notice_attachmentPath;
			parameters[4].Value = model.notice_id;

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
		public bool Delete(string notice_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Table_notice ");
			strSql.Append(" where notice_id=@notice_id ");
			SqlParameter[] parameters = {
					new SqlParameter("@notice_id", SqlDbType.Char,10)			};
			parameters[0].Value = notice_id;

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
		public bool DeleteList(string notice_idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Table_notice ");
			strSql.Append(" where notice_id in ("+notice_idlist + ")  ");
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
		public Maticsoft.Model.NewPort.Table_notice GetModel(string notice_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 notice_id,notice_time,notice_topic,notice_content,notice_attachmentPath from Table_notice ");
			strSql.Append(" where notice_id=@notice_id ");
			SqlParameter[] parameters = {
					new SqlParameter("@notice_id", SqlDbType.Char,10)			};
			parameters[0].Value = notice_id;

			Maticsoft.Model.NewPort.Table_notice model=new Maticsoft.Model.NewPort.Table_notice();
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
		public Maticsoft.Model.NewPort.Table_notice DataRowToModel(DataRow row)
		{
			Maticsoft.Model.NewPort.Table_notice model=new Maticsoft.Model.NewPort.Table_notice();
			if (row != null)
			{
				if(row["notice_id"]!=null)
				{
					model.notice_id=row["notice_id"].ToString();
				}
				if(row["notice_time"]!=null && row["notice_time"].ToString()!="")
				{
					model.notice_time=DateTime.Parse(row["notice_time"].ToString());
				}
				if(row["notice_topic"]!=null)
				{
					model.notice_topic=row["notice_topic"].ToString();
				}
				if(row["notice_content"]!=null)
				{
					model.notice_content=row["notice_content"].ToString();
				}
				if(row["notice_attachmentPath"]!=null)
				{
					model.notice_attachmentPath=row["notice_attachmentPath"].ToString();
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
			strSql.Append("select notice_id,notice_time,notice_topic,notice_content,notice_attachmentPath ");
			strSql.Append(" FROM Table_notice ");
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
			strSql.Append(" notice_id,notice_time,notice_topic,notice_content,notice_attachmentPath ");
			strSql.Append(" FROM Table_notice ");
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
			strSql.Append("select count(1) FROM Table_notice ");
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
			strSql.Append(")AS Row, T.*  from Table_notice T ");
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
			parameters[0].Value = "Table_notice";
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

