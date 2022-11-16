using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Usuariobuscador.BuscarProductores;

namespace Usuariobuscador.BuscarCasaDis
{
    internal class CtrlCasaDis
    {
        public List<Object> consulta2(string dato)
        {
            MySqlDataReader reader;
            List<Object> lista = new List<object>();
            string sql;

            if (dato == null)
            {
                sql = "SELECT  nomcasa, perfilcasa, localizacion, nombrealbum FROM casadiscografica ORDER BY nomcasa ASC";
            }
            else
            {
                sql = "SELECT nomcasa, perfilcasa, localizacion, nombrealbum  FROM casadiscografica WHERE nomcasa LIKE '%" + dato + "%' OR perfilcasa LIKE '%" + dato + "%' OR localizacion LIKE '%" + dato + "%' OR nombrealbum LIKE '%" + dato + "%' ORDER BY nomcasa ASC";
            }

            try
            {
                MySqlConnection conexionBD = CONEXION2.getConexion();
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    CasaDisquera _casadis = new CasaDisquera();
                    _casadis.Nomcasa = reader[0].ToString();
                    _casadis.Perfilcasa = reader[1].ToString();
                   _casadis.Localizacion = reader[2].ToString();
                    _casadis.Nombrealbum= reader[3].ToString();
                    lista.Add(_casadis);
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
