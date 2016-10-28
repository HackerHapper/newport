<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage_GWH.master" AutoEventWireup="true" CodeBehind="InvestPlan.aspx.cs" Inherits="Maticsoft.Web.GWH.InvestPlan"  EnableEventValidation = "false" %>
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
        width: 307px;
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
        color: Blue;
        width: 393px;
        font-weight: none;
    }
    .style6
    {
        color: Black;
        font-weight: bold;
        width: 130px;
    }
    .style7
    {
        color: Black;
        font-weight: bold;
        width: 132px;
    }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MiddleContent2" runat="server">
<script>
    function clitype() 
    {
        var collid = document.getElementById("<%=cb_alltype.ClientID%>");
        var collid1 = document.getElementById("<%=cb_Ganhang.ClientID%>");
        var collid2 = document.getElementById("<%=cb_Jishuyun.ClientID%>");
        var collid3 = document.getElementById("<%=cb_Lingang.ClientID%>");
        if (collid.checked) {
            collid1.checked = true;
            collid2.checked = true;
            collid3.checked = true;
        }
        else {
            collid1.checked = false;
            collid2.checked = false;
            collid3.checked = false;
        }
    }
    function clitypeNoAll() {
        var collid = document.getElementById("<%=cb_alltype.ClientID%>");
        collid.checked = false;
    }

    function clistate() {
        var collid = document.getElementById("<%=cb_allstate.ClientID%>");
        var collid1 = document.getElementById("<%=cb_New.ClientID%>");
        var collid2 = document.getElementById("<%=cb_Goon.ClientID%>");
        if (collid.checked) {
            collid1.checked = true;
            collid2.checked = true;
        }
        else {
            collid1.checked = false;
            collid2.checked = false;
        }
        if (collid1.checked == false || collid2.checked == false) {
            collid.checked = false;
        }
    }
    function clistateNoAll() {
        var collid = document.getElementById("<%=cb_allstate.ClientID%>");
        collid.checked = false;
    }
    function cliarea() {
        var collid = document.getElementById("<%=cb_allarea.ClientID%>");
        var collid1 = document.getElementById("<%=cb_Wuhan.ClientID%>");
        var collid2 = document.getElementById("<%=cb_Ezhou.ClientID%>");
        var collid3 = document.getElementById("<%=cb_Huanggan.ClientID%>");
        var collid4 = document.getElementById("<%=cb_Xianning.ClientID%>");
        var collid5 = document.getElementById("<%=cb_Xinzhou.ClientID%>");
        var collid6 = document.getElementById("<%=cb_Hannan.ClientID%>");
        var collid7 = document.getElementById("<%=cb_HGQ.ClientID%>");
        var collid8 = document.getElementById("<%=cb_XGT.ClientID%>");
        var collid9 = document.getElementById("<%=cb_Wugan.ClientID%>");
        var collid10 = document.getElementById("<%=cb_Jiangxia.ClientID%>");

        if (collid.checked) {
            collid1.checked = true;
            collid2.checked = true;
            collid3.checked = true;
            collid4.checked = true;
            collid5.checked = true;
            collid6.checked = true;
            collid7.checked = true;
            collid8.checked = true;
            collid9.checked = true;
            collid10.checked = true;
        }
        else {
            collid1.checked = false;
            collid2.checked = false;
            collid3.checked = false;
            collid4.checked = false;
            collid5.checked = false;
            collid6.checked = false;
            collid7.checked = false;
            collid8.checked = false;
            collid9.checked = false;
            collid10.checked = false;
        }
        if (collid1.checked == false || collid2.checked == false || collid3.checked == false || collid4.checked == false || collid5.checked == false || collid6.checked == false || collid7.checked == false || collid8.checked == false || collid9.checked == false || collid10.checked == false) {
            collid.checked = false;
        }
    }
    function cliareaNoAll() {
        var collid = document.getElementById("<%=cb_allarea.ClientID%>");
        collid.checked = false;
    }
</script>
    <div>
 <h3>投资计划统计</h3>
</div>
 <table style="width: 200%;" cellpadding="2" cellspacing="1" class="border">
 <tr><td class="style4">     
