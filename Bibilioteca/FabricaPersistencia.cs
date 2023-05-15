using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1_Prog3
{
    public interface FabricaPersistencia
    {
        PersistenciaDepartamento ObtenerPersistenciaDepartamento();
        PersistenciaEmpleado ObtenerPersistenciaEmpleado();
    }
}
