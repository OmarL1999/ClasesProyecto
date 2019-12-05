using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2.Clases
{
    public class Cliente:Persona
    {
        private String descripcion;

        public String Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        private String historial;

        public String Historial
        {
            get { return historial; }
            set { historial = value; }
        }

        public Cliente(string descripcion, string historial,string nombre, string apellido, string cedula):base(nombre,apellido,cedula)
        {
            this.Descripcion = descripcion;
            this.Historial = historial;
        }
    }
}
