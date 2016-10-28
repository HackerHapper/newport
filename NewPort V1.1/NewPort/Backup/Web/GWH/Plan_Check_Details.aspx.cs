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
    public partial class Plan_Check_Details : System.Web.UI.Page
    {
        static string strid = ""; 
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["isLogin"] != "ok")
            {
                Response.Redirect("../Login.aspx");
            }
            if (!Page.IsPostBack)
            {
                if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
                {
                    strid = Request.Params["id"];
                    ShowInfo(strid);
                }
            }

            
        }
        private void ShowInfo(string strid)
        {
            Maticsoft.BLL.NewPort.Table_project bll = new Maticsoft.BLL.NewPort.Table_project();
            Maticsoft.Model.NewPort.Table_project model = bll.GetModel(strid);
            this.lbl_number.Text = model.project_id.ToString();
            this.lbl_type.Text = model.project_type.ToString();
            this.lbl_name.Text = model.project_name.ToString();
            this.lbl_owner.Text = model.project_owner.ToString();
            this.lbl_address.Text = model.project_positon.ToString();
            this.lbl_apc.Text = model.project_designCapacity.ToString();
            this.lbl_dis.Text = model.project_coveredArea.ToString();
            this.lbl_money.Text = model.project_totalInvestment.ToString();
            this.lbl_startyear.Text = string.Format("{0:d}", model.project_constrStartTime);
            this.lbl_overyear.Text = string.Format("{0:d}", model.project_constrEndTime);
            this.TextContent.Text = model.project_constrContent.ToString();
            /*
            string radiobuttonvalue = model.project_check.ToString();
            if (radiobuttonvalue == "审核通过")
            {
                this.radiono.Checked = false;
                this.radioyes.Checked = true;
            }
            if (radiobuttonvalue == "审核未通过")
            {
                this.radiono.Checked = true;
                this.radioyes.Checked = false;
            }
            else
            {
                this.radioyes.Checked = false;
                this.radiono.Checked = false;
            }
            Label1.Text = radiobuttonvalue;*/
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("Plan_Check.aspx");
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string str="";
            if(radioyes.Checked ==true || radiono.Checked==true)
            {
            if(radioyes.Checked)
                str = "审核通过";
            if(radiono.Checked)
                str = "审核未通过";

            Maticsoft.Model.NewPort.Table_project model = new Maticsoft.Model.NewPort.Table_project();
            model.project_id = strid;
            model.project_check = str;
            Maticsoft.BLL.NewPort.Table_project bll = new Maticsoft.BLL.NewPort.Table_project();
            bll.UpdateCheck(model);
            Maticsoft.Common.MessageBox.ShowAndRedirect(this, "保存成功！", "Plan_Check.aspx");
            }
            else
                Response.Write("<script>alert('请先进行审核！');</script>");
        }
    }
}