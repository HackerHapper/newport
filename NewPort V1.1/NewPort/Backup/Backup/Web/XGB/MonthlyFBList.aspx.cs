using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;

namespace Maticsoft.Web.XGB
{
    public partial class MonthlyFBList : System.Web.UI.Page
    {
        Maticsoft.BLL.NewPort.Table_project bll = new Maticsoft.BLL.NewPort.Table_project();
        Maticsoft.BLL.NewPort.Table_monthlyFeedback bllmf = new Maticsoft.BLL.NewPort.Table_monthlyFeedback();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["isLogin"] != "ok")
            {
                Response.Redirect("../Login.aspx");
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
            DropDownListBindData();
        }
        public void DropDownListBindData()
        {

            this.GridView_Project.DataSourceID = null;
            DataSet ds = new DataSet();
            StringBuilder strWhere = new StringBuilder();
            if (txtKeyword.Text.Trim() != "")
            {
                strWhere.AppendFormat("monthlyFeedback_fulfilmentDescription like '%{0}%'", txtKeyword.Text.Trim());
            }
            ds = bllmf.GetList(strWhere.ToString());
            GridView_Project.DataSource = ds;
            GridView_Project.DataBind();
        }

        protected void btnmSearch_Click(object sender, EventArgs e)
        {

        }
    }
}