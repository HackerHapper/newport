using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Maticsoft.Web.GWH
{
    public partial class UserAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["isLogin"].ToString() != "ok")
            {
                Response.Redirect("../Login.aspx");
            }
        }

        protected void btneSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                Maticsoft.Model.NewPort.Table_user model = new Maticsoft.Model.NewPort.Table_user();
                model.user_id = txtAccount.Text;
                model.user_name = txtName.Text;
                model.user_dept = ddlDepart.SelectedValue;
                model.user_liablePerson = txtPerson.Text;
                model.user_contacterInfo = txtConnect.Text;
                model.user_password = txtPwd.Text;
                Maticsoft.BLL.NewPort.Table_user bll = new Maticsoft.BLL.NewPort.Table_user();
                bll.Add(model);
                Maticsoft.Common.MessageBox.ShowAndRedirect(this, "保存成功！", "User_Management.aspx");
            }
            catch (Exception e2)
            {
                Maticsoft.Common.MessageBox.ShowAndRedirect(this, "填写错误，请重新确认后再提交！", "UserAdd.aspx");
            }
        }
        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("User_Management.aspx");
        }
    }
}