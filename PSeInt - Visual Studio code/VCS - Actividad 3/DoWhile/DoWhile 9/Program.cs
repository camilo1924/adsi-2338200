using System;

namespace DoWhile_9
{
    class Program
    {
        static void Main(string[] args)
        {
            //9. Escribir un programa que muestre el siguiente menú y que permita pasar magnitudes de grados a
            //radianes y de radianes a grados.
            //1. Pasar de grados a radianes
            //2. Pasar de radianes a grados
            //3. Salir del programa

            double operacion, numero;
            int eleccion;
            do
            {
                Console.WriteLine("¿Que operacion necesita realizar? Digite la opcion de acuerdo a lo siguiente");
                Console.WriteLine("1. Pasar de grados a radianes");
                Console.WriteLine("2.Pasar de radianes a grados");
                Console.WriteLine("3.Salir del programa");
                _ = int.TryParse(Console.ReadLine(), out eleccion);

                if (eleccion < 1 || eleccion > 3)
                {
                    Console.WriteLine("¿Que operacion necesita realizar? Digite la opcion de acuerdo a lo siguiente");
                    Console.WriteLine("1. Pasar de grados a radianes");
                    Console.WriteLine("2.Pasar de radianes a grados");
                    Console.WriteLine("3.Salir del programa");
                }
                else if (eleccion == 1)
                {
                    Console.WriteLine("Digite los grados que quiere pasar a radianes");
                    numero = double.TryParse(Console.ReadLine());
                    operacion = numero * Math.PI / 180;
                    Console.WriteLine("El número convertido a radianes es: " + operacion);
                }
                else
                {
                    Console.WriteLine("Digite los radianes que quiere pasar a grados");
                    numero = double.TryParse(Console.ReadLine());
                    operación = numero * 180 / Math.PI;
                    Console.WriteLine("El número convertido a grados es: " + operacion);
                }
            } while (eleccion < 3);
            Console.WriteLine("termino el programa");
        }
    }
}
