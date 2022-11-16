using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Usuariobuscador.BuscarProductores
{
    public partial class Bproductor : Form
    {
        public Bproductor()
        {
            InitializeComponent();
            cargarTabla(null);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cargarTabla(string dato)
        {
            List<Artista> lista = new List<Artista>();
            CtrlProduc _ctrlArtista = new CtrlProduc();
            bunifuDataGridView1.DataSource = _ctrlArtista.consulta2(dato);
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            string dato = buscaproductor.Text;
            cargarTabla(dato);
        }

        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
