using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto1_Prog3
{
    public class IngresoEmpleado : VisitanteEmpleado
    {
        public List<Empleado> resultado = new List<Empleado>();
        private DateTime fecha_ingreso;

        public IngresoEmpleado(int fecha_ingreso)
        {
            this.fecha_ingreso = fecha_ingreso;
        }

        public void visitar(Empleado emp)
        {
            if (emp.fecha_ingreso == fecha_ingreso)
                resultado.Add(emp);
        }
    }
}