using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto1_Prog3
{
    public class ContadorPorDepto:VisitanteEmpleado
    {
        public int resultado = 0;
        private int cod_depto;

        public ContadorPorDepto(int cod_depto)
        {
            this.cod_depto = cod_depto;
        }

        public void visitar(Empleado emp)
        {
            if (emp.Cod_depto == cod_depto)
                resultado++;
        }
    }
}