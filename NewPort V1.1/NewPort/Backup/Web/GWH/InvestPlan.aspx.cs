using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;

namespace Maticsoft.Web.GWH
{
    public partial class InvestPlan : System.Web.UI.Page
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
        protected void btneSubmit_Click(object sender, EventArgs e)
        {
            BindData();
        }
        public void BindData()
        {
            this.GridView_Project.Visible = true;
           // Maticsoft.BLL.NewPort.projecttable bll = new Maticsoft.BLL.NewPort.projecttable();
            Maticsoft.BLL.NewPort.Table_project bll = new Maticsoft.BLL.NewPort.Table_project();
            this.GridView_Project.DataSourceID = null;
            DataSet ds = new DataSet();
            StringBuilder strWhere = new StringBuilder();
            strWhere.AppendFormat("(");
            strWhere.AppendFormat("project_year like '%{0}%' and ", DDL_Year1.SelectedValue.Trim());
            if(cb_alltype.Checked == false)
            {
                if (cb_Ganhang.Checked) { strWhere.AppendFormat("project_type like '%{0}%' or ", "港航项目"); }
                if (cb_Jishuyun.Checked) { strWhere.AppendFormat("project_type like '%{0}%' or ", "集疏运项目"); }
                if (cb_Lingang.Checked) { strWhere.AppendFormat("project_type like '%{0}%' or ", "临港产业项目"); }
                strWhere.AppendFormat("project_type like '%{0}%' )and (", "visual2010");
            } 

            if (cb_allstate.Checked == false)            
            {
                if (cb_New.Checked) { strWhere.AppendFormat("project_state like '%{0}%' or ", "新开工"); }
                if (cb_Goon.Checked) { strWhere.AppendFormat("project_state like '%{0}%' or ", "续建"); }
                strWhere.AppendFormat("project_state like '%{0}%' )and (", "visual2010");
            }
            
            if (cb_allarea.Checked == false)
            {
                if (cb_Wuhan.Checked) { strWhere.AppendFormat("project_area like '%{0}%' or ", "武汉"); }
                if (cb_Ezhou.Checked) { strWhere.AppendFormat("project_area like '%{0}%' or ", "鄂州"); }
                if (cb_Huanggan.Checked) { strWhere.AppendFormat("project_area like '%{0}%' or ", "黄冈"); }
                if (cb_Xianning.Checked) { strWhere.AppendFormat("project_area like '%{0}%' or ", "咸宁"); }
                if (cb_Xinzhou.Checked) { strWhere.AppendFormat("project_area like '%{0}%' or ", "新洲"); }
                if (cb_Hannan.Checked) { strWhere.AppendFormat("project_area like '%{0}%' or ", "汉南"); }
                if (cb_HGQ.Checked) { strWhere.AppendFormat("project_area like '%{0}%' or ", "化工区"); }
                if (cb_XGT.Checked) { strWhere.AppendFormat("project_area like '%{0}%' or ", "新港投"); }
                if (cb_Wugan.Checked) { strWhere.AppendFormat("project_area like '%{0}%' or ", "武港"); }
                if (cb_Jiangxia.Checked) { strWhere.AppendFormat("project_area like '%{0}%' or ", "江夏"); }
                strWhere.AppendFormat("project_area like '%{0}%')", "visual2010");
            }
            else
            {
                strWhere.AppendFormat("'visual2010' like '%{0}%')", "visual2010");
            }

            ds = bll.GetList(strWhere.ToString());
            GridView_Project.DataSource = ds;
            GridView_Project.DataBind();
        }
        protected void btneBack_Click(object sender, EventArgs e)
        {
            DumpExcel(GridView_Project,"tt.xlsx");
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

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("InvestAddMiles.aspx");
        }

    }
}