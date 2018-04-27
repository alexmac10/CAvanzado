using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    class CTiendaTelevisor
    {
        private ArrayList misTelevisores = new ArrayList();

        public CTiendaTelevisor()
        {
            misTelevisores.Add(new CTelevisor("Plasma",1700.00));
            misTelevisores.Add(new CTelevisor("LED", 2300.50));
            misTelevisores.Add(new CTelevisor("Pantalla Plana", 800.33));
        }

        //Creamos Indexer
        public CTelevisor this[int posicion]
        {
            //Para poder leer la información en esa posicion
            get { return (CTelevisor)misTelevisores[posicion]; }
            //Para poder escribir la información en esa posicion
            set { misTelevisores[posicion] = value; }
        }
    }
}
