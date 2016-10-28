<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage_GWH.master" AutoEventWireup="true" CodeBehind="Notice_Details.aspx.cs" Inherits="Maticsoft.Web.GWH.Notice_Details" %>
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
        .style4
        {
            color: Black;
            font-weight: bold;
            width: 1051px;
            height: 246px;
        }
        .style13
        {
            color: Black;
            font-weight: bold;
            width: 827px;
            height: 35px;
        }
        .style14
        {
            color: Blue;
            font-weight: none;
            width: 992px;
            height: 35px;
        }
        .style15
        {
            color: Black;
            font-weight: bold;
            width: 1443px;
            height: 35px;
        }
        .style16
        {
            color: Blue;
            font-weight: none;
            width: 3411px;
            height: 35px;
        }
        .row
        {
            position:absolute;
            margin-left:10px;
            margin-top:-80px;
            top: 2px;
            left: 0px;
            width: 560px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MiddleContent" runat="server">

<div class="row">
 <h3>通知信息详情</h3>
	<tr>
	<td align="right" class="style13">通知编号：</td>
    <td align="left" class="style14">&nbsp&nbsp<asp:Label id="lbl_number" runat="server"></asp:Label></td>
    </tr>
    </br>
    <tr>
    <td align="right" class="style15">通知<br />发布时间：</td>
	<td align="left" class="style16">&nbsp&nbsp<asp:Label id="lbl_time" runat="server"></asp:Label></td>
    </tr>
    </br>
	<tr>
	<td align="right" class="style13">通知主题：</td>
	<td align="left" class="style14">&nbsp&nbsp<asp:Label id="lbl_completed" runat="server"></asp:Label></td>
    </tr>
    </br>
    <tr>
	<td align="right" class="style15">通知内容：</td>
	<td align="left" class="style16">&nbsp&nbsp<asp:Label id="lbl_process" runat="server"></asp:Label></td>
    </tr>
    </br>
    <tr>
	<td align="right" class="style13">附件下载：</td>
	<td align="left" class="style14">&nbsp&nbsp <asp:Button ID="btnDownLoad" 
        runat="server"  Text="下载" Height="26px" Width="54px" 
        onclick="btnDownLoad_Click" />
    </td>
    </tr>
    </br>
    <tr>
	<td align="right" class="style13"></td>
    <td align="left"class="style14"> 
        <asp:Button ID="btnBack" runat="server"  class="btn btn-success"  Text="返回" onclick="btnBack_Click" />
        </td>
    </tr>
</div>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceLeft" runat="server">
<div id="sidebar"><a href="#" class="visible-phone"><i class="icon icon-home"></i> Dashboard</a>
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
        <li ><a href="InvestPlan.aspx">投资计划统计</a></li>
        <li><a href="InvestPlanTable.aspx">投资完成情况统计</a></li>
      </ul>
    </li>
    <li class="submenu"> <a href="#"><i class="icon icon-th-list"></i> <span>通知公告</span> <span class="label label-important"></span></a>
      <ul>
        <li class="active"><a href="Notice.aspx">通知信息</a></li>
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
    <div id="breadcrumb"> <a href="Default_GWH.aspx" title="回到主页" class="tip-bottom"><i class="icon-home"></i> 主页</a> <a href="">项目管理</a><a href="">通知管理</a><a href="Notice.aspx">通知信息</a><a href="Notice_Details.aspx" class="current">通知详情</a></div>
  </div>
</asp:Content>