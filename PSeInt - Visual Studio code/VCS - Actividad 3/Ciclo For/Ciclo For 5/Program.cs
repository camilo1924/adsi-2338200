using System;

namespace Ciclo_For_5
{
    class Program
    {
        static void Main(string[] args)
        {
                //Calcular e imprimir la tabla de multiplicar de un número cualquiera. Imprimir el multiplicando, el
                //multiplicador y el producto.
                Console.WriteLine("Digite el numero que desea multiplica :")
                _ = double.TryParse(Console.ReadLine(), out double Numero);

                double Resultado_1 = 0;

                for (int i = 1; i <= 10; i++)
                {
                    Resultado_1 = Numero * i;
                    Console.WriteLine(Numero + " * " + i + " = " + Resultado_1);
                }
                Console.WriteLine();           
        }
    }

}