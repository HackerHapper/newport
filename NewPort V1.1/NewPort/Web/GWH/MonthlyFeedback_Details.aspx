<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage_GWH.master" AutoEventWireup="true" CodeBehind="MonthlyFeedback_Details.aspx.cs" Inherits="Maticsoft.Web.GWH.MonthlyFeedback_Details" %>
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
        .style_button
        {
            text-align:right;}
        .style4
        {
            color: Black;
            font-weight: bold;
            width: 145px;
        }
        .style5
        {
            color: Black;
            font-weight: bold;
            width: 152px;
            height: 30px;
        }
        .style10
        {
            color: Black;
            font-weight: bold;
            width: 121px;
            height: 30px;
        }
        .style11
        {
            color: Blue;
            width: 200px;
            font-weight: none;
            height: 30px;
        }
        .style12
        {
            color: Blue;
            font-weight: none;
            height: 30px;
        }
        .style13
        {
            color: Black;
            font-weight: bold;
            width: 121px;
            height: 39px;
        }
        .style14
        {
            color: Blue;
            width: 200px;
            font-weight: none;
            height: 39px;
        }
        .style15
        {
            color: Black;
            font-weight: bold;
            width: 152px;
            height: 39px;
        }
        .style16
        {
            color: Blue;
            font-weight: none;
            height: 39px;
        }
         .row
        {
            position:relative;
            margin-left:90px;
            top: 6px;
            left: 0px;
            width: 200px;
            height: 263px;
        }
        .row2
        {
            position:absolute;
            margin-left:90px;
            margin-top:0px;
            top: 141px;
            left: 215px;
            height: 420px;
            width: 375px;
        }
        .fontstyle
        {
            color: #0000FF; 
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MiddleContent2" runat="server">
    <div>
 <h3>项目详情信息</h3>
</div>  
<div class="row">
  <div class="eightcol last">

    <!-- Begin Form -->


           <div><label class="fontstyle">项目编号：</label><asp:Label ID="lbl_number" runat="server"></asp:Label></div>
           <div><label class="fontstyle">本次反馈时间：</label><asp:Label id="lbl_time" runat="server"></asp:Label></div>
          <div><label class="fontstyle">本月完成投资：</label><asp:Label id="lbl_completed"  runat="server"></asp:Label></div>
          <div><label class="fontstyle">本月完成工程形象进度：</label><asp:Label id="lbl_process"  runat="server"></asp:Label></div>      
      <div>
          <asp:Button ID="btnSubmit" runat="server" Text="返回" onclick="btnSubmit_Click" 
              class="btn btn-success" Width="60px"/>
        
      </div>


  </div>

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
        <li class="active"><a href="MonthlyFeedback.aspx">月度反馈管理</a></li>
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
    <div id="breadcrumb"> <a href="Default_GWH.aspx" title="回到主页" class="tip-bottom"><i class="icon-home"></i> 主页</a> <a href="">项目管理</a><a href="MonthlyFeedback.aspx">月度反馈管理</a><a href="MonthlyFeedback_Details.aspx" class="current">月度反馈详情</a></div>
  </div>
</asp:Content>