<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage_GWH.master" AutoEventWireup="true" CodeBehind="UserAdd.aspx.cs" Inherits="Maticsoft.Web.GWH.UserAdd" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="MiddleContent" runat="server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="MiddleContent2" runat="server">

<div>
 <h4>添加账户信息</h4>
</div>
<div>
    <tr>
	<td align="right" class="style1">账号：</td>
    <td align="left" class="style1">&nbsp&nbsp<asp:TextBox id="txtAccount" runat="server" Height="15px" Width="120px"></asp:TextBox></td>            
    </tr>
    <tr>
	<td align="right" class="style1">账户名称：</td>
    <td align="left" class="style1">&nbsp&nbsp<asp:TextBox id="txtName" runat="server" Height="15px" Width="120px"></asp:TextBox></td>            
    </tr>
    <tr>
	<td align="right" class="style1">所属单位：</td>           
        <asp:DropDownList ID="ddlDepart" runat="server" Height="27px" Width="133px">
            <asp:ListItem>新港办用户</asp:ListItem>
            <asp:ListItem>管委会用户</asp:ListItem>
    </asp:DropDownList>
    </tr>
    <tr>
	<td align="right" class="style1">责任人：</td>
    <td align="left" class="style1">&nbsp&nbsp<asp:TextBox id="txtPerson" runat="server" Height="15px" Width="120px"></asp:TextBox></td>            
    </tr>
    <tr>
	<td align="right" class="style1">联系方式：</td>
    <td align="left" class="style1">&nbsp&nbsp<asp:TextBox id="txtConnect" runat="server" Height="15px" Width="120px"></asp:TextBox></td>            
    </tr>
    <tr>
	<td align="right" class="style1">密码：</td>
    <td align="left" class="style1">&nbsp&nbsp<asp:TextBox id="txtPwd" runat="server" Height="15px" Width="120px"></asp:TextBox></td>            
    </tr>    
    <tr>
	<td align="right" class="style1"><asp:Button  class="btn btn-success" ID="btneSubmit" runat="server" Text="确定" onclick="btneSubmit_Click" /></td>       
    &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp	<td align="right" class="style1">
    <asp:Button  class="btn btn-success" ID="btnBack" runat="server" Text="返回" 
        onclick="btnBack_Click" /></td>       

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
        <li><a href="#">进度预警</a></li>
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
        <li class="active"><a href="Notice_Add.aspx">发布通知</a></li>
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

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceTop" runat="server">
  <div id="content-header">
<div id="breadcrumb"> <a href="Default_GWH.aspx" title="回到主页" class="tip-bottom"><i class="icon-home"></i> 主页</a> <a href="">系统维护</a><a href="User_Management.aspx">用户管理</a> <a href="#" class="current">添加新用户</a> </div> 
  </div>
</asp:Content>