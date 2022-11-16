using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Usuariobuscador
{
    public partial class BuscarProductor : Form
    {
        public BuscarProductor()
        {
            InitializeComponent();
            cargarTabla(null);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void cargarTabla(string dato)
        {
            List<Artista> lista = new List<Artista>();
            CTRLARTISTA _ctrlArtista = new CTRLARTISTA();
            bunifuDataGridView1.DataSource = _ctrlArtista.consulta(dato);
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuDatavizBasic1_Load(object sender, EventArgs e)
        {

        }

        private void txtBuscador_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BusquedaCasa_Click(object sender, EventArgs e)
        {
            string dato = bunifuTextBox1.Text;
            cargarTabla(dato);
        }

        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
