using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace holaMundo
{
    class Program
    {
         static void Main(string[] args)
        {
            string Nombre = "", Apellido = "";
            Console.WriteLine("Ingrese su nombre");
            Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su apellido");
            Apellido = Console.ReadLine();
            // Create a new instance of the Persona class
            Persona persona = new Persona(Nombre, Apellido);

            // Call the AgregarNombre method of the persona object
            Console.WriteLine(persona.MostrarNombre());
        }
    }

    class Persona
    {
        // Declare the variables nombre and apellido
        string nombre, apellido;

        // Create a constructor for the Persona class
        public Persona(string nombre, string apellido){
            this.nombre = nombre;
            this.apellido = apellido;
        }

        // Create a method that returns the full name of the person
        public string MostrarNombre(){
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Apellido: " + apellido);
            string nombreCompleto = nombre + " " + apellido;

            return nombreCompleto;
        }

    }
}
