using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teatros
{
    public class FantasmaOpera : ICartelera
    {
        public short Codigo
        {
            get
            {
                return 1986;
            }
        }

        public string Nombre
        {
            get
            {
                return "Fantasma Opera";
            }
        }
    }
}
