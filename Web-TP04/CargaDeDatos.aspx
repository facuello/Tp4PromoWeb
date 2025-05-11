<%@ Page Title="" Language="C#" MasterPageFile="~/MiMaster.Master" AutoEventWireup="true" CodeBehind="CargaDeDatos.aspx.cs" Inherits="Web_TP04.CargaDeDatos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="Estilos.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row text-center">
        <h1 class="H1CargaDeDatos">Ingrese sus datos</h1>
    </div>
    <div class="TxtDatos">
        <div>
            <asp:Label ID="LblDni" runat="server" Text="DNI:"></asp:Label>
            <asp:TextBox ID="TxtDni" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="lblNombre" runat="server" Text="Nombre:"></asp:Label>
            <asp:TextBox ID="TxtNombre" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="lblApellido" runat="server" Text="Apellido:"></asp:Label>
            <asp:TextBox ID="TxtApellido" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="lblCorreo" runat="server" Text="Correo:"></asp:Label>
            <asp:TextBox ID="TxtCorreo" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="lblDireccion" runat="server" Text="Direccion:"></asp:Label>
            <asp:TextBox ID="TxtDireccion" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="lblCiudad" runat="server" Text="Ciudad:"></asp:Label>
            <asp:TextBox ID="TxtCiudad" runat="server"></asp:TextBox>
        </div>
    </div>
</asp:Content>
