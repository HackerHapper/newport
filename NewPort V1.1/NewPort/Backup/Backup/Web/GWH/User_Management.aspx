﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage_GWH.master" AutoEventWireup="true" CodeBehind="User_Management.aspx.cs" Inherits="Maticsoft.Web.GWH.User_Management" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
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
                     <asp:Button class="btn btn-success" ID="btnSearch" runat="server" Text="查询"   Width="85px" 
                    Height="30px" OnClick="btnSearch_Click">
                    </asp:Button> &nbsp;&nbsp;&nbsp;
                     <asp:Button class="btn btn-success" ID="btnAdd" runat="server" Text="添加新用户"   Width="100px" 
                    Height="30px" OnClick="btnAdd_Click">
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
    <asp:GridView ID="GridView_Project" runat="server" AutoGenerateColumns="False" 
        DataKeyNames="user_id" DataSourceID="SqlDataSource_Project" Width="1000px" 
        AllowPaging="True" BackColor="#CCCCCC" BorderColor="#999999"
        BorderStyle="Solid" BorderWidth="1px" CellPadding="4" CellSpacing="2" 
        ForeColor="Black" OnPageIndexChanging="gvwDesignationName_PageIndexChanging" 
        CssClass="testGridView">
        <Columns>
            <asp:BoundField DataField="user_id" HeaderText="账号" 
                SortExpression="user_id" ReadOnly="True" />
            <asp:BoundField DataField="user_name" HeaderText="账户名称" 
                SortExpression="user_name" />
            <asp:BoundField DataField="user_dept" HeaderText="所属部门" 
                SortExpression="user_dept" />
            <asp:BoundField DataField="user_liablePerson" HeaderText="责任人" 
                SortExpression="user_liablePerson" />
            <asp:BoundField DataField="user_contacterInfo" HeaderText="责任人联系方式" 
                SortExpression="user_contacterInfo" />
            <asp:BoundField DataField="user_password" HeaderText="密码" 
                SortExpression="user_password" />  
            <asp:HyperLinkField HeaderText="项目编辑" ControlStyle-Width="50" 
                DataNavigateUrlFields="user_id" DataNavigateUrlFormatString="UserDetails.aspx?id={0}"
                                Text="编辑" ItemStyle-ForeColor="#0000CC" >
<ControlStyle Width="50px" ForeColor="Blue"></ControlStyle><ItemStyle ForeColor="#0000CC"></ItemStyle></asp:HyperLinkField>
            
            <asp:HyperLinkField HeaderText="删除" ControlStyle-Width="50" 
                DataNavigateUrlFields="user_id" DataNavigateUrlFormatString="User_Management.aspx?id={0}"
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
    <asp:SqlDataSource ID="SqlDataSource_Project" runat="server" 
        ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
        SelectCommand="SELECT * FROM [Table_user]" 
         ConflictDetection="CompareAllValues" 
         DeleteCommand="DELETE FROM [Table_user] WHERE [user_id] = @original_user_id AND (([user_name] = @original_user_name) OR ([user_name] IS NULL AND @original_user_name IS NULL)) AND (([user_dept] = @original_user_dept) OR ([user_dept] IS NULL AND @original_user_dept IS NULL)) AND (([user_liablePerson] = @original_user_liablePerson) OR ([user_liablePerson] IS NULL AND @original_user_liablePerson IS NULL)) AND (([user_contacterInfo] = @original_user_contacterInfo) OR ([user_contacterInfo] IS NULL AND @original_user_contacterInfo IS NULL)) AND (([user_authority] = @original_user_authority) OR ([user_authority] IS NULL AND @original_user_authority IS NULL)) AND (([user_password] = @original_user_password) OR ([user_password] IS NULL AND @original_user_password IS NULL))" 
         InsertCommand="INSERT INTO [Table_user] ([user_id], [user_name], [user_dept], [user_liablePerson], [user_contacterInfo], [user_authority], [user_password]) VALUES (@user_id, @user_name, @user_dept, @user_liablePerson, @user_contacterInfo, @user_authority, @user_password)" 
         OldValuesParameterFormatString="original_{0}" 
         UpdateCommand="UPDATE [Table_user] SET [user_name] = @user_name, [user_dept] = @user_dept, [user_liablePerson] = @user_liablePerson, [user_contacterInfo] = @user_contacterInfo, [user_authority] = @user_authority, [user_password] = @user_password WHERE [user_id] = @original_user_id AND (([user_name] = @original_user_name) OR ([user_name] IS NULL AND @original_user_name IS NULL)) AND (([user_dept] = @original_user_dept) OR ([user_dept] IS NULL AND @original_user_dept IS NULL)) AND (([user_liablePerson] = @original_user_liablePerson) OR ([user_liablePerson] IS NULL AND @original_user_liablePerson IS NULL)) AND (([user_contacterInfo] = @original_user_contacterInfo) OR ([user_contacterInfo] IS NULL AND @original_user_contacterInfo IS NULL)) AND (([user_authority] = @original_user_authority) OR ([user_authority] IS NULL AND @original_user_authority IS NULL)) AND (([user_password] = @original_user_password) OR ([user_password] IS NULL AND @original_user_password IS NULL))">
        <DeleteParameters>
            <asp:Parameter Name="original_user_id" Type="String" />
            <asp:Parameter Name="original_user_name" Type="String" />
            <asp:Parameter Name="original_user_dept" Type="String" />
            <asp:Parameter Name="original_user_liablePerson" Type="String" />
            <asp:Parameter Name="original_user_contacterInfo" Type="String" />
            <asp:Parameter Name="original_user_authority" Type="Int32" />
            <asp:Parameter Name="original_user_password" Type="String" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="user_id" Type="String" />
            <asp:Parameter Name="user_name" Type="String" />
            <asp:Parameter Name="user_dept" Type="String" />
            <asp:Parameter Name="user_liablePerson" Type="String" />
            <asp:Parameter Name="user_contacterInfo" Type="String" />
            <asp:Parameter Name="user_authority" Type="Int32" />
            <asp:Parameter Name="user_password" Type="String" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="user_name" Type="String" />
            <asp:Parameter Name="user_dept" Type="String" />
            <asp:Parameter Name="user_liablePerson" Type="String" />
            <asp:Parameter Name="user_contacterInfo" Type="String" />
            <asp:Parameter Name="user_authority" Type="Int32" />
            <asp:Parameter Name="user_password" Type="String" />
            <asp:Parameter Name="original_user_id" Type="String" />
            <asp:Parameter Name="original_user_name" Type="String" />
            <asp:Parameter Name="original_user_dept" Type="String" />
            <asp:Parameter Name="original_user_liablePerson" Type="String" />
            <asp:Parameter Name="original_user_contacterInfo" Type="String" />
            <asp:Parameter Name="original_user_authority" Type="Int32" />
            <asp:Parameter Name="original_user_password" Type="String" />
        </UpdateParameters>
     </asp:SqlDataSource>
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
        <li class="active"><a href="User_Management.aspx">用户管理</a></li>
      </ul>
    </li>
  </ul>
</div>
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceTop" runat="server">
  <div id="content-header">
     <div id="breadcrumb"> <a href="Default_GWH.aspx" title="回到主页" class="tip-bottom"><i class="icon-home"></i> 主页</a> <a href="">系统维护</a><a href="User_Management.aspx" class="current">用户管理</a> </div>
  </div>
</asp:Content>
