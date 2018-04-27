using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallbackInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            CCaldera miCaldera = new CCaldera(50.0f);
            CEventosCalderaSink sinkNormal = new CEventosCalderaSink();
            CEventoParanoicoSink sinkParanoico = new CEventoParanoicoSink();
            miCaldera.adicionaSink(sinkNormal);
            miCaldera.adicionaSink(sinkParanoico);

            while (miCaldera.Combustible > 0 && !sinkParanoico.Detener)
            {
                miCaldera.trabajo();
            }
        }
    }
}
