<%@ Page Title="" Language="C#" MasterPageFile="~/MiMaster.Master" AutoEventWireup="true" CodeBehind="Premios.aspx.cs" Inherits="Web_TP04.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="Estilos.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row text-center">
        <h1 class="H1Premios">¡Elegi el producto por el que quieras participar!</h1>
        <br>
    </div>

    <div class="row row-cols-1 row-cols-md-3 g-4">
        <% foreach (Promo.Articulo art in ListaArticulos)
           {
                var imagenes = ImagenesPorArticulo.ContainsKey(art.id) ? ImagenesPorArticulo[art.id] : new List<string> { "https://cdn3.iconfinder.com/data/icons/it-and-ui-mixed-filled-outlines/48/default_image-512.png" };
                string carouselId = "carousel-" + art.id;
            %>
            <div class="col">
                <div class="card h-100 text-center">
                    <div id="<%= carouselId %>" class="carousel slide" data-bs-ride="carousel">
                        <div class="carousel-inner">
                            <% for (int i = 0; i < imagenes.Count; i++)
                                { %>
                            <div class="carousel-item <%= i == 0 ? "active" : "" %>">
                                <img src="<%= imagenes[i] %>" class="d-block mx-auto card-img-top" style="max-height: 150px; width: auto;" alt="Imagen <%= i + 1 %> de <%: art.nombre %>">
                            </div>
                            <% } %>
                        </div>

                        <% if (imagenes.Count > 1) // Botones para el carrusel
                           { %>
                        <button class="carousel-control-prev" type="button" data-bs-target="#<%= carouselId %>" data-bs-slide="prev">
                            <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                            <span class="visually-hidden">Anterior</span>
                        </button>
                        <button class="carousel-control-next" type="button" data-bs-target="#<%= carouselId %>" data-bs-slide="next">
                            <span class="carousel-control-next-icon" aria-hidden="true"></span>
                            <span class="visually-hidden">Siguiente</span>
                        </button>
                        <% } %>
                    </div>

                    <div class="card-body"> <!-- Texto descriptivo del articulo -->
                        <h5 class="card-title"><%: art.nombre %></h5>
                        <p class="card-text"><%: art.descripcion %></p>
                        <a href='Premios.aspx?id=<%= art.id %>' class='btn btn-primary mt-2'>Seleccionar</a>
                    </div>
                </div>
            </div>
        <% } %>
    </div>

</asp:Content>
