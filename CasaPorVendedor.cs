using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2.Clases
{
    public class CasaPorVendedor
    {
        private Vendedor vendedor;

        public Vendedor Vendedor
        {
            get { return vendedor; }
            set { vendedor = value; }
        }
        private Casa casas;

            public Casa Casas
        {
            get { return casas; }
            set { casas = value; }
        }

        public CasaPorVendedor(Vendedor vendedor, Casa casas)
        {
            this.Vendedor = vendedor;
            this.Casas = casas;
        }

    }
}
