using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Data;
using Maticsoft.Common;
using System.Drawing;
using LTP.Accounts.Bus;

namespace Maticsoft.Web.GWH
{
    public partial class Plan_Check : System.Web.UI.Page
    {
        Maticsoft.BLL.NewPort.Table_project bll = new Maticsoft.BLL.NewPort.Table_project();
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

        protected void btnSearch_Click(object sender, EventArgs e)
        {
           BindData();
        }
        public void BindData()
        {
            this.GridView_Project.DataSourceID = null;
            DataSet ds = new DataSet();
            StringBuilder strWhere = new StringBuilder();
            string value = DropDownList_isCheck.SelectedValue.ToString().Trim();
            string value1 = DropDownList_State.SelectedValue.ToString().Trim();
            string value2 = DropDownList_Type.SelectedValue.ToString().Trim();
            strWhere.AppendFormat("project_check like '%{0}%'", value);
            strWhere.AppendFormat("and project_state like '%{0}%'", value1);
            strWhere.AppendFormat("and project_type like '%{0}%'", value2);

            if (txtKeyword.Text.Trim() != "")
            {
                strWhere.AppendFormat("and(project_name like '%{0}%' or project_owner like '%{0}%' or project_positon like '%{0}%')", txtKeyword.Text.Trim());
            }
            ds = bll.GetList(strWhere.ToString());
            GridView_Project.DataSource = ds;
            GridView_Project.DataBind();
        }

        protected void DropDownList_isCheck_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownListBindData();
        }

        protected void DropDownList_State_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownListBindData();
        }

        protected void DropDownList_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownListBindData();
        }
        public void DropDownListBindData()
        {
            string value = DropDownList_isCheck.SelectedValue.ToString().Trim();
            string value1 = DropDownList_State.SelectedValue.ToString().Trim();
            string value2 = DropDownList_Type.SelectedValue.ToString().Trim();

            this.GridView_Project.DataSourceID = null;
            DataSet ds = new DataSet();
            StringBuilder strWhere = new StringBuilder();
            strWhere.AppendFormat("project_check like '%{0}%'", value);
            strWhere.AppendFormat("and project_state like '%{0}%'", value1);
            strWhere.AppendFormat("and project_type like '%{0}%'", value2);
            if (txtKeyword.Text.Trim() != "")
            {
                strWhere.AppendFormat("and(project_name like '%{0}%' or project_owner like '%{0}%' or project_positon like '%{0}%')", txtKeyword.Text.Trim());
            }
            ds = bll.GetList(strWhere.ToString());
            GridView_Project.DataSource = ds;
            GridView_Project.DataBind();
        }
    }
}