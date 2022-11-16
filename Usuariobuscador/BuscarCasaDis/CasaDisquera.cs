using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Usuariobuscador.BuscarProductores;

namespace Usuariobuscador.BuscarCasaDis
{
    internal class CasaDisquera
    {
        private string nomcasa;
        private string perfilcasa;
        private string localizacion;
        private string nombrealbum;

        public string Nomcasa { get => nomcasa; set => nomcasa = value; }
        public string Perfilcasa { get => perfilcasa; set => perfilcasa = value; }
        public string Localizacion { get => localizacion; set => localizacion = value; }
        public string Nombrealbum { get => nombrealbum; set => nombrealbum = value; }
    }


}
