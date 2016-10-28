using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using LTP.Accounts;

namespace Maticsoft.Web.GWH
{
    public partial class Plan_Management_Edit : System.Web.UI.Page
    {
        static string estrid = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Session["isLogin"] != "ok")
                {
                    Response.Redirect("../Login.aspx");
                }
                if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
                {
                    estrid = Request.Params["id"];
                    eShowInfo(estrid);
                }
            }
        }
        private void eShowInfo(string estrid)
        {
            Maticsoft.BLL.NewPort.Table_project bll = new Maticsoft.BLL.NewPort.Table_project();
            Maticsoft.Model.NewPort.Table_project model = bll.GetModel(estrid);
            this.lbl_enumber.Text = model.project_id.ToString();
            this.input1.Value = string.Format("{0:d}", model.project_constrStartTime);
            this.input2.Value = string.Format("{0:d}", model.project_constrEndTime);
            this.lbl_ename.Text = model.project_name.ToString();
            this.lbl_eowner.Text = model.project_owner.ToString();
            this.lbl_eaddress.Text = model.project_positon.ToString();
            this.lbl_eapc.Text = model.project_designCapacity.ToString();
            this.lbl_edis.Text = model.project_coveredArea.ToString();
            this.lbl_emoney.Text = model.project_totalInvestment.ToString();
            this.eTextContent.Text = model.project_constrContent.ToString();
            this.DDLState.SelectedValue = model.project_state.ToString();
        }

        protected void btneBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("Plan_Management.aspx");
        }
        protected void btneSubmit_Click(object sender, EventArgs e)
        {
            Maticsoft.Model.NewPort.Table_project model = new Maticsoft.Model.NewPort.Table_project();

            model.project_name = this.lbl_ename.Text;
            model.project_owner =this.lbl_eowner.Text;
            model.project_positon = this.lbl_eaddress.Text;
            model.project_designCapacity = decimal.Parse(this.lbl_eapc.Text);
            model.project_coveredArea = decimal.Parse(this.lbl_edis.Text);
            model.project_totalInvestment = decimal.Parse(this.lbl_emoney.Text); 

            model.project_constrContent = this.eTextContent.Text;
            model.project_constrStartTime = Convert.ToDateTime(this.input1.Value);
            model.project_constrEndTime = Convert.ToDateTime(this.input2.Value);
            model.project_state = this.DDLState.SelectedValue;
            model.project_id = estrid;

            UpdateData1(model);
            Maticsoft.Common.MessageBox.ShowAndRedirect(this, "保存成功！", "Plan_Management.aspx");


        }
        public bool UpdateData1(Maticsoft.Model.NewPort.Table_project model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Table_project set ");
            strSql.Append("project_name=@project_name,");
            strSql.Append("project_owner=@project_owner,");
            strSql.Append("project_positon=@project_positon,");
            strSql.Append("project_designCapacity=@project_designCapacity,");
            strSql.Append("project_coveredArea=@project_coveredArea,");
            strSql.Append("project_totalInvestment=@project_totalInvestment,");
            strSql.Append("project_constrStartTime=@project_constrStartTime,");
            strSql.Append("project_constrEndTime=@project_constrEndTime,");
            strSql.Append("project_constrContent=@project_constrContent,");
            strSql.Append("project_state=@project_state");
            strSql.Append(" where project_id=@project_id ");
            SqlParameter[] parameters = {
					new SqlParameter("@project_name", SqlDbType.NVarChar,30),
					new SqlParameter("@project_owner", SqlDbType.NVarChar,30),
					new SqlParameter("@project_positon", SqlDbType.NVarChar,30),
					new SqlParameter("@project_designCapacity", SqlDbType.Float,8),
					new SqlParameter("@project_coveredArea", SqlDbType.Float,8),
					new SqlParameter("@project_totalInvestment", SqlDbType.Float,8),
					new SqlParameter("@project_constrStartTime", SqlDbType.DateTime),
					new SqlParameter("@project_constrEndTime", SqlDbType.DateTime),
					new SqlParameter("@project_constrContent", SqlDbType.NText),
					new SqlParameter("@project_state", SqlDbType.NVarChar,10),
					new SqlParameter("@project_id", SqlDbType.Char,8)};
            parameters[0].Value = model.project_name;
            parameters[1].Value = model.project_owner;
            parameters[2].Value = model.project_positon;
            parameters[3].Value = model.project_designCapacity;
            parameters[4].Value = model.project_coveredArea;
            parameters[5].Value = model.project_totalInvestment;
            parameters[6].Value = model.project_constrStartTime;
            parameters[7].Value = model.project_constrEndTime;
            parameters[8].Value = model.project_constrContent;
            parameters[9].Value = model.project_state;
            parameters[10].Value = model.project_id;

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
    }
}