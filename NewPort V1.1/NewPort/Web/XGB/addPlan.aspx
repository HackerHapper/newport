<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage_XGB.Master" AutoEventWireup="true" CodeBehind="addPlan.aspx.cs" Inherits="Maticsoft.Web.XGB.addnewplan" %>



<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceTop" runat="server">

   
<div class="container-fluid"> 
    
    <p style="text-align:center;"><H4 style="text-align:center;">计划申报</H4></p>
    <hr/>  


        <div class="widget-box">
              <div class="widget-title"> <span class="icon"> <i class="icon-info-sign"></i> </span>
                 <h5>计划信息</h5>
              </div>
          <div class="widget-content">
          
           <table>           
                
                 <tr>
                     <td>
                    <span class="trbold">计划类型：</span>
                    <span class="trbold"> <asp:dropdownlist ID="planClass" runat="server" class="select2-container" DataSourceID="SqlDataSource1" DataTextField="plan_name" DataValueField="plan_id" OnSelectedIndexChanged="planClass_SelectedIndexChanged" AutoPostBack="True">
                             <asp:ListItem>未选择</asp:ListItem>
                         </asp:dropdownlist>
                         <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [plan_id], [plan_name] FROM [Table_plan]"></asp:SqlDataSource>
                         </span>
                 </td>
                      <td >
                    <span class="trbold">计划年度：</span>
                    <span class="trbold"><asp:dropdownlist ID="planYear" runat="server" class="select2-container" OnSelectedIndexChanged="planYear_SelectedIndexChanged" AutoPostBack="True"></asp:dropdownlist></span>
                 </td>
                 <td>
                      <asp:button ID="checkInfo" runat="server" class="btn-primary" Text="查看已提交计划" OnClick="checkInfo_Click"></asp:button>
                 </td>
                      </tr>
                
               
                   
              </table>      
              
          </div>
        </div>
  
