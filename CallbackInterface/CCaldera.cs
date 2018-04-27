using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallbackInterface
{
    class CCaldera
    {
        private float combustible;
        private float temperatura;
        ArrayList misSinks = new ArrayList();

        public CCaldera(float combInicial)
        {
            this.combustible = combInicial;
            this.temperatura = 10.0f;
        }

        public float Combustible
        {
            get{ return this.combustible; }
        }

        public void trabajo()
        {
            this.combustible -= 0.3f;
            this.temperatura += 0.8f;

            Console.WriteLine("Combustible = {0}, Temperatura = {1}", this.combustible, this.temperatura);

            if (this.combustible < 5.0f)
            {
                foreach(IEventosCaldera evento in misSinks)
                {
                    evento.EPocoCombustible(this.combustible);
                }
            }

            if (this.temperatura > 115.0f)
            {
                foreach (IEventosCaldera evento in misSinks)
                {
                    evento.EAltaTempertatura(this.temperatura);
                }
            }
        }

        public void adicionaSink(IEventosCaldera sink)
        {
            misSinks.Add(sink);
        }

        public void borrarSink(IEventosCaldera sink)
        {
            misSinks.Remove(sink);
        }
    }
}
