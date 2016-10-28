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
    public partial class Plan_Management : System.Web.UI.Page
    {
        static string strid = ""; 
        Maticsoft.BLL.NewPort.Table_project bllm = new Maticsoft.BLL.NewPort.Table_project();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["isLogin"] != "ok")
            {
                Response.Redirect("../Login.aspx");
            }
            if (Request.QueryString["id"] != null)
            {
                strid = Request.QueryString["id"].ToString();
                Maticsoft.BLL.NewPort.Table_project bll = new Maticsoft.BLL.NewPort.Table_project();
                bll.Delete(strid);
            }

        }
        protected void gvwDesignationName_mPageIndexChanging(object sender, GridViewPageEventArgs e)
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

        protected void btnmSearch_Click(object sender, EventArgs e)
        {
            BindData();
        }
        public void BindData()
        {
            this.GridView_mProject.DataSourceID = null;
            DataSet ds = new DataSet();
            StringBuilder strWhere = new StringBuilder();
            string value = DropDownList_misCheck.SelectedValue.ToString().Trim();
            string value1 = DropDownList_mState.SelectedValue.ToString().Trim();
            string value2 = DropDownList_mType.SelectedValue.ToString().Trim();
            string value3 = DropDownList_Year.SelectedValue.ToString().Trim();
            
            strWhere.AppendFormat("project_class like '%{0}%'", value);
            strWhere.AppendFormat("and project_state like '%{0}%'", value1);
            strWhere.AppendFormat("and project_type like '%{0}%'", value2);
            strWhere.AppendFormat("and project_year like '%{0}%'", value3);

            if (txtmKeyword.Text.Trim() != "")
            {
                strWhere.AppendFormat("and(project_name like '%{0}%' or project_owner like '%{0}%' or project_positon like '%{0}%')", txtmKeyword.Text.Trim());
            }
            ds = bllm.GetList(strWhere.ToString());
            GridView_mProject.DataSource = ds;
            GridView_mProject.DataBind();
        }

        protected void DropDownList_mType_SelectedIndexChanged(object sender, EventArgs e)
        {
            mDropDownListBindData();
        }

        protected void DropDownList_mState_SelectedIndexChanged(object sender, EventArgs e)
        {
            mDropDownListBindData();
        }

        protected void DropDownList_misCheck_SelectedIndexChanged(object sender, EventArgs e)
        {
            mDropDownListBindData();
        }
        protected void DropDownList_Year_SelectedIndexChanged(object sender, EventArgs e)
        {
            mDropDownListBindData();
        }
        public void mDropDownListBindData()
        {
            string value = DropDownList_misCheck.SelectedValue.ToString().Trim();
            string value1 = DropDownList_mState.SelectedValue.ToString().Trim();
            string value2 = DropDownList_mType.SelectedValue.ToString().Trim();
            string value3 = DropDownList_Year.SelectedValue.ToString().Trim();

            this.GridView_mProject.DataSourceID = null;
            DataSet ds = new DataSet();
            StringBuilder strWhere = new StringBuilder();
            strWhere.AppendFormat("project_class like '%{0}%'", value);
            strWhere.AppendFormat("and project_state like '%{0}%'", value1);
            strWhere.AppendFormat("and project_type like '%{0}%'", value2);
            strWhere.AppendFormat("and project_year like '%{0}%'", value3);
            if (txtmKeyword.Text.Trim() != "")
            {
                strWhere.AppendFormat("and(project_name like '%{0}%' or project_owner like '%{0}%' or project_positon like '%{0}%' or project_year like '%{0}%')", txtmKeyword.Text.Trim());
            }
            ds = bllm.GetList(strWhere.ToString());
            GridView_mProject.DataSource = ds;
            GridView_mProject.DataBind();
        }

    }
}