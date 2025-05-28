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
            <asp:TextBox ID="TxtDni" runat="server" Placeholder="DNI" required="true" AutoPostBack="true" OnTextChanged="TxtDni_TextChanged" TextMode="Number"></asp:TextBox>
        </div>
        <div>
            <asp:TextBox ID="TxtNombre" runat="server" Placeholder="Nombre" required="true"></asp:TextBox>
        </div>
        <div>
            <asp:TextBox ID="TxtApellido" runat="server" Placeholder="Apellido" required="true"></asp:TextBox>
        </div>
        <div>
            <asp:TextBox ID="TxtCorreo" runat="server" Placeholder="Correo" required="true" TextMode="Email"></asp:TextBox>
        </div>
        <div>
            <asp:TextBox ID="TxtDireccion" runat="server" Placeholder="Direccion" required="true"></asp:TextBox>
        </div>
        <div>
            <asp:TextBox ID="TxtCiudad" runat="server" Placeholder="Ciudad" required="true"></asp:TextBox>
        </div>
        <div>
            <asp:TextBox ID="TxtCodigo" runat="server" Placeholder="Codigo postal" required="true" TextMode="Number"></asp:TextBox>
        </div>
        <div class="DivAgregar">
            <asp:Button ID="BtnAgregar" runat="server" Text="Participar" OnClick="BtnAgregar_Click" />
        </div>
    </div>
    <div class="col text-center p-3">
        <asp:Label ID="lblError" runat="server" ForeColor="Red" Visible="True"></asp:Label>
    </div>
</asp:Content>
