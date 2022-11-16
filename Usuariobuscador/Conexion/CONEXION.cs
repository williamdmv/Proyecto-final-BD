using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usuariobuscador
{
    internal class CONEXION
    {
        public static MySqlConnection getConexion()
        {
            string servidor = "localhost";
            string puerto = "3306";
            string usuario = "root";
            string password = "sw1t@h&8OR1O";
            string bd = "usuarios_sistema";

            string cadenaConexion = "server=" + servidor + ";" + " port=" + puerto + "; " + "user id=" + usuario + ";" + "password=" + password + "; " + "database=" + bd;

            MySqlConnection conexion = new MySqlConnection(cadenaConexion);

            return conexion;

        }
    }
}
