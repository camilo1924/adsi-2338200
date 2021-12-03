using System;

namespace dotnet_ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            //Suponga que se tiene un conjunto de calificaciones de un grupo de 40 alumnos. Realizar un algoritmo
            //para calcular la calificación promedio y la calificación más baja de todo el grupo.
            
            double  suma = 0, promedio = 0, baja = 0;

            for (int i=1; i<=4; i++ )
            {
                Console.WriteLine("Digite la calificiacion numero " +i);
                _ = double.TryParse(Console.ReadLine(), out double calificacion);
                suma += calificacion;
                promedio = suma/4;

                if (i == 1)
                    {
                        baja = calificacion;
                    }
                    else if ( calificacion < baja)
                    {
                        baja = calificacion;
                    }
            }
            Console.WriteLine("El promedio del grupo es de: " +promedio);
            Console.WriteLine("La nota mas baja fue: " +baja);
        }
    }
}