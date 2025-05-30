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

        protected void TxtDni_TextChanged(object sender, EventArgs e)
        {
            lblError.Text = "";
            List<Clientes> clientes = new List<Clientes>();
            AccesoClientes datosClientes = new AccesoClientes();

            clientes = datosClientes.listar();

            foreach (Clientes aux in clientes)
            {
                if (aux.documento == TxtDni.Text)
                {
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

            foreach (Clientes aux in accesoClientes.listar())
            {
                if (aux.documento == nuevoCliente.documento)
                {
                    if (vau.actualizarVoucher((Voucher)Session["Voucher"], aux, (Articulo)Session["Articulo"]))
                    {
                        //lblMensaje.ForeColor = System.Drawing.Color.Green;
                        lblMensaje.Text = "¡El voucher fue usado exitosamente!";
                        //Response.Redirect("Default.aspx");
                    } else
                    {
                        lblError.Text = "No puede participar el mismo cliente por el mismo articulo.";
                        btnVolver.Visible = true;
                    }
                }
            }
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}