<table style='BORDER-COLLAPSE: collapse; width: 850px;' borderColor='black' 
         border='0' bgcolor=#dddddd align="center">

	<tr>
	<td height="25" align="right" class="style1">选择统计年度：</td>
    <td>
        <asp:DropDownList ID="DDL_Year1" runat="server" Width="70px" Height="25px">
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
        </asp:DropDownList>&nbsp 年
    </td>        
    </tr>

	<tr>
    <td height="25" align="right" class="style3">参与统计的项目类型：</td>
	<td height="25" align="left" class="style2">
    <asp:CheckBox id="cb_alltype" runat="server" onclick="clitype()"/>全选
    <asp:CheckBox id="cb_Ganhang" runat="server" onclick="clitypeNoAll()"/>港航项目
    <asp:CheckBox id="cb_Jishuyun" runat="server" onclick="clitypeNoAll()"/>集疏运项目
    <asp:CheckBox id="cb_Lingang" runat="server" onclick="clitypeNoAll()"/>临港产业项目
    </td>    
    </tr>

	<tr>
    <td height="25" align="right" class="style3">参与统计的项目状态：</td>
	<td height="25" align="left" class="style2">
    <asp:CheckBox ID="cb_allstate" runat="server"  onclick="clistate()"/>全选
    <asp:CheckBox ID="cb_New" runat="server" onclick="clistateNoAll()"/>新开工
    <asp:CheckBox ID="cb_Goon" runat="server" onclick="clistateNoAll()"/>续建
    </td>    
    </tr>

    <tr>
    <td height="25" align="right" class="style3">参与统计的项目区域：</td>
	<td height="25" align="left" class="style2">
    <asp:CheckBox ID="cb_allarea" runat="server"  onclick="cliarea()"/>全选
    <asp:CheckBox ID="cb_Wuhan" runat="server" onclick="cliareaNoAll()"/>武汉
    <asp:CheckBox ID="cb_Ezhou" runat="server" onclick="cliareaNoAll()"/>鄂州
    <asp:CheckBox ID="cb_Huanggan" runat="server" onclick="cliareaNoAll()"/>黄冈
    <asp:CheckBox ID="cb_Xianning" runat="server" onclick="cliareaNoAll()"/>咸宁
    <asp:CheckBox ID="cb_Xinzhou" runat="server" onclick="cliareaNoAll()"/>新洲
    <asp:CheckBox ID="cb_Hannan" runat="server" onclick="cliareaNoAll()"/>汉南
    <asp:CheckBox ID="cb_HGQ" runat="server" onclick="cliareaNoAll()"/>化工区
    <asp:CheckBox ID="cb_XGT" runat="server" onclick="cliareaNoAll()"/>新港投
    <asp:CheckBox ID="cb_Wugan" runat="server" onclick="cliareaNoAll()"/>武港
    <asp:CheckBox ID="cb_Jiangxia" runat="server" onclick="cliareaNoAll()" />江夏
    </td>    
    </tr>

    
    <tr>
	<td height="21" align="right" class="style6">
    <asp:Button class="btn btn-success" ID="Button1" runat="server" Text="生成统计报表" onclick="btneSubmit_Click" />
        <asp:Button class="btn btn-success" ID="Button3" runat="server" Text="导出到excel" onclick="btneBack_Click" /></td>
	<td height="21" align="left"class="style2"> 
        <asp:Button class="btn btn-success" ID="Button4" runat="server" 
            Text="集疏运改扩建、新增里程统计" onclick="Button4_Click"  />
        </td>
    </tr>    
</table>
</br> 
 <div class="gridviewPage">
    <asp:GridView ID="GridView_Project" runat="server" AutoGenerateColumns="False" 
         DataSourceID="SqlDataSource_Project" Width="1000px" BackColor="#CCCCCC" BorderColor="#999999"
        BorderStyle="Solid" BorderWidth="1px" CellPadding="4" CellSpacing="2" 
        ForeColor="Black"   CssClass="testGridView" Visible="false" 
         OnRowDataBound="gridViewImportPercent_RowDataBound">
        <Columns>
        <asp:BoundField HeaderText="序号" ><ItemStyle HorizontalAlign="Center" />
        <HeaderStyle HorizontalAlign="Center" Width="30px" /></asp:BoundField>  
            <asp:BoundField DataField="project_name" HeaderText="项目名称" 
                SortExpression="project_name" />
            <asp:BoundField DataField="project_state" HeaderText="项目状态" 
                SortExpression="project_state" />
            <asp:BoundField DataField="project_type" HeaderText="项目类型" 
                SortExpression="project_type" />
            <asp:BoundField DataField="project_area" HeaderText="所在城市" 
                SortExpression="project_area" />
            <asp:BoundField DataField="project_owner" HeaderText="项目地点" 
                SortExpression="project_owner" />
            <asp:BoundField DataField="project_positon" HeaderText="项目地点" 
                SortExpression="project_positon" />
            <asp:BoundField DataField="project_constrContent" HeaderText="建设内容" 
                SortExpression="project_constrContent" />
            <asp:BoundField DataField="project_scale" HeaderText="岸线/里程" 
                SortExpression="project_scale" />
            <asp:BoundField DataField="project_designCapacity" 
                HeaderText="设计能力" 
                SortExpression="project_designCapacity" />
            <asp:BoundField DataField="project_totalInvestment" 
                HeaderText="总投资（万元）" 
                SortExpression="project_totalInvestment" />
            <asp:BoundField DataField="project_startend" HeaderText="建设起止时间" 
                SortExpression="project_startend" />
            <asp:BoundField DataField="investmentin2014" HeaderText="本年完成投资（万元）" 
                SortExpression="investmentin2014" />
            <asp:BoundField DataField="investuntil2014" 
                HeaderText="截至本年完成投资" SortExpression="investuntil2014" />
            <asp:BoundField DataField="investmentin2015" HeaderText="下年计划投资（万元）" 
                SortExpression="investmentin2015" />
            <asp:BoundField DataField="totalinvestment" HeaderText="累计投资（万元）" 
                SortExpression="totalinvestment" />
            <asp:BoundField DataField="planaccounting" HeaderText="占计划比" 
                SortExpression="planaccounting" />
            <asp:BoundField DataField="schedule" HeaderText="形象进度" 
                SortExpression="schedule" />
            <asp:BoundField DataField="occupies" HeaderText="项目占地" 
                SortExpression="occupies" />
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
    <div id="breadcrumb"> <a href="Default_GWH.aspx" title="回到主页" class="tip-bottom"><i class="icon-home"></i> 主页</a> <a href="">统计分析</a> <a href="InvestPlan.aspx" class="current">投资计划统计</a></div>
  </div>
</asp:Content>


