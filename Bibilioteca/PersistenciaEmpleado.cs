using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1_Prog3
{
     public interface PersistenciaEmpleado
    {
        Empleado buscar(int id);
        int guardar(Empleado e);
        int eliminar(int id);
        List<Empleado> lista();
    }
}
