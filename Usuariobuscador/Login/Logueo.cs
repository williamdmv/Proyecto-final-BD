using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Usuariobuscador.Panel_usuario;
using Usuariobuscador.Otras_clases;
using Session = Usuariobuscador.Otras_clases.Session;
using Usuariobuscador.Registro;
using Usuariobuscador.CrudArtista;

namespace Usuariobuscador.Login
{
    public partial class Logueo : Form
    {
        public Logueo()
        {
            InitializeComponent();
        }
        
        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            string usuario = bunifuTextBox1.Text;
            string password = bunifuTextBox2.Text;

            try
            {
                Controles ctrl = new Controles();
                string respuesta = ctrl.ctrlLogin(usuario, password);
                if (respuesta.Length > 0)
                {
                    MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                    MessageBox.Show("Bienvenido:", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    if (Session.id_tipo == 2)
                    {
                        CrudArtistas frm = new CrudArtistas();
                        frm.Show();
                        this.Hide();
                    }

                    else
                    {

                        Panelusuario BuscarProductor = new Panelusuario();
                        BuscarProductor.Show();
                        this.Hide();
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
             Registros  ventana = new Registros();
            ventana.Show();
            this.Hide();
        }
    }
}
