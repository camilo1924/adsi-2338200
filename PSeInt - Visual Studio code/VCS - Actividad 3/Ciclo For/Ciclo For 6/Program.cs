using System;

namespace Ciclo_For_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Una persona debe realizar un muestreo con 50 personas para determinar el promedio de peso de los
            //niños, jóvenes, adultos y adultos mayores que existen en su zona habitacional. Se determinan las
            //categorías con base en la sig, tabla

            //CATEGORIA      EDAD
            //Niños         0 – 12
            //Jóvenes      13 - 29
            //Adultos      30 - 59
            //Adultos    Mayores 60 en adelante

            //. Se debe solicitar la edad y el peso de cada persona y calcular y mostrar el promedio por categoría.

            double cantidadNiños = 0, cantidadJovenes = 0, cantidadAdultos = 0, cantidadAdultosM = 0, sumaNiños = 0, sumaJovenes = 0, sumaAdultos = 0,
            sumaAdultosM = 0, promedioNiños = 0, promedioJovenes = 0, promedioAdultos = 0, promedioAdultosM = 0;
            for (int i = 1; i <= 4; i++)
            {
                Console.WriteLine("\nDigite el peso en Kilogramos de la persona #" + i);
                _ = double.TryParse(Console.ReadLine(), out double peso);
                Console.WriteLine("\nDigite la edad en años de la persona numero #" + i);
                _ = double.TryParse(Console.ReadLine(), out double edad);

                if (edad >= 0 && edad <= 12)
                {
                    cantidadNiños += 1;
                    sumaNiños = sumaNiños + peso;
                }
                else if (edad > 12 && edad <= 29)
                {
                    cantidadJovenes += 1;
                    sumaJovenes = sumaJovenes + peso;
                }
                else if (edad > 29 && edad <= 59)
                {
                    cantidadAdultos += 1;
                    sumaAdultos = sumaAdultos + peso;
                }
                else if (edad >= 60)
                {
                    cantidadAdultosM += 1;
                    sumaAdultosM = sumaAdultosM + peso;
                }
            }
            promedioNiños = sumaNiños / cantidadNiños;
            promedioJovenes = sumaJovenes / cantidadJovenes;
            promedioAdultos = sumaAdultos / cantidadAdultos;
            promedioAdultosM = sumaAdultosM / cantidadAdultosM;

            Console.WriteLine("El promedio del peso en la categoria de niños es de " + promedioNiños);
            Console.WriteLine("El promedio del peso en la categoria de jovenes es de " + promedioJovenes);
            Console.WriteLine("El promedio del peso en la categoria de adultos es de " + promedioAdultos);
            Console.WriteLine("El promedio del peso en la categoria de adultos mayores es de " + promedioAdultosM);
        }
    }
}
