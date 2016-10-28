using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;


namespace Maticsoft.Web.XGB
{
    public partial class planHistoryList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           if (!IsPostBack)
            {
                Session["dept"] = "江夏区";

                DateTime now = DateTime.Now;//初始化计划年份下拉列表
                //2000 为起始年份
                int year = 2000;
                //向后10年
                for (int i = 0; i < now.Year - 2000 + 10; i++)
                {
                    string value = (year + i).ToString();
                    planYear.Items.Add(new ListItem(value, value));

                }
                
              /* DataView ds = (DataView)SqlDataSource1.Select(DataSourceSelectArguments.Empty);
                planClass.DataSource = ds.Table;
                planClass.DataTextField = "plan_name";
                planClass.DataValueField = "plan_id";
                planClass.DataBind();

                planYear.SelectedValue = Request.QueryString["py"].ToString().Trim();
                planClass.SelectedValue = Request.QueryString["pc"].ToString().Trim();
                showClass.Text = planClass.SelectedItem.Text;
                showYear.Text = planYear.SelectedValue;
                unit.Text = Session["dept"].ToString();
               */
            }
     
        

        }
        protected override void OnPreRenderComplete(EventArgs e)//注意aspx页面的生命周期
        {
            planYear.SelectedValue = Request.QueryString["py"].ToString().Trim();
            planClass.SelectedValue = Request.QueryString["pc"].ToString().Trim();

            showClass.Text = planClass.SelectedItem.Text;
            showYear.Text = planYear.SelectedValue;
            unit.Text = Session["dept"].ToString();

        }

           


        protected void planClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            Server.Transfer("planHistoryList.aspx?py=" + planYear.SelectedValue + "&pc=" + planClass.SelectedValue.ToString() + "");
   
           // Response.Redirect("planHistoryList.aspx?py=" + planYear.SelectedValue + "&pc=" + planClass.SelectedValue.ToString() + "");
        }

        protected void planYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            Server.Transfer("planHistoryList.aspx?py=" + planYear.SelectedValue + "&pc=" + planClass.SelectedValue.ToString() + "");
 
            //Response.Redirect("planHistoryList.aspx?py=" + planYear.SelectedValue + "&pc=" + planClass.SelectedValue.ToString() + "");
        }
    }
}