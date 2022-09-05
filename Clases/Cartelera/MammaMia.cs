using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teatros
{
    public class MammaMia : ICartelera
    {
        public short Codigo
        {
            get
            {
                return 2008;
            }
        }

        public string Nombre
        {
            get
            {
                return "MammaMia";
            }
        }
    }
}
