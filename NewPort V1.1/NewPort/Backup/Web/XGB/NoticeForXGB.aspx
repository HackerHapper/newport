<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage_XGB.Master" AutoEventWireup="true" CodeBehind="NoticeForXGB.aspx.cs" Inherits="Maticsoft.Web.XGB.NoticeForXGB" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceTop" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MiddleContent" runat="server">
<div class="searchtext">
                <tr>
                    <td style="width: 80px" align="right" class="tdbg">
                         <b>关键字：</b>
                    </td> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <td class="tdbg">                       
                    <asp:TextBox ID="txtKeyword" runat="server" Height="20px" Width="265px"></asp:TextBox>
                    &nbsp;&nbsp;&nbsp;&nbsp;
                     <asp:Button class="btn btn-success" ID="btnmSearch" runat="server" Text="查询"   Width="85px" 
                    Height="30px" OnClick="btnSearch_Click">
                    </asp:Button> &nbsp;&nbsp;&nbsp;                    
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
        DataKeyNames="notice_id" DataSourceID="SqlDataSource_fProject" Width="1000px" 
        AllowPaging="True" BackColor="#CCCCCC" BorderColor="#999999"
        BorderStyle="Solid" BorderWidth="1px" CellPadding="4" CellSpacing="2" 
        ForeColor="Black" OnPageIndexChanging="gvwDesignationName_fPageIndexChanging" 
        CssClass="testGridView">
        <Columns>
            <asp:BoundField DataField="notice_id" HeaderText="通知编号" 
                SortExpression="notice_id" ReadOnly="True" />
            <asp:BoundField DataField="notice_time" HeaderText="通知发布时间" 
                SortExpression="notice_time" />
            <asp:BoundField DataField="notice_topic" HeaderText="通知主题" 
                SortExpression="notice_topic" />
                <asp:HyperLinkField HeaderText="查看详情" ControlStyle-Width="50" 
                DataNavigateUrlFields="notice_id" DataNavigateUrlFormatString="Notice_Details.aspx?id={0}"
                                Text="查看详情" ItemStyle-ForeColor="#0000CC" >
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
    <asp:SqlDataSource ID="SqlDataSource_fProject" runat="server" 
        ConnectionString="<%$ ConnectionStrings:ConnectionString %>"         
         SelectCommand="SELECT [notice_id], [notice_time], [notice_topic], [notice_content] FROM [Table_notice]"></asp:SqlDataSource>
</div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MiddleContent2" runat="server">
</asp:Content>
