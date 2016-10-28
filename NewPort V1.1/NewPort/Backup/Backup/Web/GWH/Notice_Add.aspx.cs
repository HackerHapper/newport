using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Maticsoft.Web.GWH
{
    public partial class Notice_Add : System.Web.UI.Page
    {
        static string savePath = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["isLogin"] != "ok")
            {
                Response.Redirect("../Login.aspx");
            }

        }

        protected void btneSubmit_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                //指定上传文件在服务器上的保存路径 
                savePath = Server.MapPath("~/upload/");
                //检查服务器上是否存在这个物理路径，如果不存在则创建 
                if (!System.IO.Directory.Exists(savePath))
                {
                    //需要注意的是，需要对这个物理路径有足够的权限，否则会报错 
                    //另外，这个路径应该是在网站之下，而将网站部署在C盘却把上传文件保存在D盘 
                    System.IO.Directory.CreateDirectory(savePath);
                }
                savePath = savePath + "//" + FileUpload1.FileName;
                FileUpload1.SaveAs(savePath);//保存文件 
                //literal.Text = string.Format("<a href='upload/{0}'>upload/{0}</a>", FileUpload1.FileName);
            } 


           Maticsoft.Model.NewPort.Table_notice model = new Maticsoft.Model.NewPort.Table_notice();

           model.notice_id = txtnono.Text.Trim();
           model.notice_content = txtcontent.Text.Trim();
           model.notice_topic = txttitle.Text.Trim();
           model.notice_time = System.DateTime.Now;
           model.notice_attachmentPath = savePath.ToString();

           try
           {
               Maticsoft.BLL.NewPort.Table_notice nobll = new Maticsoft.BLL.NewPort.Table_notice();
               nobll.Add(model);
               Maticsoft.Common.MessageBox.ShowAndRedirect(this, "保存成功！", "Notice.aspx");
           }
           catch (Exception e2) {
               Maticsoft.Common.MessageBox.ShowAndRedirect(this, "填写错误，请重新填写！", "Notice_Add.aspx");
           }
        }

        protected void btneBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("Notice.aspx");
        }
    }
}