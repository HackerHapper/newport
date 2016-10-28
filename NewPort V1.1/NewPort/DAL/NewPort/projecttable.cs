using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL.NewPort
{
	/// <summary>
	/// 数据访问类:projecttable
	/// </summary>
	public partial class projecttable
	{
		public projecttable()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Maticsoft.Model.NewPort.projecttable model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into projecttable(");
			strSql.Append("project_id,project_name,project_state,project_type,project_area,project_unit,project_place,peoject_content,project_mileage,peoject_capacity,project_totalinvestment,project_startend,investmentin2014,investuntil2014,investmentin2015,totalinvestment,planaccounting,schedule,occupies)");
			strSql.Append(" values (");
			strSql.Append("@project_id,@project_name,@project_state,@project_type,@project_area,@project_unit,@project_place,@peoject_content,@project_mileage,@peoject_capacity,@project_totalinvestment,@project_startend,@investmentin2014,@investuntil2014,@investmentin2015,@totalinvestment,@planaccounting,@schedule,@occupies)");
			SqlParameter[] parameters = {
					new SqlParameter("@project_id", SqlDbType.Float,8),
					new SqlParameter("@project_name", SqlDbType.NVarChar,255),
					new SqlParameter("@project_state", SqlDbType.NVarChar,255),
					new SqlParameter("@project_type", SqlDbType.NVarChar,255),
					new SqlParameter("@project_area", SqlDbType.NVarChar,255),
					new SqlParameter("@project_unit", SqlDbType.NVarChar,255),
					new SqlParameter("@project_place", SqlDbType.NVarChar,255),
					new SqlParameter("@peoject_content", SqlDbType.NVarChar,255),
					new SqlParameter("@project_mileage", SqlDbType.Float,8),
					new SqlParameter("@peoject_capacity", SqlDbType.NVarChar,255),
					new SqlParameter("@project_totalinvestment", SqlDbType.Float,8),
					new SqlParameter("@project_startend", SqlDbType.NVarChar,255),
					new SqlParameter("@investmentin2014", SqlDbType.Float,8),
					new SqlParameter("@investuntil2014", SqlDbType.Float,8),
					new SqlParameter("@investmentin2015", SqlDbType.Float,8),
					new SqlParameter("@totalinvestment", SqlDbType.Float,8),
					new SqlParameter("@planaccounting", SqlDbType.Float,8),
					new SqlParameter("@schedule", SqlDbType.NVarChar,255),
					new SqlParameter("@occupies", SqlDbType.Float,8)};
			parameters[0].Value = model.project_id;
			parameters[1].Value = model.project_name;
			parameters[2].Value = model.project_state;
			parameters[3].Value = model.project_type;
			parameters[4].Value = model.project_area;
			parameters[5].Value = model.project_unit;
			parameters[6].Value = model.project_place;
			parameters[7].Value = model.peoject_content;
			parameters[8].Value = model.project_mileage;
			parameters[9].Value = model.peoject_capacity;
			parameters[10].Value = model.project_totalinvestment;
			parameters[11].Value = model.project_startend;
			parameters[12].Value = model.investmentin2014;
			parameters[13].Value = model.investuntil2014;
			parameters[14].Value = model.investmentin2015;
			parameters[15].Value = model.totalinvestment;
			parameters[16].Value = model.planaccounting;
			parameters[17].Value = model.schedule;
			parameters[18].Value = model.occupies;

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
		public bool Update(Maticsoft.Model.NewPort.projecttable model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update projecttable set ");
			strSql.Append("project_id=@project_id,");
			strSql.Append("project_name=@project_name,");
			strSql.Append("project_state=@project_state,");
			strSql.Append("project_type=@project_type,");
			strSql.Append("project_area=@project_area,");
			strSql.Append("project_unit=@project_unit,");
			strSql.Append("project_place=@project_place,");
			strSql.Append("peoject_content=@peoject_content,");
			strSql.Append("project_mileage=@project_mileage,");
			strSql.Append("peoject_capacity=@peoject_capacity,");
			strSql.Append("project_totalinvestment=@project_totalinvestment,");
			strSql.Append("project_startend=@project_startend,");
			strSql.Append("investmentin2014=@investmentin2014,");
			strSql.Append("investuntil2014=@investuntil2014,");
			strSql.Append("investmentin2015=@investmentin2015,");
			strSql.Append("totalinvestment=@totalinvestment,");
			strSql.Append("planaccounting=@planaccounting,");
			strSql.Append("schedule=@schedule,");
			strSql.Append("occupies=@occupies");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
					new SqlParameter("@project_id", SqlDbType.Float,8),
					new SqlParameter("@project_name", SqlDbType.NVarChar,255),
					new SqlParameter("@project_state", SqlDbType.NVarChar,255),
					new SqlParameter("@project_type", SqlDbType.NVarChar,255),
					new SqlParameter("@project_area", SqlDbType.NVarChar,255),
					new SqlParameter("@project_unit", SqlDbType.NVarChar,255),
					new SqlParameter("@project_place", SqlDbType.NVarChar,255),
					new SqlParameter("@peoject_content", SqlDbType.NVarChar,255),
					new SqlParameter("@project_mileage", SqlDbType.Float,8),
					new SqlParameter("@peoject_capacity", SqlDbType.NVarChar,255),
					new SqlParameter("@project_totalinvestment", SqlDbType.Float,8),
					new SqlParameter("@project_startend", SqlDbType.NVarChar,255),
					new SqlParameter("@investmentin2014", SqlDbType.Float,8),
					new SqlParameter("@investuntil2014", SqlDbType.Float,8),
					new SqlParameter("@investmentin2015", SqlDbType.Float,8),
					new SqlParameter("@totalinvestment", SqlDbType.Float,8),
					new SqlParameter("@planaccounting", SqlDbType.Float,8),
					new SqlParameter("@schedule", SqlDbType.NVarChar,255),
					new SqlParameter("@occupies", SqlDbType.Float,8)};
			parameters[0].Value = model.project_id;
			parameters[1].Value = model.project_name;
			parameters[2].Value = model.project_state;
			parameters[3].Value = model.project_type;
			parameters[4].Value = model.project_area;
			parameters[5].Value = model.project_unit;
			parameters[6].Value = model.project_place;
			parameters[7].Value = model.peoject_content;
			parameters[8].Value = model.project_mileage;
			parameters[9].Value = model.peoject_capacity;
			parameters[10].Value = model.project_totalinvestment;
			parameters[11].Value = model.project_startend;
			parameters[12].Value = model.investmentin2014;
			parameters[13].Value = model.investuntil2014;
			parameters[14].Value = model.investmentin2015;
			parameters[15].Value = model.totalinvestment;
			parameters[16].Value = model.planaccounting;
			parameters[17].Value = model.schedule;
			parameters[18].Value = model.occupies;

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
		public bool Delete()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from projecttable ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

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
		public Maticsoft.Model.NewPort.projecttable GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 project_id,project_name,project_state,project_type,project_area,project_unit,project_place,peoject_content,project_mileage,peoject_capacity,project_totalinvestment,project_startend,investmentin2014,investuntil2014,investmentin2015,totalinvestment,planaccounting,schedule,occupies from projecttable ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			Maticsoft.Model.NewPort.projecttable model=new Maticsoft.Model.NewPort.projecttable();
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
		public Maticsoft.Model.NewPort.projecttable DataRowToModel(DataRow row)
		{
			Maticsoft.Model.NewPort.projecttable model=new Maticsoft.Model.NewPort.projecttable();
			if (row != null)
			{
				if(row["project_id"]!=null && row["project_id"].ToString()!="")
				{
					model.project_id=decimal.Parse(row["project_id"].ToString());
				}
				if(row["project_name"]!=null)
				{
					model.project_name=row["project_name"].ToString();
				}
				if(row["project_state"]!=null)
				{
					model.project_state=row["project_state"].ToString();
				}
				if(row["project_type"]!=null)
				{
					model.project_type=row["project_type"].ToString();
				}
				if(row["project_area"]!=null)
				{
					model.project_area=row["project_area"].ToString();
				}
				if(row["project_unit"]!=null)
				{
					model.project_unit=row["project_unit"].ToString();
				}
				if(row["project_place"]!=null)
				{
					model.project_place=row["project_place"].ToString();
				}
				if(row["peoject_content"]!=null)
				{
					model.peoject_content=row["peoject_content"].ToString();
				}
				if(row["project_mileage"]!=null && row["project_mileage"].ToString()!="")
				{
					model.project_mileage=decimal.Parse(row["project_mileage"].ToString());
				}
				if(row["peoject_capacity"]!=null)
				{
					model.peoject_capacity=row["peoject_capacity"].ToString();
				}
				if(row["project_totalinvestment"]!=null && row["project_totalinvestment"].ToString()!="")
				{
					model.project_totalinvestment=decimal.Parse(row["project_totalinvestment"].ToString());
				}
				if(row["project_startend"]!=null)
				{
					model.project_startend=row["project_startend"].ToString();
				}
				if(row["investmentin2014"]!=null && row["investmentin2014"].ToString()!="")
				{
					model.investmentin2014=decimal.Parse(row["investmentin2014"].ToString());
				}
				if(row["investuntil2014"]!=null && row["investuntil2014"].ToString()!="")
				{
					model.investuntil2014=decimal.Parse(row["investuntil2014"].ToString());
				}
				if(row["investmentin2015"]!=null && row["investmentin2015"].ToString()!="")
				{
					model.investmentin2015=decimal.Parse(row["investmentin2015"].ToString());
				}
				if(row["totalinvestment"]!=null && row["totalinvestment"].ToString()!="")
				{
					model.totalinvestment=decimal.Parse(row["totalinvestment"].ToString());
				}
				if(row["planaccounting"]!=null && row["planaccounting"].ToString()!="")
				{
					model.planaccounting=decimal.Parse(row["planaccounting"].ToString());
				}
				if(row["schedule"]!=null)
				{
					model.schedule=row["schedule"].ToString();
				}
				if(row["occupies"]!=null && row["occupies"].ToString()!="")
				{
					model.occupies=decimal.Parse(row["occupies"].ToString());
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
			strSql.Append("select project_id,project_name,project_state,project_type,project_area,project_unit,project_place,peoject_content,project_mileage,peoject_capacity,project_totalinvestment,project_startend,investmentin2014,investuntil2014,investmentin2015,totalinvestment,planaccounting,schedule,occupies ");
			strSql.Append(" FROM projecttable ");
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
			strSql.Append(" project_id,project_name,project_state,project_type,project_area,project_unit,project_place,peoject_content,project_mileage,peoject_capacity,project_totalinvestment,project_startend,investmentin2014,investuntil2014,investmentin2015,totalinvestment,planaccounting,schedule,occupies ");
			strSql.Append(" FROM projecttable ");
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
			strSql.Append("select count(1) FROM projecttable ");
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
			strSql.Append(")AS Row, T.*  from projecttable T ");
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
			parameters[0].Value = "projecttable";
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

