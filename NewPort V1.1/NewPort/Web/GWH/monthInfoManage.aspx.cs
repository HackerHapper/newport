using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;

namespace Maticsoft.Web.GWH
{
    public partial class monthInfoManage : System.Web.UI.Page
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
            BindData(theGrid);
        }
        public void BindData(GridView gv)
        {
            gv.DataSourceID = null;
            DataSet ds = new DataSet();
            gv.DataSource = ds;
            gv.DataBind();
        }
        public void DropDownListBindData(GridView gvName,string queryStr)
        {
          
           
                gvName.DataSourceID = null;
           
            DataSet ds = new DataSet();
            StringBuilder strWhere = new StringBuilder();
            if ((queryStr != "")&&(gvName.ID.ToString()=="GVbyPro"))
            {
                strWhere.AppendFormat("[project_id] like '%{0}%' order by [monthlyFeedback_yyyyMM]", queryStr);
            }
            else if ((queryStr != "") &&(gvName.ID.ToString () == "GVbyMonth"))
            {
                strWhere.AppendFormat("[monthlyFeedback_yyyyMM] like '%{0}%' order by [project_id]", queryStr);
            }
            ds = bllmf.GetList(strWhere.ToString());
            gvName.DataSource = ds;
            gvName.DataBind();
        }
        protected void btnSearch_Click(object sender, EventArgs e)
        {
            GVbyPro.Visible = true; GVbyMonth.Visible = false; 
            //根据页面情况传入dropdownlist的选项或者是TEXTBOX里的项目ID，到gvByPro这个GIRDVIEW里面，然后重新绑定即可。
            DropDownListBindData(GVbyPro, tbox_pro.Text);
        }
        protected void ddlist_pro_selectChange(object sender, EventArgs e)
        {
            GVbyPro.Visible = true; GVbyMonth.Visible = false;
          tbox_pro.Text=ddlist_pro.SelectedValue;
          DropDownListBindData(GVbyPro, tbox_pro.Text);
        }

        protected void btnSearch_ClickbyMonth(object sender, EventArgs e)
        {
            GVbyPro.Visible = false; GVbyMonth.Visible = true;
            //根据页面情况传入dropdownlist的选项或者是TEXTBOX里的项目ID，到gvByPro这个GIRDVIEW里面，然后重新绑定即可。
            DropDownListBindData(GVbyMonth, tbox_month.Text);
        }
    }
}