using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usuariobuscador
{
    internal class Artista
    {
        private string nombre;
        private string apellidos;
        private string nombreartistico;
        private string descripcion;
        private string generomusical;
 

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Nombreartistico { get => nombreartistico; set => nombreartistico = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Generomusical { get => generomusical; set => generomusical = value; }
    
    }
}
