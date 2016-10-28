<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage_XGB.Master" AutoEventWireup="true" CodeBehind="noticeDetails.aspx.cs" Inherits="Maticsoft.Web.XGB.Notice_Details" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceTop" runat="server">
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
            margin-left:30px;
            margin-top:30px;
            top: 2px;
            left: 0px;
            width: 235px;
        }
    </style>
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
<asp:Content ID="Content2" ContentPlaceHolderID="MiddleContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MiddleContent2" runat="server">
</asp:Content>
