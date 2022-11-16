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

namespace Usuariobuscador.CrudCancion
{
    public partial class CrudCanciones : Form
    {
        public CrudCanciones()
        {
            InitializeComponent();
        }

        private void bunifuButton26_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtidcancion.Text);
            MemoryStream ms = new MemoryStream();
            bunifuPictureBox1.Image.Save(ms, ImageFormat.Jpeg);
            byte[] aByte = ms.ToArray();

            MySqlConnection conexionBD = CONEXION2.getConexion();
            conexionBD.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand("Update cancion set imgCancion = @imagen where idCancion = '" + id + "'", conexionBD);
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
            int id = int.Parse(txtidcancion.Text);
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
                    bunifuPictureBox1.Image = bm;
                    txtNomCancion.Text = reader["nomCancion"].ToString();
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

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            try
            {
                String nomcancion = nomCanciontxt.Text;
                int duracioncancion = int.Parse(Duraciontxt.Text);
                String añocancion = Añotxt.Text;
                String NombreAlbum = NomAlbum.Text;
                //double precio_publico = double.Parse(txtPrecioPublico.Text);
                //int existencias = int.Parse(txtExistencias.Text);

                if (nomcancion != "" && duracioncancion > 0 && añocancion != "" && NombreAlbum != "")
                {

                    string sql = "INSERT INTO cancion (nomcancion, duracioncancion, añocancion, nombrealbum) VALUES ('" + nomcancion + "', '" + duracioncancion + "', '" + añocancion + "','" + NombreAlbum + "')";

                    MySqlConnection conexionBD = CONEXION2.getConexion();
                    conexionBD.Open();

                    try
                    {
                        MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Registro guardado");
                        limpiar();
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Error al guardar: " + ex.Message);
                    }
                    finally
                    {
                        conexionBD.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Debe completar todos los campos");
                }
            }
            catch (FormatException fex)
            {
                MessageBox.Show("Datos incorrectos: " + fex.Message);
            }
        }

        private void limpiar()
        {
            nomCanciontxt.Text = "";
            Duraciontxt.Text = "";
            Añotxt.Text = "";
            NomAlbum.Text = "";
        }

        private void bunifuButton23_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void bunifuButton24_Click(object sender, EventArgs e)
        {
            String id = idcanciontxt.Text;

            string sql = "DELETE FROM cancion WHERE idcancion='" + id + "'";

            MySqlConnection conexionBD = CONEXION2.getConexion();
            conexionBD.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                comando.ExecuteNonQuery();
                MessageBox.Show("Registro eliminado");
                limpiar();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }
        }

        private void bunifuButton22_Click(object sender, EventArgs e)
        {
            String id = idcanciontxt.Text;
            String nomcancion = nomCanciontxt.Text;
            int duracioncancion = int.Parse(Duraciontxt.Text);
            String añocancion = Añotxt.Text;
            String NombreAlbum = NomAlbum.Text;
            string sql = "UPDATE cancion SET NomCancion='" + nomcancion + "', duracioncancion='" + duracioncancion + "', añocancion='" + añocancion + "', NombreAlbum='" + NombreAlbum + "' WHERE idCancion='" + id + "'";

            MySqlConnection conexionBD = CONEXION2.getConexion();
            conexionBD.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                comando.ExecuteNonQuery();
                MessageBox.Show("Registro modificado");
                limpiar();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al modificar: " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }
        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel5_Click(object sender, EventArgs e)
        {

        }
    }
}
