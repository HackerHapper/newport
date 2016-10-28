using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL.NewPort
{
	/// <summary>
	/// 数据访问类:Table_specialFundRecord
	/// </summary>
	public partial class Table_specialFundRecord
	{
		public Table_specialFundRecord()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string specialFundRecord_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Table_specialFundRecord");
			strSql.Append(" where specialFundRecord_id=@specialFundRecord_id ");
			SqlParameter[] parameters = {
					new SqlParameter("@specialFundRecord_id", SqlDbType.Char,10)			};
			parameters[0].Value = specialFundRecord_id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Maticsoft.Model.NewPort.Table_specialFundRecord model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Table_specialFundRecord(");
			strSql.Append("project_id,specialFundRecord_id,specialFundRecord_description,specialFundRecord_amount,specialFundRecord_methods,specialFundRecord_channel)");
			strSql.Append(" values (");
			strSql.Append("@project_id,@specialFundRecord_id,@specialFundRecord_description,@specialFundRecord_amount,@specialFundRecord_methods,@specialFundRecord_channel)");
			SqlParameter[] parameters = {
					new SqlParameter("@project_id", SqlDbType.Char,8),
					new SqlParameter("@specialFundRecord_id", SqlDbType.Char,10),
					new SqlParameter("@specialFundRecord_description", SqlDbType.NVarChar,200),
					new SqlParameter("@specialFundRecord_amount", SqlDbType.Float,8),
					new SqlParameter("@specialFundRecord_methods", SqlDbType.NVarChar,10),
					new SqlParameter("@specialFundRecord_channel", SqlDbType.NVarChar,20)};
			parameters[0].Value = model.project_id;
			parameters[1].Value = model.specialFundRecord_id;
			parameters[2].Value = model.specialFundRecord_description;
			parameters[3].Value = model.specialFundRecord_amount;
			parameters[4].Value = model.specialFundRecord_methods;
			parameters[5].Value = model.specialFundRecord_channel;

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
		public bool Update(Maticsoft.Model.NewPort.Table_specialFundRecord model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Table_specialFundRecord set ");
			strSql.Append("project_id=@project_id,");
			strSql.Append("specialFundRecord_description=@specialFundRecord_description,");
			strSql.Append("specialFundRecord_amount=@specialFundRecord_amount,");
			strSql.Append("specialFundRecord_methods=@specialFundRecord_methods,");
			strSql.Append("specialFundRecord_channel=@specialFundRecord_channel");
			strSql.Append(" where specialFundRecord_id=@specialFundRecord_id ");
			SqlParameter[] parameters = {
					new SqlParameter("@project_id", SqlDbType.Char,8),
					new SqlParameter("@specialFundRecord_description", SqlDbType.NVarChar,200),
					new SqlParameter("@specialFundRecord_amount", SqlDbType.Float,8),
					new SqlParameter("@specialFundRecord_methods", SqlDbType.NVarChar,10),
					new SqlParameter("@specialFundRecord_channel", SqlDbType.NVarChar,20),
					new SqlParameter("@specialFundRecord_id", SqlDbType.Char,10)};
			parameters[0].Value = model.project_id;
			parameters[1].Value = model.specialFundRecord_description;
			parameters[2].Value = model.specialFundRecord_amount;
			parameters[3].Value = model.specialFundRecord_methods;
			parameters[4].Value = model.specialFundRecord_channel;
			parameters[5].Value = model.specialFundRecord_id;

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
		public bool Delete(string specialFundRecord_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Table_specialFundRecord ");
			strSql.Append(" where specialFundRecord_id=@specialFundRecord_id ");
			SqlParameter[] parameters = {
					new SqlParameter("@specialFundRecord_id", SqlDbType.Char,10)			};
			parameters[0].Value = specialFundRecord_id;

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
		public bool DeleteList(string specialFundRecord_idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Table_specialFundRecord ");
			strSql.Append(" where specialFundRecord_id in ("+specialFundRecord_idlist + ")  ");
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
		public Maticsoft.Model.NewPort.Table_specialFundRecord GetModel(string specialFundRecord_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 project_id,specialFundRecord_id,specialFundRecord_description,specialFundRecord_amount,specialFundRecord_methods,specialFundRecord_channel from Table_specialFundRecord ");
			strSql.Append(" where specialFundRecord_id=@specialFundRecord_id ");
			SqlParameter[] parameters = {
					new SqlParameter("@specialFundRecord_id", SqlDbType.Char,10)			};
			parameters[0].Value = specialFundRecord_id;

			Maticsoft.Model.NewPort.Table_specialFundRecord model=new Maticsoft.Model.NewPort.Table_specialFundRecord();
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
		public Maticsoft.Model.NewPort.Table_specialFundRecord DataRowToModel(DataRow row)
		{
			Maticsoft.Model.NewPort.Table_specialFundRecord model=new Maticsoft.Model.NewPort.Table_specialFundRecord();
			if (row != null)
			{
				if(row["project_id"]!=null)
				{
					model.project_id=row["project_id"].ToString();
				}
				if(row["specialFundRecord_id"]!=null)
				{
					model.specialFundRecord_id=row["specialFundRecord_id"].ToString();
				}
				if(row["specialFundRecord_description"]!=null)
				{
					model.specialFundRecord_description=row["specialFundRecord_description"].ToString();
				}
				if(row["specialFundRecord_amount"]!=null && row["specialFundRecord_amount"].ToString()!="")
				{
					model.specialFundRecord_amount=decimal.Parse(row["specialFundRecord_amount"].ToString());
				}
				if(row["specialFundRecord_methods"]!=null)
				{
					model.specialFundRecord_methods=row["specialFundRecord_methods"].ToString();
				}
				if(row["specialFundRecord_channel"]!=null)
				{
					model.specialFundRecord_channel=row["specialFundRecord_channel"].ToString();
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
			strSql.Append("select project_id,specialFundRecord_id,specialFundRecord_description,specialFundRecord_amount,specialFundRecord_methods,specialFundRecord_channel ");
			strSql.Append(" FROM Table_specialFundRecord ");
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
			strSql.Append(" project_id,specialFundRecord_id,specialFundRecord_description,specialFundRecord_amount,specialFundRecord_methods,specialFundRecord_channel ");
			strSql.Append(" FROM Table_specialFundRecord ");
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
			strSql.Append("select count(1) FROM Table_specialFundRecord ");
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
				strSql.Append("order by T.specialFundRecord_id desc");
			}
			strSql.Append(")AS Row, T.*  from Table_specialFundRecord T ");
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
			parameters[0].Value = "Table_specialFundRecord";
			parameters[1].Value = "specialFundRecord_id";
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

