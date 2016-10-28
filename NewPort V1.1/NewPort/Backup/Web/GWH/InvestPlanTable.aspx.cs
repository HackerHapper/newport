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

namespace Maticsoft.Web.GWH
{
    public partial class InvestPlanTable : System.Web.UI.Page
    {
        protected string evalgh, evaljsy, evallg, evalghandnew, evaljsyandnew, evallgandnew, evalghandgoon, evaljsyandgoon, evallgandgoon, evalall,evalallgoon,evalallnew;
        protected double countsum = 0, countgoon = 0, countnew = 0;
        protected string evalgh1, evaljsy1, evallg1, evalghandnew1, evaljsyandnew1, evallgandnew1, evalghandgoon1, evaljsyandgoon1, evallgandgoon1, evalall1, evalallgoon1, evalallnew1;
        protected double countsum1 = 0, countgoon1 = 0, countnew1 = 0;
        protected string evalgh2, evaljsy2, evallg2, evalghandnew2, evaljsyandnew2, evallgandnew2, evalghandgoon2, evaljsyandgoon2, evallgandgoon2, evalall2, evalallgoon2, evalallnew2;
        protected double countsum2 = 0, countgoon2 = 0, countnew2 = 0;

        protected string lastyeargh, lastyearjsy, lastyearlg, lastyearghandnew, lastyearjsyandnew, lastyearlgandnew, lastyearghandgoon, lastyearjsyandgoon, lastyearlgandgoon, lastyearall, lastyearallgoon, lastyearallnew;
        protected double lastyearsum = 0, lastyeargoon = 0, lastyearnew = 0;
        protected string lastyeargh1, lastyearjsy1, lastyearlg1, lastyearghandnew1, lastyearjsyandnew1, lastyearlgandnew1, lastyearghandgoon1, lastyearjsyandgoon1, lastyearlgandgoon1, lastyearall1, lastyearallgoon1, lastyearallnew1;
        protected double lastyearsum1 = 0, lastyeargoon1 = 0, lastyearnew1 = 0;
        protected string lastyeargh2, lastyearjsy2, lastyearlg2, lastyearghandnew2, lastyearjsyandnew2, lastyearlgandnew2, lastyearghandgoon2, lastyearjsyandgoon2, lastyearlgandgoon2, lastyearall2, lastyearallgoon2, lastyearallnew2;
        protected double lastyearsum2 = 0, lastyeargoon2 = 0, lastyearnew2 = 0;

