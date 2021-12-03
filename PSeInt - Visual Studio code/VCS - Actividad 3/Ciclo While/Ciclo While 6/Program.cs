using System;

namespace Ciclo_While_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //6. Calcular el promedio de edades de hombres, mujeres y de todo un grupo de n alumnos.

            Console.WriteLine("¿Cuantos alumnos hay en este grupo? ");
            _ = double.TryParse(Console.ReadLine(), out double n);
            int contador = 0;
            double promedio1 = 0, promedio2 = 0, promedioT = 0, sumaedadH = 0, sumaedadM = 0;
            int genero1 = 0, genero2 = 0;

            while (contador < n)
            {
                Console.WriteLine("\nIngrese el genero del alumno deacuerdo a lo siguiente: \n si es hombre marque la opcion 1 \n si es mujer marque la opcion 2");
                _ = int.TryParse(Console.ReadLine(), out int genero);
                Console.WriteLine("Digite la edad en años");
                _ = int.TryParse(Console.ReadLine(), out int edad);

                if (genero == 1)
                {
                    genero1 = genero1 + 1;
                    sumaedadH = sumaedadH + edad;
                    promedio1 = sumaedadH / genero1;
                }
                else if (genero == 2)
                {
                    genero2 = genero2 + 1;
                    sumaedadM = sumaedadM + edad;
                    promedio2 = sumaedadM / genero2;
                }
                contador++;
            }
            promedioT = (sumaedadH + sumaedadM) / n;
            Console.WriteLine("\nEl promedio de las edades de los hombres es de " + promedio1);
            Console.WriteLine("\nEl promedio de las edades de las mujeres es de " + promedio2);
            Console.WriteLine("\nEl promedio de las edades del grupo es de " + promedioT);
        }
    }
}
