using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teatros
{
    public abstract class TipoTicket
    {
        public short Cantidad { get; set; }
        public abstract string Nombre {get;}
    }
}
