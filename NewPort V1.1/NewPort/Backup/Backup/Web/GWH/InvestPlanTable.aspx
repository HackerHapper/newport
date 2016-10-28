<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage_GWH.master" AutoEventWireup="true" CodeBehind="InvestPlanTable.aspx.cs" Inherits="Maticsoft.Web.GWH.InvestPlanTable" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
<style type="text/css">
        .style_title
        {
            color:Black;font-weight:bold;
        }
        .style_content
        {
            color:Blue;font-weight:none;
        }
        .style1
        {
            color: Black;
            font-weight: bold;
            width: 121px;
        }
        .style2
        {
        color: Blue;
        width: 307px;
        font-weight: none;
    }
        .style3
        {
            color: Black;
            font-weight: bold;
            width: 117px;
        }
        .style4
        {
            color: Black;
            font-weight: bold;
            width: 145px;
        }
    .style5
    {
        color: Blue;
        width: 393px;
        font-weight: none;
    }
    .style6
    {
        color: Black;
        font-weight: bold;
        width: 130px;
    }
    .style7
    {
        color: Black;
        font-weight: bold;
        width: 132px;
    }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MiddleContent2" runat="server">
<script>

    function cliarea() {
        var collid = document.getElementById("<%=cb_allarea.ClientID%>");
        var collid1 = document.getElementById("<%=cb_Wuhan.ClientID%>");
        var collid2 = document.getElementById("<%=cb_Ezhou.ClientID%>");
        var collid3 = document.getElementById("<%=cb_Huanggan.ClientID%>");
        var collid4 = document.getElementById("<%=cb_Xianning.ClientID%>");
        var collid5 = document.getElementById("<%=cb_Xinzhou.ClientID%>");
        var collid6 = document.getElementById("<%=cb_Hannan.ClientID%>");
        var collid7 = document.getElementById("<%=cb_HGQ.ClientID%>");
        var collid8 = document.getElementById("<%=cb_XGT.ClientID%>");
        var collid9 = document.getElementById("<%=cb_Wugan.ClientID%>");
        var collid10 = document.getElementById("<%=cb_Jiangxia.ClientID%>");

        if (collid.checked) {
            collid1.checked = true;
            collid2.checked = true;
            collid3.checked = true;
            collid4.checked = true;
            collid5.checked = true;
            collid6.checked = true;
            collid7.checked = true;
            collid8.checked = true;
            collid9.checked = true;
            collid10.checked = true;
        }
        else {
            collid1.checked = false;
            collid2.checked = false;
            collid3.checked = false;
            collid4.checked = false;
            collid5.checked = false;
            collid6.checked = false;
            collid7.checked = false;
            collid8.checked = false;
            collid9.checked = false;
            collid10.checked = false;
        }
        if (collid1.checked == false || collid2.checked == false || collid3.checked == false || collid4.checked == false || collid5.checked == false || collid6.checked == false || collid7.checked == false || collid8.checked == false || collid9.checked == false || collid10.checked == false) {
            collid.checked = false;
        }
    }
    function cliareaNoAll() {
        var collid = document.getElementById("<%=cb_allarea.ClientID%>");
        collid.checked = false;
    }
</script>
    <div>
 <h3>投资计划统计</h3>
</div>
 <table style="width: 200%;" cellpadding="2" cellspacing="1" class="border">
 <tr><td class="style4">     
