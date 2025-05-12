using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Caching;
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

        protected void BtnBuscar_Click(object sender, EventArgs e)
        {
            //int dni;
            //if (int.TryParse(TxtDni.Text, out dni))
            //{
            //    AccesoClientes accesoClientes = new AccesoClientes();
            //    AccesoDatos datos = new AccesoDatos();

            //    Clientes cliente = accesoClientes.obtenerClientePorDni(dni);
            //    if (cliente != null)
            //    {
            //        // Cargar los datos del cliente en los campos
            //        TxtNombre.Text = cliente.nombre;
            //        TxtApellido.Text = cliente.apellido;
            //        TxtCorreo.Text = cliente.email;
            //        TxtDireccion.Text = cliente.direccion;
            //        TxtCiudad.Text = cliente.ciudad;
            //        TxtCodigo.Text = cliente.codigoPostal.ToString();
            //    }
            //}
        }


        protected void BtnAgregar_Click(object sender, EventArgs e)
        {
            AccesoClientes datoClientes = new AccesoClientes();
            List<Clientes> clientes = new List<Clientes>();
            Voucher vouAux = new Voucher();
            AccesoVoucher vau = new AccesoVoucher();
            bool verificaAgregado = false;

            vouAux = (Voucher)Session["Voucher"];

            Clientes nuevoCliente = new Clientes
            {
                documento = TxtDni.Text,
                nombre = TxtNombre.Text,
                apellido = TxtApellido.Text,
                email = TxtCorreo.Text,
                direccion = TxtDireccion.Text,
                ciudad = TxtCiudad.Text,
                codigoPostal = int.Parse(TxtCodigo.Text)
            };
            AccesoClientes accesoClientes = new AccesoClientes();
            clientes = datoClientes.listar();
            foreach (Clientes aux in clientes) {
                if (nuevoCliente.documento == aux.documento) {
                    verificaAgregado=true;
                }
            }
            if (!verificaAgregado) {
                accesoClientes.agregarCliente(nuevoCliente);
            }
            clientes = new List<Clientes>();
            clientes = datoClientes.listar();

            vau.actualizarVoucher((Voucher)Session["Voucher"], clientes[(clientes.Count)-1], (Articulo)Session["Articulo"]);

            // Limpiamos los campos
            TxtDni.Text = "";
            TxtNombre.Text = "";
            TxtApellido.Text = "";
            TxtCorreo.Text = "";
            TxtDireccion.Text = "";
            TxtCiudad.Text = "";
            TxtCodigo.Text = "";

            Response.Redirect("Default.aspx");
        }

        protected void TxtDni_TextChanged(object sender, EventArgs e)
        {
            List<Clientes> clientes = new List<Clientes>();
            AccesoClientes datosClientes = new AccesoClientes();

            clientes = datosClientes.listar();

            foreach (Clientes aux in clientes) {
                if (aux.documento == TxtDni.Text) {
                    TxtDni.Text = aux.documento;
                    TxtNombre.Text = aux.nombre;
                    TxtApellido.Text = aux.apellido;
                    TxtCorreo.Text = aux.email;
                    TxtDireccion.Text = aux.direccion;
                    TxtCiudad.Text = aux.ciudad;
                    TxtCodigo.Text = aux.codigoPostal.ToString();
                    return;
                }
            }
            TxtNombre.Text = "";
            TxtApellido.Text = "";
            TxtCorreo.Text = "";
            TxtDireccion.Text = "";
            TxtCiudad.Text = "";
            TxtCodigo.Text = "";
        }
    }
}