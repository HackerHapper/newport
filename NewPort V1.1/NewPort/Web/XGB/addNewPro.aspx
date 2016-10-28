<%@ Page Title="新港项目管理-添加项目" Language="C#" MasterPageFile="~/MasterPage_XGB.Master" AutoEventWireup="true" CodeBehind="addNewPro.aspx.cs" Inherits="Maticsoft.Web.XGB.addNewPro" %>





<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceTop" runat="server">
 
 <div class="container-fluid"><hr/>
    
    <div class="row-fluid">
      <div class="span12 ">
        <div class="widget-box">
              <div class="widget-title"> <span class="icon"> <i class="icon-info-sign"></i> </span>
                 <h5>添加新项目</h5>
              </div>
          <div class="widget-content">
          
           <table style="margin:5px">           
               <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePartialRendering="true"></asp:ScriptManager>  
               <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Always">
                   <ContentTemplate>

               <tr style="margin:5px">
                     <td>
                    <label class="control-label"><span class="trbold">项目编号：</span></label>
                   <asp:Label ID="number" runat="server" Text="项目编号由系统自动生成" ForeColor="Red"></asp:Label>
                     </td>
                     <td >
                    <label class="control-label"><span class="trbold">项目名称：</span></label>   
                    <asp:TextBox ID="proName" runat="server" class="span11" Width="200px"></asp:TextBox>
                 </td>
                 </tr>
                 <tr style="margin:5px">
                     <td>
                    <label class="control-label"><span class="trbold">项目类型：</span></label>      
                    <asp:dropdownlist ID="proClass" runat="server" class="select2-container" OnSelectedIndexChanged="proClass_SelectedIndexChanged" AutoPostBack="True">
                        <asp:ListItem>未选择</asp:ListItem>
                        <asp:ListItem Value="01">港航项目</asp:ListItem>
                        <asp:ListItem Value="02">集疏运项目</asp:ListItem>
                        <asp:ListItem Value="03">临港产业项目</asp:ListItem>            
                        <asp:ListItem Value="99">其他项目</asp:ListItem>
                         </asp:dropdownlist>
                 </td>
                      <td >
                    <label class="control-label"><span class="trbold">业主单位：</span></label>   
                    <asp:TextBox ID="proHost" runat="server" class="span11" Width="200px"></asp:TextBox>

                 </td>
                 </tr>
             </ContentTemplate>
        </asp:UpdatePanel>


                  <tr style="margin:5px">
                     <td>
                    <label class="control-label"><span class="trbold">项目地点：</span></label>      
                    <asp:Textbox ID="proPlace" runat="server" class="span11" Width="200px"></asp:Textbox>
                 </td>
                      <td >
                    <label class="control-label"><span class="trbold">设计能力：</span></label>   
                    <asp:TextBox ID="capacity" runat="server" class="span11" Width="120px"></asp:TextBox><asp:dropdownlist ID="capacityUnit" runat="server" class="span11" Width="80px">
                              <asp:ListItem>TEU</asp:ListItem>
                              <asp:ListItem>T</asp:ListItem>
                          </asp:dropdownlist>
                 </td>
                 </tr>
                   <tr style="margin:5px">
                     <td>
                    <label class="control-label"><span class="trbold">岸线：</span></label>      
                    <asp:Textbox ID="scale" runat="server" class="span11" Width="200px"></asp:Textbox>
                         <label class="control-label"><span class="trbold">占地：</span></label>      
                    <asp:Textbox ID="coverdArea" runat="server" class="span11" Width="200px"></asp:Textbox>
                 </td>
                      <td >
                    <label class="control-label"><span class="trbold">总投资：</span></label>   
                    <asp:TextBox ID="totalFund" runat="server" class="span11" Width="200px"></asp:TextBox>
                 </td>
                 </tr>
                   <tr style="margin:5px" >
                     <td>
                    <label class="control-label"><span class="trbold">建设起始年度：</span></label>      
                    <asp:Textbox ID="start" runat="server" class="datepicker span11" Width="200px" TextMode="Date"></asp:Textbox>
                 </td>
                      <td >
                    <label class="control-label"><span class="trbold">建设终止年度：</span></label>   
                    <asp:TextBox ID="end" runat="server" class="datepicker span11" Width="200px" TextMode="Date"></asp:TextBox>
                 </td>
                 </tr>
                   <tr style="margin:5px" >
                     <td>
                    <label class="control-label"><span class="trbold">前期工作情况：</span></label>      
                    <asp:Textbox ID="earlierStage" runat="server" class="datepicker span11" Width="200px" TextMode="MultiLine" Height="150"></asp:Textbox>
                 </td>
                      <td >
                    <label class="control-label"><span class="trbold">建设内容：</span></label>   
                    <asp:TextBox ID="content" runat="server" class="datepicker span11" Width="200px" TextMode="MultiLine" Height="150"></asp:TextBox>
                 </td>
                 </tr>
              </table>

         
          </div>
        </div>
      </div>
    </div>



        <div class="widget-box">
          <div class="widget-title"> <span class="icon"> <i class="icon-info-sign"></i> </span>
            <h5>上传附件</h5>
          </div>
        <div class="widget-content nopadding">
          <asp:UpdatePanel ID="UpdatePanel2" runat="server">
           <ContentTemplate>
            <div style="border-style: dashed; border-color: inherit; border-width: 1px; width:500px; height:150px; position:inherit;right:-4px; top: 44px;"> <b>附件预览</b>
               <asp:Label ID="Label1" runat="server" Text="0"></asp:Label>
               <div id="fujianliebiao" runat="server"></div>
            </div>
         </ContentTemplate>
          
      </asp:UpdatePanel>

              <div class="control-group">
                <ul>

                  <li><asp:FileUpload ID="FileUpload1" runat="server" /></li>
                  <li> <asp:Button ID="upload" runat="server" Text="上传" OnClick="upload_Click" /></li>
                </ul>      
              </div>
              
    
     </div> 
            

          </div>   
   
     
  <p style="text-align: center"><asp:Button ID="Button1" runat="server" Text="保存信息到数据库" class="btn-primary" OnClick="Button1_Click"/><asp:Button ID="Button2" runat="server" Text="批量导入到数据库（不含附件）" class="btn"/></p>
    
</div>


</asp:Content>
