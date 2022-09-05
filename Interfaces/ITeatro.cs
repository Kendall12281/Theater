using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teatros
{
   public  interface ITeatro
    {
         string Nombre { get; }

        List<ICartelera> ObtenerCartelera();
        double ObtenerPrecio(TipoGraderia graderia, TipoTicket ticket);
    }
}
