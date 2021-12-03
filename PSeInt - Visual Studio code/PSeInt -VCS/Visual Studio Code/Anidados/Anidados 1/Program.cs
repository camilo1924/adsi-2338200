using System;

namespace Anidados_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1.Dado tres números calcular el mayor */

            byte num1, num2, num3;

            Console.WriteLine("BUENAS!");
            Console.WriteLine("Digite el primer numero");
            num1 = byte.Parse(Console.ReadLine());
            Console.WriteLine("Digite el segundo numero");
            num2 = byte.Parse(Console.ReadLine());
            Console.WriteLine("Digite el tecer numero");
            num3 = byte.Parse(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("El número mayor es " + num1);
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine("El número mayor es " + num2);
            }
            else if (num3 > num1 && num3 > num2)
            {
                Console.WriteLine("El número mayor es " + num3);
            }

        }
    }
}
