using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Promo
{
    public class Voucher
    {
        public string CodigoVoucher { get; set; }
        public System.Int32 IdCliente { get; set; }
        public System.DateTime FechaCanje { get; set; }
        public System.Int32 IdArticulo { get; set; }

    }
}
