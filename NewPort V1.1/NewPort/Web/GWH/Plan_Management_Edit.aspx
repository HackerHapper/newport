<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage_GWH.master" AutoEventWireup="true" CodeBehind="Plan_Management_Edit.aspx.cs" Inherits="Maticsoft.Web.GWH.Plan_Management_Edit" %>
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
            width: 223px;
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
            color: Black;
            font-weight: bold;
            width: 147px;
            height: 20px;
        }
        .style6
        {
            color: Blue;
            width: 353px;
            font-weight: none;
            height: 20px;
        }
        .style7
        {
            color: Black;
            font-weight: bold;
            width: 117px;
            height: 20px;
        }
        .style8
        {
            color: Blue;
            font-weight: none;
            height: 20px;
        }
        
        .style9
        {
            color: Blue;
            width: 353px;
            font-weight: none;
        }
        .style10
        {
            width: 353px;
        }
        .style11
        {
            color: Black;
            font-weight: bold;
            width: 353px;
        }
        .style12
        {
            color: Black;
            font-weight: bold;
            width: 147px;
        }
        
    </style>
        <script language="javascript" type="text/javascript" src="My97DatePicker/WdatePicker.js"></script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MiddleContent2" runat="server">
    <div>
 <h3>编辑项目信息</h3>
</div>
 <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
 <tr>
 <td class="style4">     
<table align="center">

	<tr>
	<td align="right" class="style5">项目编号：</td>
    <td align="left" class="style6">&nbsp&nbsp<asp:Label id="lbl_enumber" runat="server"></asp:Label></td>
    <td align="right" class="style7">计划类别：</td>
    <td width="*" align="left" class="style8">&nbsp;
    <asp:DropDownList ID="DDLPlanType" runat="server" Height="26px" Width="150px">
                            <asp:ListItem Value="武汉新港建设项目">武汉新港建设项目</asp:ListItem>
                            <asp:ListItem Value="临港经济新区">临港经济新区</asp:ListItem>
                            <asp:ListItem Value="航运中心项目">航运中心项目</asp:ListItem>
                            <asp:ListItem Value="“十三五”期间项目">“十三五”期间项目</asp:ListItem>
        </asp:DropDownList>
    </td>
        
    </tr>

	<tr>
	<td height="25" align="right" class="style12">项目名称：</td>
	<td height="25" align="left" class="style9">&nbsp&nbsp<asp:TextBox ID="lbl_ename" runat="server" Height="16px" Width="136px"></asp:TextBox>
    </td>
    <td height="25" align="right" class="style3">业主单位：</td>
	<td height="25" width="*" align="left" class="style_content">&nbsp&nbsp<asp:TextBox ID="lbl_eowner" runat="server" Height="16px" Width="136px"></asp:TextBox>
    </td>
    </tr>

	<tr>
	<td height="25" align="right" class="style12">项目地点：</td>
	<td height="25" align="left" class="style9">&nbsp&nbsp<asp:TextBox ID="lbl_eaddress" runat="server" Height="16px" Width="136px"></asp:TextBox>
    </td>
	<td height="25" align="right" class="style3">设计能力：</td>
	<td height="25" width="*" align="left" class="style_content">&nbsp&nbsp<asp:TextBox ID="lbl_eapc" runat="server" Height="16px" Width="136px"></asp:TextBox>
    </td>
    </tr>

	<tr>
	<td height="25" align="right" class="style12">岸线：</td>
	<td height="25" align="left" class="style9">&nbsp&nbsp<asp:TextBox ID="lbl_edis" runat="server" Height="16px" Width="136px"></asp:TextBox>
    </td>    
	<td height="25" align="right" class="style3">总投资：</td>
	<td height="25" width="*" align="left" class="style_content">&nbsp&nbsp<asp:TextBox ID="lbl_emoney" runat="server" Height="16px" Width="136px"></asp:TextBox>
    </td>
    </tr>
	<tr>
	<td height="25" align="right" class="style12">建设起止时间：</td>&nbsp&nbsp&nbsp&nbsp
    <td class="style10">&nbsp;<input class="Wdate" id="input1" height="12px" width="12px" type="text" onClick="WdatePicker()" runat="server"> <font color=red></font></input> 至<input class="Wdate" id="input2" height="12px" width="12px" type="text" onClick="WdatePicker()" runat="server"> <font color=red></font></input></td>    
    <td height="25" align="right" class="style1">建设内容：</td>
    <td height="25" align="left" class="style_content">&nbsp&nbsp<asp:TextBox  TextMode="MultiLine" ID="eTextContent" runat="server" Height="16px" Width="136px"></asp:TextBox>
    </td>
	<tr>
	<td height="25" align="right" class="style12">前期工作进展情况：</td>
	<td height="25" align="left" class="style9">&nbsp&nbsp;
    <asp:TextBox TextMode="MultiLine" ID="eTextPre" runat="server" Height="16px" Width="136px"></asp:TextBox></td>    
	<td height="25" align="right" class="style1">备注：</td>
	<td height="25" align="left" class="style_content">&nbsp&nbsp<asp:TextBox TextMode="MultiLine" ID="eTextOthers" runat="server" Height="16px" Width="136px"></asp:TextBox>
    </td>    
    </tr>
	<td height="25" align="right" class="style12">状态：</td>
    <td height="25" align="left" class="style11">&nbsp&nbsp<asp:DropDownList ID="DDLState" runat="server" Height="26px" Width="150px">
                            <asp:ListItem Value="策划">策划</asp:ListItem>
                            <asp:ListItem Value="新开工">新开工</asp:ListItem>
                            <asp:ListItem Value="续建项目">续建项目</asp:ListItem>
        </asp:DropDownList>
        </td>
        <td></td>
	<td height="25" align="left"class="style2"> &nbsp&nbsp
    <asp:Button  class="btn btn-success" ID="btneSubmit" runat="server" Text="确定" onclick="btneSubmit_Click" />&nbsp&nbsp 
        <asp:Button  class="btn btn-success" ID="btneBack" runat="server" Text="返回" onclick="btneBack_Click" />
        </td>
        
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
 <div id="breadcrumb"> <a href="Default_GWH.aspx" title="回到主页" class="tip-bottom"><i class="icon-home"></i> 主页</a> <a href="">项目管理</a><a href="Plan_Management.aspx">项目查询及编辑</a> <a href="Plan_Management_Details.aspx" class="current">项目编辑</a> </div> 
  </div>
</asp:Content>
