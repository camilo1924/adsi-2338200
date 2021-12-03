using System;

namespace DoWhile_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //5. Calcular la suma siguiente:
            //100 + 98 + 96 + 94 + . . . + 0 en este orden

            int x = 100, suma = 0;

            Console.WriteLine("\nPrograma para calcular la suma de 100 + 98 + 96 + 94 + . . . + 0 en ese orden");

            do
            {
                suma += x;
                x = x - 2;
            } while (x != 0);
            Console.WriteLine("\nEl resultado de esta suma es: " + suma + "\n");
        }
    }
}
