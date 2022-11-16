using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Usuariobuscador.BuscarProductores
{
    internal class CtrlProduc
    {
        public List<Object> consulta2(string dato)
        {
            MySqlDataReader reader;
            List<Object> lista = new List<object>();
            string sql;

            if (dato == null)
            {
                sql = "SELECT  nomProductor, Perfil FROM productor ORDER BY nomProductor ASC";
            }
            else
            {
                sql = "SELECT  nomProductor, Perfil FROM productor WHERE nomProductor LIKE '%" + dato + "%' OR Perfil LIKE '%" + dato + "%' ORDER BY nomProductor ASC";
            }

            try
            {
                MySqlConnection conexionBD = CONEXION2.getConexion();
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Productor _productor = new Productor();
                    _productor.Nomproductor = reader[0].ToString();
                    _productor.Perfil = reader[1].ToString();
                    lista.Add(_productor);
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            return lista;
        }
    }
}
