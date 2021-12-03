using System;

namespace dotnet_ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. Leer 10 números e imprimir solamente los números positivos

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Digite el numero " + i);
                _ = double.TryParse(Console.ReadLine(), out double num);

                if (num > 0)
                {
                    Console.WriteLine("El numero " + num + " es positivo \n");
                }
            }
        }
    }
}