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

namespace Usuariobuscador.CrudArtista
{
    public partial class CrudArtistas : Form
    {
        public CrudArtistas()
        {
            InitializeComponent();
            cargarTabla(null);
        }
        private void cargarTabla(string dato)
        {
            List<Artista> lista = new List<Artista>();
            CTRLARTISTA _ctrlArtista = new CTRLARTISTA();
            bunifuDataGridView1.DataSource = _ctrlArtista.consulta(dato);
        }

        private void bunifuCircleProgress1_ProgressChanged(object sender, Bunifu.UI.WinForms.BunifuCircleProgress.ProgressChangedEventArgs e)
        {

        }

        private void bunifuTextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel6_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton26_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Idartistatxt.Text);
            MemoryStream ms = new MemoryStream();
            bunifuPictureBox1.Image.Save(ms, ImageFormat.Jpeg);
            byte[] aByte = ms.ToArray();

            MySqlConnection conexionBD = CONEXION2.getConexion();
            conexionBD.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand("Update artistas set imgartista = @imagen where idartistas= '" + id + "'", conexionBD);
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
            int id = int.Parse(Idartistatxt.Text);
            string sql = "SELECT nomartistico, imgartista FROM artistas WHERE idartistas='" + id + "'";

            MySqlConnection conexionBD = CONEXION2.getConexion();
            conexionBD.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                MySqlDataReader reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    MemoryStream ms = new MemoryStream((byte[])reader["imgartista"]);
                    Bitmap bm = new Bitmap(ms);
                    bunifuPictureBox1.Image = bm;
                    txtnomcancion.Text = reader["nomartistico"].ToString();
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

        private void bunifuButton22_Click(object sender, EventArgs e)
        {
            String id = txtidartista2.Text;
            String nombreArtistico = txtnomartistico2.Text;
            String nombre = txtnomartista2.Text;
            String descripcion = txtdescripcion.Text;
            String GeneroMusical = txtgenero.Text;
            String Apellido = txtapeartista2.Text;
            string sql = "UPDATE artistas SET NomArtistico='" + nombreArtistico + "', Nombre='" + nombre + "', Apellidos='" + Apellido + "', descripcion='" + descripcion + "', GeneroMusical='" + GeneroMusical + "' WHERE idArtistas='" + id + "'";

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

        private void limpiar()
        {
            txtnomartista2.Text = "";
            txtapeartista2.Text = "";
            txtdescripcion.Text = "";
            txtgenero.Text = "";
            txtnomartistico2.Text = "";
            txtidartista2.Text = "";
        }

        private void bunifuButton24_Click(object sender, EventArgs e)
        {
            String id = txtidartista2.Text;

            string sql = "DELETE FROM artistas WHERE idArtistas='" + id + "'";

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

        private void bunifuButton23_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            try
            {
                String nombreArtistico = txtnomartistico2.Text;
                String nombre = txtnomartista2.Text;
                String descripcion = txtdescripcion.Text;
                String GeneroMusical = txtgenero.Text;
                String Apellido = txtapeartista2.Text;
                //double precio_publico = double.Parse(txtPrecioPublico.Text);
                //int existencias = int.Parse(txtExistencias.Text);

                if (nombreArtistico != "" && nombre != "" && descripcion != "" && GeneroMusical != "")
                {

                    string sql = "INSERT INTO artistas (Nombre, Apellidos, NomArtistico, GeneroMusical, Descripcion) VALUES ('" + nombre + "', '" + Apellido + "', '" + nombreArtistico + "','" + GeneroMusical + "','" + descripcion + "')";

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
    }
}
