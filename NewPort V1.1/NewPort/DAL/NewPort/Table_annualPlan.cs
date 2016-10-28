using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL.NewPort
{
	/// <summary>
	/// 数据访问类:Table_annualPlan
	/// </summary>
	public partial class Table_annualPlan
	{
		public Table_annualPlan()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string annualPlan_sn)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Table_annualPlan");
			strSql.Append(" where annualPlan_sn=@annualPlan_sn ");
			SqlParameter[] parameters = {
					new SqlParameter("@annualPlan_sn", SqlDbType.Char,10)			};
			parameters[0].Value = annualPlan_sn;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Maticsoft.Model.NewPort.Table_annualPlan model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Table_annualPlan(");
			strSql.Append("annualPlan_sn,project_id,plan_id,annualPlan_targetCompletion,annualPlan_targetDescription,annualPlan_earlyProgress,annualPlan_checkState)");
			strSql.Append(" values (");
			strSql.Append("@annualPlan_sn,@project_id,@plan_id,@annualPlan_targetCompletion,@annualPlan_targetDescription,@annualPlan_earlyProgress,@annualPlan_checkState)");
			SqlParameter[] parameters = {
					new SqlParameter("@annualPlan_sn", SqlDbType.Char,10),
					new SqlParameter("@project_id", SqlDbType.Char,8),
					new SqlParameter("@plan_id", SqlDbType.Char,6),
					new SqlParameter("@annualPlan_targetCompletion", SqlDbType.Float,8),
					new SqlParameter("@annualPlan_targetDescription", SqlDbType.NText),
					new SqlParameter("@annualPlan_earlyProgress", SqlDbType.NText),
					new SqlParameter("@annualPlan_checkState", SqlDbType.NChar,10)};
			parameters[0].Value = model.annualPlan_sn;
			parameters[1].Value = model.project_id;
			parameters[2].Value = model.plan_id;
			parameters[3].Value = model.annualPlan_targetCompletion;
			parameters[4].Value = model.annualPlan_targetDescription;
			parameters[5].Value = model.annualPlan_earlyProgress;
			parameters[6].Value = model.annualPlan_checkState;

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
		public bool Update(Maticsoft.Model.NewPort.Table_annualPlan model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Table_annualPlan set ");
			strSql.Append("project_id=@project_id,");
			strSql.Append("plan_id=@plan_id,");
			strSql.Append("annualPlan_targetCompletion=@annualPlan_targetCompletion,");
			strSql.Append("annualPlan_targetDescription=@annualPlan_targetDescription,");
			strSql.Append("annualPlan_earlyProgress=@annualPlan_earlyProgress,");
			strSql.Append("annualPlan_checkState=@annualPlan_checkState");
			strSql.Append(" where annualPlan_sn=@annualPlan_sn ");
			SqlParameter[] parameters = {
					new SqlParameter("@project_id", SqlDbType.Char,8),
					new SqlParameter("@plan_id", SqlDbType.Char,6),
					new SqlParameter("@annualPlan_targetCompletion", SqlDbType.Float,8),
					new SqlParameter("@annualPlan_targetDescription", SqlDbType.NText),
					new SqlParameter("@annualPlan_earlyProgress", SqlDbType.NText),
					new SqlParameter("@annualPlan_checkState", SqlDbType.NChar,10),
					new SqlParameter("@annualPlan_sn", SqlDbType.Char,10)};
			parameters[0].Value = model.project_id;
			parameters[1].Value = model.plan_id;
			parameters[2].Value = model.annualPlan_targetCompletion;
			parameters[3].Value = model.annualPlan_targetDescription;
			parameters[4].Value = model.annualPlan_earlyProgress;
			parameters[5].Value = model.annualPlan_checkState;
			parameters[6].Value = model.annualPlan_sn;

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
		public bool Delete(string annualPlan_sn)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Table_annualPlan ");
			strSql.Append(" where annualPlan_sn=@annualPlan_sn ");
			SqlParameter[] parameters = {
					new SqlParameter("@annualPlan_sn", SqlDbType.Char,10)			};
			parameters[0].Value = annualPlan_sn;

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
		public bool DeleteList(string annualPlan_snlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Table_annualPlan ");
			strSql.Append(" where annualPlan_sn in ("+annualPlan_snlist + ")  ");
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
		public Maticsoft.Model.NewPort.Table_annualPlan GetModel(string annualPlan_sn)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 annualPlan_sn,project_id,plan_id,annualPlan_targetCompletion,annualPlan_targetDescription,annualPlan_earlyProgress,annualPlan_checkState from Table_annualPlan ");
			strSql.Append(" where annualPlan_sn=@annualPlan_sn ");
			SqlParameter[] parameters = {
					new SqlParameter("@annualPlan_sn", SqlDbType.Char,10)			};
			parameters[0].Value = annualPlan_sn;

			Maticsoft.Model.NewPort.Table_annualPlan model=new Maticsoft.Model.NewPort.Table_annualPlan();
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
		public Maticsoft.Model.NewPort.Table_annualPlan DataRowToModel(DataRow row)
		{
			Maticsoft.Model.NewPort.Table_annualPlan model=new Maticsoft.Model.NewPort.Table_annualPlan();
			if (row != null)
			{
				if(row["annualPlan_sn"]!=null)
				{
					model.annualPlan_sn=row["annualPlan_sn"].ToString();
				}
				if(row["project_id"]!=null)
				{
					model.project_id=row["project_id"].ToString();
				}
				if(row["plan_id"]!=null)
				{
					model.plan_id=row["plan_id"].ToString();
				}
				if(row["annualPlan_targetCompletion"]!=null && row["annualPlan_targetCompletion"].ToString()!="")
				{
					model.annualPlan_targetCompletion=decimal.Parse(row["annualPlan_targetCompletion"].ToString());
				}
				if(row["annualPlan_targetDescription"]!=null)
				{
					model.annualPlan_targetDescription=row["annualPlan_targetDescription"].ToString();
				}
				if(row["annualPlan_earlyProgress"]!=null)
				{
					model.annualPlan_earlyProgress=row["annualPlan_earlyProgress"].ToString();
				}
				if(row["annualPlan_checkState"]!=null)
				{
					model.annualPlan_checkState=row["annualPlan_checkState"].ToString();
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
			strSql.Append("select annualPlan_sn,project_id,plan_id,annualPlan_targetCompletion,annualPlan_targetDescription,annualPlan_earlyProgress,annualPlan_checkState ");
			strSql.Append(" FROM Table_annualPlan ");
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
			strSql.Append(" annualPlan_sn,project_id,plan_id,annualPlan_targetCompletion,annualPlan_targetDescription,annualPlan_earlyProgress,annualPlan_checkState ");
			strSql.Append(" FROM Table_annualPlan ");
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
			strSql.Append("select count(1) FROM Table_annualPlan ");
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
				strSql.Append("order by T.annualPlan_sn desc");
			}
			strSql.Append(")AS Row, T.*  from Table_annualPlan T ");
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
			parameters[0].Value = "Table_annualPlan";
			parameters[1].Value = "annualPlan_sn";
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

