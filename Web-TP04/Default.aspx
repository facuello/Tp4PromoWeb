<%@ Page Title="" Language="C#" MasterPageFile="~/MiMaster.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Web_TP04.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="Estilos.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row text-center">
        <h1 class="H1Default">¡Bienvenido a UTNTechnco!</h1>
    </div>
    <div class="DivImgDefault">
        <asp:Image ID="Image1" runat="server" ImageUrl="imagenes/UTN_logo.jpg" CssClass="UTN_img" />
    </div>

</asp:Content>
