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
    public partial class Sorteo : System.Web.UI.Page
    {
        private AccesoVoucher datosVouchers = null;
        private List<Voucher> vouchers = null;

        protected void Page_Load(object sender, EventArgs e)
        {
        }
        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            datosVouchers = new AccesoVoucher();
            vouchers = new List<Voucher>();
            vouchers = datosVouchers.listar();

            foreach (Voucher voucher in vouchers)
            {
                if ((voucher.CodigoVoucher == txtCodigo.Text) && (voucher.IdCliente == 0))
                {
                    Session.Add("Voucher", voucher);
                    Response.Redirect("Premios.aspx");
                }
            }
        }
    }
}