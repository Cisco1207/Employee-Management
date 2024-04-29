using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo_P2_MJ
{
    class EmpleadoHora:Empleado
    {
        public override double Cobrar()
        {
            Console.Write("Ingrese las horas laboradas: ");
            int horas = int.Parse(Console.ReadLine());

            Salario = Salario * horas;
            return Salario;
        }
    }
}
