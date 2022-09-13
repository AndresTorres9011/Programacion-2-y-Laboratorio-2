using System;

namespace Clase_02_01
{
    //    Realizar una clase llamada Validador que posea un método estático llamado Validar con la siguiente firma:

    //bool Validar(int valor, int min, int max)

    //valor: dato a validar.
    //min: mínimo valor incluido.
    //max: máximo valor incluido.
    //Pedir al usuario que ingrese 10 números enteros.Validar con el método desarrollado anteriormente que estén dentro del rango -100 y 100.

    //Terminado el ingreso mostrar el valor mínimo ingresado, valor máximo ingresado y el promedio.
    class Program
    {
        static void Main(string[] args)
        {
            int acumulador = 0;
            int maximo = 0;
            int minimo = 0;
            float promedio;
            bool funciono = false;
            bool estaEnRango=false;
            int cantidadNumeros = 10;

            for (int i = 0; i < cantidadNumeros; i++)
            {

                Console.WriteLine("Ingrese numero entre -100 y 100");
                string numeroString = Console.ReadLine();
                funciono = int.TryParse(numeroString, out int numero);
                estaEnRango = Validador.ValidarRango(numero, -100, 100);

                if (estaEnRango== true && funciono == true)
                {
                    acumulador += numero;
                    if (i == 0)
                    {
                        minimo = numero;
                        maximo = numero;
                    }
                    else
                    {
                        if (numero > maximo)
                        {
                            maximo = numero;

                        }
                        if ((numero < minimo))
                        {
                            minimo = numero;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("No ingresaste un numero, o numero fuera del rango.");
                    break;

                }


            }

            if (funciono == true && estaEnRango == true)
            {
                promedio = (float)acumulador / cantidadNumeros;
                Console.WriteLine("El promedio es {0}, el valor minimo es {1} y el valor maximo {2} ", promedio, minimo, maximo);
            }

        }
    }
}


