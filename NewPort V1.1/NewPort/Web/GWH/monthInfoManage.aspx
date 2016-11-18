<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage_GWH.master" AutoEventWireup="true" CodeBehind="monthInfoManage.aspx.cs" Inherits="Maticsoft.Web.GWH.monthInfoManage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceTop" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MiddleContent" runat="server">
    <div class="searchtext" style="width: 300px; left: 0px; position: absolute; border-right-style: dashed; border-right-width: thin; border-right-color: #C0C0C0;">
                <ul>
                    <li style="width: 80px"  class="tdbg">
                         <b>选择项目：</b>                     
                   
                        <asp:ScriptManager ID="ScriptManager1" runat="server" > 
                        </asp:ScriptManager> 
                        <asp:UpdatePanel ID="UpdatePanel1" runat="server" ChildrenAsTriggers="True" RenderMode="Block" > 
                        <ContentTemplate> 
                              <asp:dropdownlist ID="ddlist_pro" runat="server" Height="51px" Width="250px" AutoPostBack="true" DataSourceID="SqlDataSource_Project" DataTextField="project_idAndName" DataValueField="project_id" OnSelectedIndexChanged="ddlist_pro_selectChange"></asp:dropdownlist>
                              或者输入ID：
                             <asp:TextBox ID="tbox_pro" runat="server" Height="20px" Width="240px" TextMode="singleline" Text="或者在这里输入ID"></asp:TextBox>
                        </ContentTemplate> 
                        <Triggers > 
                        <asp:AsyncPostBackTrigger ControlID="tbox_pro" /> 
                        <asp:PostBackTrigger   ControlID="ddlist_pro"/>                    
                        </Triggers> 
                        </asp:UpdatePanel>
                        
                        <asp:Button class="btn btn-success" ID="btnSearchByPro" runat="server" Text="按项目查询"   Width="103px" 
                    Height="30px" OnClick="btnSearch_Click" >
                    </asp:Button> &nbsp;&nbsp;&nbsp;
                    </li>
                   
                    
                   <li style="width: 80px"  class="tdbg">
                         <b>选择年月：</b>
                       <asp:TextBox ID="tbox_month" runat="server" Height="20px" Width="240px" TextMode="SingleLine"></asp:TextBox>
                    &nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button class="btn btn-success" ID="btnSearchByMonth" runat="server" Text="按月份查询"   Width="102px" 
                    Height="30px" OnClick="btnSearch_ClickbyMonth" >
                        </asp:Button> &nbsp;&nbsp;&nbsp;
                    </li>
                  
                </ul>
    </div>
   <!--Search end-->
      <!--DropdownList的数据源-->
     <asp:SqlDataSource ID="SqlDataSource_Project" runat="server" 
        ConnectionString="<%$ ConnectionStrings:wuhanNewPort_ppdmsConnectionString %>" 
        SelectCommand="SELECT [project_id], [project_name],([project_id]+'：'+[project_name]) as project_idAndName FROM [Table_project]"></asp:SqlDataSource>     
            
 <div class="gridviewPage" style="border: 0px dashed #000000; width: 650px; left:350px; top:0px;position: absolute">
    <asp:GridView ID="GVbyPro" runat="server" AutoGenerateColumns="False" 
        DataKeyNames="monthlyFeedback_sn" Width="650px" 
        AllowPaging="True" BackColor="#CCCCCC" BorderColor="#999999"
        BorderStyle="Solid" BorderWidth="1px" CellPadding="4" CellSpacing="2" 
        ForeColor="Black" OnPageIndexChanging="gvwDesignationName_PageIndexChanging" 
        CssClass="testGridView" AllowSorting="True">
        <Columns>
            <asp:BoundField HeaderText="序列号" DataField="monthlyFeedback_sn" >
            <ItemStyle Width="50px" />
            </asp:BoundField>
            <asp:BoundField HeaderText="所属年月" DataField="monthlyFeedback_yyyyMM" DataFormatString="{0:D} " >
            <ItemStyle Width="100px" ForeColor="Red" />
            </asp:BoundField>
            <asp:BoundField HeaderText="本月完成投资" DataField="monthlyFeedback_fulfilment" />
            <asp:BoundField HeaderText="本月完成工程形象进度" DataField="monthlyFeedback_fulfilmentDescription" />
                <asp:BoundField DataField="monthlyFeedback_writer" HeaderText="责任单位" />
                <asp:ButtonField HeaderText="编辑" Text="按钮" ><ItemStyle /></asp:ButtonField>
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
  
    <asp:GridView ID="GVbyMonth" runat="server" AutoGenerateColumns="False" 
        DataKeyNames="monthlyFeedback_sn" Width="650px" 
        AllowPaging="True" BackColor="#CCCCCC" BorderColor="#999999"
        BorderStyle="Solid" BorderWidth="1px" CellPadding="4" CellSpacing="2" 
        ForeColor="Black" OnPageIndexChanging="gvwDesignationName_PageIndexChanging" 
        CssClass="testGridView">
        <Columns>
            <asp:TemplateField HeaderText="序号" InsertVisible="False"> 
                <ItemTemplate> 
                <%#Container.DataItemIndex+1%> 
                </ItemTemplate> 
                </asp:TemplateField> 
            <asp:BoundField HeaderText="项目ID" DataField="project_id" />
            <asp:BoundField DataField="monthlyFeedback_yyyyMM" HeaderText="所属年月" 
                SortExpression="monthlyFeedback_yyyyMM" DataFormatString="{0:D} " />
            <asp:BoundField DataField="monthlyFeedback_fulfilment" HeaderText="本月完成投资" 
                SortExpression="monthlyFeedback_fulfilment" />
            <asp:BoundField DataField="monthlyFeedback_fulfilmentDescription" HeaderText="本月完成工程形象进度" 
                SortExpression="monthlyFeedback_fulfilmentDescription" />
                <asp:ButtonField HeaderText="编辑" Text="按钮" />
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
</div>


</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MiddleContent2" runat="server">
</asp:Content>
