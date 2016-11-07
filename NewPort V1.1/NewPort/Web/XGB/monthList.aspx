<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage_XGB.Master" AutoEventWireup="true" CodeBehind="monthList.aspx.cs" Inherits="Maticsoft.Web.XGB.MonthlyFBList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceTop" runat="server">
    <div class="searchtext">
        </br></br></br></br>  &nbsp;&nbsp;&nbsp;  
        <tr>            
            <td><b>项目编号：</b></td>
            <td><b><asp:Label ID="lblNumber" runat="server" Text=""></asp:Label></b></td>
        </tr>        
        <tr>         
            <td> <b> <br />&nbsp;&nbsp;&nbsp;  
        搜索选项：</b>
                    <td>
                    <asp:DropDownList ID="DropDownList_Year" runat="server" Height="28px" Width="130px" >
                            <asp:ListItem Value=" ">选择年度</asp:ListItem>
                            <asp:ListItem Value="2016">2016</asp:ListItem>
                            <asp:ListItem Value="2017">2017</asp:ListItem>
                            <asp:ListItem Value="2018">2018</asp:ListItem>
                            <asp:ListItem Value="2019">2019</asp:ListItem>
                            <asp:ListItem Value="2020">2020</asp:ListItem>
                            <asp:ListItem Value="2021">2021</asp:ListItem>
                            <asp:ListItem Value="2022">2022</asp:ListItem>
                            <asp:ListItem Value="2023">2023</asp:ListItem>
                            <asp:ListItem Value="2024">2024</asp:ListItem>
                            <asp:ListItem Value="2025">2025</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                <td>
                        <asp:DropDownList ID="DropDownList_Month" runat="server" Height="28px" Width="130px"  >
                            <asp:ListItem Value=" ">选择月度</asp:ListItem>
                            <asp:ListItem Value="2016">1</asp:ListItem>
                            <asp:ListItem Value="2017">2</asp:ListItem>
                            <asp:ListItem Value="2018">3</asp:ListItem>
                            <asp:ListItem Value="2019">4</asp:ListItem>
                            <asp:ListItem Value="2020">5</asp:ListItem>
                            <asp:ListItem Value="2021">6</asp:ListItem>
                            <asp:ListItem Value="2022">7</asp:ListItem>
                            <asp:ListItem Value="2023">8</asp:ListItem>
                            <asp:ListItem Value="2024">9</asp:ListItem>
                            <asp:ListItem Value="2025">10</asp:ListItem>
                            <asp:ListItem Value="2024">11</asp:ListItem>
                            <asp:ListItem Value="2025">12</asp:ListItem>
                        </asp:DropDownList>     
                    </td>&nbsp;&nbsp;
                </tr>
                    <asp:Button class="btn btn-success" ID="btnmSearch" runat="server" 
                    Text="查询"   Width="85px" 
                    Height="30px" onclick="btnmSearch_Click"  >
                    </asp:Button> &nbsp;&nbsp;&nbsp;
                    </td>
                    <td class="tdbg">
                    </td>
                </tr>
        <br /><br />&nbsp;&nbsp;&nbsp; 
        <tr>
	<td height="25" align="right" class="style5"><b>本月完成投资：</b></td>
	<td height="25" align="left" class="style2"><asp:Label ID="lblInvest" runat="server" Text=""></asp:Label>&nbsp 万元</td>
    </tr>
    </br>&nbsp;&nbsp;&nbsp; 
    <tr>
	<td height="25" align="right" class="style5"><b>本月完成</b><br />&nbsp;&nbsp;&nbsp; 
     <b>工程形象进度：</b></td>
	<td height="25" align="left" class="style2"><asp:Label ID="lblProcess" runat="server" Text=""></asp:Label> </td>
    </tr>
    </br>
                </div>
            <!--Search end-->
            <br />
            <br />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MiddleContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MiddleContent2" runat="server">
</asp:Content>
