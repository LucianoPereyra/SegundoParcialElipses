using SegundoParcialElipses.Datos;
using SegundoParcialElipses.Entidades;

namespace SegundoParcialElipses.Windows
{
    public partial class frmElipses : Form
    {
        public frmElipses()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

            frmElipsesAE formElipse = new frmElipsesAE() { Text = "Agregar un Elipse" };
            DialogResult dr = formElipse.ShowDialog(this);

            if (dr == DialogResult.Cancel) return;

            Elipse? elipseAgregado = formElipse.AgregarElipse();

            if (!RepositorioElipses.Existe(elipseAgregado))
            {

                RepositorioElipses.Agregar(elipseAgregado);
                MostrarLista();

                MessageBox.Show("Elipse agregado correctamente.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {

                MessageBox.Show(" Este elipse ya existe!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
    }
    
    }
}
