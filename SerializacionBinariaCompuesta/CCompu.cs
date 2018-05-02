using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializacionBinariaCompuesta
{
    [Serializable]
    class CCompu
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

        public override string ToString()
        {
            return string.Format("Monitor {0}, CPU - {1}, {2} GB de memoria, {3} GB de HD", this.monitor, this.cpu.Procesador, this.cpu.Memoria, this.cpu.DiscoDuro);
        }
    }
}
