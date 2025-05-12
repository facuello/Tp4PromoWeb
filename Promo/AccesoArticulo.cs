using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Promo
{
    public class AccesoArticulo
    {
        private AccesoDatos datos = null;
        private List<Articulo> articulos = null;

        public List<Articulo> listar() { 
            articulos = new List<Articulo>();
            datos = new AccesoDatos();
            datos.Conectar();
            datos.Consultar("SELECT A.Id, A.Codigo, A.Nombre, A.Descripcion, M.Descripcion AS MarcaDescripcion, C.Descripcion AS CategoriaDescripcion, Precio FROM Articulos A INNER JOIN Marcas M ON M.Id = A.IdMarca INNER JOIN Categorias C ON C.Id = A.IdCategoria");
            datos.Leer();

            try
            {
                Articulo aux = new Articulo();
                while (datos.Lector.Read()) {
                    aux.id = datos.validarNullInt32(datos.Lector["Id"]);
                    aux.codigo = datos.validarNullString(datos.Lector["Codigo"]);
                    aux.nombre = datos.validarNullString(datos.Lector["Nombre"]);
                    aux.descripcion = datos.validarNullString(datos.Lector["Descripcion"]);
                    //aux.marca.Descripcion = datos.validarNullString(datos.Lector["MarcaDescripcion"]);
                    //aux.categoria.Descripcion = datos.validarNullString(datos.Lector["CategoriaDescripcion"]);
                    aux.precio = datos.validarNullDecimal(datos.Lector["Precio"]);

                    articulos.Add(aux);
                }
            }
            catch (Exception er)
            {
                throw er;
            }

            datos.Cerrar();
            return articulos;
        }
    }
}
