using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SerializarVariosObjetos
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
                
                ArrayList compus = new ArrayList();
                compus.Add(new CCompu(20, "i3", 1, 1300));
                compus.Add(new CCompu(24, "i5", 2, 2500));
                compus.Add(new CCompu(32, "i7", 4, 41200));
                Console.WriteLine("Salvando el objeto");
                XmlSerializer formateador = new XmlSerializer(typeof(ArrayList), new Type[] { typeof(CCompu), typeof(CCPU) });
                Stream miStream = new FileStream("miCPU.cpu", FileMode.Create, FileAccess.Write, FileShare.None);
                formateador.Serialize(miStream, compus);
                miStream.Close();
            }

            if (opcion == "2")
            {
                Console.WriteLine("Leyendo el objeto");
                XmlSerializer formateador = new XmlSerializer(typeof(ArrayList), new Type[] { typeof(CCompu), typeof(CCPU) });
                Stream miStream = new FileStream("miCPU.cpu", FileMode.Open, FileAccess.Read, FileShare.None);
                ArrayList miCompu2 = (ArrayList)formateador.Deserialize(miStream);
                miStream.Close();
                for (int n=0; n<miCompu2.Count; n++)
                {
                    CCompu temp = (CCompu)miCompu2[n];
                    Console.WriteLine(miCompu2[n].ToString());
                }

            }
        }
    }
}
