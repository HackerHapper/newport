<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage_GWH.master" AutoEventWireup="true" CodeBehind="InvestAddMiles.aspx.cs" Inherits="Maticsoft.Web.GWH.InvestAddMiles" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MiddleContent2" runat="server">

    <div>
 <h3>武汉新港集疏运改扩建、新增里程统计</h3>
</div>
 <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
 <tr><td class="style4">     	
<table> 
<tr>
	<td height="25" align="right" class="style1">选择统计时间段：</td>
    <td>
        <asp:DropDownList ID="DDL_Year" runat="server" Width="70px" Height="24px">
            <asp:ListItem Value="2010"></asp:ListItem>
            <asp:ListItem Value="2011"></asp:ListItem>
            <asp:ListItem Value="2012"></asp:ListItem>
            <asp:ListItem Value="2013"></asp:ListItem>
            <asp:ListItem Value="2014"></asp:ListItem>
            <asp:ListItem Value="2015"></asp:ListItem>
            <asp:ListItem Value="2016"></asp:ListItem>
        </asp:DropDownList>&nbsp 年&nbsp  
    </td>        
    </tr>

     <tr>
	<td height="21" align="right" class="style6">
    <asp:Button class="btn btn-success" ID="btnTable" runat="server" Text="生成统计报表" onclick="btnTable_Click"/></td>
	<td height="21" align="left"class="style2"> 
        <asp:Button class="btn btn-success" ID="btnPrint" runat="server" Text="打印" onclick="btnPrint_Click" />
        <asp:Button class="btn btn-success" ID="btnBack" runat="server" Text="返回" 
            onclick="btnBack_Click"/>
        </td>
    </tr>
    <div>
    
 <div class="gridviewPage">
    <asp:GridView ID="GridView_Project" runat="server" AutoGenerateColumns="False" 
         DataSourceID="SqlDataSource_Project" Width="1000px" BackColor="#CCCCCC" BorderColor="#999999"
        BorderStyle="Solid" BorderWidth="1px" CellPadding="4" CellSpacing="2" PageSize="10"
        ForeColor="Black"   CssClass="testGridView" Visible="false"
         OnRowDataBound="gridViewImportPercent_RowDataBound">
        <Columns>
            <asp:BoundField DataField="project_id" HeaderText="项目编号" 
                SortExpression="project_id" />
            <asp:BoundField DataField="project_name" HeaderText="项目名称" 
                SortExpression="project_name" />
            <asp:BoundField DataField="project_mileage" HeaderText="改扩建、新增里程" 
                SortExpression="project_mileage" />
        </Columns>
        <EmptyDataTemplate>
            未能检索到信息！
        </EmptyDataTemplate>
        <FooterStyle BackColor="#eeeeee" />
        <HeaderStyle BackColor="#eeeeee" Font-Bold="True" ForeColor="#666666" />
        <PagerStyle BackColor="#eeeeee" ForeColor="#666666" HorizontalAlign="right" />
        <RowStyle BackColor="White" ForeColor="#666666" HorizontalAlign="center"/>
        <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="#808080" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#383838" />
        <PagerTemplate> 
&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp 当前第&nbsp
<!--((GridView)Container.NamingContainer)就是为了得到当前的控件 -->
<asp:Label ID="LabelCurrentPage" runat="server" Text="<%# ((GridView)Container.NamingContainer).PageIndex + 1 %>"></asp:Label>
页 &nbsp;/ &nbsp;共&nbsp
<!--//得到分页页面的总数  -->
<asp:Label ID="LabelPageCount" runat="server" Text="<%# ((GridView)Container.NamingContainer).PageCount %>"></asp:Label>
页 
<!--//如果该分页是首分页，那么该连接就不会显示了.同时对应了自带识别的命令参数CommandArgument  -->
<asp:LinkButton ID="LinkButtonFirstPage" runat="server" CommandArgument="First" CommandName="Page" 
Visible='<%#((GridView)Container.NamingContainer).PageIndex != 0 %>'>&nbsp 首页</asp:LinkButton> 
<asp:LinkButton ID="LinkButtonPreviousPage" runat="server" CommandArgument="Prev" 
CommandName="Page" Visible='<%# ((GridView)Container.NamingContainer).PageIndex != 0 %>'>&nbsp&nbsp 上一页</asp:LinkButton> 
<!--如果该分页是尾页，那么该连接就不会显示了 -->
<asp:LinkButton ID="LinkButtonNextPage" runat="server" CommandArgument="Next" CommandName="Page" 
Visible='<%# ((GridView)Container.NamingContainer).PageIndex != ((GridView)Container.NamingContainer).PageCount - 1 %>'>&nbsp&nbsp 下一页</asp:LinkButton> 
<asp:LinkButton ID="LinkButtonLastPage" runat="server" CommandArgument="Last" CommandName="Page" 
Visible='<%# ((GridView)Container.NamingContainer).PageIndex != ((GridView)Container.NamingContainer).PageCount - 1 %>'>&nbsp&nbsp 尾页</asp:LinkButton> 
&nbsp&nbsp 转到第 
<asp:TextBox ID="txtNewPageIndex" runat="server" Width="12px" height="10px" Text='<%# ((GridView)Container.Parent.Parent).PageIndex + 1 %>' /> 页 
<!--//这里将CommandArgument即使点击该按钮e.newIndex 值为3 -->&nbsp&nbsp
<asp:LinkButton ID="btnGo" runat="server" CausesValidation="False" CommandArgument="-2" 
CommandName="Page" Text="确定" /> &nbsp;&nbsp
</PagerTemplate> 
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource_Project" runat="server" 
        ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
        SelectCommand="SELECT * FROM [projecttable]"></asp:SqlDataSource>
</div>
    </div>    
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceLeft" runat="server">
<div id="sidebar"><a href="#" class="visible-phone"><i class="icon icon-home"></i> 武汉新港计划项目动态管理系统</a>
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
        <li class="active"><a href="InvestPlan.aspx">投资计划统计</a></li>
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
    <div id="breadcrumb"> <a href="Default_GWH.aspx" title="回到主页" class="tip-bottom"><i class="icon-home"></i> 主页</a> <a href="">统计分析</a> <a href="InvestPlan.aspx" class="current">武汉新港集疏运改扩建、新增里程统计</a></div>
  </div>
</asp:Content>
