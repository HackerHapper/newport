using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;
using Maticsoft.Common;//Please add references

namespace Maticsoft.DAL.NewPort
{
	/// <summary>
	/// 数据访问类:Table_project
	/// </summary>
	public partial class Table_project
	{
		public Table_project()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string project_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Table_project");
			strSql.Append(" where project_id=@project_id ");
			SqlParameter[] parameters = {
					new SqlParameter("@project_id", SqlDbType.Char,8)			};
			parameters[0].Value = project_id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Maticsoft.Model.NewPort.Table_project model)
		{
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Table_project(");
            strSql.Append("project_id,project_responUnit,project_name,project_owner,project_positon,project_type,project_constrContent,project_scale,project_designCapacity,project_designCapacityUnit,project_designCapacityRemarks,project_totalInvestment,project_constrStartTime,project_constrEndTime,project_coveredArea,project_state,project_stateChangedTime)");
            strSql.Append(" values (");
            strSql.Append("@project_id,@project_responUnit,@project_name,@project_owner,@project_positon,@project_type,@project_constrContent,@project_scale,@project_designCapacity,@project_designCapacityUnit,@project_designCapacityRemarks,@project_totalInvestment,@project_constrStartTime,@project_constrEndTime,@project_coveredArea,@project_state,@project_stateChangedTime)");
            SqlParameter[] parameters = {
					new SqlParameter("@project_id", SqlDbType.Char,8),
                    new SqlParameter("@project_responUnit", SqlDbType.NVarChar,20),
					new SqlParameter("@project_name", SqlDbType.NVarChar,30),
					new SqlParameter("@project_owner", SqlDbType.NVarChar,30),
					new SqlParameter("@project_positon", SqlDbType.NVarChar,30),
					new SqlParameter("@project_type", SqlDbType.NVarChar,10),
					new SqlParameter("@project_constrContent", SqlDbType.NText),
					new SqlParameter("@project_scale", SqlDbType.Float,8),
					new SqlParameter("@project_designCapacity", SqlDbType.Float,8),
					new SqlParameter("@project_designCapacityUnit", SqlDbType.NChar,10),
					new SqlParameter("@project_designCapacityRemarks", SqlDbType.NVarChar,50),
					new SqlParameter("@project_totalInvestment", SqlDbType.Float,8),
					new SqlParameter("@project_constrStartTime", SqlDbType.DateTime),
					new SqlParameter("@project_constrEndTime", SqlDbType.DateTime),
					new SqlParameter("@project_coveredArea", SqlDbType.Float,8),
					new SqlParameter("@project_state", SqlDbType.NVarChar,10),
					new SqlParameter("@project_stateChangedTime", SqlDbType.DateTime)};
            parameters[0].Value = model.project_id;
            parameters[1].Value = model.project_responUnit;
            parameters[2].Value = model.project_name;
            parameters[3].Value = model.project_owner;
            parameters[4].Value = model.project_positon;
            parameters[5].Value = model.project_type;
            parameters[6].Value = model.project_constrContent;
            parameters[7].Value = model.project_scale;
            parameters[8].Value = model.project_designCapacity;
            parameters[9].Value = model.project_designCapacityUnit;
            parameters[10].Value = model.project_designCapacityRemarks;
            parameters[11].Value = model.project_totalInvestment;
            parameters[12].Value = model.project_constrStartTime;
            parameters[13].Value = model.project_constrEndTime;
            parameters[14].Value = model.project_coveredArea;
            parameters[15].Value = model.project_state;
            parameters[16].Value = model.project_stateChangedTime;

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
		public bool Update(Maticsoft.Model.NewPort.Table_project model)
		{
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Table_project set ");
            strSql.Append("project_responUnit=@project_responUnit,");
            strSql.Append("project_name=@project_name,");
            strSql.Append("project_owner=@project_owner,");
            strSql.Append("project_positon=@project_positon,");
            strSql.Append("project_type=@project_type,");
            strSql.Append("project_constrContent=@project_constrContent,");
            strSql.Append("project_scale=@project_scale,");
            strSql.Append("project_designCapacity=@project_designCapacity,");
            strSql.Append("project_designCapacityUnit=@project_designCapacityUnit,");
            strSql.Append("project_designCapacityRemarks=@project_designCapacityRemarks,");
            strSql.Append("project_totalInvestment=@project_totalInvestment,");
            strSql.Append("project_constrStartTime=@project_constrStartTime,");
            strSql.Append("project_constrEndTime=@project_constrEndTime,");
            strSql.Append("project_coveredArea=@project_coveredArea,");
            strSql.Append("project_state=@project_state,");
            strSql.Append("project_stateChangedTime=@project_stateChangedTime");
            strSql.Append(" where project_id=@project_id ");
            SqlParameter[] parameters = {
                    new SqlParameter("@project_responUnit", SqlDbType.NVarChar,20),
					new SqlParameter("@project_name", SqlDbType.NVarChar,30),
					new SqlParameter("@project_owner", SqlDbType.NVarChar,30),
					new SqlParameter("@project_positon", SqlDbType.NVarChar,30),
					new SqlParameter("@project_type", SqlDbType.NVarChar,10),
					new SqlParameter("@project_constrContent", SqlDbType.NText),
					new SqlParameter("@project_scale", SqlDbType.Float,8),
					new SqlParameter("@project_designCapacity", SqlDbType.Float,8),
					new SqlParameter("@project_designCapacityUnit", SqlDbType.NChar,10),
					new SqlParameter("@project_designCapacityRemarks", SqlDbType.NVarChar,50),
					new SqlParameter("@project_totalInvestment", SqlDbType.Float,8),
					new SqlParameter("@project_constrStartTime", SqlDbType.DateTime),
					new SqlParameter("@project_constrEndTime", SqlDbType.DateTime),
					new SqlParameter("@project_coveredArea", SqlDbType.Float,8),
					new SqlParameter("@project_state", SqlDbType.NVarChar,10),
					new SqlParameter("@project_stateChangedTime", SqlDbType.DateTime),
					new SqlParameter("@project_id", SqlDbType.Char,8)};
            parameters[0].Value = model.project_responUnit;
            parameters[1].Value = model.project_name;
            parameters[2].Value = model.project_owner;
            parameters[3].Value = model.project_positon;
            parameters[4].Value = model.project_type;
            parameters[5].Value = model.project_constrContent;
            parameters[6].Value = model.project_scale;
            parameters[7].Value = model.project_designCapacity;
            parameters[8].Value = model.project_designCapacityUnit;
            parameters[9].Value = model.project_designCapacityRemarks;
            parameters[10].Value = model.project_totalInvestment;
            parameters[11].Value = model.project_constrStartTime;
            parameters[12].Value = model.project_constrEndTime;
            parameters[13].Value = model.project_coveredArea;
            parameters[14].Value = model.project_state;
            parameters[15].Value = model.project_stateChangedTime;
            parameters[16].Value = model.project_id;


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
        public bool UpdateCheck(Maticsoft.Model.NewPort.Table_project model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Table_project set ");
            strSql.Append("project_check=@project_check");
            strSql.Append(" where project_id=@project_id ");
            SqlParameter[] parameters = {
					new SqlParameter("@project_check", SqlDbType.Char,10),
					new SqlParameter("@project_id", SqlDbType.Char,8)};
            parameters[0].Value = model.project_check;
            parameters[1].Value = model.project_id;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
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
		public bool Delete(string project_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Table_project ");
			strSql.Append(" where project_id=@project_id ");
			SqlParameter[] parameters = {
					new SqlParameter("@project_id", SqlDbType.Char,8)			};
			parameters[0].Value = project_id;

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
		public bool DeleteList(string project_idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Table_project ");
			strSql.Append(" where project_id in ("+project_idlist + ")  ");
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
		public Maticsoft.Model.NewPort.Table_project GetModel(string project_id)
		{

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 project_id,project_responUnit,project_name,project_owner,project_positon,project_type,project_constrContent,project_scale,project_designCapacity,project_designCapacityUnit,project_designCapacityRemarks,project_totalInvestment,project_constrStartTime,project_constrEndTime,project_coveredArea,project_state,project_stateChangedTime from Table_project ");
            strSql.Append(" where project_id=@project_id ");
            SqlParameter[] parameters = {
					new SqlParameter("@project_id", SqlDbType.Char,8)			};
            parameters[0].Value = project_id;

			Maticsoft.Model.NewPort.Table_project model=new Maticsoft.Model.NewPort.Table_project();
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
		public Maticsoft.Model.NewPort.Table_project DataRowToModel(DataRow row)
		{
			Maticsoft.Model.NewPort.Table_project model=new Maticsoft.Model.NewPort.Table_project();
            if (row != null)
            {
                if (row["project_id"] != null)
                {
                    model.project_id = row["project_id"].ToString();
                }
                if (row["project_responUnit"] != null)
                {
                    model.project_id = row["project_responUnit"].ToString();
                }
                if (row["project_name"] != null)
                {
                    model.project_name = row["project_name"].ToString();
                }
                if (row["project_owner"] != null)
                {
                    model.project_owner = row["project_owner"].ToString();
                }
                if (row["project_positon"] != null)
                {
                    model.project_positon = row["project_positon"].ToString();
                }
                if (row["project_type"] != null)
                {
                    model.project_type = row["project_type"].ToString();
                }
                if (row["project_constrContent"] != null)
                {
                    model.project_constrContent = row["project_constrContent"].ToString();
                }
                if (row["project_scale"] != null && row["project_scale"].ToString() != "")
                {
                    model.project_scale = decimal.Parse(row["project_scale"].ToString());
                }
                if (row["project_designCapacity"] != null && row["project_designCapacity"].ToString() != "")
                {
                    model.project_designCapacity = decimal.Parse(row["project_designCapacity"].ToString());
                }
                if (row["project_designCapacityUnit"] != null)
                {
                    model.project_designCapacityUnit = row["project_designCapacityUnit"].ToString();
                }
                if (row["project_designCapacityRemarks"] != null)
                {
                    model.project_designCapacityRemarks = row["project_designCapacityRemarks"].ToString();
                }
                if (row["project_totalInvestment"] != null && row["project_totalInvestment"].ToString() != "")
                {
                    model.project_totalInvestment = decimal.Parse(row["project_totalInvestment"].ToString());
                }
                if (row["project_constrStartTime"] != null && row["project_constrStartTime"].ToString() != "")
                {
                    model.project_constrStartTime = DateTime.Parse(row["project_constrStartTime"].ToString());
                }
                if (row["project_constrEndTime"] != null && row["project_constrEndTime"].ToString() != "")
                {
                    model.project_constrEndTime = DateTime.Parse(row["project_constrEndTime"].ToString());
                }
                if (row["project_coveredArea"] != null && row["project_coveredArea"].ToString() != "")
                {
                    model.project_coveredArea = decimal.Parse(row["project_coveredArea"].ToString());
                }
                if (row["project_state"] != null)
                {
                    model.project_state = row["project_state"].ToString();
                }
                if (row["project_stateChangedTime"] != null && row["project_stateChangedTime"].ToString() != "")
                {
                    model.project_stateChangedTime = DateTime.Parse(row["project_stateChangedTime"].ToString());
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
            strSql.Append("select project_id,project_responUnit,project_name,project_owner,project_positon,project_type,project_constrContent,project_scale,project_designCapacity,project_designCapacityUnit,project_designCapacityRemarks,project_totalInvestment,project_constrStartTime,project_constrEndTime,project_coveredArea,project_state,project_stateChangedTime ");
            strSql.Append(" FROM Table_project ");
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
            strSql.Append(" project_id,project_responUnit,project_name,project_owner,project_positon,project_type,project_constrContent,project_scale,project_designCapacity,project_designCapacityUnit,project_designCapacityRemarks,project_totalInvestment,project_constrStartTime,project_constrEndTime,project_coveredArea,project_state,project_stateChangedTime ");
            strSql.Append(" FROM Table_project ");
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
			strSql.Append("select count(1) FROM Table_project ");
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
				strSql.Append("order by T.project_id desc");
			}
			strSql.Append(")AS Row, T.*  from Table_project T ");
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
			parameters[0].Value = "Table_project";
			parameters[1].Value = "project_id";
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

