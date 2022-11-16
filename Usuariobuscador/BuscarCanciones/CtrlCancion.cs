using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Usuariobuscador.BuscarProductores;

namespace Usuariobuscador.Canciones
{
    internal class CtrlCancion
    {
        public List<Object> consulta2(string dato)
        {
            MySqlDataReader reader;
            List<Object> lista = new List<object>();
            string sql;

            if (dato == null)
            {
                sql = "SELECT  nomCancion, duracionCancion, añocancion, nombrealbum, nomartista FROM cancion ORDER BY nomCancion ASC";
            }
            else
            {
                sql = "SELECT  nomCancion, duracionCancion, añocancion, nombrealbum, nomartista FROM cancion WHERE nomCancion LIKE '%" + dato + "%' OR duracionCancion LIKE '%" + dato + "%' OR añocancion LIKE '%" + dato + "%' OR nombrealbum LIKE '%" + dato + "%' OR nomartista LIKE '%" + dato + "%' ORDER BY nomCancion ASC";
            }

            try
            {
                MySqlConnection conexionBD = CONEXION2.getConexion();
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Canciones _productor = new Canciones();
                    _productor.Nomcancion = reader[0].ToString();
                    _productor.Duracioncancion = reader[1].ToString();
                    _productor.Añocancion = reader[2].ToString();
                    _productor.Nombrealbum = reader[3].ToString();
                    _productor.Nomartista = reader[4].ToString();
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

