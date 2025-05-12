using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Promo;

namespace Web_TP04
{
    public partial class CargaDeDatos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //protected void BtnBuscar_Click(object sender, EventArgs e)
        //{
        //    int dni;
        //    if (int.TryParse(TxtDni.Text, out dni))
        //    {
        //        AccesoClientes accesoClientes = new AccesoClientes();
        //        AccesoDatos datos = new AccesoDatos();

        //        Clientes cliente = accesoClientes.obtenerClientePorDni(dni);
        //        if (cliente != null)
        //        {
        //            // Cargar los datos del cliente en los campos
        //            TxtNombre.Text = cliente.nombre;
        //            TxtApellido.Text = cliente.apellido;
        //            TxtCorreo.Text = cliente.email;
        //            TxtDireccion.Text = cliente.direccion;
        //            TxtCiudad.Text = cliente.ciudad;
        //            TxtCodigo.Text = cliente.codigoPostal.ToString();
        //        }
        //    }
        //}


        protected void BtnAgregar_Click(object sender, EventArgs e)
        {
            // Crear un nuevo objeto Clientes
            Clientes nuevoCliente = new Clientes
            {
                documento = int.Parse(TxtDni.Text),
                nombre = TxtNombre.Text,
                apellido = TxtApellido.Text,
                email = TxtCorreo.Text,
                direccion = TxtDireccion.Text,
                ciudad = TxtCiudad.Text,
                codigoPostal = 0
            };
            AccesoClientes accesoClientes = new AccesoClientes();
            accesoClientes.agregarCliente(nuevoCliente);

            // Limpiamos los campos
            TxtDni.Text = "";
            TxtNombre.Text = "";
            TxtApellido.Text = "";
            TxtCorreo.Text = "";
            TxtDireccion.Text = "";
            TxtCiudad.Text = "";
            TxtCodigo.Text = "";
        }
    }
}