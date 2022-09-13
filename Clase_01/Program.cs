using System;

namespace Clase_01
{
    class Program
    {
        //        Consigna
        //Ingresar 5 números por consola, guardándolos en una variable escalar.Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio.
        static void Main(string[] args)
        {
            int acumulador = 0;
            int maximo = 0;
            int minimo = 0;
            float promedio;
            bool funciono = false;
            int cantidadNumeros = 5;

            for (int i = 0; i < cantidadNumeros; i++)
            {

                Console.WriteLine("Ingrese numero");
                string numeroString = Console.ReadLine();
                funciono = int.TryParse(numeroString, out int numero);
                if (funciono == true)
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
                    Console.WriteLine("No ingresaste un numero me cierro");
                    break;

                }


            }

            if (funciono == true)
            {
                promedio = (float)acumulador / cantidadNumeros;
                Console.WriteLine("El promedio es {0}, el valor minimo es {1} y el valor maximo {2} ", promedio, minimo, maximo);
            }

        }
    }
}
