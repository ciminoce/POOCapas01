using POOCapas01.Datos;
using POOCapas01.Entidades;
using System;
using System.Collections.Generic;

namespace POOCapas01.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            var repo = new RepositorioDePersonas();
            var p = new Persona();
            p.Nombres = "George";
            p.Apellido = "Harrison";

            p.Dni = 14977777;
            repo.Agregar(p);
            Console.WriteLine(p.NombreCompleto());
            var p3 = new Persona();
            p3.Nombres = "John";
            p3.Apellido = "Doe";
            p3.Dni = 40000000;
            repo.Agregar(p3);
            Console.WriteLine(p3.NombreCompleto());
            Console.Clear();
            Console.WriteLine($"Cantidad de personas en repositorio: {repo.GetCantidad()}");
            var lista = repo.GetLista();
            MostrarPersonas(lista);
            var pEnRepo = repo.GetPersona(1);
            if (pEnRepo!=null)
            {
                Console.WriteLine(pEnRepo.NombreCompleto());

            }
            else
            {
                Console.WriteLine("Persona no encontrada!!!");
            }
            Console.ReadLine();
        }

        private static void MostrarPersonas(List<Persona> lista)
        {
            foreach (var p in lista)
            {
                Console.WriteLine(p.NombreCompleto());
            }
        }
    }
}
