<%@ Page Title="" Language="C#" MasterPageFile="~/MiMaster.Master" AutoEventWireup="true" CodeBehind="Premios.aspx.cs" Inherits="Web_TP04.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="Estilos.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row text-center">
        <h1 class="H1Premios">¡Elegi el producto por el que quieras participar!</h1>
    </div>
    <div class="Premios">
        <div class="row">
            <div class="col">
                <a href="CargaDeDatos.aspx">
                    <asp:Image ID="imgPremio1" runat="server" CssClass="imagen-premio1" class="rounded float-start" />
                </a>
            </div>
            <div class="col">
                <a href="CargaDeDatos.aspx">
                    <asp:Image ID="imgPremio2" runat="server" CssClass="imagen-premio2" class="rounded float-start" />
                </a>
            </div>
            <div class="col">
                <a href="CargaDeDatos.aspx">
                    <asp:Image ID="imgPremio3" runat="server" CssClass="imagen-premio3" class="rounded float-start"/>
                </a>
                
            </div>
        </div>
    </div>
</asp:Content>
