using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo_P2_MJ
{
    class EmpleadoContratado:Empleado
    {
        public override double Cobrar()
        {
            Salario -= Salario * 0.1;
            return Salario;
        }
    }
}
