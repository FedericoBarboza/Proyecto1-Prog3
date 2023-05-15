using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto1_Prog3
{
    public class Empleado
    {
        public int Nro_doc { get; set; }
        public String nombre { get; set; }
        public String dir_emp { get; set; }
        public int salario { get; set; }
        public String sexo { get; set; }
        public int Cod_depto { get; set; }
        public DateTime fecha_ingreso { get; set; }
        public string grado_formacion { get; set; }
        public int nro_cobro { get; set; }
    }
}