<table style='BORDER-COLLAPSE: collapse; width: 850px;' borderColor='black' 
         border='0' bgcolor=#dddddd align="center">

	<tr>
	<td height="25" align="right" class="style1">选择统计时间段：</td>
    <td>
        <asp:DropDownList ID="DDL_Year1" runat="server" Width="70px" Height="24px">
            <asp:ListItem Value="2010"></asp:ListItem>
            <asp:ListItem Value="2011"></asp:ListItem>
            <asp:ListItem Value="2012"></asp:ListItem>
            <asp:ListItem Value="2013"></asp:ListItem>
            <asp:ListItem Value="2014"></asp:ListItem>
            <asp:ListItem Value="2015"></asp:ListItem>
            <asp:ListItem Value="2016"></asp:ListItem>
        </asp:DropDownList>&nbsp 年&nbsp  
    </td>        
    </tr>

    <tr>
    <td height="25" align="right" class="style3">参与统计的项目区域：</td>
	<td height="25" align="left" class="style2">
    <asp:CheckBox ID="cb_allarea" runat="server"  onclick="cliarea()"/>全选
    <asp:CheckBox ID="cb_Wuhan" runat="server" onclick="cliareaNoAll()"/>武汉
    <asp:CheckBox ID="cb_Ezhou" runat="server" onclick="cliareaNoAll()"/>鄂州
    <asp:CheckBox ID="cb_Huanggan" runat="server" onclick="cliareaNoAll()"/>黄冈
    <asp:CheckBox ID="cb_Xianning" runat="server" onclick="cliareaNoAll()"/>咸宁
    <asp:CheckBox ID="cb_Xinzhou" runat="server" onclick="cliareaNoAll()"/>新洲
    <asp:CheckBox ID="cb_Hannan" runat="server" onclick="cliareaNoAll()"/>汉南
    <asp:CheckBox ID="cb_HGQ" runat="server" onclick="cliareaNoAll()"/>化工区
    <asp:CheckBox ID="cb_XGT" runat="server" onclick="cliareaNoAll()"/>新港投
    <asp:CheckBox ID="cb_Wugan" runat="server" onclick="cliareaNoAll()"/>武港
    <asp:CheckBox ID="cb_Jiangxia" runat="server" onclick="cliareaNoAll()"/>江夏
    </td>    
    </tr>

    
    <tr>
	<td height="21" align="right" class="style6"></td>
	<td height="21" align="left"class="style2"> 
    <asp:Button class="btn btn-success" ID="Button1" runat="server" Text="生成统计报表" onclick="btneSubmit_Click" />
        <asp:Button class="btn btn-success" ID="Button2" runat="server" Text="返回" onclick="btneBack_Click" />
        </td>
    </tr>    
