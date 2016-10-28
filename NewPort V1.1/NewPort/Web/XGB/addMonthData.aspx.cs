using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Maticsoft.Web.XGB
{
    public partial class monthlyFeedback : System.Web.UI.Page
    {
        static string monid = ""; 
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["isLogin"] != "ok")
            {
                Response.Redirect("../Login.aspx");
            }
            //strid = "mon"+Session["UserName"].ToString().Trim();

            Random ran = new Random();
            string RandKey = ran.Next(1, 99).ToString();
            monid = "m" + DateTime.Now.ToString("yyMMdd").ToString().Trim() + RandKey;
        }

        protected void btnmBack_Click(object sender, EventArgs e)
        {
            Maticsoft.Model.NewPort.Table_monthlyFeedback model = new Maticsoft.Model.NewPort.Table_monthlyFeedback();
            model.monthlyFeedback_sn = monid;
            model.project_id = DropDownList1.SelectedValue.ToString().Trim();
            model.monthlyFeedback_yyyyMM = DateTime.Now.ToUniversalTime(); 
            model.monthlyFeedback_fulfilmentDescription = this.txta.Value;
            model.monthlyFeedback_fulfilment = Decimal.Parse(this.txtInvestment.Text.Trim());
            model.monthlyFeedback_writer = Session["UserName"].ToString();

            Maticsoft.BLL.NewPort.Table_monthlyFeedback bll = new Maticsoft.BLL.NewPort.Table_monthlyFeedback();
            bll.Add(model);
            Maticsoft.Common.MessageBox.ShowAndRedirect(this, "保存成功！", "monthlyFeedbackCheck.aspx");

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Maticsoft.BLL.NewPort.Table_project bll = new Maticsoft.BLL.NewPort.Table_project();
            Maticsoft.Model.NewPort.Table_project model = bll.GetModel(DropDownList1.SelectedValue.ToString().Trim());
            this.lblName.Text = model.project_name.ToString();
        }
    }
}