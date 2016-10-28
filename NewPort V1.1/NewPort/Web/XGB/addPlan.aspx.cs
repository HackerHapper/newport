using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Maticsoft.Web.XGB
{
    public partial class addnewplan : System.Web.UI.Page
    {
        static string strid = ""; 
        //关键点：AJAX动态更新，postBack原理（页面加载原理），数据绑定，数据源相关操作，触发SelectedIndexChanged 事件。
        protected void Page_Load(object sender, EventArgs e)
        {
            //this.planYear.SelectedIndexChanged += new System.EventHandler(this.planYear_SelectedIndexChanged);
            if (Session["isLogin"] != "ok")
            {
                Response.Redirect("../Login.aspx");
            }
            strid = Session["UserName"].ToString().Trim();

            Session["CurrenProId"] = "";
           

            for (int i = 0; i < GridView1.Rows.Count; i++)  //初始化取到数据，只是默认都看不见。
                GridView1.Rows[i].Visible = false;

            if (!Page.IsPostBack)
            {
                DateTime now = DateTime.Now;//初始化计划年份下拉列表
                //2000 为起始年份
                int year = 2000;
                //向后10年
                for (int i = 0; i < now.Year - 2000 + 10; i++)
                {
                    string value = (year + i).ToString();
                    planYear.Items.Add(new ListItem(value, value));


                }
                planYear.SelectedIndex = now.Year - 2000; //默认选择当前年度
            }
        }


        protected void Button2_Click(object sender, EventArgs e)
        {
            // for (int i = 0; i < GridView1.Rows.Count; i++)  //初始化取到数据，只是默认都看不见。
            //     GridView1.Rows[i].Visible = false;

            if (toAddList.SelectedItem != null)
            {
                addedList.Items.Add(toAddList.Items[toAddList.SelectedIndex]);
                toAddList.Items.Remove(toAddList.SelectedItem);
                for (int n = 0; n < addedList.Items.Count; n++) //重新编辑GRIVDVIEW1的显示
                {
                    int j = 0;
                    for (int i = 0; i <= GridView1.Rows.Count - 1; i++)
                    {
                        if (GridView1.Rows[i].Cells[0].Text.Trim() == addedList.Items[n].Value.Trim())
                        { j = i; break; }
                    }
                    GridView1.Rows[j].Visible = true;

                }
            }
            else { Response.Write("<SCRIPT>ALERT('您未选择任何项目')</SCRIPT>"); }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (addedList.SelectedItem != null)
            {
                toAddList.Items.Add(addedList.Items[addedList.SelectedIndex]);
                addedList.Items.Remove(addedList.SelectedItem);
                for (int n = 0; n < addedList.Items.Count; n++) //重新编辑GRIVDVIEW1的显示
                {
                    int j = 0;
                    for (int i = 0; i <= GridView1.Rows.Count - 1; i++)
                    {
                        if (GridView1.Rows[i].Cells[0].Text.Trim() == addedList.Items[n].Value.Trim())
                        { j = i; break; }
                    }
                    GridView1.Rows[j].Visible = true;
                }
            }
            else { Response.Write("<SCRIPT>ALERT('您未选择任何项目')</SCRIPT>"); }
        }

        protected void save_Click(object sender, EventArgs e)
        {
            int count = 0;
            try
            {
                Maticsoft.Model.NewPort.Table_annualPlan md = new Model.NewPort.Table_annualPlan();
                Maticsoft.BLL.NewPort.Table_annualPlan BLLtp = new BLL.NewPort.Table_annualPlan();
                int n = 0;
                for (int i = 0; i < GridView1.Rows.Count; i++)//获取当前待申报计划列表中可见计划的数量
                {
                    if (GridView1.Rows[i].Visible == true) n++;
                }

                for (int i = 0; i < n; i++)
                {
                    string toDay = DateTime.Now.Year.ToString().Substring(2, 2) + DateTime.Now.Month.ToString().PadLeft(2, '0') + DateTime.Now.Day.ToString().PadLeft(2, '0');
                    md.annualPlan_sn = toDay + (BLLtp.GetRecordCount("annualPlan_sn like '" + toDay + "%'") + 1).ToString().PadLeft(4, '0');
                    md.plan_id = planClass.SelectedValue;
                    md.project_id = GridView1.Rows[i].Cells[0].Text.ToString();
                    md.annualPlan_checkState = "待审核";
                    TextBox tempTextBox;
                    tempTextBox = (TextBox)GridView1.Rows[i].Cells[15].FindControl("earlyProgress");
                    md.annualPlan_earlyProgress = tempTextBox.Text;
                    tempTextBox = (TextBox)GridView1.Rows[i].Cells[16].FindControl("thisPlanInvestment");
                    md.annualPlan_targetCompletion = Convert.ToDecimal(tempTextBox.Text);
                    tempTextBox = (TextBox)GridView1.Rows[i].Cells[17].FindControl("thisPlanProgress");
                    md.annualPlan_targetDescription = tempTextBox.Text;
                    md.planYear = planYear.Text;
                    BLLtp.Add(md);
                    count++;

                }
                Maticsoft.Common.MessageBox.Show(this, "全部保存成功，共处理" + count + "条计划");

            }
            catch
            {
                Maticsoft.Common.MessageBox.Show(this, "未能成功保存所有条目，仅成功处理" + count + "条计划");
            }

        }

        protected void planClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) { Maticsoft.Common.MessageBox.Show(this, "类型改变"); }

        }

        protected void planYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            Response.Write("<SCRIPT>ALERT('年度改变alert')<SCRIPT>");

            if (!Page.IsPostBack) { Maticsoft.Common.MessageBox.Show(this, "年度改变"); }
        }

        protected void checkInfo_Click(object sender, EventArgs e)
        {
            Response.Redirect("planHistoryList.aspx?py=" + planYear.SelectedValue + "&pc=" + planClass.SelectedValue.ToString() + "");
        }



    }
}