using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallbackInterface
{
    class CEventosCalderaSink : IEventosCaldera
    {
        public void EAltaTempertatura(float t)
        {
            Console.WriteLine("-----");
            Console.WriteLine("----- Temperatura alta {0} grados", t);
            Console.WriteLine("-----");
        }

        public void EPocoCombustible(float c)
        {
            Console.WriteLine("-----");
            Console.WriteLine("----- Queda poco combustible {0} litros", c);
            Console.WriteLine("-----");
        }
    }
}
