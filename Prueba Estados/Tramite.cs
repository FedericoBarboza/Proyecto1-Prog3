using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_Estados
{
    public class Tramite
    {
        public DateTime fecha { get; set; }
        public int numero { get; set; }

        //otros atributos
        public EstadoTramite estado { get; set; }

        public Tramite()
        { //constructor //los tramites inician con el estado A
            estado = new EstadoTramiteA();
            fecha = DateTime.Today;
        }


        public void operacion3()
        {
            if (estado != null)
                estado.operacion3(this);
            else
                throw new Exception("Estado inválido, no puede ser nulo");
        }

        public void operacion2(int valor)
        {
            if (estado != null)
                estado.operacion2(this, valor);
            else
                throw new Exception("Estado inválido, no puede ser nulo");
        }
    }
}
