<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage_XGB.Master" AutoEventWireup="true" CodeBehind="MonthlyFeedback_Details.aspx.cs" Inherits="Maticsoft.Web.XGB.MonthlyFeedback_Details" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceTop" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MiddleContent" runat="server">

<style>
.row
{
    position:absolute;
    margin-left:6px;
    margin-top:-50px;
        top: -52px;
        left: 24px;
        width: 420px;
        height: 223px;
    }
</style>
    <div class="row">
 <h3>月度反馈信息</h3>
	<tr>
	<td align="right" class="style10">项目编号：</td>
    <td align="left" class="style11">&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp<asp:Label id="lbl_number" runat="server"></asp:Label></td>
    </br>
    <td align="right" class="style5">本次反馈时间：</td>
    <td width="*" align="left" class="style12">&nbsp&nbsp<asp:Label id="lbl_time" runat="server"></asp:Label></td>
    </tr>    
    </br>
	<tr>
	<td align="right" class="style10">本月完成投资：</td>
	<td align="left" class="style11">&nbsp&nbsp<asp:Label id="lbl_completed" runat="server"></asp:Label></td>
    </br>
    <td align="right" class="style5">本月完成<br />工程形象进度：</td>
	<td width="*" align="left" class="style12">&nbsp&nbsp<asp:Label id="lbl_process" runat="server"></asp:Label></td>
    </tr>
    </br>
    <tr>
	<td align="right" class="style10"></td>
	<td align="left"class="style11"> 
        <asp:Button ID="btnmBack"  class="btn btn-success" runat="server" Text="返回" onclick="btnBack_Click"  />
        </td>
    </tr>
</div>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MiddleContent2" runat="server">
</asp:Content>
