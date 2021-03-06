﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;

namespace Maticsoft.Web.GWH
{
    public partial class MonthlyFeedback : System.Web.UI.Page
    {
        static string strid = ""; 
        Maticsoft.BLL.NewPort.Table_project bll = new Maticsoft.BLL.NewPort.Table_project();
        Maticsoft.BLL.NewPort.Table_monthlyFeedback bllmf = new Maticsoft.BLL.NewPort.Table_monthlyFeedback();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["isLogin"] != "ok")
            {
                Response.Redirect("../Login.aspx");
            }
            if (Request.QueryString["id"] != null)
            {
                strid = Request.QueryString["id"].ToString();
                Maticsoft.BLL.NewPort.Table_monthlyFeedback bll = new Maticsoft.BLL.NewPort.Table_monthlyFeedback();
                bll.Delete(strid);
            }
        }
        protected void gvwDesignationName_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            // 得到该控件 
            GridView theGrid = sender as GridView;
            int newPageIndex = 0;
            if (e.NewPageIndex == -3)
            {
                //点击了Go按钮 
                TextBox txtNewPageIndex = null;
                //GridView较DataGrid提供了更多的API，获取分页块可以使用BottomPagerRow 或者TopPagerRow，当然还增加了HeaderRow和FooterRow 
                GridViewRow pagerRow = theGrid.BottomPagerRow;
                if (pagerRow != null)
                {
                    //得到text控件 
                    txtNewPageIndex = pagerRow.FindControl("txtNewPageIndex") as TextBox;
                }
                if (txtNewPageIndex != null)
                {
                    //得到索引 
                    newPageIndex = int.Parse(txtNewPageIndex.Text) - 1;
                }
            }
            else
            {
                //点击了其他的按钮 
                newPageIndex = e.NewPageIndex;
            }
            //防止新索引溢出 
            newPageIndex = newPageIndex < 0 ? 0 : newPageIndex;
            newPageIndex = newPageIndex >= theGrid.PageCount ? theGrid.PageCount - 1 : newPageIndex;
            //得到新的值 
            theGrid.PageIndex = newPageIndex;
            //重新绑定 
            BindData();
        }
        public void BindData()
        {
            this.GridView_Project.DataSourceID = null;
            DataSet ds = new DataSet();
            GridView_Project.DataSource = ds;
            GridView_Project.DataBind();
        }
        protected void btnSearch_Click(object sender, EventArgs e)
        {
            mDropDownListBindData();
        }

        protected void DropDownList_mType_SelectedIndexChanged(object sender, EventArgs e)
        {
            mDropDownListBindData();
        }
        public void mDropDownListBindData()
        {
            string value = DropDownList_mType.SelectedValue.ToString().Trim();
            this.GridView_Project.DataSourceID = null;
            DataSet ds = new DataSet();
            StringBuilder strWhere = new StringBuilder();
            strWhere.AppendFormat("project_id like '%{0}%'", value);
            if (txtKeyword.Text.Trim() != "")
            {
                strWhere.AppendFormat("and(monthlyFeedback_fulfilmentDescription like '%{0}%' or monthlyFeedback_writer like '%{0}%' or project_id like '%{0}%')", txtKeyword.Text.Trim());
            }
            ds = bllmf.GetList(strWhere.ToString());
            GridView_Project.DataSource = ds;
            GridView_Project.DataBind();
        }
    }
}