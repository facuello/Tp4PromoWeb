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
            <asp:TextBox ID="TxtDni" runat="server" Placeholder="DNI"></asp:TextBox>
        </div>
        <div>
            <asp:TextBox ID="TxtNombre" runat="server" Placeholder="Nombre"></asp:TextBox>
        </div>
        <div>
            <asp:TextBox ID="TxtApellido" runat="server" Placeholder="Apellido"></asp:TextBox>
        </div>
        <div>
            <asp:TextBox ID="TxtCorreo" runat="server" Placeholder="Correo"></asp:TextBox>
        </div>
        <div>
            <asp:TextBox ID="TxtDireccion" runat="server" Placeholder="Direccion"></asp:TextBox>
        </div>
        <div>
            <asp:TextBox ID="TxtCiudad" runat="server" Placeholder="Ciudad"></asp:TextBox>
        </div>
        <div>
            <asp:TextBox ID="TxtCodigo" runat="server"  Placeholder="Codigo postal"></asp:TextBox>
        </div>
        <div class="DivAgregar">
            <asp:Button ID="BtnAgregar" runat="server" Text="Agregar Cliente" OnClick="BtnAgregar_Click"/>
        </div>
    </div>
</asp:Content>
