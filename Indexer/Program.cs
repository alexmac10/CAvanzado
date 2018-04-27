using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    class Program
    {
        static void Main(string[] args)
        {
            CTiendaTelevisor miTienda = new CTiendaTelevisor();

            for (int i = 0; i < 3; i++)
            {
                miTienda[i].CalculaImpuesto(0.16);
                miTienda[i].MuestraInformacion();
            }

            Console.WriteLine("-----------------------------");
            miTienda[0] = new CTelevisor("Blanco y negro", 9.0);
            miTienda[1] = new CTelevisor("Descompuesta", 0.50);
            miTienda[2] = new CTelevisor("Sin antena", 8.33);

            for (int i = 0; i < 3; i++)
            {
                miTienda[i].CalculaImpuesto(0.16);
                miTienda[i].MuestraInformacion();
            }

        }
    }
}
