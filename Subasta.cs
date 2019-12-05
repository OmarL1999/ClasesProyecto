using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2.Clases
{
    public class Subasta
    {
        private int pujaInicio;

        public int PujaInicio 
        {
            get { return pujaInicio; }
            set { pujaInicio = value; }
        }
        private int pujaFinal;

        public int PujaFinal 
        {
            get { return pujaFinal; }
            set { pujaFinal = value; }
        }

    }
}
