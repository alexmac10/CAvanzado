using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallbackInterface
{
    class CEventoParanoicoSink : IEventosCaldera
    {
        private bool detener = false;

        public bool Detener
        {
            get { return this.detener; }
        }

        public void EAltaTempertatura(float t)
        {
            if (t > 150.0f)
            {
                Console.WriteLine("---Peligro--");
                Console.WriteLine("---Peligro Apagar Caldera--");
                Console.WriteLine("-------------------");
                this.detener = true;
            }
            else if (t > 130.0f)
            {
                Console.WriteLine("---Peligro--");
                Console.WriteLine("----- Temperatura muy alta {0} grados", t);
                Console.WriteLine("-------------------");
            }
            else if (t > 120.0f)
            {
                Console.WriteLine("---Peligro--");
                Console.WriteLine("----- Temperatura alta {0} grados", t);
                Console.WriteLine("-------------------");
            }
        }

        public void EPocoCombustible(float c)
        {
            Console.WriteLine("---Peligro--");
            Console.WriteLine("---Peligro--");
            Console.WriteLine("----- Casi sin combustible {0} litros", c);
            Console.WriteLine("-------------------");
        }
    }
}
