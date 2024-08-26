using Sesion3.Modelo;

namespace Sesion3
{
    internal class Program
    {
        /* calcular la edad de una persona y decir si es mayor o menor de edad*/
         
        static void Main(string[] args)
        {
            Persona persona = new Persona();
            string nombre;
            DateTime fechaNac;
            Console.WriteLine("Nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Fecha de nacimiento: " );
            fechaNac = DateTime.Parse(Console.ReadLine());
            persona.Nombre = nombre;
            persona.FechaNac = fechaNac;
            Console.WriteLine(persona.EvaluarEdad());
        }
    }
}
