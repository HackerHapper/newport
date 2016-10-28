using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Maticsoft.Common;
using Maticsoft.DAL.NewPort;
using Maticsoft.BLL;

namespace Maticsoft.Web.XGB
{
    public partial class addNewPro : System.Web.UI.Page
    {
        static string strid = ""; 
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["isLogin"].ToString() != "ok")
            {
                Response.Redirect("../Login.aspx");
            }
            strid = Session["UserName"].ToString().Trim();
           
            Session["CurrenProId"] = "";
           
           
        }

        protected void upload_Click(object sender, EventArgs e)
        {
            
            if ((proClass.SelectedValue == "未选择") || (proName.Text.Trim().Equals(""))) { Maticsoft.Common.MessageBox.Show(this, "还未选择项目类型或未填写项目名称，因此项目编号未确定，无法上传附件。"); return; }
            try
            { 
                //判断是否上传了文件 
                if (FileUpload1.HasFile)
                {
                    Maticsoft.Model.NewPort.Table_projectAttachment model = new Model.NewPort.Table_projectAttachment();
                    model.project_id = number.Text;
                    model.projectAttachment_name = FileUpload1.FileName;
                    model.projectAttachment_id = DateTime.Now.Year.ToString().Substring(2, 2) + DateTime.Now.Month.ToString().PadLeft(2, '0') + DateTime.Now.Day.ToString().PadLeft(2, '0');
                    Table_projectAttachment tpa = new Table_projectAttachment();
                    int no = tpa.GetRecordCount("projectAttachment_id like '" + model.projectAttachment_id + "%'");
                    model.projectAttachment_id += no.ToString().PadLeft(4, '0');
                    model.projectAttachment_uploadTime = DateTime.Now;
                    //指定上传文件在服务器上的保存路径 
                    string savePath = Server.MapPath("~/upload/");
                    //检查服务器上是否存在这个物理路径，如果不存在则创建 
                    if (!System.IO.Directory.Exists(savePath))
                    {
                        //需要注意的是，需要对这个物理路径有足够的权限，否则会报错 
                        //另外，这个路径应该是在网站之下，而将网站部署在C盘却把上传文件保存在D盘 
                        System.IO.Directory.CreateDirectory(savePath);
                    }
                    int index = FileUpload1.FileName.LastIndexOf(".");
                    string lastName = FileUpload1.FileName.Substring(index, FileUpload1.FileName.Length - index);//
                    savePath = savePath +"//" + model.projectAttachment_id+lastName;
                    model.projectAttachment_path = savePath;
                    FileUpload1.SaveAs(savePath);//保存文件 
                    //不过需要注意的是，在客户端访问却需要指定的是URL地址，而不是在服务器上的物理地址 
                    // literal.Text = string.Format("<a href='upload/{0}'>upload/{0}</a>", FileUpload1.FileName);

                    fujianliebiao.InnerHtml += "<a href='" + savePath + "'>" + FileUpload1.FileName + "</a>&nbsp;&nbsp;&nbsp;";
                  
                    Maticsoft.Model.NewPort.Table_project md = new Model.NewPort.Table_project();
                    md.project_id=number.Text;
                    md.project_name = proName.Text.Trim();
                    Table_project tp = new Table_project();
                   
                    if(!tp.Exists(number.Text))tp.Add(md);
                     Maticsoft.BLL.NewPort.Table_projectAttachment BLLtpa = new Maticsoft.BLL.NewPort.Table_projectAttachment();
                    BLLtpa.Add(model);
                    Maticsoft.Common.MessageBox.Show(this, " 上传成功！");
                    Label1.Text =Convert.ToString(int.Parse(Label1.Text) + 1);
                   

                }
                else { Maticsoft.Common.MessageBox.Show(this, " 还没有选择任何文件！"); }


               
            }
            catch { Maticsoft.Common.MessageBox.Show(this,"文件上传失败，请重试！"); }

        
        }

        protected void proClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            number.Text = DateTime.Now.Year.ToString().Substring(2, 2) + deptNumber.findNumber(Session["dept"].ToString()) + "_ _ _ _";    
            if (proClass.SelectedValue == "未选择") { return; }
            number.Text = number.Text.Substring(0, 4) + proClass.SelectedValue;
            Table_project tp = new Table_project();
            int no=tp.GetRecordCount("project_id like '"+number.Text+"%'");
            if (no < 10) { number.Text += "0" + no; }
            else { number.Text += no; }
            Session["CurrenProId"] = number.Text;
            Label1.Text = "0";
            fujianliebiao.InnerHtml = "";
       
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if ((proClass.SelectedValue == "未选择") || (proName.Text.Trim().Equals(""))) { Maticsoft.Common.MessageBox.Show(this, "还未选择项目类型或未填写项目名称，因此项目编号未确定，无法保存。"); return; }
            try
            {
                Maticsoft.Model.NewPort.Table_project md = new Model.NewPort.Table_project();
                Maticsoft.BLL.NewPort.Table_project BLLtp = new BLL.NewPort.Table_project();
                md.project_id = number.Text;
                if (!BLLtp.Exists(number.Text)) BLLtp.Add(md);
                md.project_name = proName.Text.Trim();
                md.project_owner = proHost.Text.Trim();
                md.project_constrContent = content.Text.Trim();
                md.project_positon = proPlace.Text.Trim();
                md.project_scale = decimal.Parse(scale.Text.Trim());
                md.project_totalInvestment = decimal.Parse(totalFund.Text.Trim());
                md.project_type = proClass.SelectedValue.ToString();
                md.project_designCapacity = decimal.Parse(capacity.Text.Trim());
                md.project_designCapacityUnit = capacityUnit.SelectedValue;
                md.project_coveredArea = decimal.Parse(coverdArea.Text);
                md.project_constrEndTime = DateTime.Parse(end.Text); 
                md.project_constrStartTime = DateTime.Parse(start.Text);
                md.project_responUnit = Session["dept"].ToString();
                BLLtp.Update(md);
                Maticsoft.Common.MessageBox.Show(this, "保存成功！");
            }
            catch  { Maticsoft.Common.MessageBox.Show(this, "保存失败，请稍后再试！"); }
        }
    }
}