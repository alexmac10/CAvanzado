using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace SerializacionBinariaCompuesta
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
                CCompu miCompu = new CCompu(24,"i7", 4, 1000);
                Console.WriteLine("Salvando el objeto");
                BinaryFormatter formateador = new BinaryFormatter();
                Stream miStream = new FileStream("miCompu.cmp", FileMode.Create, FileAccess.Write, FileShare.None);
                formateador.Serialize(miStream, miCompu);
                miStream.Close();
            }

            if (opcion == "2")
            {
                Console.WriteLine("Leyendo el objeto");
                BinaryFormatter formateador = new BinaryFormatter();
                Stream miStream = new FileStream("miCompu.cmp", FileMode.Open, FileAccess.Read, FileShare.None);
                CCompu miCompu2 = (CCompu)formateador.Deserialize(miStream);
                miStream.Close();
                Console.WriteLine(miCompu2.ToString());
            }
        }
    }
}
