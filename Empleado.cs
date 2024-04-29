using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo_P2_MJ
{
   abstract class Empleado
    {
        public string Nombre { get; set; }
        public double Salario { get; set; }

        public abstract double Cobrar();

        public override string ToString()
        {
            return $"{Nombre}, recibira: {Salario}";
        }
    }
}
