using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Promo
{
    public class AccesoVoucher
    {
        private List<Voucher> vouchers = null;
        private AccesoDatos datos = null;

        public List<Voucher> listar() { 
            vouchers = new List<Voucher>();
            datos = new AccesoDatos();
            datos.Conectar();
            datos.Consultar("SELECT CodigoVoucher, IdCliente, FechaCanje, IdArticulo FROM Vouchers");
            datos.Leer();

            try
            {
                while (datos.Lector.Read()) {
                    Voucher aux = new Voucher();
                    aux.CodigoVoucher = datos.validarNullString(datos.Lector["CodigoVoucher"]);
                    aux.IdCliente = datos.validarNullInt32(datos.Lector["IdCliente"]);
                    aux.FechaCanje = datos.validarNullDate(datos.Lector["FechaCanje"]);
                    aux.IdArticulo = datos.validarNullInt32(datos.Lector["IdArticulo"]);

                    vouchers.Add(aux);
                }
            }
            catch (Exception er)
            {
                throw er;
            }
            datos.Cerrar();
            return vouchers;
        }
    }
}
