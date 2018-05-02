using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SerializacionXMLCompuesta
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
                CCompu miCompu = new CCompu(24, "i7", 8, 1000);
                Console.WriteLine("Salvando el objeto");
                XmlSerializer formateador = new XmlSerializer(typeof(CCompu), new Type[] { typeof(CCPU)});
                Stream miStream = new FileStream("miCPU.cpu", FileMode.Create, FileAccess.Write, FileShare.None);
                formateador.Serialize(miStream, miCompu);
                miStream.Close();
            }

            if (opcion == "2")
            {
                Console.WriteLine("Leyendo el objeto");
                XmlSerializer formateador = new XmlSerializer(typeof(CCompu), new Type[] { typeof(CCPU) });
                Stream miStream = new FileStream("miCPU.cpu", FileMode.Open, FileAccess.Read, FileShare.None);
                CCompu miCompu2 = (CCompu)formateador.Deserialize(miStream);
                miStream.Close();
                Console.WriteLine(miCompu2.ToString());
            }
        }
    }
}
