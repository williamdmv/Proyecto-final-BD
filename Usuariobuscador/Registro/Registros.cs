using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Usuariobuscador.Login;
using Usuariobuscador.Otras_clases;

namespace Usuariobuscador.Registro
{
    public partial class Registros : Form
    {
        public Registros()
        {
            InitializeComponent();
        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuLabel6_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            Usuarios usuario = new Usuarios();
            usuario.Usuario = bunifuTextBox1.Text;
            usuario.Password = bunifuTextBox2.Text;
            usuario.ConPassword = bunifuTextBox3.Text;
            usuario.Nombre = bunifuTextBox4.Text;
            usuario.Apellido = bunifuTextBox5.Text;

            try
            {

                Controles control = new Controles();
                string respuesta = control.ctrlRegistro(usuario);

                if (respuesta.Length > 0)
                {
                    MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Usuario registrado, Proceda a ingresar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Logueo ventana = new Logueo();
                    ventana.Show();
                    this.Hide();
                    // System.Windows.Application.Current.Shutdown();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            Logueo ventana = new Logueo();
            ventana.Show();
            this.Hide();
        }
    }
}
