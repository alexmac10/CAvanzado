using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventosDelegados
{
    class Program
    {
        static void Main(string[] args)
        {
            CCaldera miCaldera = new CCaldera(6.5f);
            CCaldera.DPocoCombustible pc = new CCaldera.DPocoCombustible(MetodoCombustible);
            CCaldera.DPocoCombustible pcp = new CCaldera.DPocoCombustible(MetodoCombustibleParanoico);
            CCaldera.DAltaTemperatura at = new CCaldera.DAltaTemperatura(MetodoAltaTemperatura);

            miCaldera.mPocoCombustible += pc;
            miCaldera.mPocoCombustible += pcp;
            miCaldera.mAltaTemperatura -= at;

            while (miCaldera.Combustible > 0)
            {
                miCaldera.trabajo();
            }

            miCaldera.mPocoCombustible -= pc;
            miCaldera.Combustible = 7.0f;
            Console.WriteLine("**************************");

            while (miCaldera.Combustible > 0)
            {
                miCaldera.trabajo();
            }

        }

        public static void MetodoCombustible(float c)
        {
            Console.WriteLine("-----------");
            Console.WriteLine("----------- Queda poco combustible, {0} litros", c);
            Console.WriteLine("-----------");
        }

        public static void MetodoAltaTemperatura(float t)
        {
            Console.WriteLine("-----------");
            Console.WriteLine("----------- Temperatura alta, {0} grados", t);
            Console.WriteLine("-----------");
        }

        public static void MetodoCombustibleParanoico(float t)
        {
            Console.WriteLine("----- Peligro ------");
            Console.WriteLine("----- Peligro ------");
            Console.WriteLine("----------- Casi sin combustible, {0} litros", t);
            Console.WriteLine("--------------------");
        }
    }
}
