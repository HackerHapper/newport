<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage_GWH.master" AutoEventWireup="true" CodeBehind="Plan_Check.aspx.cs" Inherits="Maticsoft.Web.GWH.Plan_Check" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MiddleContent" runat="server">
<div class="ddl3">
            <tr>
                     <td>
                         <b>搜索选项：</b>
                    </td>&nbsp;&nbsp;
                    <td>
                        <asp:DropDownList ID="DropDownList_Type" runat="server" Height="28px" 
                       Width="130px" 
                       onselectedindexchanged="DropDownList_Type_SelectedIndexChanged" 
                       AutoPostBack="True">
                            <asp:ListItem Value=" ">选择项目类型</asp:ListItem>
                            <asp:ListItem Value="港航项目"></asp:ListItem>
                            <asp:ListItem Value="集疏运项目"></asp:ListItem>
                            <asp:ListItem Value="物流园区项目"></asp:ListItem>
                            <asp:ListItem Value="其他类型"></asp:ListItem>
                        </asp:DropDownList>                                             
                    </td>&nbsp;&nbsp;
                    <td>
                        <asp:DropDownList ID="DropDownList_State" runat="server" Height="28px" 
                       Width="130px" 
                       onselectedindexchanged="DropDownList_State_SelectedIndexChanged" 
                       AutoPostBack="True">
                            <asp:ListItem Value=" ">选择项目状态</asp:ListItem>
                            <asp:ListItem Value="策划"></asp:ListItem>
                            <asp:ListItem Value="新开工"></asp:ListItem>
                            <asp:ListItem Value="续建项目"></asp:ListItem>
                        </asp:DropDownList>     
                    </td>&nbsp;&nbsp;
                    <td>
                        <asp:DropDownList ID="DropDownList_isCheck" runat="server" Height="28px" 
                       Width="130px" 
                       onselectedindexchanged="DropDownList_isCheck_SelectedIndexChanged" 
                       AutoPostBack="True" >
                            <asp:ListItem Value=" ">选择审核信息</asp:ListItem>
                            <asp:ListItem Value="审核通过">审核通过</asp:ListItem>
                            <asp:ListItem Value="审核未通过">审核未通过</asp:ListItem>
                            <asp:ListItem Value="待审核">待审核</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
            </div>
            <div class="searchtext">
                <tr>
                    <td style="width: 80px" align="right" class="tdbg">
                         <b>关键字：</b>
                    </td> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <td class="tdbg">                       
                    <asp:TextBox ID="txtKeyword" runat="server" Height="20px" Width="258px"></asp:TextBox>
                    &nbsp;&nbsp;&nbsp;
                    <asp:Button class="btn btn-success" ID="btnmSearch" runat="server" Text="查询"   Width="85px" 
                    Height="30px" OnClick="btnSearch_Click" >
                    </asp:Button> 
                    &nbsp;&nbsp;&nbsp;                    
                    </td>
                    <td class="tdbg">
                    </td>
                </tr>
                </div>
            <!--Search end-->
            <br />
            <br />
            
 <div class="gridviewPage">
    <asp:GridView ID="GridView_Project" runat="server" AutoGenerateColumns="False" 
        DataKeyNames="project_id" DataSourceID="SqlDataSource_Project" Width="1000px" 
        AllowPaging="True" BackColor="#CCCCCC" BorderColor="#999999"
        BorderStyle="Solid" BorderWidth="1px" CellPadding="4" CellSpacing="2" 
        ForeColor="Black" OnPageIndexChanging="gvwDesignationName_PageIndexChanging" 
        CssClass="testGridView">
        <Columns>
            <asp:BoundField DataField="project_name" HeaderText="项目名称" 
                SortExpression="project_name" />
            <asp:BoundField DataField="project_owner" HeaderText="业主单位" 
                SortExpression="project_owner" />
            <asp:BoundField DataField="project_positon" HeaderText="项目地点" 
                SortExpression="project_positon" />
            <asp:BoundField DataField="project_type" HeaderText="项目类型" 
                SortExpression="project_type" />
            <asp:BoundField DataField="project_state" HeaderText="项目属性" 
                SortExpression="project_state" />
            <asp:BoundField DataField="project_check" HeaderText="审核状态" 
                SortExpression="project_check" />
            <asp:HyperLinkField HeaderText="进行审核" ControlStyle-Width="50" 
                DataNavigateUrlFields="project_id" DataNavigateUrlFormatString="Plan_Check_Details.aspx?id={0}" Text="审核" ItemStyle-ForeColor="#0000CC" >
<ControlStyle Width="50px" ForeColor="Blue"></ControlStyle><ItemStyle ForeColor="#0000CC"></ItemStyle>
            </asp:HyperLinkField>
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
        SelectCommand="SELECT * FROM [Table_project]"></asp:SqlDataSource>
</div>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceLeft" runat="server">
<div id="sidebar"><a href="#" class="visible-phone"><i class="icon icon-home"></i> Dashboard</a>
  <ul>
    <li><a href="Default_GWH.aspx" onclick="javascript:addClass(this.parentNode,'active')"><i class="icon icon-inbox"></i> <span>系统首页</span></a></li>
    <li class="active"><a href="Plan_Check.aspx" onclick="javascript:addClass(this.parentNode,'active')"><i class="icon icon-inbox"></i> <span>项目审核</span></a></li>
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
    <div id="breadcrumb"> <a href="Default_GWH.aspx" title="回到主页" class="tip-bottom"><i class="icon-home"></i> 主页</a> <a href="Plan_Check.aspx" class="current">项目审核</a></div>
  </div>
</asp:Content>