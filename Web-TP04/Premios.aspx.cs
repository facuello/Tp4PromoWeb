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
            List<string> img1 = new List<string>();
            List<string> img2 = new List<string>();
            List<string> img3 = new List<string>();
            AccesoImagen aux = new AccesoImagen();
            lista = aux.listar();
            foreach (Imagen img in lista) {
                if (img.IdArticulo == 1)
                {
                    img1.Add(img.UrlImagen);
                }
                else if (img.IdArticulo == 2)
                {
                    img2.Add(img.UrlImagen);
                }
                else {
                    img3.Add(img.UrlImagen);
                }
            }
            imgPremio11.ImageUrl = img1[0];
            imgPremio12.ImageUrl = img1[1];
            imgPremio13.ImageUrl = img1[2];

            imgPremio21.ImageUrl = img2[0];
            imgPremio22.ImageUrl = img2[1];
            imgPremio23.ImageUrl = img2[2];

            imgPremio31.ImageUrl = img3[0];
            imgPremio32.ImageUrl = img3[1];
            imgPremio33.ImageUrl = img3[2];
        }
        protected void BtnElegirPremio(object sender, EventArgs e)
        {
            AccesoArticulo data = new AccesoArticulo();
            List<Articulo> arts = new List<Articulo>();
            arts = data.listar();

            Session.Add("Articulo", arts[0]);
            Response.Redirect("CargaDeDatos.aspx");
        }

        protected void btnPremio2_Click(object sender, EventArgs e)
        {
            AccesoArticulo data = new AccesoArticulo();
            List<Articulo> arts = new List<Articulo>();
            arts = data.listar();

            Session.Add("Articulo", arts[1]);
            Response.Redirect("CargaDeDatos.aspx");
        }

        protected void btnPremio3_Click(object sender, EventArgs e)
        {
            AccesoArticulo data = new AccesoArticulo();
            List<Articulo> arts = new List<Articulo>();
            arts = data.listar();

            Session.Add("Articulo", arts[2]);
            Response.Redirect("CargaDeDatos.aspx");
        }
    }
}