using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usuariobuscador.Canciones
{
    internal class Canciones
    {
        private string nomcancion, duracioncancion, añocancion, nombrealbum, nomartista;

        public string Nomcancion { get => nomcancion; set => nomcancion = value; }
        public string Duracioncancion { get => duracioncancion; set => duracioncancion = value; }
        public string Añocancion { get => añocancion; set => añocancion = value; }
        public string Nomartista { get => nomartista; set => nomartista = value; }
        public string Nombrealbum { get => nombrealbum; set => nombrealbum = value; }
    }
}
