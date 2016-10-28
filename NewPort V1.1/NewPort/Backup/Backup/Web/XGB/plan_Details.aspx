<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage_XGB.Master" AutoEventWireup="true" CodeBehind="plan_Details.aspx.cs" Inherits="Maticsoft.Web.XGB.plan_Details" %>
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
 <div>
<h3>&nbsp;&nbsp; 项目详情信息</h3>
</div>
&nbsp;&nbsp; <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
 <tr><td class="style4">     
<table width="100%" style='BORDER-COLLAPSE: collapse;' borderColor='black' 
         border='1' bgcolor=#dddddd align="left">

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

    <tr border='0'>
	<td height="25" align="right" class="style1"></td>
	<td height="25" align="left"class="style2"> 
        <asp:Button ID="btnmBack"  class="btn btn-success" runat="server" Text="返回" onclick="btnmBack_Click" />
        </td>
    </tr>
</table>
</td>
</tr>
</table>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MiddleContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MiddleContent2" runat="server">
</asp:Content>
