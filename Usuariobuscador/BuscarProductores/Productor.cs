using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usuariobuscador.BuscarProductores
{
    internal class Productor
    {
        private string nomproductor;
        private string perfil;

        public string Nomproductor { get => nomproductor; set => nomproductor = value; }
        public string Perfil { get => perfil; set => perfil = value; }
    }
}
