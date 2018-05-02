using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializarVariosObjetos
{
    [Serializable]
    public class CCPU
    {
        private string procesador;
        private int memoria;
        private double discoDuro;
        private string fabricante;

        public CCPU()
        {
            this.procesador = "i3";
            this.memoria = 1;
            this.discoDuro = 80.0;
            this.fabricante = "PatitoCo";
        }

        public CCPU(string pprocesador, int mmemoria, double ddiscoDuro)
        {
            this.procesador = pprocesador;
            this.memoria = mmemoria;
            this.discoDuro = ddiscoDuro;
            this.fabricante = "PatitoCo";
        }

        public string Procesador
        {
            get { return this.procesador; }
            set { this.procesador = value;}
        }

        public int Memoria
        {
            get { return this.memoria; }
            set { this.memoria = value; }
        }

        public double DiscoDuro
        {
            get { return this.discoDuro; }
            set { this.discoDuro = value; }
        }

        public override string ToString()
        {
            return string.Format("CPU - {0}, {1} GB de memoria, {2} GB de HD", this.procesador, this.memoria, this.discoDuro);            
        }
    }
}
