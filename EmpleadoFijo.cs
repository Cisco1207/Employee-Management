using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo_P2_MJ
{
    class EmpleadoFijo:Empleado
    {
        public override double Cobrar()
        {
            return Salario;
        }
    }
}
