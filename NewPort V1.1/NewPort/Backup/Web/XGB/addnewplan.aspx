<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage_XGB.Master" AutoEventWireup="true" CodeBehind="addnewplan.aspx.cs" Inherits="Maticsoft.Web.XGB.addnewplan" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceTop" runat="server">


    <script language="javascript" type="text/javascript" src="My97DatePicker/WdatePicker.js"></script>
    <style>
        .row
        {
            position:relative;
            margin-left:90px;
            top: 60px;
            left: 0px;
            width: 200px;
        }
        .row2
        {
            position:absolute;
            margin-left:90px;
            margin-top:0px;
            top: 86px;
            left: 215px;
            height: 475px;
            width: 375px;
        }
        .fontstyle
        {
            color: #0000FF; 
        }
    </style>

    <div class="row">

  <div class="eightcol last">

    <!-- Begin Form -->


           <div><label class="fontstyle">项目编号：</label><asp:Label ID="lbl_number" runat="server" Text=""></asp:Label></div>
                    <div><label class="fontstyle">项目地点：</label><asp:TextBox ID="txtAddress" runat="server" Height="16px"></asp:TextBox></div>
          <div><label class="fontstyle">项目名称：</label><asp:TextBox ID="txtName" runat="server" Height="16px"></asp:TextBox></div>
         <div><label class="fontstyle">项目类型：</label>
          <asp:DropDownList ID="DDL_PlayType" runat="server" Height="27px" Width="183px">
        <asp:ListItem Value=""  class="fontstyle">项目类型</asp:ListItem>
                            <asp:ListItem Value="港航项目">港航项目</asp:ListItem>
                            <asp:ListItem Value="集疏运项目">集疏运项目</asp:ListItem>
                            <asp:ListItem Value="物流园区项目">物流园区项目</asp:ListItem>
                            <asp:ListItem Value="其他类型">其他类型</asp:ListItem>
        </asp:DropDownList>
          </div>
          <div><label class="fontstyle">业主单位：</label><asp:TextBox ID="txtOwner" runat="server" Height="16px"></asp:TextBox></div>
          <div><label class="fontstyle">总投资：</label><asp:TextBox ID="txtTotal" runat="server" Height="16px" Width="73px"></asp:TextBox>&nbsp 万元</div>
          <div><label class="fontstyle">建设内容：</label><textarea ID="txtA2" runat="server"></textarea></div>

        </section>


      <div>
          <asp:Button ID="btnSubmit" runat="server" Text="提交" onclick="btnSubmit_Click" 
              class="btn btn-success" Width="100px"/>
        
      </div>


  </div>

</div>

 <div class="row2">

  <div class="eightcol last">

    <!-- Begin Form -->

    <form id="Form1">
    <section name="第一步">
     <div><label class="fontstyle">申请年度：</label>
          <asp:DropDownList ID="DDL_Year" runat="server" Height="27px" Width="183px">
        <asp:ListItem Value=" "  class="fontstyle">年份</asp:ListItem>
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
          </div>       
          <div><label class="fontstyle">所在城市：</label><asp:TextBox ID="txtArea" runat="server" Height="16px"></asp:TextBox></div>
          <div><label class="fontstyle">计划类别：</label>
          <asp:DropDownList ID="DropDownList_PlanType" runat="server" Height="27px" Width="183px">
        <asp:ListItem Value=" "  class="fontstyle">选择计划类别</asp:ListItem>
                            <asp:ListItem Value="武汉新港建设项目">武汉新港建设项目</asp:ListItem>
                            <asp:ListItem Value="临港经济新区">临港经济新区</asp:ListItem>
                            <asp:ListItem Value="航运中心项目">航运中心项目</asp:ListItem>
                            <asp:ListItem Value="“十三五”期间项目">“十三五”期间项目</asp:ListItem>
        </asp:DropDownList>
          </div>
          <div><label class="fontstyle">设计能力：</label> 
          <asp:TextBox ID="txtCapacity" runat="server" Height="16px" Width="73px" ></asp:TextBox>
          &nbsp单位：
          <asp:TextBox ID="txtUnit" runat="server" Height="16px" Width="34px"></asp:TextBox></div>
          <div><label class="fontstyle">岸线：</label><asp:TextBox ID="txtCoast" runat="server" Height="16px"></asp:TextBox></div>
          <div><label class="fontstyle">建设起止时间：</label><input class="Wdate" id="input1" height="12px" width="12px" type="text" onClick="WdatePicker()" runat="server"> <font color=red></font></input> 至<input class="Wdate" id="input2" height="12px" width="12px" type="text" onClick="WdatePicker()" runat="server"> <font color=red></font></input></div>
          <div><label class="fontstyle">备注：</label><textarea ID="txtA3" runat="server"></textarea></div>
          
          
        </section>
    </form>
    </div>
    </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MiddleContent2" runat="server" >
    


</asp:Content>