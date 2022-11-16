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

namespace Usuariobuscador.Canciones
{
    public partial class BuscaCancion : Form
    {
        public BuscaCancion()
        {
            InitializeComponent();
            cargarTabla(null);
        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            String nombrecancion = textonombre.Text;
            string sql = "SELECT imgCancion FROM cancion WHERE Nomcancion='" + nombrecancion + "'";

            MySqlConnection conexionBD = CONEXION2.getConexion();
            conexionBD.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                MySqlDataReader reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    MemoryStream ms = new MemoryStream((byte[])reader["imgCancion"]);
                    Bitmap bm = new Bitmap(ms);
                    bunifuPictureBox1.Image = bm;
                }
                else
                {
                    MessageBox.Show("No se encontraron registros");
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al buscar " + ex.Message);
            }
        }

        private void bunifuTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
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

        private void cargarTabla(string dato)
        {
            List<Artista> lista = new List<Artista>();
            CtrlCancion _ctrlArtista = new CtrlCancion();
            bunifuDataGridView1.DataSource = _ctrlArtista.consulta2(dato);
        }
    }
}
