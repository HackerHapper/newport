<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage_XGB.Master" AutoEventWireup="true" CodeBehind="planHistoryList.aspx.cs" Inherits="Maticsoft.Web.XGB.planHistoryList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceTop" runat="server">
   

         &nbsp;&nbsp;计划类型<asp:DropDownList ID="planClass" runat="server" AutoPostBack="True" OnSelectedIndexChanged="planClass_SelectedIndexChanged" AppendDataBoundItems="True" ViewStateMode="Enabled" DataSourceID="SqlDataSource1" DataTextField="plan_name" DataValueField="plan_id">
        </asp:DropDownList> 
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT rtrim([plan_id]) as plan_id, [plan_name] FROM [Table_plan]"></asp:SqlDataSource>
        <span style="width:50px;"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</span>
    计划申报年度<asp:DropDownList ID="planYear" runat="server" AutoPostBack="True" OnSelectedIndexChanged="planYear_SelectedIndexChanged"></asp:DropDownList>

    <hr />


    <h3><asp:Label ID="unit" runat="server" Text="XXXX"></asp:Label><asp:Label ID="showYear" runat="server" Text="XXXX"></asp:Label>年
        <asp:Label ID="showClass" runat="server" Text="XXXX"></asp:Label>&nbsp;列表</h3>
     <div>

         <asp:GridView ID="planList" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="annualPlan_sn" DataSourceID="SqlDataSource2" ForeColor="#333333" GridLines="None">
             <AlternatingRowStyle BackColor="White" />
             <Columns>
                 <asp:BoundField DataField="annualPlan_sn" HeaderText="流水号" ReadOnly="True" SortExpression="annualPlan_sn" />
                 <asp:BoundField DataField="project_id" HeaderText="项目ID" SortExpression="project_id" />
                 <asp:BoundField DataField="plan_id" HeaderText="计划类型ID" SortExpression="plan_id" />
                 <asp:BoundField DataField="annualPlan_targetCompletion" HeaderText="年度计划目标" SortExpression="annualPlan_targetCompletion" />
                 <asp:BoundField DataField="annualPlan_targetDescription" HeaderText="年度工程形象进度目标" SortExpression="annualPlan_targetDescription" />
                 <asp:BoundField DataField="annualPlan_earlyProgress" HeaderText="前期进展情况" SortExpression="annualPlan_earlyProgress" />
                 <asp:BoundField DataField="annualPlan_checkState" HeaderText="审核状态" SortExpression="annualPlan_checkState" />
                 <asp:BoundField DataField="planYear" HeaderText="计划年度" SortExpression="planYear" />
             </Columns>
             <EditRowStyle BackColor="#2461BF" />
             <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
             <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
             <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
             <RowStyle BackColor="#EFF3FB" />
             <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
             <SortedAscendingCellStyle BackColor="#F5F7FB" />
             <SortedAscendingHeaderStyle BackColor="#6D95E1" />
             <SortedDescendingCellStyle BackColor="#E9EBEF" />
             <SortedDescendingHeaderStyle BackColor="#4870BE" />
         </asp:GridView>


         <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM Table_annualPlan where planYear=@py and plan_id=@pid and project_id in (select project_id from Table_project WHERE [project_responUnit]=@PRU )">
             <SelectParameters>
                 <asp:QueryStringParameter Name="py" QueryStringField="py" />
                 <asp:QueryStringParameter Name="pid" QueryStringField="pc" />
                 <asp:SessionParameter Name="PRU" SessionField="dept" />
             </SelectParameters>
         </asp:SqlDataSource>


     </div>

 

</asp:Content>
