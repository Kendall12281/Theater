using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teatros
{
   public  class TicketAdulto : TipoTicket
    {
        public override string Nombre
        {
            get
            {
                return "Adulto";
            }
        }

        public TicketAdulto(short cantidad)
        {
            Cantidad = cantidad;
        }
    }
}
