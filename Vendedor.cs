using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2.Clases
{
    public class Vendedor:Persona
    {
        private String descripcion;

        public String Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        private List<Ciudad> ciudads;

        public List<Ciudad> Ciudads
        {
            get { return ciudads; }
            set { ciudads = value; }
        }

        public Vendedor(string descripcion, List<Ciudad> ciudads, string nombre, string apellido, string cedula):base(nombre,apellido,cedula)
        {
            this.Descripcion = descripcion;
            this.Ciudads = ciudads;
        }
    }
}
