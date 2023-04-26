using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto1_Prog3
{
    public class Empresa
    {

        private List<Empleado> empleados = new List<Empleado>();

        private Empresa() { }
        private static Empresa instancia = null;
        public static Empresa getInstancia()
        {

            if (instancia == null)
                instancia = new Empresa();

            return instancia;
        }

        public void renovar()
        {
            empleados = Global.fabricaPersistencia.ObtenerPersistenciaEmpleado().lista();
        }

        public void procesarEmpleados(VisitanteEmpleado vis)
        {

            for (int i = 0; i < empleados.Count; i++)
            {
                //podrian existir filtros o controles sobre que elementos permitir visitar (EJEMPLO IF)
                vis.visitar(empleados[i]);
            }

        }
    }
}