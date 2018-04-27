using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avanzado
{
    class CTelevisor : IProducto, IComparable
    {
        double costo;
        double impuesto;
        string description;

        public CTelevisor(string desc, double pcosto)
        {
            this.costo = pcosto;
            this.description = desc;
        }

        public void colocarCosto(double nCosto)
        {
            this.costo = nCosto;
        }

        public void calculaImpuesto(double imp)
        {
            this.impuesto = this.costo * imp;
        }

        public void muetraInformacion()
        {
            Console.WriteLine("-- Producto televidsor");
            Console.WriteLine(this.description);            
            Console.WriteLine("Costo {0}, impuesto {1} ", this.costo, this.impuesto);

        }

        public int CompareTo(object obj)
        {
            CTelevisor temp = (CTelevisor) obj;
            if(this.costo > temp.costo)
            {
                return 1;
            }else if (this.costo < temp.costo)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
