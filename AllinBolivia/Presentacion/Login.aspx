<%@ Page Title="Log in" Language="C#" MasterPageFile="~/Presentacion/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="AllinBolivia.Account.Login" %>
<%@ Register Src="~/Account/OpenAuthProviders.ascx" TagPrefix="uc" TagName="OpenAuthProviders" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <hgroup class="title">
        <h1><%: Title %>.</h1>
    </hgroup>
    <section id="loginForm">
        <h2>Use a local account to log in.</h2>
            <table ><tr><td style="padding-left:25px">
    <asp:Login ID="Login1" runat="server" OnAuthenticate="Login1_Authenticate" BorderPadding="0" EnableTheming="True" FailureText="El intento de ingreso no fue exitoso" LoginButtonText="Entrar" PasswordLabelText="Contraseña:" PasswordRequiredErrorMessage="La contreseña es requerida" RememberMeText="Recordarme" TitleText="Ingreso" UserNameLabelText="Correo electronico" UserNameRequiredErrorMessage="El campo correo es requerido" Font-Bold="True" ForeColor="White" LoginButtonImageUrl="~/Images/ingresar.png" LoginButtonType="Image" Font-Strikeout="False">
        <LoginButtonStyle Width="146px" Font-Bold="True" Height="31px" BackColor="Transparent" BorderColor="Transparent" BorderStyle="None" />
                </asp:Login>
        </td></tr></table>
        <p>
            <asp:HyperLink runat="server" ID="RegisterHyperLink" ViewStateMode="Disabled">Register</asp:HyperLink>
            if you don't have an account.
        </p>
    </section>

   
</asp:Content>
