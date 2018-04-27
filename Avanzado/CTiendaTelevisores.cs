using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avanzado
{
    class CTiendaTelevisores : IEnumerable
    {
        private CTelevisor[] televisores;

        public CTiendaTelevisores()
        {
            this.televisores = new CTelevisor[3];
            this.televisores[0] = new CTelevisor("Televisor LCD", 1500.0);
            this.televisores[1] = new CTelevisor("Televisor Plasma", 1800.50);
            this.televisores[2] = new CTelevisor("Televisor LED", 2500.75);
        }

        public IEnumerator GetEnumerator()
        {
            return this.televisores.GetEnumerator();
        }
    }
}
