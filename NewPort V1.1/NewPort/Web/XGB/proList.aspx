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
                    <!--<td>
                        <asp:DropDownList ID="DropDownList_misCheck" runat="server" 
                Height="28px" Width="130px" AutoPostBack="True" 
                onselectedindexchanged="DropDownList_misCheck_SelectedIndexChanged" DataSourceID="SqlDataSource_JHLX" DataTextField="plan_name" DataValueField="plan_id"  >
                        </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource_JHLX" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [plan_id], [plan_name] FROM [Table_plan]"></asp:SqlDataSource>
                    </td>&nbsp;&nbsp;-->
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
                </br>
    <asp:GridView ID="GridView_mProject" runat="server" AutoGenerateColumns="False" 
        DataKeyNames="project_id" DataSourceID="SqlDataSource_mProject" Width="1000px" 
        AllowPaging="True" BackColor="#CCCCCC" BorderColor="#999999"
        BorderStyle="Solid" BorderWidth="1px" CellPadding="4" CellSpacing="2" 
        ForeColor="Black" OnPageIndexChanging="gvwDesignationName_mPageIndexChanging" 
        CssClass="testGridView" 
            onselectedindexchanged="GridView_mProject_SelectedIndexChanged">
        <Columns>
            <asp:BoundField DataField="project_id" HeaderText="项目编号" ReadOnly="True" SortExpression="project_id" />
            <asp:BoundField DataField="project_name" HeaderText="项目名称" SortExpression="project_name" />
            <asp:BoundField DataField="project_positon" HeaderText="项目地点" SortExpression="project_positon" />
            <asp:BoundField DataField="project_type" HeaderText="项目类型" SortExpression="project_type" />
            <asp:BoundField DataField="project_state" HeaderText="项目状态" SortExpression="project_state" />
            <asp:HyperLinkField HeaderText="查看详情" ControlStyle-Width="50" 
                DataNavigateUrlFields="project_id" DataNavigateUrlFormatString="proDetail.aspx?id={0}"
                                Text="详情" ItemStyle-ForeColor="#0000CC" >
<ControlStyle Width="50px" ForeColor="Blue"></ControlStyle><ItemStyle ForeColor="#0000CC"></ItemStyle></asp:HyperLinkField>

            <asp:HyperLinkField HeaderText="月度反馈" ControlStyle-Width="50" 
                DataNavigateUrlFields="project_id" DataNavigateUrlFormatString="monthList.aspx?id={0}"
                                Text="月度信息" ItemStyle-ForeColor="#0000CC" >
<ControlStyle Width="50px" ForeColor="Blue"></ControlStyle><ItemStyle ForeColor="#0000CC"></ItemStyle></asp:HyperLinkField>

            <asp:HyperLinkField HeaderText="资金支持" ControlStyle-Width="50" 
                DataNavigateUrlFields="project_id" DataNavigateUrlFormatString="proDetail.aspx?id={0}"
                                Text="支持详情" ItemStyle-ForeColor="#0000CC" >
<ControlStyle Width="50px" ForeColor="Blue"></ControlStyle><ItemStyle ForeColor="#0000CC"></ItemStyle></asp:HyperLinkField>
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
