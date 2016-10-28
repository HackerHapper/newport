using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL.NewPort
{
	/// <summary>
	/// 数据访问类:Table_plan
	/// </summary>
	public partial class Table_plan
	{
		public Table_plan()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string plan_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Table_plan");
			strSql.Append(" where plan_id=@plan_id ");
			SqlParameter[] parameters = {
					new SqlParameter("@plan_id", SqlDbType.Char,6)			};
			parameters[0].Value = plan_id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Maticsoft.Model.NewPort.Table_plan model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Table_plan(");
			strSql.Append("plan_id,plan_name,plan_description,plan_startTime,plan_endTime)");
			strSql.Append(" values (");
			strSql.Append("@plan_id,@plan_name,@plan_description,@plan_startTime,@plan_endTime)");
			SqlParameter[] parameters = {
					new SqlParameter("@plan_id", SqlDbType.Char,6),
					new SqlParameter("@plan_name", SqlDbType.NVarChar,20),
					new SqlParameter("@plan_description", SqlDbType.NVarChar,200),
					new SqlParameter("@plan_startTime", SqlDbType.DateTime),
					new SqlParameter("@plan_endTime", SqlDbType.DateTime)};
			parameters[0].Value = model.plan_id;
			parameters[1].Value = model.plan_name;
			parameters[2].Value = model.plan_description;
			parameters[3].Value = model.plan_startTime;
			parameters[4].Value = model.plan_endTime;

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
		public bool Update(Maticsoft.Model.NewPort.Table_plan model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Table_plan set ");
			strSql.Append("plan_name=@plan_name,");
			strSql.Append("plan_description=@plan_description,");
			strSql.Append("plan_startTime=@plan_startTime,");
			strSql.Append("plan_endTime=@plan_endTime");
			strSql.Append(" where plan_id=@plan_id ");
			SqlParameter[] parameters = {
					new SqlParameter("@plan_name", SqlDbType.NVarChar,20),
					new SqlParameter("@plan_description", SqlDbType.NVarChar,200),
					new SqlParameter("@plan_startTime", SqlDbType.DateTime),
					new SqlParameter("@plan_endTime", SqlDbType.DateTime),
					new SqlParameter("@plan_id", SqlDbType.Char,6)};
			parameters[0].Value = model.plan_name;
			parameters[1].Value = model.plan_description;
			parameters[2].Value = model.plan_startTime;
			parameters[3].Value = model.plan_endTime;
			parameters[4].Value = model.plan_id;

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
		public bool Delete(string plan_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Table_plan ");
			strSql.Append(" where plan_id=@plan_id ");
			SqlParameter[] parameters = {
					new SqlParameter("@plan_id", SqlDbType.Char,6)			};
			parameters[0].Value = plan_id;

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
		public bool DeleteList(string plan_idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Table_plan ");
			strSql.Append(" where plan_id in ("+plan_idlist + ")  ");
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
		public Maticsoft.Model.NewPort.Table_plan GetModel(string plan_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 plan_id,plan_name,plan_description,plan_startTime,plan_endTime from Table_plan ");
			strSql.Append(" where plan_id=@plan_id ");
			SqlParameter[] parameters = {
					new SqlParameter("@plan_id", SqlDbType.Char,6)			};
			parameters[0].Value = plan_id;

			Maticsoft.Model.NewPort.Table_plan model=new Maticsoft.Model.NewPort.Table_plan();
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
		public Maticsoft.Model.NewPort.Table_plan DataRowToModel(DataRow row)
		{
			Maticsoft.Model.NewPort.Table_plan model=new Maticsoft.Model.NewPort.Table_plan();
			if (row != null)
			{
				if(row["plan_id"]!=null)
				{
					model.plan_id=row["plan_id"].ToString();
				}
				if(row["plan_name"]!=null)
				{
					model.plan_name=row["plan_name"].ToString();
				}
				if(row["plan_description"]!=null)
				{
					model.plan_description=row["plan_description"].ToString();
				}
				if(row["plan_startTime"]!=null && row["plan_startTime"].ToString()!="")
				{
					model.plan_startTime=DateTime.Parse(row["plan_startTime"].ToString());
				}
				if(row["plan_endTime"]!=null && row["plan_endTime"].ToString()!="")
				{
					model.plan_endTime=DateTime.Parse(row["plan_endTime"].ToString());
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
			strSql.Append("select plan_id,plan_name,plan_description,plan_startTime,plan_endTime ");
			strSql.Append(" FROM Table_plan ");
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
			strSql.Append(" plan_id,plan_name,plan_description,plan_startTime,plan_endTime ");
			strSql.Append(" FROM Table_plan ");
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
			strSql.Append("select count(1) FROM Table_plan ");
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
				strSql.Append("order by T.plan_id desc");
			}
			strSql.Append(")AS Row, T.*  from Table_plan T ");
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
			parameters[0].Value = "Table_plan";
			parameters[1].Value = "plan_id";
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

