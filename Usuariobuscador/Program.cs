using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Usuariobuscador.Agregar_Imagen;
using Usuariobuscador.BuscarCasaDis;
using Usuariobuscador.Canciones;
using Usuariobuscador.Crud_Album;
using Usuariobuscador.CrudArtista;
using Usuariobuscador.CrudCancion;
using Usuariobuscador.CrudCasa;
using Usuariobuscador.CrudProductor;
using Usuariobuscador.Login;

namespace Usuariobuscador
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Logueo());
        }
    }
}
