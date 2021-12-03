using System;

namespace Ciclo_While_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //5. Obtener el promedio de calificaciones de un grupo de n alumnos.

            Console.WriteLine("¿Cuantos alumnos hay en este Salon? ");
            _ = double.TryParse(Console.ReadLine(), out double n);
            int contador = 0;
            double suma = 0, promedio = 0;

            while (contador < n)
            {
                Console.WriteLine("\nDigite la calificacion del alumno");
                _ = double.TryParse(Console.ReadLine(), out double not);

                suma += not;
                contador++;
            }
            promedio = suma / n;
            Console.WriteLine("\nEl promedio de las calificaciones del grupo es de " + promedio);
        }
    }
}
