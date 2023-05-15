using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto1_Prog3
{
    public class BuscadorPorDepto : VisitanteEmpleado
    {
        public List<Empleado> resultado = new List<Empleado>();
        private int cod_depto;

        public BuscadorPorDepto(int cod_depto)
        {
            this.cod_depto = cod_depto;
        }

        public void visitar(Empleado emp)
        {
            if (emp.Cod_depto == cod_depto)
                resultado.Add(emp);
        }
    }
}