<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage_XGB.Master" AutoEventWireup="true" CodeBehind="proList.aspx.cs" Inherits="Maticsoft.Web.XGB.planSearch" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceTop" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MiddleContent" runat="server">
    <div class="ddl3">
            <tr>
                     <td>
                         <b>搜索选项：</b>
                    <td>
                        <asp:DropDownList ID="DropDownList_mType" runat="server" 
                Height="28px" Width="130px" AutoPostBack="True" 
                onselectedindexchanged="DropDownList_mType_SelectedIndexChanged"  >
                            <asp:ListItem Value=" ">选择项目类型</asp:ListItem>
                            <asp:ListItem Value="港航项目"></asp:ListItem>
                            <asp:ListItem Value="集疏运项目"></asp:ListItem>
                            <asp:ListItem Value="物流园区项目"></asp:ListItem>
                            <asp:ListItem Value="其他类型"></asp:ListItem>
                        </asp:DropDownList>                                             
                    </td>&nbsp;&nbsp;
                    <td>
                        <asp:DropDownList ID="DropDownList_mState" runat="server" 
                Height="28px" Width="130px" AutoPostBack="True" 
                onselectedindexchanged="DropDownList_mState_SelectedIndexChanged"  >
                            <asp:ListItem Value=" ">选择项目状态</asp:ListItem>
                            <asp:ListItem Value="策划"></asp:ListItem>
                            <asp:ListItem Value="新开工"></asp:ListItem>
                            <asp:ListItem Value="续建项目"></asp:ListItem>
                        </asp:DropDownList>     
                    </td>&nbsp;&nbsp;
                    <td>
                        <asp:DropDownList ID="DropDownList_misCheck" runat="server" 
                Height="28px" Width="130px" AutoPostBack="True" 
                onselectedindexchanged="DropDownList_misCheck_SelectedIndexChanged" DataSourceID="SqlDataSource_JHLX" DataTextField="plan_name" DataValueField="plan_id"  >
                        </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource_JHLX" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [plan_id], [plan_name] FROM [Table_plan]"></asp:SqlDataSource>
                    </td>&nbsp;&nbsp;
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
                    </td> &nbsp;&nbsp;&nbsp;
                    <td class="tdbg">                       
                    <asp:TextBox ID="txtmKeyword" runat="server" Height="20px" Width="257px"></asp:TextBox>
                    &nbsp;&nbsp;&nbsp;
                    <asp:Button class="btn btn-success" ID="btnmSearch" runat="server" 
                    Text="查询"   Width="85px" 
                    Height="30px" onclick="btnmSearch_Click">
                    </asp:Button> 
                    </td>
                    <td class="tdbg">
                    </td>
                </tr>

                </div> <div class="gridviewPage">
                </br><asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    <asp:GridView ID="GridView_mProject" runat="server" AutoGenerateColumns="False" 
        DataKeyNames="project_id" DataSourceID="SqlDataSource_mProject" Width="1000px" 
        AllowPaging="True" BackColor="#CCCCCC" BorderColor="#999999"
        BorderStyle="Solid" BorderWidth="1px" CellPadding="4" CellSpacing="2" 
        ForeColor="Black" OnPageIndexChanging="gvwDesignationName_mPageIndexChanging" 
        CssClass="testGridView" 
            onselectedindexchanged="GridView_mProject_SelectedIndexChanged">
        <Columns>
            <asp:BoundField DataField="project_id" HeaderText="project_id" ReadOnly="True" SortExpression="project_id" />
            <asp:BoundField DataField="project_responUnit" HeaderText="project_responUnit" SortExpression="project_responUnit" />
            <asp:BoundField DataField="project_name" HeaderText="project_name" SortExpression="project_name" />
            <asp:BoundField DataField="project_owner" HeaderText="project_owner" SortExpression="project_owner" />
            <asp:BoundField DataField="project_positon" HeaderText="project_positon" SortExpression="project_positon" />
            <asp:BoundField DataField="project_type" HeaderText="project_type" SortExpression="project_type" />
            <asp:BoundField DataField="project_constrContent" HeaderText="project_constrContent" SortExpression="project_constrContent" />
            <asp:BoundField DataField="project_scale" HeaderText="project_scale" SortExpression="project_scale" />
            <asp:BoundField DataField="project_designCapacity" HeaderText="project_designCapacity" SortExpression="project_designCapacity" />
            <asp:BoundField DataField="project_designCapacityUnit" HeaderText="project_designCapacityUnit" SortExpression="project_designCapacityUnit" />
            <asp:BoundField DataField="project_designCapacityRemarks" HeaderText="project_designCapacityRemarks" SortExpression="project_designCapacityRemarks" />
            <asp:BoundField DataField="project_totalInvestment" HeaderText="project_totalInvestment" SortExpression="project_totalInvestment" />
            <asp:BoundField DataField="project_constrStartTime" HeaderText="project_constrStartTime" SortExpression="project_constrStartTime" />
            <asp:BoundField DataField="project_constrEndTime" HeaderText="project_constrEndTime" SortExpression="project_constrEndTime" />
            <asp:BoundField DataField="project_coveredArea" HeaderText="project_coveredArea" SortExpression="project_coveredArea" />
            <asp:BoundField DataField="project_state" HeaderText="project_state" SortExpression="project_state" />
            <asp:BoundField DataField="project_stateChangedTime" HeaderText="project_stateChangedTime" SortExpression="project_stateChangedTime" />
            <asp:BoundField DataField="project_check" HeaderText="project_check" SortExpression="project_check" />
            <asp:BoundField DataField="project_writer" HeaderText="project_writer" SortExpression="project_writer" />
            <asp:BoundField DataField="project_year" HeaderText="project_year" SortExpression="project_year" />
            <asp:BoundField DataField="project_class" HeaderText="project_class" SortExpression="project_class" />
            <asp:BoundField DataField="project_area" HeaderText="project_area" SortExpression="project_area" />
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
<asp:Content ID="Content3" ContentPlaceHolderID="MiddleContent2" runat="server">
</asp:Content>
