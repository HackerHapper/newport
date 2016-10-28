using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Maticsoft.Web.GWH
{
    public partial class Plan_SpecialtyAdd : System.Web.UI.Page
    {
        static string sfid = "";
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
                    sfid = Request.Params["id"];
                    ShowInfo(sfid);
                }
            }
        }
        private void ShowInfo(string estrid)
        {
            Maticsoft.BLL.NewPort.Table_project bll = new Maticsoft.BLL.NewPort.Table_project();
            Maticsoft.Model.NewPort.Table_project model = bll.GetModel(sfid);

            this.lbl_enumber.Text = model.project_id.ToString();
            this.lbl_PlanType.Text = model.project_type.ToString();
            this.lbl_ename.Text = model.project_name.ToString();
            this.lbl_eowner.Text = model.project_owner.ToString();
            this.lbl_eaddress.Text = model.project_positon.ToString();
            this.lbl_emoney.Text = model.project_totalInvestment.ToString();
        }
        protected void btneSubmit_Click(object sender, EventArgs e)
        {
            Maticsoft.Model.NewPort.Table_specialFundRecord model = new Maticsoft.Model.NewPort.Table_specialFundRecord();

            model.project_id = sfid;
            model.specialFundRecord_id = sfid;
            model.specialFundRecord_amount = decimal.Parse(this.txtbox_money.Text); 
            model.specialFundRecord_channel = this.txtbox_method.Text;
            model.specialFundRecord_description = this.txtbox_des.Text;
            model.specialFundRecord_methods = this.txtbox_method.Text;


            Maticsoft.BLL.NewPort.Table_specialFundRecord sfbll = new Maticsoft.BLL.NewPort.Table_specialFundRecord();
            sfbll.Add(model);
            Maticsoft.Common.MessageBox.ShowAndRedirect(this, "保存成功！", "Plan_Check.aspx");

        }

        protected void btneBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("Plan_Management.aspx");
        }
    }
}