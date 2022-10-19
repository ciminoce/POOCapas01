using POOCapas01.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOCapas01.Datos
{
    public class RepositorioDePersonas
    {
        private List<Persona> personas;

        public RepositorioDePersonas()
        {
            personas = new List<Persona>();//instancio la lista
        }
        //Métodos
        public void Agregar(Persona persona)
        {
            personas.Add(persona);
        }
        public int GetCantidad()
        {
            return personas.Count;
        }

        public List<Persona> GetLista()
        {
            return personas;
        }
        public Persona GetPersona(int index)
        {
            if (index>=personas.Count)
            {
                return null;
            }
            return personas[index];
        }
    }
}
