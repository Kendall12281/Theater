using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teatros
{
    public class LuchoBarahona : ITeatro
    {
        public string Nombre
        {
            get
            {
                return "Lucho Barahona";
            }
        }

        public List<ICartelera> ObtenerCartelera()
        {
            List<ICartelera> Lista = new List<ICartelera>();

            Lista.Add(new FantasmaOpera());
            Lista.Add(new ReyLeon());
            Lista.Add(new MammaMia());

            return Lista;
        }

        public double ObtenerPrecio(TipoGraderia graderia, TipoTicket ticket)
        {
            double Total = 0;

            switch (ticket.Nombre)
            {
                case "Niño":
                    if (graderia.Equals(TipoGraderia.General)) { Total = ticket.Cantidad * 86; }
                    if (graderia.Equals(TipoGraderia.Platea)) { Total = ticket.Cantidad * 97; }
                    if (graderia.Equals(TipoGraderia.Palco)) { Total = ticket.Cantidad * 112; }
                    break;

                case "Adulto":
                    if (graderia.Equals(TipoGraderia.General)) { Total = ticket.Cantidad * 90; }
                    if (graderia.Equals(TipoGraderia.Platea)) { Total = ticket.Cantidad * 105; }
                    if (graderia.Equals(TipoGraderia.Palco)) { Total = ticket.Cantidad * 120; }
                    break;

                case "Adulto Mayor":
                    if (graderia.Equals(TipoGraderia.General)) { Total = ticket.Cantidad * 88; }
                    if (graderia.Equals(TipoGraderia.Platea)) { Total = ticket.Cantidad * 101; }
                    if (graderia.Equals(TipoGraderia.Palco)) { Total = ticket.Cantidad * 116; }
                    break;

            }

            return Total;
        }
    }
}
