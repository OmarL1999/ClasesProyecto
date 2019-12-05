using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2.Clases
{
    public class Recibo
    {
        private List<CasaPorCiudades> casaPorCiudades;

        public List<CasaPorCiudades> CasaPorCiudades

        {
            get { return casaPorCiudades; }
            set { casaPorCiudades = value; }
        }
        private List<SubastaPorCasa> subastaPorCasas;

        public List<SubastaPorCasa> SubastaPorCasas
        {
            get { return subastaPorCasas; }
            set { subastaPorCasas = value; }
        }
        private List<CasaPorVendedor> casaPorVendedors;

        public List<CasaPorVendedor> CasaPorVendedors
        {
            get { return casaPorVendedors; }
            set { casaPorVendedors = value; }
        }



    }
}
