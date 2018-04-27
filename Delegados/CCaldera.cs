using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegados
{
    class CCaldera
    {
        public delegate void DPocoCombustible(float c);
        public delegate void DAltaTemperatura(float c);
        private DPocoCombustible mPocoCombustible;
        private DAltaTemperatura mAltaTemperatura;
        private float combustible;
        private float temperatura;
        ArrayList misSinks = new ArrayList();

        public CCaldera(float combInicial)
        {
            this.combustible = combInicial;
            this.temperatura = 10.0f;
        }

        public void AdicionalPocoCombustible(DPocoCombustible pmetodo)
        {
            mPocoCombustible += pmetodo;
        }

        public void AdicionalAltaTemperatura(DAltaTemperatura pmetodo)
        {
            mAltaTemperatura += pmetodo;
        }

        public void EliminarPocoCombustible(DPocoCombustible pmetodo)
        {
            mPocoCombustible -= pmetodo;
        }

        public float Combustible
        {
            get { return this.combustible; }
            set { combustible = value; }
        }

        public void trabajo()
        {
            this.combustible -= 0.3f;
            this.temperatura += 0.8f;

            Console.WriteLine("Combustible = {0}, Temperatura = {1}", this.combustible, this.temperatura);

            if (this.combustible < 5.0f)
            {
                mPocoCombustible(combustible);
            }

            if (this.temperatura > 115.0f)
            {
                mAltaTemperatura(temperatura);
            }
        }
    }
}
