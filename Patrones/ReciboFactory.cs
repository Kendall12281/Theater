using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teatros
{
    public class ReciboFactory
    {
        public Recibo CrearRecibo(bool melico, bool variedades, bool lucho, ICartelera cartelera, Horario horario, short adultos, short adultosMayores, short niños, bool px2x1, bool px3x2, bool p20)
        {
            Recibo recibo = new Recibo();

            if (melico)
            {
                recibo.Teatro = new MelicoSalazar();
            }
            if (variedades)
            {
                recibo.Teatro = new Variedades();
            }
            if (lucho)
            {
                recibo.Teatro = new LuchoBarahona();
            }

            //Cartelera
            recibo.Cartelera = cartelera;

            //Horario
            recibo.Horario = horario;

            //Tipo persona
            List<TipoTicket> Lista = new List<TipoTicket>();
            Lista.Add(new TicketAdulto(adultos));
            Lista.Add(new TicketNiño(niños));
            Lista.Add(new TicketAdultoMayor(adultosMayores));

            recibo.Tickets = Lista;


            //Descuento
            if (px2x1)
            {
                recibo.Descuento = Descuentos.Descuento2x1;
            }
            if (px3x2)
            {
                recibo.Descuento = Descuentos.Descuento3x2;
            }
            if (p20)
            {
                recibo.Descuento = Descuentos.Descuento20;
            }


            return recibo;
        }
    }
}
