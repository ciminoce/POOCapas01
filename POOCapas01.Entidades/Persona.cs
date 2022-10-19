using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOCapas01.Entidades
{
    public class Persona
    {
        //Atributos
      
        public string Nombres { get; set; }
        public string Apellido { get; set; }
        public long Dni { get; set; }
        public Persona()//Método constructor
        {

        }
        //Métodos
        public string NombreCompleto()
        {
            return $"{Nombres} {Apellido}";
        }

    }
}
