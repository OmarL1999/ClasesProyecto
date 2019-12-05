using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2.Clases
{
    public class SubastaPorCasa
    {
        private Subasta subastas;

        public Subasta Subastas
        {
            get { return subastas; }
            set { subastas = value; }
        }
        private Casa casas;

        public Casa Casas
        {
            get { return casas; }
            set { casas = value; }
        }

        public SubastaPorCasa(Subasta subastas, Casa casas)
        {
            this.Subastas = subastas;
            this.Casas = casas;
        }
    }
}
