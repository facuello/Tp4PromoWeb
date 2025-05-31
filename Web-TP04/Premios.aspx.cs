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
        public List<Articulo> ListaArticulos { get; set; }
        public Dictionary<int, List<string>> ImagenesPorArticulo
        {
            get { return (Dictionary<int, List<string>>)ViewState["ImagenesPorArticulo"]; }
            set { ViewState["ImagenesPorArticulo"] = value; }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

            AccesoArticulo accesoArticulo = new AccesoArticulo();
            AccesoImagen accesoImagen = new AccesoImagen();

            ListaArticulos = accesoArticulo.listar();
            var imagenes = accesoImagen.listar();

            Dictionary<int, List<string>> imagenesDict = new Dictionary<int, List<string>>();

            foreach (var art in ListaArticulos)
            {
                imagenesDict[art.id] = imagenes
                    .Where(img => img.IdArticulo == art.id)
                    .Select(img => img.UrlImagen)
                    .ToList();

                if (imagenesDict[art.id].Count == 0)
                    imagenesDict[art.id].Add("https://cdn3.iconfinder.com/data/icons/it-and-ui-mixed-filled-outlines/48/default_image-512.png");
            }

            ImagenesPorArticulo = imagenesDict;

            if (Request.QueryString["id"] != null)
            {
                if (int.TryParse(Request.QueryString["id"], out int idSeleccionado))
                {
                    Articulo seleccionado = ListaArticulos.FirstOrDefault(a => a.id == idSeleccionado);
                    if (seleccionado != null)
                    {
                        Session["Articulo"] = seleccionado;
                        Response.Redirect("CargaDeDatos.aspx");
                    }
                }
            }

        }
    }
}