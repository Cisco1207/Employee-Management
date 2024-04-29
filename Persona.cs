using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo_P2_MJ
{
    class Persona
    {
        //Atributos
        private string nombre;
        public string Nombre
        {
            get 
            {
                return nombre; //Devolviendo el valor del atributo privado
            }
            set
            {
                nombre = value;
            }
        }
        public int edad { get; set; }


        //Metodos
        public void comer()
        {
            // Aqui va el codigo de este metodo
        }

        public void correr()
        {
            // Aqui va el codigo de este metodo
        }
    }
}
