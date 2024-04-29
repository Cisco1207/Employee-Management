using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo_P2_MJ
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Persona persona = new Persona();
            persona.edad = 26;
            persona.Nombre = "Juan";
            Console.WriteLine(persona.Nombre);*/


            // Polimorfismo
            Empleado emp = new EmpleadoFijo();
            //emp = new EmpleadoContratado();
            //emp = new EmpleadoHora();

            Console.Write("\n [1] Fijo \n [2]Por Contrato \n [3]Por hora \n" +
                  "Que tipo de empleado va a procesar? \n   \n" +  "Digitelo: ");
           

            bool opcionValida = false;

            while (!opcionValida)
            {
                if (int.TryParse(Console.ReadLine(), out int opcionElegida))
                {
                    switch (opcionElegida)
                    {
                        case 1:
                            emp = new EmpleadoFijo();
                            opcionValida = true;
                            break;
                        case 2:
                            emp = new EmpleadoContratado();
                            opcionValida = true;
                            break;
                        case 3:
                            emp = new EmpleadoHora();
                            opcionValida = true;
                            break;
                        default:
                            Console.WriteLine("Opción Incorrecta. Por favor, elija una opción válida.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Opción Incorrecta. Por favor, elija una opción válida.");
                }
            }
            Console.Write("Ingrese el nombre: ");
            emp.Nombre = Console.ReadLine();

            Console.Write("Ingrese el Monto: ");
            emp.Salario = int.Parse(Console.ReadLine());

            emp.Cobrar();

            Console.WriteLine(emp);
            Console.ReadKey();
        }
    }
}
