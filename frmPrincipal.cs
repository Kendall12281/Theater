using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teatros
{
    public partial class frmPrincipal : Form
    {
        TeatroFacade facade = new TeatroFacade();
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(cmbHorario.Text))
                {
                    MessageBox.Show("Debe seleccionar un horario");
                    return;
                }

                ReciboFactory reciboFactory = new ReciboFactory();

                Recibo recibo = reciboFactory.CrearRecibo(rbtMelico.Checked, rbtVariedades.Checked, rbtLucho.Checked,
                    (ICartelera)cmbObra.SelectedItem,(Horario)cmbHorario.SelectedItem, (short)nudAdultos.Value, (short)nudAdultosMayores.Value,
                    (short)nudNiños.Value, rbt2x1.Checked, rbt3x2.Checked, rbt20.Checked);

                ///Crear XML
                recibo.ConvertirXml("Test.xml");
                webBrowser.Url = new Uri(System.Windows.Forms.Application.StartupPath + @"\Test.xml");
            }
            catch (Exception)
            {

                MessageBox.Show("Debe de llenar los espacios con la informacion correspondiente");
            }
        }
     
        private void frmPrincipal_Load(object sender, EventArgs e)
        {

            cmbObra.Items.Add(new FantasmaOpera());
            cmbObra.Items.Add(new ReyLeon());
            cmbObra.Items.Add(new MammaMia());

            cmbObra.DisplayMember = "Nombre";

            cmbObra.SelectedIndex = 0;


        }

        private void ObtenerHorarios()
        {
            try
            {
                List<Horario> Lista = facade.ObtenerHorarios((ICartelera)cmbObra.SelectedItem);

                foreach (var item in Lista)
                {
                    cmbHorario.Items.Add(item);
                }
                cmbHorario.DisplayMember = "Descripcion";
                cmbHorario.SelectedItem = 0;

            }
            catch (Exception)
            {

                throw;
            }
        }
        private void cmbCartelera_SelectedIndexChanged(object sender, EventArgs e)
        {
            ObtenerHorarios();
        }

        private void splitContainer_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
