using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Maticsoft.Web.GWH
{
    public partial class UserDetails : System.Web.UI.Page
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
            Maticsoft.BLL.NewPort.Table_user bll = new Maticsoft.BLL.NewPort.Table_user();
            Maticsoft.Model.NewPort.Table_user model = bll.GetModel(estrid);
            this.lbl_account.Text = model.user_id;
            this.lbl_address.Text = model.user_contacterInfo;
            this.lbl_name.Text = model.user_name;
            this.lbl_owner.Text = model.user_liablePerson;
            this.lbl_pwd.Text = model.user_password;
            this.DDLPlanType.SelectedValue = model.user_dept;
        }

            protected void btneSubmit_Click(object sender, EventArgs e)
            {
                Maticsoft.Model.NewPort.Table_user model = new Maticsoft.Model.NewPort.Table_user();
                model.user_id = lbl_account.Text;
                model.user_contacterInfo = lbl_address.Text;
                model.user_name = lbl_name.Text;
                model.user_liablePerson = lbl_owner.Text;
                model.user_password = lbl_pwd.Text;
                model.user_dept = DDLPlanType.SelectedValue;

                Maticsoft.BLL.NewPort.Table_user bll = new Maticsoft.BLL.NewPort.Table_user();
                bll.Update(model);
                Maticsoft.Common.MessageBox.ShowAndRedirect(this, "保存成功！", "User_Management.aspx");

            }

            protected void btneBack_Click(object sender, EventArgs e)
            {
                Response.Redirect("User_Management.aspx");
            }
    }
}