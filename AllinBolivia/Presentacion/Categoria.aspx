<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Site.Master" AutoEventWireup="true" CodeBehind="Categoria.aspx.cs" Inherits="AllinBolivia.Presentacion.Categoria" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .auto-style1 {        margin-left: 200px;
    }
        .auto-style2 {
            width: 141px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">



    <table width="1170" border="0" align="center" cellpadding="0" cellspacing="0" bgcolor="#ebebeb">
  <tr>
    <td valign="top" class="BodyTable">
    
    
        <img src="../Images/GesCategoria.png" />

          <table width="100%" border="0" align="center" cellpadding="0" cellspacing="0">
          	
            <tr id="ide" runat="server">
                <td class="auto-style2">

                    ID:</td>

                <td class="auto-style1">

                    
                    <asp:TextBox ID="TextBox3" runat="server" Width="152px" Enabled="False"></asp:TextBox>

                    
                </td>
                <td>

                    
                </td>
            </tr>   
         
            
           
            
            
            
            <tr>
                <td class="auto-style2">

                    Nombre:</td>

                <td class="auto-style1">

                    
                    <asp:TextBox ID="TextBox1" runat="server" Width="374px"></asp:TextBox>

                    
                </td>
                <td>

                    
                    &nbsp;</td>
            </tr>   
         
            
           
            
            
            
            <tr>
                <td class="auto-style2">

                    Descripcion:</td>

                <td class="auto-style1" align="rigth" colspan="2">

                    
                    &nbsp;<asp:TextBox ID="TextBox2" runat="server" Height="121px" TextMode="MultiLine" Width="474px"></asp:TextBox>

                    
                </td>
            </tr>   
         
            
           
            
            
            
            <tr>
                <td class="auto-style2">

                    &nbsp;</td>

                <td class="auto-style1" align="rigth" colspan="2">

                    
                    <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Images/GUARDAR.png" OnClick="ImageButton1_Click" />

                    
                &nbsp;&nbsp;&nbsp;&nbsp;

                    
                    <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/Images/ELIMINAR.png" Visible="False" OnClick="ImageButton2_Click" />

                    
                </td>
            </tr>   
         
            
           
            
            
            
            <tr>
                <td class="auto-style2">

                    &nbsp;</td>

                <td class="auto-style1" align="rigth" colspan="2">

                    
                    &nbsp;</td>
            </tr>   
         
            
           
            
            
            
          </table>
    
    
    </td>
  </tr>
</table>




</asp:Content>
