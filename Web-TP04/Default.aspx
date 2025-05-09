<%@ Page Title="" Language="C#" MasterPageFile="~/MiMaster.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Web_TP04.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="col">
        <div class="row text-center">
            <h1>¡Ingresa el codigo de tu Voucher!</h1>
        </div>
        <div class="row">
            <div class="col text-center p-3">
                <asp:TextBox ID="txtCodigo" runat="server" required="true"></asp:TextBox>
            </div>
        </div>
        <div class="row">
            <div class="col text-center p-3">
                <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" onclick="btnAceptar_Click"/>
            </div>
        </div>
    </div>
</asp:Content>
