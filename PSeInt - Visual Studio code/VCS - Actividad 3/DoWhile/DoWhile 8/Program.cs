using System;

namespace DoWhile_8
{
    class Program
    {
        static void Main(string[] args)
        {
            //8. Hacer un programa que lea caracteres desde teclado y vaya contando las vocales que aparecen. El
            //programa terminará cuando lea el carácter # y entonces mostrará un mensaje indicando cuántas
            //vocales ha leído (cuántas de cada una de ellas).

            int vocales = 0, a = 0, e = 0, i = 0, o = 0, u = 0;
            string caracter;
            do
            {
                Console.WriteLine("Digite cualquier caracter del teclado");
                caracter = Console.ReadLine();
                caracter.ToUpper();
                if (caracter == "a" || caracter == "e" || caracter == "i" || caracter == "o" || caracter == "u")
                {
                    A++;
                }
                else if (caracter == "e")
                {
                    e++;
                }
                else if (caracter == "i")
                {
                    i++;
                }
                else if (caracter == "o")
                {
                    o++;
                }
                else if (caracter == "u")
                {
                    u++;
                }
                else
                {
                    Console.WriteLine("No Hay Vocales");
                }
            } while (caracter != "#");
            Vocales = a + e + i + o + u;
            Console.WriteLine("El total de vocales que se ingreso fue de " + vocales);
            Console.WriteLine("El total de vocales a fue de " + a);
            Console.WriteLine("El total de vocales e fue de " + e);
            Console.WriteLine("El total de vocales i fue de " + i);
            Console.WriteLine("El total de vocales o fue de " + o);
            Console.WriteLine("El total de vocales u fue de " + u);
        }
    }
}
