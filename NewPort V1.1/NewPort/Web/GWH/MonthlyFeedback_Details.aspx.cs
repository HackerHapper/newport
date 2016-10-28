using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Maticsoft.Web.GWH
{
    public partial class MonthlyFeedback_Details : System.Web.UI.Page
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
            Maticsoft.BLL.NewPort.Table_monthlyFeedback bll = new Maticsoft.BLL.NewPort.Table_monthlyFeedback();
            Maticsoft.Model.NewPort.Table_monthlyFeedback model = bll.GetModel(strid);

            this.lbl_number.Text = model.project_id.ToString();
            this.lbl_time.Text = model.monthlyFeedback_yyyyMM.ToString();
            this.lbl_completed.Text = model.monthlyFeedback_fulfilment.ToString();
            this.lbl_process.Text = model.monthlyFeedback_fulfilmentDescription.ToString();
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Response.Redirect("MonthlyFeedback.aspx");
        }
    }
}