using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teatros
{
    public class MelicoSalazar : ITeatro
    {
        public string Nombre
        {
            get
            {
                return "Melicos Salazar";
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
                    if (graderia.Equals(TipoGraderia.General)) { Total = ticket.Cantidad * 116; }
                    if (graderia.Equals(TipoGraderia.Platea)) { Total = ticket.Cantidad * 132; }
                    if (graderia.Equals(TipoGraderia.Palco)) { Total = ticket.Cantidad * 148; }
                    break;

                case "Adulto":
                    if (graderia.Equals(TipoGraderia.General)) { Total = ticket.Cantidad * 120; }
                    if (graderia.Equals(TipoGraderia.Platea)) { Total = ticket.Cantidad * 140; }
                    if (graderia.Equals(TipoGraderia.Palco)) { Total = ticket.Cantidad * 160; }
                    break;

                case "Adulto Mayor":
                    if (graderia.Equals(TipoGraderia.General)) { Total = ticket.Cantidad * 118; }
                    if (graderia.Equals(TipoGraderia.Platea)) { Total = ticket.Cantidad * 136; }
                    if (graderia.Equals(TipoGraderia.Palco)) { Total = ticket.Cantidad * 154; }
                    break;

            }

            return Total;
        }
    }
}
