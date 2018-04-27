using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avanzado
{
    class CRadio : IProducto, ICloneable
    {

        double costo;
        double impuesto;
        string descripcion;

        public CRadio()
        {
            this.costo = 150.85;
            this.descripcion = "Radio de onda corta";
        }

        public void colocarCosto(double nCosto)
        {
            this.costo = nCosto;
        }

        public void calculaImpuesto(double imp)
        {
            this.impuesto = costo * imp;
        }
        
        public void muetraInformacion()
        {
            Console.WriteLine("-- Producto radio");
            Console.WriteLine(this.descripcion);
            Console.WriteLine("Costo {0}, impuesto {1} ", this.costo, this.impuesto);

        }

        public object Clone()
        {
            CRadio temp = new CRadio();
            temp.costo = this.costo;
            temp.descripcion = this.descripcion;
            temp.impuesto = this.impuesto;
            return temp;
        }
    }
}
