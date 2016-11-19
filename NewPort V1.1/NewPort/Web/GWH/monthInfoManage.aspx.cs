using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;
using System.Data.SqlClient;
namespace Maticsoft.Web.GWH
{
    public partial class monthInfoManage : System.Web.UI.Page
    {
        Maticsoft.BLL.NewPort.Table_project bll = new Maticsoft.BLL.NewPort.Table_project();
        Maticsoft.BLL.NewPort.Table_monthlyFeedback bllmf = new Maticsoft.BLL.NewPort.Table_monthlyFeedback();
        SqlConnection sqlcon;
        SqlCommand sqlcom;
        string strCon =System.Web.Configuration.WebConfigurationManager.ConnectionStrings["wuhanNewPort_ppdmsConnectionString"].ToString();
        static string strQuery;
        static Boolean flag;//flag 为TRUE表示按照项目查询

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["isLogin"] != "ok")
            {
                Response.Redirect("../Login.aspx");
            }
         //   GVbyPro.Attributes.Add("style", "table-layout:fixed");
        }
        public static void Show(System.Web.UI.Page page, string msg)
        {
        page.ClientScript.RegisterStartupScript(page.GetType(), "message", "<script language='javascript' defer>alert('" +  msg.ToString() + "');</script>");
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
          
              DropDownListBindData(theGrid,strQuery,flag);
                
        }



        public void DropDownListBindData(GridView gvName, string queryStr,Boolean flag)
        {


            gvName.DataSourceID = null;

            DataSet ds = new DataSet();
            StringBuilder strWhere = new StringBuilder();
            if ((queryStr != "") && (flag))
            {
                strWhere.AppendFormat("[project_id] like '%{0}%' order by [monthlyFeedback_yyyyMM]", queryStr);
            }
            else 
            {
                strWhere.AppendFormat("[monthlyFeedback_yyyyMM] like '%{0}%' order by [project_id]", queryStr);
            }
            ds = bllmf.GetList(strWhere.ToString());
            gvName.DataSource = ds;
            gvName.DataBind();
        }
            //过滤过长字符串
        /*  for (int i = 0; i <= gvName.Rows.Count - 1; i++)
            {
                DataRowView mydrv;
                string fd;
                if (gvName.PageIndex == 0)
                {
                    mydrv = ds.Tables[0].DefaultView[i];//表名
                    fd = Convert.ToString(mydrv["monthlyFeedback_fulfilmentDescription"]);//所要处理的字段
                    if (gvName.ID == "GVbyPro") gvName.Rows[i].Cells[3].Text = SubStr(fd, 20);
                    if (gvName.ID == "GVbyMonth") gvName.Rows[i].Cells[4].Text = SubStr(fd, 20);
                }
                else
                {
                    mydrv =  ds.Tables[0].DefaultView[i + (10 * gvName.PageIndex)];
                    fd = Convert.ToString(mydrv["monthlyFeedback_fulfilmentDescription"]);
                    if (gvName.ID == "GVbyPro") gvName.Rows[i].Cells[3].Text = SubStr(fd, 20);
                    if(gvName.ID=="GVbyMonth")gvName.Rows[i].Cells[4].Text = SubStr(fd, 20);
                }
            } 
        }

        public string SubStr(string sString, int nLeng)
        {
            if (sString.Length <= nLeng)
            {
                return sString;
            }
            string sNewStr = sString.Substring(0, nLeng);
            sNewStr = sNewStr + "...";
            return sNewStr;
        }
            */


        protected void btnSearch_Click(object sender, EventArgs e)
        {
           
            strQuery=tbox_pro.Text;
            flag = true;
            //根据页面情况传入dropdownlist的选项或者是TEXTBOX里的项目ID，到gvByPro这个GIRDVIEW里面，然后重新绑定即可。
            DropDownListBindData(GVbyPro, tbox_pro.Text,flag);
        }

        protected void ddlist_pro_selectChange(object sender, EventArgs e)
        {
       
          tbox_pro.Text=ddlist_pro.SelectedValue;
          strQuery = tbox_pro.Text; 
           flag = true;
          DropDownListBindData(GVbyPro, strQuery,flag);
        }

        protected void btnSearch_ClickbyMonth(object sender, EventArgs e)
        {
            
            strQuery = tbox_month.Text; 
            flag = false;
            //根据页面情况传入dropdownlist的选项或者是TEXTBOX里的项目ID，到gvByPro这个GIRDVIEW里面，然后重新绑定即可。
            DropDownListBindData(GVbyPro,strQuery,flag);
        }

        protected void GridView_RowDataBound(object sender, GridViewRowEventArgs e)
    {
         GridView theGrid = sender as GridView;
            int i;
        //执行循环，保证每条数据都可以更新
        for (i = -1; i < theGrid.Rows.Count; i++)
        {
            //首先判断是否是数据行
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                //当鼠标停留时更改背景色
                e.Row.Attributes.Add("onmouseover", "c=this.style.backgroundColor;this.style.backgroundColor='#00A9FF'");
                //当鼠标移开时还原背景色
                e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor=c");
            }
        }
    }

        protected void GridView_RowEditing(object sender, GridViewEditEventArgs e)
    {   GridView theGrid = sender as GridView;
        theGrid.EditIndex = e.NewEditIndex;
        DropDownListBindData(theGrid, strQuery,flag);
    }
        //删除
        protected void GridView_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
         GridView theGrid = sender as GridView;
         string sqlstr = "delete from Table_monthlyFeedback where monthlyFeedback_sn='" + theGrid.DataKeys[e.RowIndex].Value.ToString() + "'";
        sqlcon = new SqlConnection(strCon);
        sqlcom = new SqlCommand(sqlstr,sqlcon);
        sqlcon.Open();
        sqlcom.ExecuteNonQuery();
        sqlcon.Close();
        DropDownListBindData(theGrid,strQuery,flag);
    }
        //更新
        protected void GridView_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        GridView theGrid = sender as GridView;
        sqlcon = new SqlConnection(strCon);
        string sqlstr = "update [Table_monthlyFeedback] set [monthlyFeedback_fulfilmentDescription]='"
            +((TextBox)(theGrid.Rows[e.RowIndex].Cells[4].Controls[0])).Text + "',[monthlyFeedback_fulfilment]='"
            + float.Parse(((TextBox)(theGrid.Rows[e.RowIndex].Cells[3].Controls[0])).Text.ToString().Trim()) + "',[monthlyFeedback_writer]='"
            + ((TextBox)(theGrid.Rows[e.RowIndex].Cells[5].Controls[0])).Text.ToString().Trim() + "' where monthlyFeedback_sn='" 
            + theGrid.DataKeys[e.RowIndex].Value.ToString() + "'";
        sqlcom=new SqlCommand(sqlstr,sqlcon);
        try
        {
            sqlcon.Open();
            sqlcom.ExecuteNonQuery();
            sqlcon.Close();
        }
        catch { Show(this, "修改失败，请稍后再试！"); return; }
        Show(this, "修改成功！");
        DropDownListBindData(theGrid, strQuery, flag);
    }
        //取消
        protected void GridView_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
       {
        
        GridView theGrid = sender as GridView;
        theGrid.EditIndex = -1;
        DropDownListBindData(theGrid,strQuery,flag);
       }
        //绑定
  
}

}
