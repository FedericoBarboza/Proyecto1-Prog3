using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto1_Prog3
{
    public class Empresa
    {
        private List<Empleado> empleados = new List<Empleado>();

        public void procesarEmpleados(Visitante vis)
        {

            for (int i = 0; i < empleados.Count; i++)
            {
                //podrian existir filtros o controles sobre que elementos permitir visitar (EJEMPLO IF)
                vis.visitar(empleados[i]);
            }

        }
    }
}