        protected string ratiogh, ratiojsy, ratiolg, ratioghandnew, ratiojsyandnew, ratiolgandnew, ratioghandgoon, ratiojsyandgoon, ratiolgandgoon, ratioall, ratioallgoon, ratioallnew;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["isLogin"] != "ok")
            {
                Response.Redirect("../Login.aspx");
            }
        }
        public void countnumberall(string strWhere, string countYear)
        {
            int intcountgh = 0, intcountjsy = 0, intcountlg = 0, intcountghandnew = 0, intcountjsyandnew = 0, intcountlgandnew = 0, intcountghandgoon = 0, intcountjsyandgoon = 0, intcountlgandgoon = 0;
            string strcountstrgh = "", strcountstrjsy = "", strcountstrlg = "", strcountstrghandnew = "", strcountstrjsyandnew = "", strcountstrlgandnew = "", strcountstrghandgoon = "", strcountstrjsyandgoon = "", strcountstrlgandgoon = "";

            StringBuilder strcountgh=new StringBuilder();
            StringBuilder strcountjsy=new StringBuilder();
            StringBuilder strcountlg=new StringBuilder();
            StringBuilder strcountghandnew=new StringBuilder();
            StringBuilder strcountjsyandnew=new StringBuilder();
            StringBuilder strcountlgandnew=new StringBuilder();
            StringBuilder strcountghandgoon=new StringBuilder();
            StringBuilder strcountjsyandgoon=new StringBuilder();
            StringBuilder strcountlgandgoon=new StringBuilder();

            strcountgh.AppendFormat("select count('港航项目') from {0} where (project_type='港航项目' and ", countYear);
            strcountjsy.AppendFormat("select count('集疏运项目') from {0}  where (project_type='集疏运项目' and ", countYear);
            strcountlg.AppendFormat("select count('临港产业项目') from {0}  where (project_type='临港产业项目' and ", countYear);
            strcountghandnew.AppendFormat("select count('港航项目') from {0}  where ((project_type='港航项目' and project_state='新开工') and ", countYear);
            strcountjsyandnew.AppendFormat("select count('集疏运项目') from {0}  where ((project_type='集疏运项目' and project_state='新开工') and ", countYear);
            strcountlgandnew.AppendFormat("select count('临港产业项目') from {0}  where ((project_type='临港产业项目' and project_state='新开工') and ", countYear);
            strcountghandgoon.AppendFormat("select count('港航项目') from {0}  where ((project_type='港航项目' and project_state='续建') and ", countYear);
            strcountjsyandgoon.AppendFormat("select count('集疏运项目') from {0}  where ((project_type='集疏运项目' and project_state='续建') and ", countYear);
            strcountlgandgoon.AppendFormat("select count('临港产业项目') from {0}  where ((project_type='临港产业项目' and project_state='续建') and", countYear);
            
            if (strWhere.Trim() != "")
            {
                strcountgh.Append(strWhere);           
                strcountjsy.Append(strWhere);
                strcountlg.Append(strWhere);
                strcountghandnew.Append(strWhere);
                strcountjsyandnew.Append(strWhere);
                strcountlgandnew.Append(strWhere);
                strcountghandgoon.Append(strWhere);
                strcountjsyandgoon.Append(strWhere);
                strcountlgandgoon.Append(strWhere);
            }
                        
            strcountstrgh = strcountgh.ToString();
            strcountstrjsy = strcountjsy.ToString();
            strcountstrlg = strcountlg.ToString();
            strcountstrghandnew = strcountghandnew.ToString();
            strcountstrjsyandnew = strcountjsyandnew.ToString();
            strcountstrlgandnew = strcountlgandnew.ToString();
            strcountstrghandgoon = strcountghandgoon.ToString();
            strcountstrjsyandgoon = strcountjsyandgoon.ToString();
            strcountstrlgandgoon = strcountlgandgoon.ToString();

            evalgh = getValue(strcountstrgh, intcountgh);
            evaljsy = getValue(strcountstrjsy, intcountjsy);
            evallg = getValue(strcountstrlg,intcountlg);
            evalghandnew = getValue(strcountstrghandnew,intcountghandnew);
            evaljsyandnew = getValue(strcountstrjsyandnew,intcountjsyandnew);
            evallgandnew = getValue(strcountstrlgandnew,intcountlgandnew);
            evalghandgoon = getValue(strcountstrghandgoon, intcountghandgoon);
            evaljsyandgoon = getValue(strcountstrjsyandgoon, intcountjsyandgoon);
            evallgandgoon = getValue(strcountstrlgandgoon, intcountlgandgoon);

            countsum = Int32.Parse(evalgh) + Int32.Parse(evaljsy) + Int32.Parse(evallg);
            countgoon = Int32.Parse(evalghandgoon) + Int32.Parse(evaljsyandgoon) + Int32.Parse(evallgandgoon);
            countnew = Int32.Parse(evalghandnew) + Int32.Parse(evaljsyandnew) + Int32.Parse(evallgandnew);
            evalall = countsum.ToString();
            evalallgoon = countgoon.ToString();
            evalallnew = countnew.ToString();
        }
        public void countinvestall(string strWhere, string countYear)
        {
           string strcountstrgh = "", strcountstrjsy = "", strcountstrlg = "", strcountstrghandnew = "", strcountstrjsyandnew = "", strcountstrlgandnew = "", strcountstrghandgoon = "", strcountstrjsyandgoon = "", strcountstrlgandgoon = "";
            StringBuilder strcountgh=new StringBuilder();
            StringBuilder strcountjsy=new StringBuilder();
            StringBuilder strcountlg=new StringBuilder();
            StringBuilder strcountghandnew=new StringBuilder();
            StringBuilder strcountjsyandnew=new StringBuilder();
            StringBuilder strcountlgandnew=new StringBuilder();
            StringBuilder strcountghandgoon=new StringBuilder();
            StringBuilder strcountjsyandgoon=new StringBuilder();
            StringBuilder strcountlgandgoon=new StringBuilder();

            strcountgh.AppendFormat("select sum(project_totalinvestment) from {0} where (project_type='港航项目' and ", countYear);
            strcountjsy.AppendFormat("select sum(project_totalinvestment) from {0} where (project_type='集疏运项目' and ", countYear);
            strcountlg.AppendFormat("select sum(project_totalinvestment) from {0} where (project_type='临港产业项目' and ", countYear);
            strcountghandnew.AppendFormat("select sum(project_totalinvestment) from {0} where ((project_type='港航项目' and project_state='新开工') and ", countYear);
            strcountjsyandnew.AppendFormat("select sum(project_totalinvestment) from {0} where ((project_type='集疏运项目' and project_state='新开工') and ", countYear);
            strcountlgandnew.AppendFormat("select sum(project_totalinvestment) from {0} where ((project_type='临港产业项目' and project_state='新开工') and ", countYear);
            strcountghandgoon.AppendFormat("select sum(project_totalinvestment) from {0} where ((project_type='港航项目' and project_state='续建') and ", countYear);
            strcountjsyandgoon.AppendFormat("select sum(project_totalinvestment) from {0} where ((project_type='集疏运项目' and project_state='续建') and  ", countYear);
            strcountlgandgoon.AppendFormat("select sum(project_totalinvestment) from {0} where ((project_type='临港产业项目' and project_state='续建') and  ", countYear);
                          
             if(strWhere.Trim()!="")
			{
                strcountgh.Append(strWhere);
                strcountstrgh = strcountgh.ToString();
                strcountjsy.Append(strWhere);
                strcountstrjsy = strcountjsy.ToString();
                strcountlg.Append(strWhere);
                strcountstrlg = strcountlg.ToString();
                strcountghandnew.Append(strWhere);
                strcountstrghandnew = strcountghandnew.ToString();
                strcountjsyandnew.Append(strWhere);
                strcountstrjsyandnew = strcountjsyandnew.ToString();
                strcountlgandnew.Append(strWhere);
                strcountstrlgandnew = strcountlgandnew.ToString();
                strcountghandgoon.Append(strWhere);
                strcountstrghandgoon = strcountghandgoon.ToString();
                strcountjsyandgoon.Append(strWhere);
                strcountstrjsyandgoon = strcountjsyandgoon.ToString();
                strcountlgandgoon.Append(strWhere);
                strcountstrlgandgoon = strcountlgandgoon.ToString();
			}
            
            evalgh1 = getCountValue(strcountstrgh);
            evaljsy1 = getCountValue(strcountstrjsy);
            evallg1 = getCountValue(strcountstrlg);
            evalghandnew1 = getCountValue(strcountstrghandnew);
            evaljsyandnew1 = getCountValue(strcountstrjsyandnew);
            evallgandnew1 = getCountValue(strcountstrlgandnew);
            evalghandgoon1 = getCountValue(strcountstrghandgoon);
            evaljsyandgoon1 = getCountValue(strcountstrjsyandgoon);
            evallgandgoon1 = getCountValue(strcountstrlgandgoon);

            countsum1 =  double.Parse(evalgh1) + double.Parse(evaljsy1) + double.Parse(evallg1);
            countgoon1 = double.Parse(evalghandgoon1) + double.Parse(evaljsyandgoon1) + double.Parse(evallgandgoon1);
            countnew1 =  double.Parse(evalghandnew1) + double.Parse(evaljsyandnew1) + double.Parse(evallgandnew1);
            
            evalall1 = countsum1.ToString();
            evalallgoon1 = countgoon1.ToString();
            evalallnew1 = countnew1.ToString();
        }
        public void countinvestplanall(string strWhere, string countYear)
         {
             string strcountstrgh = "", strcountstrjsy = "", strcountstrlg = "", strcountstrghandnew = "", strcountstrjsyandnew = "", strcountstrlgandnew = "", strcountstrghandgoon = "", strcountstrjsyandgoon = "", strcountstrlgandgoon = "";
            StringBuilder strcountgh=new StringBuilder();
            StringBuilder strcountjsy=new StringBuilder();
            StringBuilder strcountlg=new StringBuilder();
            StringBuilder strcountghandnew=new StringBuilder();
            StringBuilder strcountjsyandnew=new StringBuilder();
            StringBuilder strcountlgandnew=new StringBuilder();
            StringBuilder strcountghandgoon=new StringBuilder();
            StringBuilder strcountjsyandgoon=new StringBuilder();
            StringBuilder strcountlgandgoon=new StringBuilder();

            strcountgh.AppendFormat("select sum(investmentin2015) from {0} where (project_type='港航项目' and ", countYear);
            strcountjsy.AppendFormat("select sum(investmentin2015) from {0} where (project_type='集疏运项目' and ", countYear);
            strcountlg.AppendFormat("select sum(investmentin2015) from {0} where (project_type='临港产业项目' and ", countYear);
            strcountghandnew.AppendFormat("select sum(investmentin2015) from {0} where ((project_type='港航项目' and project_state='新开工') and ", countYear);
            strcountjsyandnew.AppendFormat("select sum(investmentin2015) from {0} where ((project_type='集疏运项目' and project_state='新开工') and ", countYear);
            strcountlgandnew.AppendFormat("select sum(investmentin2015) from {0} where ((project_type='临港产业项目' and project_state='新开工') and ", countYear);
            strcountghandgoon.AppendFormat("select sum(investmentin2015) from {0} where ((project_type='港航项目' and project_state='续建') and ", countYear);
            strcountjsyandgoon.AppendFormat("select sum(investmentin2015) from {0} where ((project_type='集疏运项目' and project_state='续建') and  ", countYear);
            strcountlgandgoon.AppendFormat("select sum(investmentin2015) from {0} where ((project_type='临港产业项目' and project_state='续建') and  ", countYear);
             
             if(strWhere.Trim()!="")
			{
                strcountgh.Append(strWhere);
                strcountstrgh = strcountgh.ToString();
                strcountjsy.Append(strWhere);
                strcountstrjsy = strcountjsy.ToString();
                strcountlg.Append(strWhere);
                strcountstrlg = strcountlg.ToString();
                strcountghandnew.Append(strWhere);
                strcountstrghandnew = strcountghandnew.ToString();
                strcountjsyandnew.Append(strWhere);
                strcountstrjsyandnew = strcountjsyandnew.ToString();
                strcountlgandnew.Append(strWhere);
                strcountstrlgandnew = strcountlgandnew.ToString();
                strcountghandgoon.Append(strWhere);
                strcountstrghandgoon = strcountghandgoon.ToString();
                strcountjsyandgoon.Append(strWhere);
                strcountstrjsyandgoon = strcountjsyandgoon.ToString();
                strcountlgandgoon.Append(strWhere);
                strcountstrlgandgoon = strcountlgandgoon.ToString();
			}
             
             evalgh2 = getCountValue(strcountstrgh);
             evaljsy2 = getCountValue(strcountstrjsy);
             evallg2 = getCountValue(strcountstrlg);
             evalghandnew2 = getCountValue(strcountstrghandnew);
             evaljsyandnew2 = getCountValue(strcountstrjsyandnew);
             evallgandnew2 = getCountValue(strcountstrlgandnew);
             evalghandgoon2 = getCountValue(strcountstrghandgoon);
             evaljsyandgoon2 = getCountValue(strcountstrjsyandgoon);
             evallgandgoon2 = getCountValue(strcountstrlgandgoon);

             countsum2 = double.Parse(evalgh2) + double.Parse(evaljsy2) + double.Parse(evallg2);
             countgoon2 = double.Parse(evalghandgoon2) + double.Parse(evaljsyandgoon2) + double.Parse(evallgandgoon2);
             countnew2 = double.Parse(evalghandnew2) + double.Parse(evaljsyandnew2) + double.Parse(evallgandnew2);

             evalall2 = countsum2.ToString();
             evalallgoon2 = countgoon2.ToString();
             evalallnew2 = countnew2.ToString();
         }

        /*去年的数据*/
        public void countnumberalllastyear(string strWhere, string countYear)
        {
            int intcountgh = 0, intcountjsy = 0, intcountlg = 0, intcountghandnew = 0, intcountjsyandnew = 0, intcountlgandnew = 0, intcountghandgoon = 0, intcountjsyandgoon = 0, intcountlgandgoon = 0;
            string strcountstrgh = "", strcountstrjsy = "", strcountstrlg = "", strcountstrghandnew = "", strcountstrjsyandnew = "", strcountstrlgandnew = "", strcountstrghandgoon = "", strcountstrjsyandgoon = "", strcountstrlgandgoon = "";

            StringBuilder strcountgh = new StringBuilder();
            StringBuilder strcountjsy = new StringBuilder();
            StringBuilder strcountlg = new StringBuilder();
            StringBuilder strcountghandnew = new StringBuilder();
            StringBuilder strcountjsyandnew = new StringBuilder();
            StringBuilder strcountlgandnew = new StringBuilder();
            StringBuilder strcountghandgoon = new StringBuilder();
            StringBuilder strcountjsyandgoon = new StringBuilder();
            StringBuilder strcountlgandgoon = new StringBuilder();

            strcountgh.AppendFormat("select count('港航项目') from {0} where (project_type='港航项目' and ", countYear);
            strcountjsy.AppendFormat("select count('集疏运项目') from {0}  where (project_type='集疏运项目' and ", countYear);
            strcountlg.AppendFormat("select count('临港产业项目') from {0}  where (project_type='临港产业项目' and ", countYear);
            strcountghandnew.AppendFormat("select count('港航项目') from {0}  where ((project_type='港航项目' and project_state='新开工') and ", countYear);
            strcountjsyandnew.AppendFormat("select count('集疏运项目') from {0}  where ((project_type='集疏运项目' and project_state='新开工') and ", countYear);
            strcountlgandnew.AppendFormat("select count('临港产业项目') from {0}  where ((project_type='临港产业项目' and project_state='新开工') and ", countYear);
            strcountghandgoon.AppendFormat("select count('港航项目') from {0}  where ((project_type='港航项目' and project_state='续建') and ", countYear);
            strcountjsyandgoon.AppendFormat("select count('集疏运项目') from {0}  where ((project_type='集疏运项目' and project_state='续建') and ", countYear);
            strcountlgandgoon.AppendFormat("select count('临港产业项目') from {0}  where ((project_type='临港产业项目' and project_state='续建') and", countYear);

            if (strWhere.Trim() != "")
            {
                strcountgh.Append(strWhere);
                strcountjsy.Append(strWhere);
                strcountlg.Append(strWhere);
                strcountghandnew.Append(strWhere);
                strcountjsyandnew.Append(strWhere);
                strcountlgandnew.Append(strWhere);
                strcountghandgoon.Append(strWhere);
                strcountjsyandgoon.Append(strWhere);
                strcountlgandgoon.Append(strWhere);
            }

            strcountstrgh = strcountgh.ToString();
            strcountstrjsy = strcountjsy.ToString();
            strcountstrlg = strcountlg.ToString();
            strcountstrghandnew = strcountghandnew.ToString();
            strcountstrjsyandnew = strcountjsyandnew.ToString();
            strcountstrlgandnew = strcountlgandnew.ToString();
            strcountstrghandgoon = strcountghandgoon.ToString();
            strcountstrjsyandgoon = strcountjsyandgoon.ToString();
            strcountstrlgandgoon = strcountlgandgoon.ToString();

            lastyeargh = getValue(strcountstrgh, intcountgh);
            lastyearjsy = getValue(strcountstrjsy, intcountjsy);
            lastyearlg = getValue(strcountstrlg, intcountlg);
            lastyearghandnew = getValue(strcountstrghandnew, intcountghandnew);
            lastyearjsyandnew = getValue(strcountstrjsyandnew, intcountjsyandnew);
            lastyearlgandnew = getValue(strcountstrlgandnew, intcountlgandnew);
            lastyearghandgoon = getValue(strcountstrghandgoon, intcountghandgoon);
            lastyearjsyandgoon = getValue(strcountstrjsyandgoon, intcountjsyandgoon);
            lastyearlgandgoon = getValue(strcountstrlgandgoon, intcountlgandgoon);

            lastyearsum = Int32.Parse(lastyeargh) + Int32.Parse(lastyearjsy) + Int32.Parse(lastyearlg);
            lastyeargoon = Int32.Parse(lastyearghandgoon) + Int32.Parse(lastyearjsyandgoon) + Int32.Parse(lastyearlgandgoon);
            lastyearnew = Int32.Parse(lastyearghandnew) + Int32.Parse(lastyearjsyandnew) + Int32.Parse(lastyearlgandnew);
            lastyearall = lastyearsum.ToString();
            lastyearallgoon = lastyeargoon.ToString();
            lastyearallnew = lastyearnew.ToString();
        }
        public void countinvestalllastyear(string strWhere, string countYear)
        {
            string strcountstrgh = "", strcountstrjsy = "", strcountstrlg = "", strcountstrghandnew = "", strcountstrjsyandnew = "", strcountstrlgandnew = "", strcountstrghandgoon = "", strcountstrjsyandgoon = "", strcountstrlgandgoon = "";
            StringBuilder strcountgh = new StringBuilder();
            StringBuilder strcountjsy = new StringBuilder();
            StringBuilder strcountlg = new StringBuilder();
            StringBuilder strcountghandnew = new StringBuilder();
            StringBuilder strcountjsyandnew = new StringBuilder();
            StringBuilder strcountlgandnew = new StringBuilder();
            StringBuilder strcountghandgoon = new StringBuilder();
            StringBuilder strcountjsyandgoon = new StringBuilder();
            StringBuilder strcountlgandgoon = new StringBuilder();

            strcountgh.AppendFormat("select sum(project_totalinvestment) from {0} where (project_type='港航项目' and ", countYear);
            strcountjsy.AppendFormat("select sum(project_totalinvestment) from {0} where (project_type='集疏运项目' and ", countYear);
            strcountlg.AppendFormat("select sum(project_totalinvestment) from {0} where (project_type='临港产业项目' and ", countYear);
            strcountghandnew.AppendFormat("select sum(project_totalinvestment) from {0} where ((project_type='港航项目' and project_state='新开工') and ", countYear);
            strcountjsyandnew.AppendFormat("select sum(project_totalinvestment) from {0} where ((project_type='集疏运项目' and project_state='新开工') and ", countYear);
            strcountlgandnew.AppendFormat("select sum(project_totalinvestment) from {0} where ((project_type='临港产业项目' and project_state='新开工') and ", countYear);
            strcountghandgoon.AppendFormat("select sum(project_totalinvestment) from {0} where ((project_type='港航项目' and project_state='续建') and ", countYear);
            strcountjsyandgoon.AppendFormat("select sum(project_totalinvestment) from {0} where ((project_type='集疏运项目' and project_state='续建') and  ", countYear);
            strcountlgandgoon.AppendFormat("select sum(project_totalinvestment) from {0} where ((project_type='临港产业项目' and project_state='续建') and  ", countYear);

            if (strWhere.Trim() != "")
            {
                strcountgh.Append(strWhere);
                strcountstrgh = strcountgh.ToString();
                strcountjsy.Append(strWhere);
                strcountstrjsy = strcountjsy.ToString();
                strcountlg.Append(strWhere);
                strcountstrlg = strcountlg.ToString();
                strcountghandnew.Append(strWhere);
                strcountstrghandnew = strcountghandnew.ToString();
                strcountjsyandnew.Append(strWhere);
                strcountstrjsyandnew = strcountjsyandnew.ToString();
                strcountlgandnew.Append(strWhere);
                strcountstrlgandnew = strcountlgandnew.ToString();
                strcountghandgoon.Append(strWhere);
                strcountstrghandgoon = strcountghandgoon.ToString();
                strcountjsyandgoon.Append(strWhere);
                strcountstrjsyandgoon = strcountjsyandgoon.ToString();
                strcountlgandgoon.Append(strWhere);
                strcountstrlgandgoon = strcountlgandgoon.ToString();
            }

            lastyeargh1 = getCountValue(strcountstrgh);
            lastyearjsy1 = getCountValue(strcountstrjsy);
            lastyearlg1 = getCountValue(strcountstrlg);
            lastyearghandnew1 = getCountValue(strcountstrghandnew);
            lastyearjsyandnew1 = getCountValue(strcountstrjsyandnew);
            lastyearlgandnew1 = getCountValue(strcountstrlgandnew);
            lastyearghandgoon1 = getCountValue(strcountstrghandgoon);
            lastyearjsyandgoon1 = getCountValue(strcountstrjsyandgoon);
            lastyearlgandgoon1 = getCountValue(strcountstrlgandgoon);

            lastyearsum1 = double.Parse(lastyeargh1) + double.Parse(lastyearjsy1) + double.Parse(lastyearlg1);
            lastyeargoon1 = double.Parse(lastyearghandgoon1) + double.Parse(lastyearjsyandgoon1) + double.Parse(lastyearlgandgoon1);
            lastyearnew1 = double.Parse(lastyearghandnew1) + double.Parse(lastyearjsyandnew1) + double.Parse(lastyearlgandnew1);

            lastyearall1 = lastyearsum1.ToString();
            lastyearallgoon1 = lastyeargoon1.ToString();
            lastyearallnew1 = lastyearnew1.ToString();
        }
        public void countinvestplanalllastyear(string strWhere, string countYear)
        {
            string strcountstrgh = "", strcountstrjsy = "", strcountstrlg = "", strcountstrghandnew = "", strcountstrjsyandnew = "", strcountstrlgandnew = "", strcountstrghandgoon = "", strcountstrjsyandgoon = "", strcountstrlgandgoon = "";
            StringBuilder strcountgh = new StringBuilder();
            StringBuilder strcountjsy = new StringBuilder();
            StringBuilder strcountlg = new StringBuilder();
            StringBuilder strcountghandnew = new StringBuilder();
            StringBuilder strcountjsyandnew = new StringBuilder();
            StringBuilder strcountlgandnew = new StringBuilder();
            StringBuilder strcountghandgoon = new StringBuilder();
            StringBuilder strcountjsyandgoon = new StringBuilder();
            StringBuilder strcountlgandgoon = new StringBuilder();

            strcountgh.AppendFormat("select sum(investmentin2015) from {0} where (project_type='港航项目' and ", countYear);
            strcountjsy.AppendFormat("select sum(investmentin2015) from {0} where (project_type='集疏运项目' and ", countYear);
            strcountlg.AppendFormat("select sum(investmentin2015) from {0} where (project_type='临港产业项目' and ", countYear);
            strcountghandnew.AppendFormat("select sum(investmentin2015) from {0} where ((project_type='港航项目' and project_state='新开工') and ", countYear);
            strcountjsyandnew.AppendFormat("select sum(investmentin2015) from {0} where ((project_type='集疏运项目' and project_state='新开工') and ", countYear);
            strcountlgandnew.AppendFormat("select sum(investmentin2015) from {0} where ((project_type='临港产业项目' and project_state='新开工') and ", countYear);
            strcountghandgoon.AppendFormat("select sum(investmentin2015) from {0} where ((project_type='港航项目' and project_state='续建') and ", countYear);
            strcountjsyandgoon.AppendFormat("select sum(investmentin2015) from {0} where ((project_type='集疏运项目' and project_state='续建') and  ", countYear);
            strcountlgandgoon.AppendFormat("select sum(investmentin2015) from {0} where ((project_type='临港产业项目' and project_state='续建') and  ", countYear);

            if (strWhere.Trim() != "")
            {
                strcountgh.Append(strWhere);
                strcountstrgh = strcountgh.ToString();
                strcountjsy.Append(strWhere);
                strcountstrjsy = strcountjsy.ToString();
                strcountlg.Append(strWhere);
                strcountstrlg = strcountlg.ToString();
                strcountghandnew.Append(strWhere);
                strcountstrghandnew = strcountghandnew.ToString();
                strcountjsyandnew.Append(strWhere);
                strcountstrjsyandnew = strcountjsyandnew.ToString();
                strcountlgandnew.Append(strWhere);
                strcountstrlgandnew = strcountlgandnew.ToString();
                strcountghandgoon.Append(strWhere);
                strcountstrghandgoon = strcountghandgoon.ToString();
                strcountjsyandgoon.Append(strWhere);
                strcountstrjsyandgoon = strcountjsyandgoon.ToString();
                strcountlgandgoon.Append(strWhere);
                strcountstrlgandgoon = strcountlgandgoon.ToString();
            }

            lastyeargh2 = getCountValue(strcountstrgh);
            lastyearjsy2 = getCountValue(strcountstrjsy);
            lastyearlg2 = getCountValue(strcountstrlg);
            lastyearghandnew2 = getCountValue(strcountstrghandnew);
            lastyearjsyandnew2 = getCountValue(strcountstrjsyandnew);
            lastyearlgandnew2 = getCountValue(strcountstrlgandnew);
            lastyearghandgoon2 = getCountValue(strcountstrghandgoon);
            lastyearjsyandgoon2 = getCountValue(strcountstrjsyandgoon);
            lastyearlgandgoon2 = getCountValue(strcountstrlgandgoon);

            lastyearsum2 = double.Parse(lastyeargh2) + double.Parse(lastyearjsy2) + double.Parse(lastyearlg2);
            lastyeargoon2 = double.Parse(lastyearghandgoon2) + double.Parse(lastyearjsyandgoon2) + double.Parse(lastyearlgandgoon2);
            lastyearnew2 = double.Parse(lastyearghandnew2) + double.Parse(lastyearjsyandnew2) + double.Parse(lastyearlgandnew2);

            lastyearall2 = lastyearsum2.ToString();
            lastyearallgoon2 = lastyeargoon2.ToString();
            lastyearallnew2 = lastyearnew2.ToString();
        }


        protected string getValue(string strconn,int count)
        {
            string connString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(connString);
            SqlCommand commandgh = new SqlCommand(strconn, con);
            con.Open();
            try
            {
                SqlDataReader drgh = commandgh.ExecuteReader();
                if (drgh.Read())
                {
                    count = int.Parse(drgh[0].ToString());
                }
                else
                {
                    count = 0;
                }
                drgh.Close();
                drgh.Dispose();
            }
            catch (System.Data.SqlClient.SqlException e)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "u1", "alert('输入错误！')", true);
            }
            con.Close();
            return count.ToString();
        }
        protected string getCountValue(string strconn)
        {
            string count = "";
            string connString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(connString);
            SqlCommand commandgh = new SqlCommand(strconn, con);
            con.Open();
            object i = commandgh.ExecuteScalar();
            con.Close();
            count = i.ToString();
            if (count == "") return "0";
            else return count;
        }
        protected void btneSubmit_Click(object sender, EventArgs e)
        {
            StringBuilder strWhere = new StringBuilder();
            strWhere.AppendFormat("(");
            if (cb_allarea.Checked == true)
            {
                cb_Wuhan.Checked = true;
                cb_Ezhou.Checked = true;
                cb_Huanggan.Checked = true;
                cb_Xianning.Checked = true;
                cb_Xinzhou.Checked = true;
                cb_Hannan.Checked = true;
                cb_HGQ.Checked = true;
                cb_XGT.Checked = true;
                cb_Wugan.Checked = true;
                cb_Jiangxia.Checked = true;
            }
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

                strWhere.AppendFormat("project_area like '%{0}%'))", "visual2010");
                string st = strWhere.ToString();
                string databasetime = "projecttable";
                string databasetimelastyear = "project2014";
                countnumberall(st, databasetime);
                countinvestall(st, databasetime);
                countinvestplanall(st, databasetime);


                countnumberalllastyear(st, databasetimelastyear);
                countinvestalllastyear(st, databasetimelastyear);
                countinvestplanalllastyear(st, databasetimelastyear);

                ratiogh = ((double.Parse(evalall2) / double.Parse(lastyearall2)).ToString("P"));
                ratiojsy = ((double.Parse(evalgh2) / double.Parse(lastyeargh2)).ToString("P"));
                ratiolg = ((double.Parse(evaljsy2) / double.Parse(lastyearjsy2)).ToString("P"));
                ratioghandnew = ((double.Parse(evallg2) / double.Parse(lastyearlg2)).ToString("P"));
                ratiojsyandnew = ((double.Parse(evalallgoon2) / double.Parse(lastyearallgoon2)).ToString("P"));
                ratiolgandnew = ((double.Parse(evalghandgoon2) / double.Parse(lastyearghandgoon2)).ToString("P"));
                ratioghandgoon = ((double.Parse(evaljsyandgoon2) / double.Parse(lastyearjsyandgoon2)).ToString("P"));
                ratiojsyandgoon = ((double.Parse(evallgandgoon2) / double.Parse(lastyearlgandgoon2)).ToString("P"));
                ratiolgandgoon = ((double.Parse(evalallnew2) / double.Parse(lastyearallnew2)).ToString("P"));
                ratioall = ((double.Parse(evalghandnew2) / double.Parse(lastyearghandnew2)).ToString("P"));
                ratioallgoon = ((double.Parse(evaljsyandnew2) / double.Parse(lastyearjsyandnew2)).ToString("P"));
                ratioallnew = ((double.Parse(evallgandnew2) / double.Parse(lastyearlgandnew2)).ToString("P"));
        }
        protected void btneBack_Click(object sender, EventArgs e)
        {

        }

        protected void cb_noarea_CheckedChanged(object sender, EventArgs e)
        {
            cb_Wuhan.Checked = true;
            cb_Ezhou.Checked = true;
            cb_Huanggan.Checked = true;
            cb_Xianning.Checked = true;
            cb_Xinzhou.Checked = true;
            cb_Hannan.Checked = true;
            cb_HGQ.Checked = true;
            cb_XGT.Checked = true;
            cb_Wugan.Checked = true;
            cb_Jiangxia.Checked = true;
        }
    }
}