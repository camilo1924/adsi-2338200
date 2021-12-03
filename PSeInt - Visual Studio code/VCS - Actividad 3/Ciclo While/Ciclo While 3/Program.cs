using System;

namespace dotnet_ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            //3. Determinar cuantos hombres y cuantas mujeres se encuentran en un grupo de n personas,
            //suponiendo que los datos son extraídos alumno por alumno.

            Console.WriteLine("¿Cuantos personas hay en este grupo? ");
            _ = int.TryParse(Console.ReadLine(), out int n);
            int contador = 0;
            int genero1 = 0, genero2 = 0;

            while (contador < n)
            {
                Console.WriteLine("\nIngrese su genero de acudero a lo siguiente: \n si es hombre marque la opcion 1 \n si es mujer marque la opcion 2");
                _ = int.TryParse(Console.ReadLine(), out int genero);

                if (genero == 1)
                {
                    genero1 = genero1 + 1;
                }
                else if (genero == 2)
                {
                    genero2 = genero2 + 1;
                }
                contador++;
            }
            Console.WriteLine("\nEn el grupo hay " + genero1 + " hombres");
            Console.WriteLine("En el grupo hay " + genero2 + " mujeres");
        }
    }
}