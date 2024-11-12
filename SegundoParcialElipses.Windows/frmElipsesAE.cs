using SegundoParcialElipses.Datos;
using SegundoParcialElipses.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SegundoParcialElipses.Entidades.Elipse;

namespace SegundoParcialElipses.Windows
{
    public partial class frmElipsesAE : Form
    {

        private Elipse? elipses;
        private RepositorioElipses? _repo;
        public frmElipsesAE()
        {
            InitializeComponent();
        }

        private void frmElipsesAE_Load(object sender, EventArgs e)
        {
            cboColores.DataSource = Enum.GetValues(typeof(ColorElipse));
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {

                if (!int.TryParse(txtSemiejeMayor.Text, out int semiejeMayor) || semiejeMayor <= 0)
                {
                    MessageBox.Show("Por favor ingrese un valor numérico válido y mayor que cero para el semieje mayor.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; 
                }

                if (!int.TryParse(txtSemiejeMenor.Text, out int semiejeMenor) || semiejeMenor <= 0)
                {
                    MessageBox.Show("Por favor ingrese un valor numérico válido y mayor que cero para el semieje menor.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; 
                }

                TipoBorde borde = ObtenerTipoBordeSeleccionado();


                Elipse nuevaElipse = new Elipse(semiejeMayor, semiejeMenor, borde, ColorElipse.Azul); 
                                                                                                      
            }
            catch (InvalidOperationException ex)
            {

                MessageBox.Show(ex.Message, "Error de selección", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private TipoBorde ObtenerTipoBordeSeleccionado()
        {
            if (rbtSolido.Checked)
            {
                return TipoBorde.Solido;
            }
            else if (rbtPunteado.Checked)
            {
                return TipoBorde.Punteado;
            }
            else if (rbtRayado.Checked)
            {
                return TipoBorde.Rayado;
            }
            else
            {
                throw new InvalidOperationException("No se ha seleccionado un tipo de borde.");
            }
        }
    }
}
    
