using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Threading.Tasks;

namespace SerializacionSOAP
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcion;

            Console.WriteLine("1.- Salvar objeto, 2.- leer objeto");
            opcion = Console.ReadLine();

            if (opcion == "1")
            {
                CCPU miCPU = new CCPU("i5", 4, 180.5);
                SoapFormatter formateador = new SoapFormatter();
                Stream miStream = new FileStream("miCPU.cpu", FileMode.Create, FileAccess.Write, FileShare.None);
                formateador.Serialize(miStream, miCPU);
                miStream.Close();
            }

            if (opcion == "2")
            {
                Console.WriteLine("Leyendo el objeto");
                SoapFormatter formateador = new SoapFormatter();
                Stream miStream = new FileStream("miCPU.cpu", FileMode.Open, FileAccess.Read, FileShare.None);
                CCPU miCPU2 = (CCPU)formateador.Deserialize(miStream);
                miStream.Close();
                Console.WriteLine(miCPU2.ToString());
            }
        }
    }
}
