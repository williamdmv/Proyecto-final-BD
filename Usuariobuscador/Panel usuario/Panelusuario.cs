using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Usuariobuscador.BuscarCasaDis;
using Usuariobuscador.BuscarProductores;
using Usuariobuscador.Canciones;

namespace Usuariobuscador.Panel_usuario
{
    public partial class Panelusuario : Form
    {
        public Panelusuario()
        {
            InitializeComponent();
        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            BuscarProductor ventana = new BuscarProductor();
            ventana.Show();
            this.Hide();
        }

        private void bunifuButton22_Click(object sender, EventArgs e)
        {
            BuscaCancion ventana = new BuscaCancion();
            ventana.Show();
            this.Hide();
        }

        private void bunifuButton23_Click(object sender, EventArgs e)
        {
             BuscarCasa  ventana = new BuscarCasa();
            ventana.Show();
            this.Hide();
        }

        private void bunifuButton24_Click(object sender, EventArgs e)
        {
            Bproductor ventana = new Bproductor();
            ventana.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bproductor ventana = new Bproductor();
            ventana.Show();
            this.Hide();
        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton21_Click_1(object sender, EventArgs e)
        {
            BuscarProductor trm= new BuscarProductor();
            trm.Show();
            this.Hide();
        }

        private void bunifuButton22_Click_1(object sender, EventArgs e)
        {
            BuscaCancion trm = new BuscaCancion();
            trm.Show();
            this.Hide();
        }

        private void bunifuButton23_Click_1(object sender, EventArgs e)
        {
            Bproductor trm = new Bproductor();
            trm.Show();
            this.Hide();
        }

        private void bunifuButton24_Click_1(object sender, EventArgs e)
        {
            BuscarCasa trm= new BuscarCasa();   
            trm.Show();
            this.Hide();
        }

        private void bunifuButton25_Click(object sender, EventArgs e)
        {
  
        }
    }
}
