using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Teatros
{
    public class Recibo
    {
        public ICartelera Cartelera { get; set; }
        public long Consecutivo { get; set; }
        public Descuentos Descuento { get; set; }
        public Horario Horario { get; set; }
        public ITeatro Teatro { get; set; }
        public List<TipoTicket> Tickets { get; set; }

        private double CalcularTotal(ref double impuesto)
        {
           
                double Total = 0;
                //Primero Tiquete segun teatro
                var tipoGraderia = TipoGraderia.Platea;
                            if (Cartelera.Codigo.Equals(0)) { tipoGraderia = TipoGraderia.General;}
                            if (Cartelera.Codigo.Equals(1)) { tipoGraderia = TipoGraderia.Platea; }


                            foreach (var item in Tickets)
                            {
                               Total +=  Teatro.ObtenerPrecio(tipoGraderia, item);
                            }

                            //Restar subtotal de la regla #1
                            double RestarDescuento = 0;
                            switch (Descuento)
                            {
                                case Descuentos.Descuento2x1:
                                    foreach (var item in Tickets)
                                    {
                                        if (item.Cantidad > 1)
                                        {
                                            item.Cantidad -= 1;
                                            RestarDescuento += Teatro.ObtenerPrecio(tipoGraderia, item);
                                        }
                                    }
                    
                                    break;
                                case Descuentos.Descuento3x2:
                                    foreach (var item in Tickets)
                                    {
                                        if (item.Cantidad > 2)
                                        {
                                            item.Cantidad -= 1;
                                            RestarDescuento += Teatro.ObtenerPrecio(tipoGraderia, item);
                                        }
                                    }
                                    break;
                                case Descuentos.Descuento20:
                                    RestarDescuento = Total * 0.20;
                                    break;

                                default:
                                    break;
                            }
                            Total -= RestarDescuento;
                            impuesto = impuesto * Total;

                            return Total + impuesto;
            

            

        }

        public void ConvertirXml(string ruta)
        {
            try
            {
                XmlDocument xmlDoc = new XmlDocument();


                XmlDeclaration dec = xmlDoc.CreateXmlDeclaration("1.0", null, null);
                xmlDoc.AppendChild(dec);
                // Se crea la raiz

                string rutaXslt = System.Windows.Forms.Application.StartupPath + "\\Xslt\\Recibo.xslt";
                XmlProcessingInstruction xslt = xmlDoc.CreateProcessingInstruction("xml-stylesheet", "type=\"text/xsl\" href=\"" + rutaXslt + "\"");
                xmlDoc.AppendChild(xslt);



                XmlElement nProducto = xmlDoc.CreateElement("Recibo");

                XmlElement nConsecutivo = xmlDoc.CreateElement("Consecutivo");
                nConsecutivo.InnerText = DateTime.Now.Ticks.ToString();

                XmlElement nTipoProd = xmlDoc.CreateElement("Teatro");
                nTipoProd.SetAttribute("Nombre", Teatro.Nombre);

                XmlElement nDimensiones = xmlDoc.CreateElement("Cartelera");
                nDimensiones.SetAttribute("Codigo", Cartelera.Codigo.ToString());
                nDimensiones.InnerText = Cartelera.Nombre;

                XmlElement nPeso = xmlDoc.CreateElement("Horario");
                nPeso.SetAttribute("Graderia", Cartelera.Codigo.ToString());
                nPeso.InnerText = Horario.ToString();



                XmlElement nAdicionales = xmlDoc.CreateElement("Tickets");
                foreach (var item in Tickets)
                {
                    XmlElement nAdicional = xmlDoc.CreateElement("Ticket");
                    nAdicional.SetAttribute("Cantidad", item.Cantidad.ToString());
                    nAdicional.InnerText = item.Nombre;

                    nAdicionales.AppendChild(nAdicional);
                }

                XmlElement nCosto = xmlDoc.CreateElement("Descuento");
                nCosto.InnerText = Descuento.ToString();

                XmlElement nTotal = xmlDoc.CreateElement("Total");
                nTotal.SetAttribute("Impuesto", "8.5");
                var impuesto = 8.5;
                nTotal.InnerText = CalcularTotal(ref impuesto).ToString();

                nTipoProd.AppendChild(nDimensiones);
                nTipoProd.AppendChild(nPeso);


                nProducto.AppendChild(nConsecutivo);
                nProducto.AppendChild(nTipoProd);
                nProducto.AppendChild(nCosto);
                nProducto.AppendChild(nAdicionales);
                nProducto.AppendChild(nTotal);

                xmlDoc.AppendChild(nProducto);

                xmlDoc.Save(ruta);
            }
            catch (Exception exp)
            {

                MessageBox.Show("Debe llenar los espacions"+exp);
            }
            
            
           
        }
    }
}
