using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    class CTelevisor
    {
        double costo;
        double impuesto;
        string descripcion;

        public CTelevisor(string desc, double pcosto)
        {
            this.costo = pcosto;
            this.descripcion = desc;
        }

        public void ColocarCosto(double nCosto)
        {
            costo = nCosto;
        }

        public void CalculaImpuesto(double imp)
        {
            this.impuesto = this.costo * imp;
        }

        public void MuestraInformacion()
        {
            Console.WriteLine("----- Producto televisor");
            Console.WriteLine(this.descripcion);
            Console.WriteLine("Costo {0}, Impuesto {1}",this.costo, this.impuesto);
        }

    }
}
