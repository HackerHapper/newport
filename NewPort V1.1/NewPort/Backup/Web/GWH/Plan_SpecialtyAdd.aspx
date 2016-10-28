<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage_GWH.master" AutoEventWireup="true" CodeBehind="Plan_SpecialtyAdd.aspx.cs" Inherits="Maticsoft.Web.GWH.Plan_SpecialtyAdd" %>
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
    <div>
 <h3>添加到专项资金支持</h3>
</div>
 <table style="width: 200%;" cellpadding="2" cellspacing="1" class="border">
 <tr><td class="style4">     
<table style='BORDER-COLLAPSE: collapse; width: 850px;' borderColor='black' 
         border='1' bgcolor=#dddddd align="center">

	<tr>
	<td height="25" align="right" class="style1">项目编号：</td>
    <td height="25" align="left" class="style2">&nbsp&nbsp<asp:Label id="lbl_enumber" runat="server"></asp:Label></td>
    
	<td height="25" align="right" class="style1">项目名称：</td>
	<td height="25" align="left" class="style5">&nbsp&nbsp<asp:Label id="lbl_ename" runat="server"></asp:Label>
    </td>        
    </tr>

	<tr>
    <td height="25" align="right" class="style3">业主单位：</td>
	<td height="25" align="left" class="style2">&nbsp&nbsp<asp:Label id="lbl_eowner" runat="server"></asp:Label>    
    <td height="25" align="right" class="style3">计划类别：</td>
    <td height="25" align="left" class="style5">&nbsp&nbsp
    <asp:Label id="lbl_PlanType" runat="server"></asp:Label>
    </td>
    </td>
    </tr>

	<tr>
	<td height="25" align="right" class="style1">项目地点：</td>
	<td height="25" align="left" class="style2">&nbsp&nbsp<asp:Label id="lbl_eaddress" runat="server"></asp:Label>
    </td>
	<td height="25" align="right" class="style3">总投资：</td>
	<td height="25" align="left" class="style5">&nbsp&nbsp<asp:Label id="lbl_emoney" runat="server"></asp:Label>
    </td>
    </tr>
</table>
</br>
 <table style="width: 200%;" cellpadding="2" cellspacing="1" class="border">
 <tr><td class="style4">     
<table style='BORDER-COLLAPSE: collapse; width: 850px;' borderColor='black' 
         border='1' bgcolor=#dddddd align="center">
    <tr>
	<td height="15" align="right" class="style6">支持年度：</td>
    <td height="15" align="left" class="style2">&nbsp&nbsp<asp:DropDownList 
            ID="DropDownList1" runat="server" Height="23px" Width="67px" 
            Font-Size="Small">
        <asp:ListItem>2016</asp:ListItem>
        <asp:ListItem>2017</asp:ListItem>
        <asp:ListItem>2018</asp:ListItem>
        <asp:ListItem>2019</asp:ListItem>
        <asp:ListItem>2020</asp:ListItem>
        <asp:ListItem>2021</asp:ListItem>
        <asp:ListItem>2022</asp:ListItem>
        <asp:ListItem>2023</asp:ListItem>
        <asp:ListItem>2024</asp:ListItem>
        <asp:ListItem>2025</asp:ListItem>
        </asp:DropDownList>&nbsp&nbsp 年
    </td>
    <td height="15" align="right" class="style7">支持金额：</td>
	<td height="15" align="left" class="style5">&nbsp&nbsp<asp:TextBox ID="txtbox_money" runat="server" Height="12px"></asp:TextBox>
    </td>        
    </tr>

	<tr>
    <td height="15" align="right" class="style6">支持方式：</td>
	<td height="15" align="left" class="style2">&nbsp&nbsp<asp:TextBox ID="txtbox_method" runat="server" Height="12px"></asp:TextBox>
    <td height="15" align="right" class="style7">项目目标：</td>
    <td height="15" align="left" class="style5">&nbsp&nbsp<asp:TextBox ID="txtbox_aim" runat="server" Height="12px"></asp:TextBox>
    </td>
    </tr>

	<tr>
    <td height="21" align="right" class="style6">支持描述：</td>
	<td height="21" align="left" class="style2">&nbsp&nbsp<asp:TextBox ID="txtbox_des" runat="server" Height="12px"></asp:TextBox>
	<td height="21" align="right" class="style6">备注：</td>
	<td height="21" align="left" class="style2">&nbsp&nbsp<asp:TextBox ID="txtbox_others" runat="server" Height="12px"></asp:TextBox>
    </td>
    </tr>

    <tr>
	<td height="21" align="right" class="style6"></td>
	<td height="21" align="left"class="style2"> 
    <asp:Button  class="btn btn-success" ID="Button1" runat="server" Text="确定" onclick="btneSubmit_Click" />
        <asp:Button  class="btn btn-success" ID="Button2" runat="server" Text="返回" onclick="btneBack_Click" />
        </td>
    </tr>
</table>
</table>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceLeft" runat="server">
<div id="sidebar"><a href="#" class="visible-phone"><i class="icon icon-home"></i> Dashboard</a>
  <ul>
    <li><a href="Default_GWH.aspx" onclick="javascript:addClass(this.parentNode,'active')"><i class="icon icon-inbox"></i> <span>系统首页</span></a></li>
    <li><a href="Plan_Check.aspx" onclick="javascript:addClass(this.parentNode,'active')"><i class="icon icon-inbox"></i> <span>项目审核</span></a></li>
    <li class="submenu"> <a href=""><i class="icon icon-th-list"></i> <span>项目管理</span> <span class="label label-important"></span></a>
      <ul>
        <li><a href="Plan_Management.aspx">项目查询及编辑</a></li>
        <li  class="active"><a href="Plan_Specialty.aspx">专项资金支持</a></li>
        <li><a href="MonthlyFeedback.aspx">月度反馈管理</a></li>
      </ul>
    </li>
    <li class="submenu"> <a href="#"><i class="icon icon-th-list"></i> <span>统计分析</span> <span class="label label-important"></span></a>
      <ul>
        <li ><a href="InvestPlan.aspx">投资计划统计</a></li>
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
 <div id="breadcrumb"> <a href="Default_GWH.aspx" title="回到主页" class="tip-bottom"><i class="icon-home"></i> 主页</a> <a href="">项目管理</a><a href="Plan_Specialty.aspx">专项资金支持</a> <a href="Plan_SpecialtyAdd.aspx" class="current">添加专项资金支持项目</a> </div> 
  </div>
</asp:Content>