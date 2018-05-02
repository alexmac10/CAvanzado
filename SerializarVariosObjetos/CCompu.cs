using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializarVariosObjetos
{
    [Serializable]
    public class CCompu
    {
        private int monitor;
        private CCPU cpu;

        public CCompu()
        {
            this.monitor = 20;
            this.cpu = new CCPU();
        }

        public CCompu(int pmonitor, string pprocesador, int mmemoria, double ddiscoDuro)
        {
            this.monitor = pmonitor;
            this.cpu = new CCPU(pprocesador,mmemoria,ddiscoDuro);
        }

        public int Monitor
        {
            get { return this.monitor; }
            set { this.monitor = value; }
        }

        public CCPU CPU
        {
            get { return this.cpu; }
            set { this.cpu = value; }
        }

        public override string ToString()
        {
            return string.Format("Monitor {0}, CPU - {1}, {2} GB de memoria, {3} GB de HD", this.monitor, this.cpu.Procesador, this.cpu.Memoria, this.cpu.DiscoDuro);
        }
    }
}
