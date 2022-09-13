using System;

namespace Clase_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string nombre = Funciones.NombreApp();
            
            int cantidad = Funciones.CantidadAlumnos("A");
            Console.WriteLine(nombre);
            Console.WriteLine(cantidad);
        }
    }
}
