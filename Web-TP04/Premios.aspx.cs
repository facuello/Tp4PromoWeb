using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Promo;

namespace Web_TP04
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Imagen> lista = new List<Imagen>();
            AccesoImagen aux = new AccesoImagen();
            lista = aux.listar();
            foreach (Imagen img in lista) {
                if (img.IdArticulo == 1)
                {
                    imgPremio1.ImageUrl = img.UrlImagen;
                }
                else if (img.IdArticulo == 2)
                {
                    imgPremio2.ImageUrl = img.UrlImagen;
                }
                else {
                    imgPremio3.ImageUrl = img.UrlImagen;
                }
            }
        }
        protected void BtnElegirPremio(object sender, EventArgs e)
        {
            Response.Redirect("CargaDeDatos.aspx");
        }
    }
}