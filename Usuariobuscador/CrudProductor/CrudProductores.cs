using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Usuariobuscador.CrudProductor
{
    public partial class CrudProductores : Form
    {
        public CrudProductores()
        {
            InitializeComponent();
        }

        private void bunifuButton26_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtidproductor.Text);
            MemoryStream ms = new MemoryStream();
            bunifuPictureBox1.Image.Save(ms, ImageFormat.Jpeg);
            byte[] aByte = ms.ToArray();

            MySqlConnection conexionBD = CONEXION2.getConexion();
            conexionBD.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand("Update productor set imgproductor = @imagen where idProductor = '" + id + "'", conexionBD);
                comando.Parameters.AddWithValue("imagen", aByte);
                comando.ExecuteNonQuery();
                MessageBox.Show("Imagen guardada");
                bunifuPictureBox1.Image = null;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al guardar imagen " + ex.Message);
            }
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdSeleccionar = new OpenFileDialog();
            ofdSeleccionar.Filter = "Imagenes | *.jpg; *.png";
            ofdSeleccionar.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            ofdSeleccionar.Title = "Seleccionar Imagen";

            if (ofdSeleccionar.ShowDialog() == DialogResult.OK)
            {
                bunifuPictureBox1.Image = Image.FromFile(ofdSeleccionar.FileName);
            }
        }

        private void bunifuButton25_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtidproductor.Text);
            string sql = "SELECT nomproductor, apellidoproductor, imgproductor FROM productor WHERE idproductor='" + id + "'";

            MySqlConnection conexionBD = CONEXION2.getConexion();
            conexionBD.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                MySqlDataReader reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    MemoryStream ms = new MemoryStream((byte[])reader["imgproductor"]);
                    Bitmap bm = new Bitmap(ms);
                    bunifuPictureBox1.Image = bm;
                    txtnomproductor.Text = reader["nomproductor"].ToString();
                    txtapellidoproductor.Text = reader["apellidoproductor"].ToString();
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
    }
}
