<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage_GWH.master" AutoEventWireup="true" CodeBehind="Default_GWH.aspx.cs" Inherits="Maticsoft.Web.Default_GWH" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceLeft" runat="server">
<div id="sidebar"><a href="#" class="visible-phone"><i class="icon icon-home"></i> Dashboard</a>
  <ul>
    <li class="active"><a href="Default_GWH.aspx" onclick="javascript:addClass(this.parentNode,'active')"><i class="icon icon-inbox"></i> <span>系统首页</span></a></li>
     
      <li class="submenu"> <a href=""><i class="icon icon-th-list"></i> <span>计划项目审核</span> <span class="label label-important"></span></a>
      <ul>
        <li><a href="pro_Check.aspx" onclick="javascript:addClass(this.parentNode,'active')"><i class="icon icon-inbox"></i> <span>新入库项目审核</span></a></li>
        <li><a href="plan_Check.aspx" onclick="javascript:addClass(this.parentNode,'active')"><i class="icon icon-inbox"></i> <span>计划审核</span></a></li>
        <li><a href="plan_List.aspx" onclick="javascript:addClass(this.parentNode,'active')"><i class="icon icon-inbox"></i> <span>计划查看</span></a></li>
      </ul>
  
       <li class="submenu"> <a href=""><i class="icon icon-th-list"></i> <span>项目管理</span> <span class="label label-important"></span></a>
      <ul>
        <li><a href="Plan_Management.aspx">项目查询及编辑</a></li>
        <li><a href="Plan_Specialty.aspx">专项资金支持</a></li>
        <li><a href="MonthlyFeedback.aspx">月度反馈管理</a></li>
      </ul>
    </li>
    <li class="submenu"> <a href="#"><i class="icon icon-th-list"></i> <span>统计分析</span> <span class="label label-important"></span></a>
      <ul>
        <li><a href="InvestPlan.aspx">投资计划统计</a></li>
        <li><a href="InvestPlanTable.aspx">投资完成情况统计</a></li>
      </ul>
    </li>
    <li class="submenu"> <a href="#"><i class="icon icon-th-list"></i> <span>通知公告</span> <span class="label label-important"></span></a>
      <ul>
        <li><a href="Notice.aspx">通知信息</a></li>
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
    <div id="breadcrumb"> <a href="Default_GWH.aspx" title="回到主页" class="tip-bottom"><i class="current"></i> 主页</a>
  </div>
</asp:Content>