</table>
<table style='BORDER-COLLAPSE: collapse; borderColor='black' border='1' bgcolor=#dddddd align="center" height="400px" width="300px">
                <tr align="center">
                    <td></td>
                    <td>2014年</td>
                    <td></td>
                    <td></td>
                    <td></td>
                    <td>2013年</td>
                    <td></td>
                </tr>
                <tr align="center">
                    <td></td>
                    <td>项目个数</td>
                    <td>总投资</td>
                    <td>计划投资</td>
                    <td>与2013年实际完成比增长%</td>
                    <td>项目个数</td>
                    <td>完成投资</td>
                </tr>

                <tr align="center">
                    <td>合 计</td>
                    <td><% = evalall%></td>
                    <td><% = evalall1%></td>
                    <td><% = evalall2%></td>
                    <td><% = ratiogh%></td>
                    <td><% = lastyearall%></td>
                    <td><% = lastyearall2%></td>
                </tr>

                <tr align="center">
                    <td>港航</td>
                    <td><% = evalgh%></td>
                    <td><% = evalgh1%></td>
                    <td><% = evalgh2%></td>
                    <td><% = ratiojsy%></td>
                    <td><% = lastyeargh%></td>
                    <td><% = lastyeargh2%></td>
                </tr>

                <tr align="center">
                    <td>集疏运</td>
                    <td><% = evaljsy%></td>
                    <td><% = evaljsy1%></td>
                    <td><% = evaljsy2%></td>
                    <td><% = ratiolg%></td>
                    <td><% = lastyearjsy%></td>
                    <td><% = lastyearjsy2%></td>
                </tr>

                <tr align="center">
                    <td>物流园</td>
                    <td><% = evallg%></td>
                    <td><% = evallg1%></td>
                    <td><% = evallg2%></td>
                    <td><% = ratioghandnew%></td>
                    <td><% = lastyearlg%></td>
                    <td><% = lastyearlg2%></td>
                </tr>

                <tr align="center">
                    <td>一、续建项目</td>
                    <td><% = evalallgoon%></td>
                    <td><% = evalallgoon1%></td>
                    <td><% = evalallgoon2%></td>
                    <td><% = ratiojsyandnew%></td>
                    <td><% = lastyearallgoon%></td>
                    <td><% = lastyearallgoon2%></td>
                </tr>

                <tr align="center">
                    <td>港航</td>
                    <td><% = evalghandgoon%></td>
                    <td><% = evalghandgoon1%></td>
                    <td><% = evalghandgoon2%></td>
                    <td><% = ratiolgandnew%></td>
                    <td><% = lastyearghandgoon%></td>
                    <td><% = lastyearghandgoon2%></td>
                </tr>

                <tr align="center">
                    <td>集疏运</td>
                    <td><% = evaljsyandgoon%></td>
                    <td><% = evaljsyandgoon1%></td>
                    <td><% = evaljsyandgoon2%></td>
                    <td><% = ratioghandgoon%></td>
                    <td><% = lastyearjsyandgoon%></td>
                    <td><% = lastyearjsyandgoon2%></td>
                </tr>

                <tr align="center">
                    <td>物流园</td>
                    <td><% = evallgandgoon%></td>
                    <td><% = evallgandgoon1%></td>
                    <td><% = evallgandgoon2%></td>
                    <td><% = ratiojsyandgoon%></td>
                    <td><% = lastyearlgandgoon%></td>
                    <td><% = lastyearlgandgoon2%></td>
                </tr>

                <tr align="center">
                    <td>二、新开工项目</td>
                    <td><% = evalallnew%></td>
                    <td><% = evalallnew1%></td>
                    <td><% = evalallnew2%></td>
                    <td><% = ratiolgandgoon%></td>
                    <td><% = lastyearallnew%></td>
                    <td><% = lastyearallnew2%></td>
                </tr>

                <tr align="center">
                    <td>港航</td>
                    <td><% = evalghandnew%></td>
                    <td><% = evalghandnew1%></td>
                    <td><% = evalghandnew2%></td>
                    <td><% = ratioall%></td>
                    <td><% = lastyearghandnew%></td>
                    <td><% = lastyearghandnew2%></td>
                </tr>

                <tr align="center">
                    <td>集疏运</td>
                    <td><% = evaljsyandnew%></td>
                    <td><% = evaljsyandnew1%></td>
                    <td><% = evaljsyandnew2%></td>
                    <td><% = ratioallgoon%></td>
                    <td><% = lastyearjsyandnew%></td>
                    <td><% = lastyearjsyandnew2%></td>
                </tr>

                <tr align="center">
                    <td>物流园</td>
                    <td><% = evallgandnew%></td>
                    <td><% = evallgandnew1%></td>
                    <td><% = evallgandnew2%></td>
                    <td><% = ratioallnew%></td>
                    <td><% = lastyearlgandnew%></td>
                    <td><% = lastyearlgandnew2%></td>
                </tr>

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceLeft" runat="server">
<div id="sidebar"><a href="#" class="visible-phone"><i class="icon icon-home"></i> 武汉新港计划项目动态管理系统</a>
  <ul>
    <li><a href="Default_GWH.aspx" onclick="javascript:addClass(this.parentNode,'active')"><i class="icon icon-inbox"></i> <span>系统首页</span></a></li>
    <li><a href="Plan_Check.aspx" onclick="javascript:addClass(this.parentNode,'active')"><i class="icon icon-inbox"></i> <span>项目审核</span></a></li>
    <li class="submenu"> <a href=""><i class="icon icon-th-list"></i> <span>项目管理</span> <span class="label label-important"></span></a>
      <ul>
        <li><a href="Plan_Management.aspx">项目查询及编辑</a></li>
        <li><a href="Plan_Specialty.aspx">专项资金支持</a></li>
        <li><a href="MonthlyFeedback.aspx">月度反馈管理</a></li>
      </ul>
    </li>
    <li class="submenu"> <a href="#"><i class="icon icon-th-list"></i> <span>统计分析</span> <span class="label label-important"></span></a>
      <ul>
        <li class="active"><a href="InvestPlan.aspx">投资计划统计</a></li>
        <li><a href="InvestPlanTable.aspx">投资完成情况统计</a></li>
      </ul>
    </li>
    <li class="submenu"> <a href="#"><i class="icon icon-th-list"></i> <span>通知公告</span> <span class="label label-important"></span></a>
      <ul>
        <li ><a href="Notice.aspx">通知信息</a></li>
        <li><a href="Notice_Add.aspx">发布通知</a></li>
      </ul>
    </li>
    <li class="submenu"> <a href="#"><i class="icon icon-th-list"></i> <span>系统维护</span> <span class="label label-important"></span></a>
      <ul>
        <li ><a href="User_Management.aspx">用户管理</a></li>
      </ul>
    </li>
  </ul>
</div>
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceTop" runat="server">
  <div id="content-header">
    <div id="breadcrumb"> <a href="Default_GWH.aspx" title="回到主页" class="tip-bottom"><i class="icon-home"></i> 主页</a> <a href="">统计分析</a> <a href="InvestPlan.aspx" class="current">投资计划统计</a></div>
  </div>
</asp:Content>