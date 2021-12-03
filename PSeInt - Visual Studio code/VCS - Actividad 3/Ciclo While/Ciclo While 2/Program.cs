using System;

namespace dotnet_ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. En una empresa se requiere calcular el salario semanal de cada uno de los n obreros que laboran en
            //ella. El salario se obtiene de la sig. forma:
            //Si el obrero trabaja 40 horas o menos se le paga $20 por hora
            //Si trabaja más de 40 horas se le paga $20 por cada una de las primeras 40 horas y $25 por cada hora extra.

            Console.WriteLine("¿Cuantos obreros trabajaron esta semana? ");
            _ = int.TryParse(Console.ReadLine(), out int n);
            int contador = 0, i = 0;
            double horaE = 0, sueldo_total = 0;

            while (contador <= n)
            {
                for (i = 1; i <= n; i++)
                {
                    Console.WriteLine("\nIngrese el numero de horas que trabajo el obrero " + i);
                    _ = double.TryParse(Console.ReadLine(), out double cantidadh);

                    if (cantidadh <= 40)
                    {
                        sueldo_total = cantidadh * 20;
                    }
                    else if (cantidadh > 40)
                    {
                        horaE = (cantidadh - 40);
                        sueldo_total = (40 * 20) + (horaE * 25);
                    }
                    Console.WriteLine("\nEl salario semanal del obrero numero " + i + " es $" + sueldo_total);
                }
                break;
            }
        }

    }
}