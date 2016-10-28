using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Maticsoft.Web.XGB
{
    public partial class plan_Details : System.Web.UI.Page
    {
        static string mstrid = "";
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
                    mstrid = Request.Params["id"];
                    mShowInfo(mstrid);
                }
            }
        }
            private void mShowInfo(string strid)
        {
            Maticsoft.BLL.NewPort.Table_project bll = new Maticsoft.BLL.NewPort.Table_project();
            Maticsoft.Model.NewPort.Table_project model = bll.GetModel(strid);
            this.lbl_mnumber.Text = model.project_id.ToString();
            this.lbl_mtype.Text = model.project_type.ToString();
            this.lbl_mname.Text = model.project_name.ToString();
            this.lbl_mowner.Text = model.project_owner.ToString();
            this.lbl_maddress.Text = model.project_positon.ToString();
            this.lbl_mapc.Text = model.project_designCapacity.ToString();
            this.lbl_mdis.Text = model.project_coveredArea.ToString();
            this.lbl_mmoney.Text = model.project_totalInvestment.ToString();
            this.lbl_mstartyear.Text = model.project_constrStartTime.ToString();
            this.lbl_moveryear.Text = model.project_constrEndTime.ToString();
        }
            protected void btnmBack_Click(object sender, EventArgs e)
            {
                Response.Redirect("planSearch.aspx");
            }
    }
}