using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;

namespace Maticsoft.Web.XGB
{
    public partial class MonthlyFBList : System.Web.UI.Page
    {
        Maticsoft.BLL.NewPort.Table_project bll = new Maticsoft.BLL.NewPort.Table_project();
        Maticsoft.BLL.NewPort.Table_monthlyFeedback bllmf = new Maticsoft.BLL.NewPort.Table_monthlyFeedback();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["isLogin"] != "ok")
            {
                Response.Redirect("../Login.aspx");
            }
            if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
            {
                lblNumber.Text = Request.Params["id"];
            }
        }

        protected void btnmSearch_Click(object sender, EventArgs e)
        {

        }
    }
}