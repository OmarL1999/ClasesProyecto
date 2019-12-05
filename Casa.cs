using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2.Clases
{
    public class Casa
    {
        private String descripcion;

        public String Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        private Vendedor nombre ;

        public Vendedor Nombre 
        {
            get { return nombre ; }
            set { nombre = value; }
        }

        public Casa(string descripcion, Vendedor nombre)
        {
            this.Descripcion = descripcion;
            this.Nombre = nombre;
        }
    }
}
