<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage_GWH.master" AutoEventWireup="true" CodeBehind="Notice_Add.aspx.cs" Inherits="Maticsoft.Web.GWH.Notice_Add" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style1
        {
            height: 30px;
        }
        .style2
        {
            height: 19px;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MiddleContent2" runat="server">
<script>
    window.onload = function messageNumber() {
        var d = new Date();
        var str = d.getHours() + "/" + d.getMinutes() + "/" + d.getSeconds();
        var oTextbox1 = document.getElementById("<%= txtnono.ClientID %>");//获取信息编号文本框的id
        oTextbox1.value = str;
    }
</script>
<div>
 <h3>添加通知信息</h3>
</div>
	<tr>
	<td align="right" class="style1">通知编号：</td>
    <td align="left" class="style1">&nbsp
    <asp:TextBox id="txtnono" runat="server" Height="15px" Width="120px"></asp:TextBox></td>
    </tr>
    </br>
    <tr>
	<td align="right" class="style1">通知主题：</td>
    <td align="left" class="style1">&nbsp&nbsp<asp:TextBox id="txttitle" runat="server" Height="15px" Width="120px"></asp:TextBox></td>            
    </tr>
    </br>
	<tr>
	<td align="right" class="style1">通知内容：</td>
	<td align="left" class="style1">&nbsp&nbsp<asp:TextBox  TextMode="MultiLine" ID="txtcontent" runat="server" Height="15px" Width="120px"></asp:TextBox>
    </td>
    </tr>
    </br>
    <tr>
    <td align="right" class="style1">附件上传：</td>
	<td align="left" class="style1">&nbsp&nbsp<asp:FileUpload ID="FileUpload1" runat="server" Height="30px" Width="180px"/>
    </td>
    </tr>
    <tr>
	<td align="right" class="style2"></td>
	<td align="left" class="style2"> 
    <asp:Button  class="btn btn-success" ID="btneSubmit" runat="server" Text="确定" onclick="btneSubmit_Click" />
        <asp:Button  class="btn btn-success" ID="btneBack" runat="server" Text="返回" onclick="btneBack_Click" />
        </td>
    </tr><asp:Label ID="literal" runat="server" Text="Label"></asp:Label>
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

<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceTop" runat="server">
  <div id="content-header">
<div id="breadcrumb"> <a href="Default_GWH.aspx" title="回到主页" class="tip-bottom"><i class="icon-home"></i> 主页</a> <a href="">项目管理</a><a href="">通知公告</a><a href="Notice_Add.aspx" class="current">发布通知</a></div>
  </div>
</asp:Content>
