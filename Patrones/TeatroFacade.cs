using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teatros
{
    public class TeatroFacade
    {
        public List<Horario> ObtenerHorarios(ICartelera cartelera)
        {
            List<Horario> Lista = new List<Horario>();

            foreach (var item in new Horario().ObtenerHorarios())
            {
                if (item.CodigoCartelera.Equals(cartelera.Codigo))
                {
                    Lista.Add(item);
                }
            }

            return Lista;
        }

        public void Pagar(Recibo recibo, out string ruta)
        {
            ruta = "Teatro.xml";
            recibo.ConvertirXml(ruta);
        }
    }
}
