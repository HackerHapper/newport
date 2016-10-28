using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL.NewPort
{
	/// <summary>
	/// 数据访问类:Table_projectAttachment
	/// </summary>
	public partial class Table_projectAttachment
	{
		public Table_projectAttachment()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string projectAttachment_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Table_projectAttachment");
			strSql.Append(" where projectAttachment_id=@projectAttachment_id ");
			SqlParameter[] parameters = {
					new SqlParameter("@projectAttachment_id", SqlDbType.Char,10)			};
			parameters[0].Value = projectAttachment_id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Maticsoft.Model.NewPort.Table_projectAttachment model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Table_projectAttachment(");
			strSql.Append("projectAttachment_id,project_id,projectAttachment_path,projectAttachment_name,projectAttachment_uploadTime)");
			strSql.Append(" values (");
			strSql.Append("@projectAttachment_id,@project_id,@projectAttachment_path,@projectAttachment_name,@projectAttachment_uploadTime)");
			SqlParameter[] parameters = {
					new SqlParameter("@projectAttachment_id", SqlDbType.Char,10),
					new SqlParameter("@project_id", SqlDbType.Char,8),
					new SqlParameter("@projectAttachment_path", SqlDbType.VarChar,255),
					new SqlParameter("@projectAttachment_name", SqlDbType.NVarChar,30),
					new SqlParameter("@projectAttachment_uploadTime", SqlDbType.DateTime)};
			parameters[0].Value = model.projectAttachment_id;
			parameters[1].Value = model.project_id;
			parameters[2].Value = model.projectAttachment_path;
			parameters[3].Value = model.projectAttachment_name;
			parameters[4].Value = model.projectAttachment_uploadTime;

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
		public bool Update(Maticsoft.Model.NewPort.Table_projectAttachment model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Table_projectAttachment set ");
			strSql.Append("project_id=@project_id,");
			strSql.Append("projectAttachment_path=@projectAttachment_path,");
			strSql.Append("projectAttachment_name=@projectAttachment_name,");
			strSql.Append("projectAttachment_uploadTime=@projectAttachment_uploadTime");
			strSql.Append(" where projectAttachment_id=@projectAttachment_id ");
			SqlParameter[] parameters = {
					new SqlParameter("@project_id", SqlDbType.Char,8),
					new SqlParameter("@projectAttachment_path", SqlDbType.VarChar,255),
					new SqlParameter("@projectAttachment_name", SqlDbType.NVarChar,30),
					new SqlParameter("@projectAttachment_uploadTime", SqlDbType.DateTime),
					new SqlParameter("@projectAttachment_id", SqlDbType.Char,10)};
			parameters[0].Value = model.project_id;
			parameters[1].Value = model.projectAttachment_path;
			parameters[2].Value = model.projectAttachment_name;
			parameters[3].Value = model.projectAttachment_uploadTime;
			parameters[4].Value = model.projectAttachment_id;

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
		public bool Delete(string projectAttachment_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Table_projectAttachment ");
			strSql.Append(" where projectAttachment_id=@projectAttachment_id ");
			SqlParameter[] parameters = {
					new SqlParameter("@projectAttachment_id", SqlDbType.Char,10)			};
			parameters[0].Value = projectAttachment_id;

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
		public bool DeleteList(string projectAttachment_idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Table_projectAttachment ");
			strSql.Append(" where projectAttachment_id in ("+projectAttachment_idlist + ")  ");
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
		public Maticsoft.Model.NewPort.Table_projectAttachment GetModel(string projectAttachment_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 projectAttachment_id,project_id,projectAttachment_path,projectAttachment_name,projectAttachment_uploadTime from Table_projectAttachment ");
			strSql.Append(" where projectAttachment_id=@projectAttachment_id ");
			SqlParameter[] parameters = {
					new SqlParameter("@projectAttachment_id", SqlDbType.Char,10)			};
			parameters[0].Value = projectAttachment_id;

			Maticsoft.Model.NewPort.Table_projectAttachment model=new Maticsoft.Model.NewPort.Table_projectAttachment();
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
		public Maticsoft.Model.NewPort.Table_projectAttachment DataRowToModel(DataRow row)
		{
			Maticsoft.Model.NewPort.Table_projectAttachment model=new Maticsoft.Model.NewPort.Table_projectAttachment();
			if (row != null)
			{
				if(row["projectAttachment_id"]!=null)
				{
					model.projectAttachment_id=row["projectAttachment_id"].ToString();
				}
				if(row["project_id"]!=null)
				{
					model.project_id=row["project_id"].ToString();
				}
				if(row["projectAttachment_path"]!=null)
				{
					model.projectAttachment_path=row["projectAttachment_path"].ToString();
				}
				if(row["projectAttachment_name"]!=null)
				{
					model.projectAttachment_name=row["projectAttachment_name"].ToString();
				}
				if(row["projectAttachment_uploadTime"]!=null && row["projectAttachment_uploadTime"].ToString()!="")
				{
					model.projectAttachment_uploadTime=DateTime.Parse(row["projectAttachment_uploadTime"].ToString());
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
			strSql.Append("select projectAttachment_id,project_id,projectAttachment_path,projectAttachment_name,projectAttachment_uploadTime ");
			strSql.Append(" FROM Table_projectAttachment ");
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
			strSql.Append(" projectAttachment_id,project_id,projectAttachment_path,projectAttachment_name,projectAttachment_uploadTime ");
			strSql.Append(" FROM Table_projectAttachment ");
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
			strSql.Append("select count(1) FROM Table_projectAttachment ");
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
				strSql.Append("order by T.projectAttachment_id desc");
			}
			strSql.Append(")AS Row, T.*  from Table_projectAttachment T ");
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
			parameters[0].Value = "Table_projectAttachment";
			parameters[1].Value = "projectAttachment_id";
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

