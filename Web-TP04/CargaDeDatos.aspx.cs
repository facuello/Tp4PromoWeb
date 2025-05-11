using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Promo;

namespace Web_TP04
{
    public partial class CargaDeDatos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
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