using System;

namespace dotnet_ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Calcular el promedio de un alumno que tiene 7 calificaciones en la materia de Diseño Estructurado
            //de Algoritmos.

            string nombre;
            double suma = 0, promedio = 0;

            Console.WriteLine("Escriba nombre del alumno: ");
            nombre = Console.ReadLine();

            for (int i = 1; i <= 7; i++)
            {
                Console.WriteLine("Digite la calificiacion numero" + i);
                _ = double.TryParse(Console.ReadLine(), out double calificacion);
                suma += calificacion;
                promedio = suma / 7;
            }
            Console.WriteLine("El alumno es " + nombre + " y el promedio que obtuvo en la materia Diseño Estructurado de Algoritmos es: " + promedio);
        }
    }
}
