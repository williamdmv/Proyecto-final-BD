using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Usuariobuscador
{
    public partial class BuscarArtista : Form
    {
        public BuscarArtista()
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
            dataGridView1.DataSource = _ctrlArtista.consulta(dato);
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            string dato = txtBuscador.Text;
            cargarTabla(dato);
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuDatavizBasic1_Load(object sender, EventArgs e)
        {

        }
    }
}
