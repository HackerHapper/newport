<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage_GWH.master" AutoEventWireup="true" CodeBehind="Plan_Management.aspx.cs" Inherits="Maticsoft.Web.GWH.Plan_Management" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MiddleContent" runat="server">
<div class="ddl3">
            <tr>
                     <td>
                         <b>搜索选项：</b>
                    </td>&nbsp;&nbsp;
                    <td>
                        <asp:DropDownList ID="DropDownList_mType" runat="server" Height="28px" 
                       Width="130px" 
                       AutoPostBack="True" 
                onselectedindexchanged="DropDownList_mType_SelectedIndexChanged">
                            <asp:ListItem Value=" ">选择项目类型</asp:ListItem>
                            <asp:ListItem Value="港航项目"></asp:ListItem>
                            <asp:ListItem Value="集疏运项目"></asp:ListItem>
                            <asp:ListItem Value="物流园区项目"></asp:ListItem>
                            <asp:ListItem Value="其他类型"></asp:ListItem>
                        </asp:DropDownList>                                             
                    </td>&nbsp;&nbsp;
                    <td>
                        <asp:DropDownList ID="DropDownList_mState" runat="server" Height="28px" 
                       Width="130px" AutoPostBack="True" 
                onselectedindexchanged="DropDownList_mState_SelectedIndexChanged">
                            <asp:ListItem Value=" ">选择项目状态</asp:ListItem>
                            <asp:ListItem Value="策划"></asp:ListItem>
                            <asp:ListItem Value="新开工"></asp:ListItem>
                            <asp:ListItem Value="续建项目"></asp:ListItem>
                        </asp:DropDownList>     
                    </td>&nbsp;&nbsp;
                    <td>
                        <asp:DropDownList ID="DropDownList_misCheck" runat="server" Height="28px" 
                       Width="130px" 
                       AutoPostBack="True" 
                onselectedindexchanged="DropDownList_misCheck_SelectedIndexChanged" >
                            <asp:ListItem Value=" ">选择计划类别</asp:ListItem>
                            <asp:ListItem Value="武汉新港建设项目">武汉新港建设项目</asp:ListItem>
                            <asp:ListItem Value="临港经济新区">临港经济新区</asp:ListItem>
                            <asp:ListItem Value="航运中心项目">航运中心项目</asp:ListItem>
                            <asp:ListItem Value="“十三五”期间项目">“十三五”期间项目</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>&nbsp;&nbsp;
                    <asp:DropDownList ID="DropDownList_Year" runat="server" 
                Height="28px" Width="130px" AutoPostBack="True" 
                onselectedindexchanged="DropDownList_Year_SelectedIndexChanged"   >
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
                </tr>
            </div>
            <div class="searchtext">
                <tr>
                    <td style="width: 80px" align="right" class="tdbg">
                         <b>关键字：</b>
                    </td> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp
                    <td class="tdbg">                       
                    <asp:TextBox ID="txtmKeyword" runat="server" Height="20px" Width="258px"></asp:TextBox>
                    &nbsp;&nbsp;&nbsp;
                    <asp:Button class="btn btn-success" ID="btnmSearch" runat="server" Text="查询"   Width="85px" 
                    Height="30px" onclick="btnmSearch_Click">
                    </asp:Button> 
                    </td>
                    <td class="tdbg">
                    </td>
                </tr>
                </div>
            <!--Search end-->
            <br />
            <br />
            
 <div class="gridviewPage">
    <asp:GridView ID="GridView_mProject" runat="server" AutoGenerateColumns="False" 
        DataKeyNames="project_id" DataSourceID="SqlDataSource_mProject" Width="1000px" 
        AllowPaging="True" BackColor="#CCCCCC" BorderColor="#999999"
        BorderStyle="Solid" BorderWidth="1px" CellPadding="4" CellSpacing="2" 
        ForeColor="Black" OnPageIndexChanging="gvwDesignationName_mPageIndexChanging" 
        CssClass="testGridView">
        <Columns>
        <asp:BoundField DataField="project_id" HeaderText="项目编号" 
                SortExpression="project_id" />
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
            <asp:HyperLinkField HeaderText="查看详情" ControlStyle-Width="50" 
                DataNavigateUrlFields="project_id" DataNavigateUrlFormatString="Plan_Management_Details.aspx?id={0}"
                                Text="详情" ItemStyle-ForeColor="#0000CC" >
<ControlStyle Width="50px" ForeColor="Blue"></ControlStyle><ItemStyle ForeColor="#0000CC"></ItemStyle></asp:HyperLinkField>
            <asp:HyperLinkField HeaderText="项目编辑" ControlStyle-Width="50" 
                DataNavigateUrlFields="project_id" DataNavigateUrlFormatString="Plan_Management_Edit.aspx?id={0}"
                                Text="编辑" ItemStyle-ForeColor="#0000CC" >
<ControlStyle Width="50px" ForeColor="Blue"></ControlStyle><ItemStyle ForeColor="#0000CC"></ItemStyle></asp:HyperLinkField>
<asp:HyperLinkField HeaderText="专项资金支持" ControlStyle-Width="50" 
                DataNavigateUrlFields="project_id" DataNavigateUrlFormatString="Plan_SpecialtyAdd.aspx?id={0}"
                                Text="添加" ItemStyle-ForeColor="#0000CC" >
<ControlStyle Width="50px" ForeColor="Red"></ControlStyle><ItemStyle ForeColor="#0000CC"></ItemStyle></asp:HyperLinkField>
<asp:HyperLinkField HeaderText="删除" ControlStyle-Width="50" 
                DataNavigateUrlFields="project_id" DataNavigateUrlFormatString="Plan_Management.aspx?id={0}"
                                Text="删除" ItemStyle-ForeColor="#0000CC" >
<ControlStyle Width="50px"></ControlStyle><ItemStyle ForeColor="#0000CC"></ItemStyle></asp:HyperLinkField>
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
页/共&nbsp
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
<asp:TextBox ID="txtNewPageIndex" runat="server" Width="18px" height="14px" Text='<%# ((GridView)Container.Parent.Parent).PageIndex + 1 %>' /> 页 
<!--//这里将CommandArgument即使点击该按钮e.newIndex 值为3 -->&nbsp&nbsp
<asp:LinkButton ID="btnGo" runat="server" CausesValidation="False" CommandArgument="-2" 
CommandName="Page" Text="确定" /> 
</PagerTemplate> 
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource_mProject" runat="server" 
        ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
        SelectCommand="SELECT * FROM [Table_project]"></asp:SqlDataSource>
</div>
</asp:Content>


<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceLeft" runat="server">
<div id="sidebar"><a href="#" class="visible-phone"><i class="icon icon-home"></i> Dashboard</a>
  <ul>
    <li><a href="Default_GWH.aspx" onclick="javascript:addClass(this.parentNode,'active')"><i class="icon icon-inbox"></i> <span>系统首页</span></a></li>
    <li><a href="Plan_Check.aspx" onclick="javascript:addClass(this.parentNode,'active')"><i class="icon icon-inbox"></i> <span>项目审核</span></a></li>
    <li class="submenu"> <a href=""><i class="icon icon-th-list"></i> <span>项目管理</span> <span class="label label-important"></span></a>
      <ul>
        <li class="active"><a href="Plan_Management.aspx">项目查询及编辑</a></li>
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
     <div id="breadcrumb"> <a href="Default_GWH.aspx" title="回到主页" class="tip-bottom"><i class="icon-home"></i> 主页</a> <a href="">项目管理</a><a href="Plan_Management_Details.aspx" class="current">项目查询及编辑</a> </div>
  </div>
</asp:Content>
