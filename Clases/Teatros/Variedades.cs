using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teatros
{
    public class Variedades : ITeatro
    {
        public string Nombre
        {
            get
            {
                return "Variedades";
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
                    if (graderia.Equals(TipoGraderia.General)) { Total = ticket.Cantidad * 50; }
                    if (graderia.Equals(TipoGraderia.Platea)) { Total = ticket.Cantidad * 70; }
                    if (graderia.Equals(TipoGraderia.Palco)) { Total = ticket.Cantidad * 100; }
                    break;

                case "Adulto":
                    if (graderia.Equals(TipoGraderia.General)) { Total = ticket.Cantidad * 60; }
                    if (graderia.Equals(TipoGraderia.Platea)) { Total = ticket.Cantidad * 80; }
                    if (graderia.Equals(TipoGraderia.Palco)) { Total = ticket.Cantidad * 110; }
                    break;

                case "Adulto Mayor":
                    if (graderia.Equals(TipoGraderia.General)) { Total = ticket.Cantidad * 55; }
                    if (graderia.Equals(TipoGraderia.Platea)) { Total = ticket.Cantidad * 75; }
                    if (graderia.Equals(TipoGraderia.Palco)) { Total = ticket.Cantidad * 105; }
                    break;

            }

            return Total;
        }
    }
    
}
