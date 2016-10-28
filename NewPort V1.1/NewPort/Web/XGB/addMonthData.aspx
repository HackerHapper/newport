<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage_XGB.Master" AutoEventWireup="true" CodeBehind="addMonthData.aspx.cs" Inherits="Maticsoft.Web.XGB.monthlyFeedback" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceTop" runat="server">
    <style>
.row
{
    position:absolute;
    margin-left:50px;
    margin-top:20px;
    }
</style>
 <div class="row">
 <h3>添加月度反馈</h3>

	<tr>
	<td align="right" class="style5" style="height: 25px">项目编号：</td>&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
    <td align="left" class="style2" style="height: 25px">
        <asp:DropDownList ID="DropDownList1" runat="server" 
            DataSourceID="SqlDataSource1" DataTextField="project_id" 
            DataValueField="project_id" Width="140px" AutoPostBack="True" 
            onselectedindexchanged="DropDownList1_SelectedIndexChanged">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
            SelectCommand="SELECT [project_id] FROM [Table_project] WHERE ([project_writer] LIKE '%' + @project_writer + '%')">
            <SelectParameters>
                <asp:SessionParameter Name="project_writer" SessionField="UserName" 
                    Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
        &nbsp&nbsp</td>    
    </tr>
    </br>
	<tr>
	<td height="25" align="right" class="style5">项目名称：</td>
	<td height="25" align="left" class="style2">&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
        <asp:Label ID="lblName" runat="server" Text=""></asp:Label></td>
    </tr>
    </br>
    <tr>
	<td height="25" align="right" class="style5">本月完成投资：</td>
	<td height="25" align="left" class="style2"><asp:TextBox ID="txtInvestment" 
            runat="server" Height="12px" Width="109px"></asp:TextBox>&nbsp 万元</td>
    </tr>
    </br>
    <tr>
	<td height="25" align="right" class="style5">本月完成<br />
     工程形象进度：</td>
	<td height="25" align="left" class="style2"><textarea id="txta" runat="server"></textarea> </td>
    </tr>
    </br>
    <tr border='0'>
	<td align="right" class="style9"></td>
	<td align="left"class="style10"> 
        <asp:Button ID="btnmBack"  class="btn btn-success" runat="server" Text="确认" 
            onclick="btnmBack_Click" Height="27px" />
        </td>
    </tr>
</div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MiddleContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MiddleContent2" runat="server">
</asp:Content>
