using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2
{
     public class Persona
    {
        private String nombre;

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private String apellido;

        public String Apellido
        {
            get { return myVar; }
            set { myVar = value; }
        }
        private String cedula;

        public String Cedula
        {
            get { return cedula; }
            set { cedula = value; }
        }

        public Persona(string nombre, string apellido, string cedula)
        {
            Nombre = nombre;
            Apellido = apellido;
            Cedula = cedula;
        }
    }
}
