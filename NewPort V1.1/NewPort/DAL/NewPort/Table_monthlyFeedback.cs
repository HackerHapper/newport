using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL.NewPort
{
	/// <summary>
	/// 数据访问类:Table_monthlyFeedback
	/// </summary>
	public partial class Table_monthlyFeedback
	{
		public Table_monthlyFeedback()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string monthlyFeedback_sn)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Table_monthlyFeedback");
			strSql.Append(" where monthlyFeedback_sn=@monthlyFeedback_sn ");
			SqlParameter[] parameters = {
					new SqlParameter("@monthlyFeedback_sn", SqlDbType.Char,10)			};
			parameters[0].Value = monthlyFeedback_sn;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Maticsoft.Model.NewPort.Table_monthlyFeedback model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Table_monthlyFeedback(");
            strSql.Append("monthlyFeedback_sn,monthlyFeedback_yyyyMM,project_id,monthlyFeedback_fulfilment,monthlyFeedback_fulfilmentDescription,monthlyFeedback_writer)");
			strSql.Append(" values (");
            strSql.Append("@monthlyFeedback_sn,@monthlyFeedback_yyyyMM,@project_id,@monthlyFeedback_fulfilment,@monthlyFeedback_fulfilmentDescription,@monthlyFeedback_writer)");
			SqlParameter[] parameters = {
					new SqlParameter("@monthlyFeedback_sn", SqlDbType.Char,10),
					new SqlParameter("@monthlyFeedback_yyyyMM", SqlDbType.DateTime,3),
					new SqlParameter("@project_id", SqlDbType.Char,8),
					new SqlParameter("@monthlyFeedback_fulfilment", SqlDbType.Float,8),
					new SqlParameter("@monthlyFeedback_fulfilmentDescription", SqlDbType.NText),
					new SqlParameter("@monthlyFeedback_writer", SqlDbType.NChar,20)};
			parameters[0].Value = model.monthlyFeedback_sn;
			parameters[1].Value = model.monthlyFeedback_yyyyMM;
			parameters[2].Value = model.project_id;
			parameters[3].Value = model.monthlyFeedback_fulfilment;
            parameters[4].Value = model.monthlyFeedback_fulfilmentDescription;
            parameters[5].Value = model.monthlyFeedback_writer;

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
		public bool Update(Maticsoft.Model.NewPort.Table_monthlyFeedback model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Table_monthlyFeedback set ");
			strSql.Append("monthlyFeedback_yyyyMM=@monthlyFeedback_yyyyMM,");
			strSql.Append("project_id=@project_id,");
			strSql.Append("monthlyFeedback_fulfilment=@monthlyFeedback_fulfilment,");
            strSql.Append("monthlyFeedback_fulfilmentDescription=@monthlyFeedback_fulfilmentDescription");
            strSql.Append("monthlyFeedback_writer=@monthlyFeedback_writer");
			strSql.Append(" where monthlyFeedback_sn=@monthlyFeedback_sn ");
			SqlParameter[] parameters = {
					new SqlParameter("@monthlyFeedback_yyyyMM", SqlDbType.DateTime,3),
					new SqlParameter("@project_id", SqlDbType.Char,8),
					new SqlParameter("@monthlyFeedback_fulfilment", SqlDbType.Float,8),
					new SqlParameter("@monthlyFeedback_fulfilmentDescription", SqlDbType.NText),
					new SqlParameter("@monthlyFeedback_writer", SqlDbType.NChar,20),
					new SqlParameter("@monthlyFeedback_sn", SqlDbType.Char,10)};
			parameters[0].Value = model.monthlyFeedback_yyyyMM;
			parameters[1].Value = model.project_id;
			parameters[2].Value = model.monthlyFeedback_fulfilment;
			parameters[3].Value = model.monthlyFeedback_fulfilmentDescription;
			parameters[4].Value = model.monthlyFeedback_sn;

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
		public bool Delete(string monthlyFeedback_sn)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Table_monthlyFeedback ");
			strSql.Append(" where monthlyFeedback_sn=@monthlyFeedback_sn ");
			SqlParameter[] parameters = {
					new SqlParameter("@monthlyFeedback_sn", SqlDbType.Char,10)			};
			parameters[0].Value = monthlyFeedback_sn;

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
		public bool DeleteList(string monthlyFeedback_snlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Table_monthlyFeedback ");
			strSql.Append(" where monthlyFeedback_sn in ("+monthlyFeedback_snlist + ")  ");
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
		public Maticsoft.Model.NewPort.Table_monthlyFeedback GetModel(string monthlyFeedback_sn)
		{
			
			StringBuilder strSql=new StringBuilder();
            strSql.Append("select  top 1 monthlyFeedback_sn,monthlyFeedback_yyyyMM,project_id,monthlyFeedback_fulfilment,monthlyFeedback_fulfilmentDescription,monthlyFeedback_writer from Table_monthlyFeedback ");
			strSql.Append(" where monthlyFeedback_sn=@monthlyFeedback_sn ");
			SqlParameter[] parameters = {
					new SqlParameter("@monthlyFeedback_sn", SqlDbType.Char,10)			};
			parameters[0].Value = monthlyFeedback_sn;

			Maticsoft.Model.NewPort.Table_monthlyFeedback model=new Maticsoft.Model.NewPort.Table_monthlyFeedback();
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
		public Maticsoft.Model.NewPort.Table_monthlyFeedback DataRowToModel(DataRow row)
		{
			Maticsoft.Model.NewPort.Table_monthlyFeedback model=new Maticsoft.Model.NewPort.Table_monthlyFeedback();
			if (row != null)
			{
				if(row["monthlyFeedback_sn"]!=null)
				{
					model.monthlyFeedback_sn=row["monthlyFeedback_sn"].ToString();
				}
				if(row["monthlyFeedback_yyyyMM"]!=null && row["monthlyFeedback_yyyyMM"].ToString()!="")
				{
					model.monthlyFeedback_yyyyMM=DateTime.Parse(row["monthlyFeedback_yyyyMM"].ToString());
				}
				if(row["project_id"]!=null)
				{
					model.project_id=row["project_id"].ToString();
				}
				if(row["monthlyFeedback_fulfilment"]!=null && row["monthlyFeedback_fulfilment"].ToString()!="")
				{
					model.monthlyFeedback_fulfilment=decimal.Parse(row["monthlyFeedback_fulfilment"].ToString());
				}
				if(row["monthlyFeedback_fulfilmentDescription"]!=null)
				{
					model.monthlyFeedback_fulfilmentDescription=row["monthlyFeedback_fulfilmentDescription"].ToString();
				}
                if (row["monthlyFeedback_writer"] != null)
                {
                    model.monthlyFeedback_fulfilmentDescription = row["monthlyFeedback_writer"].ToString();
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
            strSql.Append("select monthlyFeedback_sn,monthlyFeedback_yyyyMM,project_id,monthlyFeedback_fulfilment,monthlyFeedback_fulfilmentDescription,monthlyFeedback_writer ");
			strSql.Append(" FROM Table_monthlyFeedback ");
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
            strSql.Append(" monthlyFeedback_sn,monthlyFeedback_yyyyMM,project_id,monthlyFeedback_fulfilment,monthlyFeedback_fulfilmentDescription,monthlyFeedback_writer ");
			strSql.Append(" FROM Table_monthlyFeedback ");
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
			strSql.Append("select count(1) FROM Table_monthlyFeedback ");
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
				strSql.Append("order by T.monthlyFeedback_sn desc");
			}
			strSql.Append(")AS Row, T.*  from Table_monthlyFeedback T ");
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
			parameters[0].Value = "Table_monthlyFeedback";
			parameters[1].Value = "monthlyFeedback_sn";
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

