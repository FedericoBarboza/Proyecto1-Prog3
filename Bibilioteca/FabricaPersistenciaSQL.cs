using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto1_Prog3
{
   public class FabricaPersistenciaSQL : FabricaPersistencia
    {
        public PersistenciaDepartamento ObtenerPersistenciaDepartamento()
        {
            return new PersistenciaSQLDepto();
        }
        public PersistenciaEmpleado ObtenerPersistenciaEmpleado()
        {
            return new PersistenciaSQLEmpleado();
        }
    }
}