<asp:ScriptManager ID="ScriptManager1" runat="server" EnablePartialRendering="true"></asp:ScriptManager>
<!--<asp:UpdatePanel ID="chooseItem" runat="server" UpdateMode="Conditional" ChildrenAsTriggers="true"><ContentTemplate> -->
     <div class="widget-box">
    
              <div class="widget-title"> <span class="icon"> <i class="icon-info-sign"></i> </span>
                 <h5>选择项目到计划</h5>
              </div>
      <div class="widget-content" style="height:150px" >

             <div style="position:absolute; left: 0px; top:50px;height:150px"><asp:ListBox ID="toAddList" runat="server" Width="400px" Height="130px" DataSourceID="SqlDataSource_currentUserPro" DataTextField="idname" DataValueField="project_id" SelectionMode="Multiple"></asp:ListBox>
                 <asp:SqlDataSource ID="SqlDataSource_currentUserPro" runat="server"  ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT *,(project_id + project_name) as idname FROM [Table_project] WHERE ([project_responUnit] = @project_responUnit) and (project_id not in (select project_id from Table_annualPlan where planYear=@planYear and plan_id=@planClass))" CancelSelectOnNullParameter="False">
                     <SelectParameters>
                         <asp:SessionParameter Name="project_responUnit" SessionField="dept" Type="String" />
                         <asp:ControlParameter ControlID="planYear" DefaultValue="" Name="planYear" PropertyName="SelectedValue" Type="String" />
                         <asp:ControlParameter ControlID="planClass" DefaultValue="" Name="planClass" PropertyName="SelectedValue" Type="String" />
                     </SelectParameters>
                 </asp:SqlDataSource>
              </div>
             <div style="position:absolute; top:80px; left:500px; z-index:10000">
              <asp:Button ID="Button2" runat="server" Text="添加到计划列表>>" class="btn-primary" OnClick="Button2_Click"/><br /><br />
              <asp:Button ID="Button3" runat="server" Text="<<从计划列表删除" class="btn-primary" OnClick="Button3_Click"/>
             </div>

              <div style="position:absolute; right: 50px; top:50px"><asp:ListBox ID="addedList" runat="server" Width="400px" Height="130px" SelectionMode="Multiple">
              </asp:ListBox></div>
          </div>
        </div>
  
     <div class="widget-box">
              <div class="widget-title"> <span class="icon"> <i class="icon-info-sign"></i> </span>
                 <h5>拟上报的计划项目列表</h5>
              </div>
          <div class="widget-content">
          
              <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Width="100%" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="project_id" DataSourceID="SqlDataSource_currentUserPro">
                  <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                  <Columns>
                      <asp:BoundField DataField="project_id" HeaderText="项目ID" ReadOnly="True" SortExpression="project_id" />
                      <asp:BoundField DataField="project_name" HeaderText="项目名称" SortExpression="project_name" />
                      <asp:BoundField DataField="project_responUnit" HeaderText="管理单位" SortExpression="project_responUnit" />
                      <asp:BoundField DataField="project_owner" HeaderText="业主单位" SortExpression="project_owner" />
                      <asp:BoundField DataField="project_positon" HeaderText="项目地点" SortExpression="project_positon" />
                      <asp:BoundField DataField="project_type" HeaderText="项目类型" SortExpression="project_type" />
                      <asp:BoundField DataField="project_constrContent" HeaderText="建设内容" SortExpression="project_constrContent" />
                      <asp:BoundField DataField="project_scale" HeaderText="岸线/里程(km)" SortExpression="project_scale" />
                      <asp:BoundField DataField="project_designCapacity" HeaderText="设计能力" SortExpression="project_designCapacity" />
                      <asp:BoundField DataField="project_designCapacityUnit" HeaderText="设计能力单位" SortExpression="project_designCapacityUnit" />
                      <asp:BoundField DataField="project_totalInvestment" HeaderText="总投资" SortExpression="project_totalInvestment" />
                      <asp:BoundField DataField="project_constrStartTime" DataFormatString="{0:yyyy-MM}" HeaderText="建设起始" SortExpression="project_constrStartTime" />
                      <asp:BoundField DataField="project_constrEndTime" DataFormatString="{0:yyyy-MM}" HeaderText="建设终止" SortExpression="project_constrEndTime" />
                      <asp:BoundField DataField="project_coveredArea" HeaderText="项目占地" SortExpression="project_coveredArea" />
                      <asp:BoundField DataField="project_state" HeaderText="项目状态" SortExpression="project_state" />
                      <asp:TemplateField HeaderText="前期进展">
                          <ItemTemplate>
                              <asp:TextBox ID="earlyProgress" runat="server" TextMode="MultiLine" Width="80px"></asp:TextBox>
                          </ItemTemplate>
                      </asp:TemplateField>
                      <asp:TemplateField HeaderText="本年度计划完成投资">
                          <ItemTemplate>
                              <asp:TextBox ID="thisPlanInvestment" runat="server" Width="50px"></asp:TextBox>
                          </ItemTemplate>
                      </asp:TemplateField>
                      <asp:TemplateField HeaderText="本年度计划形象进度">
                          <ItemTemplate>
                              <asp:TextBox ID="thisPlanProgress" runat="server" Width="80px" TextMode="MultiLine"></asp:TextBox>
                          </ItemTemplate>
                      </asp:TemplateField>
                  </Columns>
                  <EditRowStyle BackColor="#999999" />
                  <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                  <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                  <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                  <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                  <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                  <SortedAscendingCellStyle BackColor="#E9E7E2" />
                  <SortedAscendingHeaderStyle BackColor="#506C8C" />
                  <SortedDescendingCellStyle BackColor="#FFFDF8" />
                  <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
              </asp:GridView>
              

        <p style="text-align:center"> <asp:Button ID="save" runat="server" Text="提交计划到管委会" class="btn-primary" OnClick="save_Click"/></p>
          </div>
        </div>

<!--</ContentTemplate>
    <Triggers> 
        <asp:AsyncPostBackTrigger ControlID="planClass"   EventName="SelectedIndexChanged" /> 
        <asp:AsyncPostBackTrigger ControlID="planYear"   EventName="SelectedIndexChanged" /> 
    </Triggers>
</asp:UpdatePanel> -->

</div>

   
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="MiddleContent2" runat="server" >
    


</asp:Content>