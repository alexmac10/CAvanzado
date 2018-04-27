using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventosDelegados
{
    class CCaldera
    {
        public delegate void DPocoCombustible(float c);
        public delegate void DAltaTemperatura(float c);       
        public event DPocoCombustible mPocoCombustible;
        public event DAltaTemperatura mAltaTemperatura;
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
            get { return this.combustible; }
            set { this.combustible = value; }
        }

        public void trabajo()
        {
            this.combustible -= 0.3f;
            this.temperatura += 0.8f;

            Console.WriteLine("Combustible = {0}, Temperatura = {1}", this.combustible, this.temperatura);

            if (this.combustible < 5.0f)
            {
                mPocoCombustible(this.combustible);
            }

            if (this.temperatura > 115.0f)
            {
                mAltaTemperatura(this.temperatura);
            }
        }
    }
}
