using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Empleado
    {
        public static ML.Empleado Calcula_Sueldo( ML.Empleado empleado)
        {
            empleado.Sueldo = empleado.SueldoDiario * empleado.DiasTrabajados;
            empleado.Correct=true;
            return empleado;
        }
    }
}
