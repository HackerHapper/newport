<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage_GWH.master" AutoEventWireup="true" CodeBehind="UserDetails.aspx.cs" Inherits="Maticsoft.Web.GWH.UserDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
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
 <div id="breadcrumb"> <a href="Default_GWH.aspx" title="回到主页" class="tip-bottom"><i class="icon-home"></i> 主页</a> <a href="">系统维护</a><a href="User_Management.aspx">用户管理</a> <a href="#" class="current">用户信息编辑</a> </div> 
  </div>
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="MiddleContent2" runat="server">

    <div>
 <h3>编辑项目信息</h3>
</div>
	<tr>
	<td align="right" class="style5">账号：</td></br>
    <td align="left" class="style6">&nbsp&nbsp<asp:Label id="lbl_account" runat="server"></asp:Label></td>
    </br>
    <td align="right" class="style7">所属单位：</td>
    <td width="*" align="left" class="style8">&nbsp;
    <asp:DropDownList ID="DDLPlanType" runat="server" Height="26px" Width="150px">
                            <asp:ListItem Value="新港办用户">新港办用户</asp:ListItem>
                            <asp:ListItem Value="管委会用户">管委会用户</asp:ListItem>
        </asp:DropDownList>
    </td>
        
    </tr>

	<tr>
	<td height="25" align="right" class="style1">账户名称：</td>
	<td height="25" align="left" class="style2">&nbsp&nbsp<asp:TextBox ID="lbl_name" runat="server" Height="16px" Width="136px"></asp:TextBox>
    </td>
    <td height="25" align="right" class="style3">责任人：</td>
	<td height="25" width="*" align="left" class="style_content">&nbsp&nbsp<asp:TextBox ID="lbl_owner" runat="server" Height="16px" Width="136px"></asp:TextBox>
    </td>
    </tr>

	<tr>
	<td height="25" align="right" class="style1">联系方式：</td>
	<td height="25" align="left" class="style2">&nbsp&nbsp<asp:TextBox ID="lbl_address" runat="server" Height="16px" Width="136px"></asp:TextBox>
    </td>
	<td height="25" align="right" class="style3">密码：</td>
	<td height="25" width="*" align="left" class="style_content">&nbsp&nbsp<asp:TextBox ID="lbl_pwd" runat="server" Height="16px" Width="136px"></asp:TextBox>
    </td>
    </tr>

    <tr>
	<td height="25" align="right" class="style1"></td>
	<td height="25" align="left"class="style2"> 
    <asp:Button  class="btn btn-success" ID="btneSubmit" runat="server" Text="确定" onclick="btneSubmit_Click" />&nbsp&nbsp
        <asp:Button  class="btn btn-success" ID="btneBack" runat="server" Text="返回" onclick="btneBack_Click" />
        </td>
    </tr>
</asp:Content>
