using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Usuariobuscador.BuscarCasaDis
{
    public partial class BuscarCasa : Form
    {
        public BuscarCasa()
        {
            InitializeComponent();
            cargarTabla(null);
        }

        private void BusquedaCasa_Click(object sender, EventArgs e)
        {
            string dato = bunifuTextBox1.Text;
            cargarTabla(dato);
        }

        private void cargarTabla(string dato)
        {
            List<Artista> lista = new List<Artista>();
            CtrlCasaDis _ctrlArtista = new CtrlCasaDis();
            bunifuDataGridView1.DataSource = _ctrlArtista.consulta2(dato);
        }

        private void buscarcasa_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {

        }
    }
}
