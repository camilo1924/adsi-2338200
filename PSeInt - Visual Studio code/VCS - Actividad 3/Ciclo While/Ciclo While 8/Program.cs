using System;

namespace Ciclo_While_8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Encontrar el mayor valor de un conjunto de n números dados.
            Console.WriteLine(" Digite el nuemro a calcular: ");
            _ = int.TryParse(Console.ReadLine(), out int n);
            int contador = 0;
            double M = 0;

            while (contador < n)
            {
                Console.WriteLine(" Digite el numero: ");
                _ = int.TryParse(Console.ReadLine(), out int Numero);

                if (contador == 1)
                {
                    M = Numero;

                }
                else if (Numero > M)
                {
                    M = Numero;
                }
                contador++;

            }
            Console.WriteLine("\nEl numero Mayor es" + M);
        }
    }
}
