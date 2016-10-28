<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage_GWH.master" AutoEventWireup="true" CodeBehind="Plan_Management_Details.aspx.cs" Inherits="Maticsoft.Web.GWH.Plan_Management_Details" %>
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
            width: 200px;
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
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MiddleContent2" runat="server">
    <div>
 <h3>项目详情信息</h3>
</div>
 <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
 <tr><td class="style4">     
<table width="100%" style='BORDER-COLLAPSE: collapse;' borderColor='black' 
         border='1' bgcolor=#dddddd align="center">

	<tr>
	<td height="25" align="right" class="style1">项目编号：</td>
    <td height="25" align="left" class="style2">&nbsp&nbsp<asp:Label id="lbl_mnumber" runat="server"></asp:Label></td>
    <td height="25" align="right" class="style3">计划类别：</td>
    <td height="25" width="*" align="left" class="style_content">&nbsp&nbsp<asp:Label id="lbl_mtype" runat="server"></asp:Label></td>
    </tr>

	<tr>
	<td height="25" align="right" class="style1">项目名称：</td>
	<td height="25" align="left" class="style2">&nbsp&nbsp<asp:Label id="lbl_mname" runat="server"></asp:Label></td>
    <td height="25" align="right" class="style3">业主单位：</td>
	<td height="25" width="*" align="left" class="style_content">&nbsp&nbsp<asp:Label id="lbl_mowner" runat="server"></asp:Label></td>
    </tr>

	<tr>
	<td height="25" align="right" class="style1">项目地点：</td>
	<td height="25" align="left" class="style2">&nbsp&nbsp<asp:Label id="lbl_maddress" runat="server"></asp:Label></td>
	<td height="25" align="right" class="style3">设计能力：</td>
	<td height="25" width="*" align="left" class="style_content">&nbsp&nbsp<asp:Label id="lbl_mapc" runat="server"></asp:Label></td>
    </tr>

	<tr>
	<td height="25" align="right" class="style1">岸线：</td>
	<td height="25" align="left" class="style2">&nbsp&nbsp<asp:Label id="lbl_mdis" runat="server"></asp:Label></td>    
	<td height="25" align="right" class="style3">总投资：</td>
	<td height="25" width="*" align="left" class="style_content">&nbsp&nbsp<asp:Label id="lbl_mmoney" runat="server"></asp:Label></td>
    </tr>
	<tr>
	<td height="25" align="right" class="style1">建设起止年限：</td>
	<td height="25" align="left" class="style2">&nbsp&nbsp<asp:Label id="lbl_mstartyear" runat="server"></asp:Label>&nbsp&nbsp 至&nbsp&nbsp<asp:Label id="lbl_moveryear" runat="server"></asp:Label></td>    
	<td height="25" align="right" class="style1">建设内容：</td>
    <td height="25" align="left" class="style_content">&nbsp&nbsp<asp:Label ID="mTextContent" runat="server" Text=""></asp:Label>
    </td>
    </tr>
	<tr b>
	<td height="25" align="right" class="style1">前期工作进展情况：</td>
	<td height="25" align="left" class="style2">&nbsp&nbsp
        <asp:Label ID="mTextPre" runat="server" Text=""></asp:Label>    
	<td height="25" align="right" class="style1">备注：</td>
	<td height="25" align="left" class="style_content">&nbsp&nbsp
        <asp:Label ID="mTextOthers" runat="server" Text=""></asp:Label>  
    </td>
    </tr>
    <tr>
	<td height="25" align="right" class="style1"></td>
	<td height="25" align="left"class="style2"> 
    <asp:Button  class="btn btn-success" ID="btneSubmit" runat="server" Text="返回" onclick="btneSubmit_Click" />&nbsp&nbsp
        </td>
    </tr>
</table>
</td>
</tr>
</table>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceLeft" runat="server">
<div id="sidebar"><a href="#" class="visible-phone"><i class="icon icon-home"></i> Dashboard</a>
  <ul>
    <li><a href="Default_GWH.aspx" onclick="javascript:addClass(this.parentNode,'active')"><i class="icon icon-inbox"></i> <span>系统首页</span></a></li>
    <li><a href="Plan_Check.aspx" onclick="javascript:addClass(this.parentNode,'active')"><i class="icon icon-inbox"></i> <span>项目审核</span></a></li>
    <li class="submenu"> <a href=""><i class="icon icon-th-list"></i> <span>项目管理</span> <span class="label label-important"></span></a>
      <ul>
        <li  class="active"><a href="Plan_Management.aspx">项目查询及编辑</a></li>
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
     <div id="breadcrumb"> <a href="Default_GWH.aspx" title="回到主页" class="tip-bottom"><i class="icon-home"></i> 主页</a> <a href="">项目管理</a><a href="Plan_Management.aspx">项目查询及编辑</a> <a href="Plan_Management_Details.aspx" class="current">项目详情</a> </div>
       </div>
</asp:Content>
