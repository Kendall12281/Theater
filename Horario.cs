using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teatros
{
    [DataContract]
    public class Horario
    {
        private string ruta
        {
            get
            {
                return System.Windows.Forms.Application.StartupPath.Replace(@"\bin\Debug","") + "\\Json\\Horarios.json";
            }
        }
        [DataMember]
        public short CodigoCartelera { get; set; }
        [DataMember]
        public string Descripcion { get; set; }
        [DataMember]
        public TipoGraderia TipoGraderia { get; set; }


        public List<Horario> ObtenerHorarios()
        {
            List<Horario> lista = new List<Horario>();

            try
            {
                if (File.Exists(ruta))
                            {
                                using (StreamReader sr = new StreamReader(ruta))
                                {
                                    string datosJson = sr.ReadToEnd();

                                    DataContractJsonSerializer oDataContractJsonSerializer = new DataContractJsonSerializer(typeof(List<Horario>));
                                    MemoryStream ms = new MemoryStream(System.Text.ASCIIEncoding.UTF8.GetBytes(datosJson));

                                    lista = (List<Horario>)oDataContractJsonSerializer.ReadObject(ms);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Ruta no encontrada JSON");
                    MessageBox.Show("STARTUP PATH-->"+System.Windows.Forms.Application.StartupPath);
                    MessageBox.Show("ALL-->"+ruta);

                }
            }
            catch (Exception exp)
            {

                MessageBox.Show("EXCEPTION -->"+exp); ;
            }
            
            

            return lista;
        }

        public override string ToString()
        {
            return Descripcion;
        }
    }
}
