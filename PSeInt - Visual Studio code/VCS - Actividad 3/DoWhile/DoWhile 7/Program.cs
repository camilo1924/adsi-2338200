using System;

namespace DoWhile_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //7. Hacer un programa que lea caracteres desde teclado hasta que lea 10 veces la letra 'a'. Por cada
            //carácter leído que no sea una 'a' debe mostrar un mensaje indicándolo. Cuando lea las 10 letras 'a'
            //el programa terminará.


            int Letra_A = 0;
            string Letras;

            do
            {
                Console.WriteLine("Ingrese una letra del abecedario");
                Letras = Console.ReadLine();
                if (Letras == "A" || Letras == "a")
                {
                    Letra_A++;
                }
                else
                {
                    Console.WriteLine("No es una letra 'A'");
                }
            } while (Letra_A <= 10);
        }
    }
}
