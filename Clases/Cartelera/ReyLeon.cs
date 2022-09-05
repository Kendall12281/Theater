using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teatros
{
    public class ReyLeon : ICartelera
    {
        public short Codigo
        {
            get
            {
                return 1997;
            }
        }

        public string Nombre
        {
            get
            {
                return "Rey Leon";
            }
        }
    }
}
