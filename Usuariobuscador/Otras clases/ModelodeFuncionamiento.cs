using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usuariobuscador.Otras_clases
{
    internal class ModelodeFuncionamiento
    {
        public int registro(Usuarios usuario)
        {
            MySqlConnection conexion = CONEXION2.getConexion();
            conexion.Open();

            string sql = "INSERT INTO usuarios (usuario, Contraseña, Nombre, Apellidos, id_tipo) VALUES(@usuario, @password, @nombre, @apellidos, @id_tipo)";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@usuario", usuario.Usuario);
            comando.Parameters.AddWithValue("@password", usuario.Password);
            comando.Parameters.AddWithValue("@nombre", usuario.Nombre);
            comando.Parameters.AddWithValue("@id_tipo", 1);
            comando.Parameters.AddWithValue("@apellidos", usuario.Apellido);

            int resultado = comando.ExecuteNonQuery();

            return resultado;
        }
        public bool existeUsuario(string usuario)
        {
            MySqlDataReader reader;
            MySqlConnection conexion = CONEXION2.getConexion();
            conexion.Open();

            string sql = "SELECT idUsuarios FROM usuarios WHERE usuario LIKE @usuario";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@usuario", usuario);

            reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Usuarios porUsuario(string usuario)
        {
            MySqlDataReader reader;
            MySqlConnection conexion = CONEXION2.getConexion();
            conexion.Open();

            string sql = "SELECT idUsuarios, Contraseña, Nombre, id_tipo, Apellidos FROM usuarios WHERE Usuario LIKE @usuario";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@usuario", usuario);

            reader = comando.ExecuteReader();

            Usuarios usr = null;

            while (reader.Read())
            {
                usr = new Usuarios();
                usr.Id = int.Parse(reader["idUsuarios"].ToString());
                usr.Password = reader["Contraseña"].ToString();
                usr.Nombre = reader["Nombre"].ToString();
                usr.Id_tipo = int.Parse(reader["id_tipo"].ToString());
                usr.Apellido = reader["Apellidos"].ToString();
            }
            return usr;
        }
    }
}
