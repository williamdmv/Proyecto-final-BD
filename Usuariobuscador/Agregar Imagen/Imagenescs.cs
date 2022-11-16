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

namespace Usuariobuscador.Agregar_Imagen
{
    public partial class Imagenescs : Form
    {
        public Imagenescs()
        {
            InitializeComponent();
        }

        private void Seleccionar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdSeleccionar = new OpenFileDialog();
            ofdSeleccionar.Filter = "Imagenes | *.jpg; *.png";
            ofdSeleccionar.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            ofdSeleccionar.Title = "Seleccionar Imagen";

            if (ofdSeleccionar.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofdSeleccionar.FileName);
            }
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, ImageFormat.Jpeg);
            byte[] aByte = ms.ToArray();

            MySqlConnection conexionBD = CONEXION2.getConexion();
            conexionBD.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand("Update cancion set imgCancion = @imagen where idCancion = '" + id + "'", conexionBD);
                comando.Parameters.AddWithValue("imagen", aByte);
                comando.ExecuteNonQuery();
                MessageBox.Show("Imagen guardada");
                pictureBox1.Image = null;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al guardar imagen " + ex.Message);
            }
        }

        private void Cargar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            string sql = "SELECT nomCancion, imgCancion FROM cancion WHERE idCancion='" + id + "'";

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
                    pictureBox1.Image = bm;
                    txtNom.Text = reader["nomCancion"].ToString();
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
