using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_Estados
{
    public class EstadoTramiteA : EstadoTramite
    {

        public void operacion3(Tramite t)
        {
            Console.WriteLine("operacion3 desde Estado A");
        }

        public void operacion2(Tramite t, int valor)
        {
            Console.WriteLine("operacion2 desde Estado A");
        }

    }
}
