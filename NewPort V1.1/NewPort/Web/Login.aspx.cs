using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;

namespace Maticsoft.Web
{
    public partial class Login : System.Web.UI.Page
    {
        string userdept;
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["isLogin"] = " ";
            Session["UserName"] = " ";
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string userid = Request["username"];
            string password = Request["password"];
            userdept = btnType.SelectedValue.Trim();
            IsUser(userid, password, userdept);
        }
        private bool IsUser(string userid, string password, string userdept)
        {

            bool boolReturnValue = false;
            string dataDir = AppDomain.CurrentDomain.BaseDirectory;
            if (dataDir.EndsWith(@"\bin\Debug\") || dataDir.EndsWith(@"\bin\Release\"))
            {
                dataDir = System.IO.Directory.GetParent(dataDir).Parent.Parent.FullName;
                AppDomain.CurrentDomain.SetData("DataDirectory", dataDir);
            }
            string connString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                String strSQL = "Select * From Table_user";
                SqlCommand command = new SqlCommand(strSQL, conn);
                SqlDataReader Dr;
                conn.Open();
                Dr = command.ExecuteReader();
                while (Dr.Read())
                {
                   if ((userid == Dr["user_id"].ToString().Trim()) && (password == Dr["user_password"].ToString().Trim()))
                    {
                        if (userdept == "管委会" && ("管委会" == Dr["user_dept"].ToString()))
                        {
                            Session["isLogin"] = "ok";
                            Session["dept"] = "管委会";
                            Response.Redirect("GWH/Default_GWH.aspx");
                            
                        }
                        else if (userdept == "新港办" && ("管委会" != Dr["user_dept"].ToString()))
                        {
                            Session["isLogin"] = "ok";
                            Session["UserName"] = userid;
                            Session["dept"] = Dr["user_dept"].ToString();
                            Response.Redirect("XGB/Index.aspx");
                           
                        }

                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "u1", "alert('用户名或密码错误,或者角色选择不正确！')", true);
                    }                 
                }
                Dr.Close();
                return boolReturnValue;
            }
        }
    }
}