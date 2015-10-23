<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Site.Master" AutoEventWireup="true" CodeBehind="GesCategoria.aspx.cs" Inherits="AllinBolivia.Presentacion.GesCategoria" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <link href="../Content/Site.css" rel="stylesheet" />
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    
    
    <table width="1170" border="0" align="center" cellpadding="0" cellspacing="0" bgcolor="#ebebeb">
  <tr>
    <td valign="top" class="BodyTable">
    
    
        <img src="../Images/GesCategoria.png" />

          <table width="100%" border="0" align="center" cellpadding="0" cellspacing="0">
          	<tr>
            	<td width="34%" align="center" valign="middle" bgcolor="#7b7575" class="Bodycelda">Nombre</td>
            	<td width="45%" align="center" valign="middle" bgcolor="#7b7575">Descripcion</td>
	            <td width="21%" align="center" valign="middle" bgcolor="#7b7575">N# Eventos</td>
          	</tr>
            
            <asp:Label ID="Categorias" runat="server"></asp:Label>
            
           
            
            
            
          </table>
    
    
    </td>
  </tr>
</table>
    
    
</asp:Content>
