using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Maticsoft.Web.XGB
{
    public class deptNumber
    {
        public static string findNumber(string dept)
        {
           string number="";
           if (dept == "管委会") number = "00";
           else if (dept == "江夏区") number = "01";
           else if (dept == "黄陂区") number = "02";
           else if (dept == "汉南区") number = "03";
           else if (dept == "咸宁市") number = "04";
           else if (dept == "黄冈市") number = "05";
           else if (dept == "鄂州市") number = "06";
           else if (dept == "新港投") number = "80";
           else if (dept == "武港集团") number = "81";
           else  number = "99";//其他单位
           return number; 
        }
        public static string findDept(string number)
        {
            string dept = "";
            if (number == "00") dept = "管委会";
            else if (number == "01") dept = "江夏区";
            else if (number == "02") dept = "黄陂区";
            else if (number == "03") dept = "汉南区";
            else if (number == "04") dept = "咸宁市";
            else if (number == "05") dept = "黄冈市";
            else if (number == "06") dept = "鄂州市";
            else if (number == "80") dept = "新港投";
            else if (number == "81") dept = "武港集团";
            else if (number == "99") dept = "其他单位";
            return dept;
        }

    }
}