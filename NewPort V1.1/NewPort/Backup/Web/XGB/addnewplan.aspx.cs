using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Maticsoft.Web.XGB
{
    public partial class addnewplan : System.Web.UI.Page
    {
        static string strid = ""; 
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["isLogin"] != "ok")
            {
                Response.Redirect("../Login.aspx");
            }
            strid = Session["UserName"].ToString().Trim();
            Random ran = new Random();
            string RandKey = ran.Next(1,99).ToString();
            lbl_number.Text = DateTime.Now.ToString("yyMMdd").ToString().Trim()+RandKey;
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                Maticsoft.Model.NewPort.Table_project model = new Maticsoft.Model.NewPort.Table_project();
                model.project_id = lbl_number.Text;
                model.project_name = this.txtName.Text;
                model.project_owner = this.txtOwner.Text;
                model.project_positon = this.txtAddress.Text;
                model.project_designCapacity = decimal.Parse(this.txtCapacity.Text.Trim());
                model.project_coveredArea = decimal.Parse(this.txtCoast.Text);
                model.project_totalInvestment = decimal.Parse(this.txtTotal.Text);
                model.project_check = "待审核";
                model.project_constrStartTime = Convert.ToDateTime(this.input1.Value);
                model.project_constrEndTime = Convert.ToDateTime(this.input2.Value);
                model.project_constrContent = this.txtA2.Value;
                model.project_writer = strid;
                model.project_state = "新开工";
                model.project_type = DDL_PlayType.SelectedValue.Trim();
                model.project_year = DDL_Year.SelectedValue.Trim();
                model.project_class = DropDownList_PlanType.SelectedValue.Trim();
                model.project_area = txtArea.Text;
                model.project_scale = decimal.Parse(txtCoast.Text);
                Maticsoft.BLL.NewPort.Table_project bll = new Maticsoft.BLL.NewPort.Table_project();
                bll.Add(model);
                Maticsoft.Common.MessageBox.ShowAndRedirect(this, "保存成功！", "planSearch.aspx");
            }
            catch (Exception e2) {
                Maticsoft.Common.MessageBox.ShowAndRedirect(this, "填写错误，请重新确认后再提交！", "addnewplan.aspx");
            }

        }

    }
}