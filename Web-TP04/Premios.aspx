<%@ Page Title="" Language="C#" MasterPageFile="~/MiMaster.Master" AutoEventWireup="true" CodeBehind="Premios.aspx.cs" Inherits="Web_TP04.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="Estilos.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row text-center">
        <h1 class="H1Premios">¡Elegi el producto por el que quieras participar!</h1>
    </div>
    <div class="Premios">
        <div class="Img-premios">
            <asp:Image ID="premio1" runat="server" ImageUrl="~/Imagenes/Teclado.png" CssClass="imagen-premio1"/>
            <asp:Image ID="premio2" runat="server" ImageUrl="~/Imagenes/Auris.png" CssClass="imagen-premio2"/>
            <asp:Image ID="premio3" runat="server" ImageUrl="~/Imagenes/Moni.png" CssClass="imagen-premio3"/>
        </div>
        <div class="botones-premios">
            <asp:Button runat="server" Text="Elegir producto" CssClass="boton-premio"  OnClick="BtnElegirPremio"/>
            <asp:Button runat="server" Text="Elegir producto" CssClass="boton-premio"  OnClick="BtnElegirPremio"/>
            <asp:Button runat="server" Text="Elegir producto" CssClass="boton-premio"  OnClick="BtnElegirPremio"/>
        </div>
    </div>
</asp:Content>
