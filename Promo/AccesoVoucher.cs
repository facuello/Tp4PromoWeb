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

        public List<Voucher> listar()
        {
            vouchers = new List<Voucher>();
            datos = new AccesoDatos();
            datos.Conectar();
            datos.Consultar("SELECT CodigoVoucher, IdCliente, FechaCanje, IdArticulo FROM Vouchers");
            datos.Leer();

            try
            {
                while (datos.Lector.Read())
                {
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
        public void actualizarVoucher(Voucher vou, Clientes cli, Articulo art)
        {
            datos = new AccesoDatos();

            try
            {
                datos.Conectar();
                datos.Consultar("UPDATE Vouchers SET IdCliente = @IdCliente, FechaCanje = GETDATE(), IdArticulo = @IdArticulo WHERE CodigoVoucher = @CodigoVoucher");
                datos.setearParametro("@IdCliente", cli.id);
                datos.setearParametro("@IdArticulo",art.id);
                datos.setearParametro("@CodigoVoucher",vou.CodigoVoucher);
                datos.EjecutarNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                datos.Cerrar();
            }
        }
    }
}
