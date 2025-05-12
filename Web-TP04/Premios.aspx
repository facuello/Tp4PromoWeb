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
                <div id="carouselExampleAutoplaying" class="carousel slide " data-bs-ride="carousel">
                    <div class="carousel-inner">
                        <div class="carousel-item active">
                            <asp:Image ID="imgPremio11" runat="server" class="d-block" alt="MochilaImg1" />
                        </div>
                        <div class="carousel-item">
                            <asp:Image ID="imgPremio12" runat="server" class="d-block" alt="MochilaImg2" />
                        </div>
                        <div class="carousel-item">
                            <asp:Image ID="imgPremio13" runat="server" class="d-block" alt="MochilaImg3" />
                        </div>
                    </div>
                    <button class="carousel-control-prev" type="button" data-bs-target="#carouselExampleAutoplaying" data-bs-slide="prev">
                        <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                        <span class="visually-hidden">Previous</span>
                    </button>
                    <button class="carousel-control-next" type="button" data-bs-target="#carouselExampleAutoplaying" data-bs-slide="next">
                        <span class="carousel-control-next-icon" aria-hidden="true"></span>
                        <span class="visually-hidden">Next</span>
                    </button>
                </div>
            </div>
        </div>
        <div class="col">

            <div id="carouselExampleAutoplaying1" class="carousel slide" data-bs-ride="carousel">
                <div class="carousel-inner">
                    <div class="carousel-item active">
                        <asp:Image ID="imgPremio21" runat="server" class="d-block" alt="MouseImg1" />
                    </div>
                    <div class="carousel-item">
                        <asp:Image ID="imgPremio22" runat="server" class="d-block" alt="MouseImg2" />
                    </div>
                    <div class="carousel-item">
                        <asp:Image ID="imgPremio23" runat="server" class="d-block" alt="MouseImg3" />
                    </div>
                </div>
                <button class="carousel-control-prev" type="button" data-bs-target="#carouselExampleAutoplaying1" data-bs-slide="prev">
                    <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                    <span class="visually-hidden">Previous</span>
                </button>
                <button class="carousel-control-next" type="button" data-bs-target="#carouselExampleAutoplaying1" data-bs-slide="next">
                    <span class="carousel-control-next-icon" aria-hidden="true"></span>
                    <span class="visually-hidden">Next</span>
                </button>
            </div>
        </div>
        <div class="col">
            <div id="carouselExampleAutoplaying2" class="carousel slide" data-bs-ride="carousel">
                <div class="carousel-inner">
                    <div class="carousel-item active">
                        <asp:Image ID="imgPremio31" runat="server" class="d-block" alt="TecladoImg1" />
                    </div>
                    <div class="carousel-item">
                        <asp:Image ID="imgPremio32" runat="server" class="d-block" alt="TecladoImg2" />
                    </div>
                    <div class="carousel-item">
                        <asp:Image ID="imgPremio33" runat="server" class="d-block" alt="TecladoImg3" />
                    </div>
                </div>
                <button class="carousel-control-prev" type="button" data-bs-target="#carouselExampleAutoplaying2" data-bs-slide="prev">
                    <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                    <span class="visually-hidden">Previous</span>
                </button>
                <button class="carousel-control-next" type="button" data-bs-target="#carouselExampleAutoplaying2" data-bs-slide="next">
                    <span class="carousel-control-next-icon" aria-hidden="true"></span>
                    <span class="visually-hidden">Next</span>
                </button>
            </div>
        </div>
    </div>
    <div>
        <asp:Button ID="btnPremio1" runat="server" Text="Button" OnClick="BtnElegirPremio"/>
    </div>
    <div>
        <asp:Button ID="btnPremio2" runat="server" Text="Button" OnClick="btnPremio2_Click"/>
    </div>
    <div>
        <asp:Button ID="btnPremio3" runat="server" Text="Button" OnClick="btnPremio3_Click"/>
    </div>
</asp:Content>

