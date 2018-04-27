using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avanzado
{
    class Program
    {
        static void Main(string[] args)
        {
            //Siguiente tema el uso de ICloneable

            CTiendaTelevisores miTienda = new CTiendaTelevisores();
            foreach (CTelevisor tv in miTienda)
            {
                tv.calculaImpuesto(0.16);
                tv.muetraInformacion();
            }

            Console.WriteLine(" ");
            Console.WriteLine("-------------- Clonando objetos -----------");

            CTelevisor miTv = new CTelevisor("Plasma", 1300.80);
            CTelevisor tuTv = miTv;

            Console.WriteLine("Objetos sin ningún cambio");
            miTv.muetraInformacion();
            tuTv.muetraInformacion();
            tuTv.colocarCosto(1500);
            Console.WriteLine("Objetos despues de los camnbios");
            miTv.muetraInformacion();
            tuTv.muetraInformacion();

            CRadio miRadio = new CRadio();
            CRadio tuRadio = (CRadio) miRadio.Clone();

            Console.WriteLine(" ");
            Console.WriteLine("------- Radios ------------");
            Console.WriteLine("Objetos sin ningún cambio");
            miRadio.muetraInformacion();
            tuRadio.muetraInformacion();
            tuRadio.colocarCosto(800.50);
            Console.WriteLine("Objetos despues de los camnbios");
            miRadio.muetraInformacion();
            tuRadio.muetraInformacion();

            Console.WriteLine(" ");
            Console.WriteLine("-------------- Coparando  objetos -----------");
            CTelevisor[] mistTvs = new CTelevisor[3];

            mistTvs[0] = new CTelevisor("Televisor de Plasma", 1500.50);
            mistTvs[1] = new CTelevisor("Televisor de LCD", 2300.45);
            mistTvs[2] = new CTelevisor("Televisor de Pantalla plana", 575.85);

            Console.WriteLine("------ Antes de ordenar -----");
            for (int n = 0; n < mistTvs.Length; n++)
            {
                mistTvs[n].muetraInformacion();
            }

            Array.Sort(mistTvs);
            Console.WriteLine("------ Despues de ordenar -----");
            for (int n = 0; n < mistTvs.Length; n++)
            {
                mistTvs[n].muetraInformacion();
            }


        }
    }
}
