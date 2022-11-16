using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using conectar = Usuariobuscador.CONEXION;

namespace Usuariobuscador
{
    internal class CTRLARTISTA
    {
        public List<Object> consulta(string dato)
        {
            MySqlDataReader reader;
            List<Object> lista = new List<object>();
            string sql;

            if (dato == null)
            {
                sql = "SELECT  nombre, apellidos, nomartistico, generomusical, descripcion FROM artistas ORDER BY nombre ASC";
            }
            else
            {
                sql = "SELECT  nombre, apellidos, nomartistico, generomusical, descripcion FROM artistas WHERE nomartistico LIKE '%" + dato + "%' OR nombre LIKE '%" + dato + "%' OR descripcion LIKE '%" + dato + "%' OR apellidos LIKE '%" + dato + "%' OR generomusical LIKE '%" + dato + "%' ORDER BY nombre ASC";
            }

            try
            {
                MySqlConnection conexionBD = conectar.getConexion();
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Artista _artista = new Artista();
                    _artista.Nombreartistico = reader[2].ToString();
                    _artista.Nombre = reader[0].ToString();
                    _artista.Descripcion = reader[4].ToString();
                    _artista.Apellidos = reader[1].ToString();
                    _artista.Generomusical = reader[3].ToString();
                    lista.Add(_artista);
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
