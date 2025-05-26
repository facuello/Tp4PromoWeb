<%@ Page Title="" Language="C#" MasterPageFile="~/MiMaster.Master" AutoEventWireup="true" CodeBehind="Sorteo.aspx.cs" Inherits="Web_TP04.Sorteo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="Estilos.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="col">
        <div class="row text-center">
            <h1 class="H1Sorteo">¡Ingresa el codigo de tu Voucher!</h1>
        </div>
        <div class="row">
            <div class="col text-center p-3">
                <asp:TextBox ID="txtCodigo" runat="server" required="true"></asp:TextBox>
            </div>
        </div>
        <div class="row">
            <div class="col text-center p-3">
                <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" OnClick="btnAceptar_Click" />
            </div>
        </div>
        <div class="row">
            <div class="col text-center p-3">
                <asp:Label ID="lblMensaje" runat="server" ForeColor="Red" Visible="False"></asp:Label>
            </div>
        </div>
    </div>
</asp:Content>