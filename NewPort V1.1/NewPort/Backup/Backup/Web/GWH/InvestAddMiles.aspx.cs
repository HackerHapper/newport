using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;
using System.IO;

namespace Maticsoft.Web.GWH
{
    public partial class InvestAddMiles : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["isLogin"] != "ok")
            {
                Response.Redirect("../Login.aspx");
            }
        }
        protected void gridViewImportPercent_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Cells[0].Text = (e.Row.RowIndex + 1).ToString();

                ////如果使用了分页控件且希望序号在翻页后不重新计算，使用下面方法  
                //int indexID = (AspNetPager1.CurrentPageIndex - 1) * AspNetPager1.PageSize + e.Row.RowIndex + 1;  
                //e.Row.Cells[0].Text = indexID.ToString();  
            }
        } 
        protected void btnTable_Click(object sender, EventArgs e)
        {
            BindData();
        }
        public void BindData()
        {
            this.GridView_Project.Visible = true;
            if (DDL_Year.SelectedValue == "2010")
            {
                Maticsoft.BLL.NewPort.projecttable bll = new Maticsoft.BLL.NewPort.projecttable();
            this.GridView_Project.DataSourceID = null;
            DataSet ds = new DataSet();
            StringBuilder strWhere = new StringBuilder();
            strWhere.AppendFormat("project_type like '%{0}%' ", "集疏运项目"); 
            ds = bll.GetList(strWhere.ToString());
            GridView_Project.DataSource = ds;
            GridView_Project.DataBind();
            }
        }
        protected void btnPrint_Click(object sender, EventArgs e)
        {
            DumpExcel(GridView_Project, "tt.xlsx");
        }
        private void DumpExcel(GridView gv, string FileName)
        {
            Response.ClearContent();

            Response.AppendHeader("Content-Disposition", "attachment;filename=" + System.Web.HttpUtility.UrlEncode("导出" + System.DateTime.Now.Date.ToString("yyyyMMdd")) + ".xls");

            Response.ContentType = "application/excel";

            StringWriter sw = new StringWriter();

            HtmlTextWriter htw = new HtmlTextWriter(sw);

            gv.RenderControl(htw);

            Response.Write(sw.ToString());

            Response.End();

        }
        public override void VerifyRenderingInServerForm(Control control)
        {
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("InvestPlan.aspx");
        }
    }
}