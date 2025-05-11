using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Promo
{
    public class AccesoImagen
    {
        private List<Imagen> imgs = null;
        private AccesoDatos datos = null;

        public List<Imagen> listar() {
            imgs = new List<Imagen>();
            datos = new AccesoDatos();
            datos.Conectar();
            datos.Consultar("SELECT IdArticulo, ImagenUrl FROM IMAGENES");
            datos.Leer();

            try
            {
                while(datos.Lector.Read()){
                    Imagen aux = new Imagen();
                    aux.IdArticulo = datos.validarNullInt32(datos.Lector["IdArticulo"]);
                    aux.UrlImagen = datos.validarNullString(datos.Lector["ImagenUrl"]);

                    imgs.Add(aux);
                }
            }
            catch (Exception er)
            {

                throw er;
            }
            datos.Cerrar();
            return imgs;
        }
    }
}
