using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobrecargaOperadores
{
    class Program
    {
        static void Main(string[] args)
        {
            CVector v1 = new CVector(5,3);
            CVector v2 = new CVector(2,1);
            CVector v3;

            Console.WriteLine("Valores de los vectores inicales");
            Console.WriteLine("V1");
            v1.Mostrar();
            Console.WriteLine("V2");
            v2.Mostrar();
            Console.WriteLine("---------------------------------");

            Console.WriteLine("Sobre carga de operadores + y -");
            v3 = v1 + v2;

            Console.WriteLine("{0} + {1} = {2}",v1,v2,v3);

            v3 = v1 - v2;

            Console.WriteLine("{0} + {1} = {2}", v1, v2, v3);

            Console.WriteLine("---------------------------------");
            Console.WriteLine("Sobre carga de operadores ++ y --");
            Console.WriteLine("incremento v1");
            Console.WriteLine("Antes {0}",v1);
            v1++;
            Console.WriteLine("Despues {0}", v1);

            Console.WriteLine("Decremento v1");
            Console.WriteLine("Antes {0}", v1);
            v1--;
            Console.WriteLine("Despues {0}", v1);

            Console.WriteLine("---------------------------------");            
            Console.WriteLine("Sobre carga de operadores == y !=");
            if (v1 == v2)
            {
                Console.WriteLine("Son iguales");
            }
            else
            {
                Console.WriteLine("No son iguales");
            }

            Console.WriteLine("---------------------------------");
            Console.WriteLine("Sobre carga de operadores < y >");

            if (v1 > v2)
            {
                Console.WriteLine("v1 es mayor");
            }
            else
            {
                Console.WriteLine("v2 es mayor");
            }

            if (v1 < v2)
            {
                Console.WriteLine("v1 es menor");
            }
            else
            {
                Console.WriteLine("v2 es menor");
            }

            Console.WriteLine("---------------------------------");
            Console.WriteLine("Utilizando sobrecarga de operadores en un ciclo");
            v1 = new CVector(-5,-33);
            v2 = new CVector(5,33);

            do
            {
                v1++;
                v2--;
                v1.Mostrar();
                v2.Mostrar();

            } while (v1 != v2);
        }
    }
}
