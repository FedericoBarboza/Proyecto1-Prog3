using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1_Prog3
{
    public interface PersistenciaDepartamento
    {
        Departamento buscar(int id);
        void guardar(Departamento depto);
        void eliminar(int id);
        List<Departamento> lista();
    }
}
