using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace Maticsoft.Web.GWH
{
    public partial class Notice_Details : System.Web.UI.Page
    {
        static string strid = "";
        static string filePath = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["isLogin"] != "ok")
            {
                Response.Redirect("../Login.aspx");
            }
            if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
            {
                strid = Request.Params["id"];
                ShowInfo(strid);
            }
        }
        private void ShowInfo(string strid)
        {
            Maticsoft.BLL.NewPort.Table_notice nobll = new Maticsoft.BLL.NewPort.Table_notice();
            Maticsoft.Model.NewPort.Table_notice model = nobll.GetModel(strid);

            this.lbl_number.Text = model.notice_id.ToString();
            this.lbl_time.Text = model.notice_time.ToString();
            this.lbl_completed.Text = model.notice_topic.ToString();
            this.lbl_process.Text = model.notice_content.ToString();
            filePath = model.notice_attachmentPath.ToString(); 
            if (filePath == "")
            {
                btnDownLoad.Visible = false;
            }
        }
        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("Notice.aspx");
        }

        protected void btnDownLoad_Click(object sender, EventArgs e)
        {
            FileInfo Fi = new FileInfo(filePath);
            if (Fi.Exists)
            {
                FileStream fs = new FileStream(filePath, FileMode.Open);
                byte[] bytes = new byte[(int)fs.Length];
                fs.Read(bytes, 0, bytes.Length);
                fs.Close();
                Response.ContentType = "application/octet-stream";//通知浏览器下载文件而不是打开
                //Response.AddHeader("Content-Disposition", "attachment; filename=" + HttpUtility.UrlEncode(dt.Rows[0]["Name"].ToString(), System.Text.Encoding.UTF8));
                Response.BinaryWrite(bytes);
                Response.Flush();
                Response.End();
            }
        }
    }
}