using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teatros
{
    public class TicketAdultoMayor : TipoTicket
    {
        public override string Nombre
        {
            get
            {
                return "Adulto Mayor";
            }
        }

        public TicketAdultoMayor(short cantidad)
        {
            Cantidad = cantidad;
        }
    }
}
