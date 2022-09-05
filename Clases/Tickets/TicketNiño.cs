using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teatros
{
    public class TicketNiño : TipoTicket
    {
        public override string Nombre
        {
            get
            {
                return "Niño";
            }
        }

        public TicketNiño(short cantidad)
        {
            Cantidad = cantidad;
        }
    }
}
