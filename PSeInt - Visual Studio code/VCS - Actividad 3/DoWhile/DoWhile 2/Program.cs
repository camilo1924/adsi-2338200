using System;

namespace DoWhile_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. Un alumno de la clase de lógica matemática desea desarrollar un algoritmo y diagrama de flujo en el
            //cual introduzca un número entero positivo e invierta los dígitos del número. Mostrar el número
            //invertido.

            int num_invert = 0, nummedio, numero;

            do
            {
                Console.WriteLine("\nIngrese un numero entero positivo");
                _ = int.TryParse(Console.ReadLine(), out numero);
            } while (numero <= 0);

            nummedio = numero;
            do
            {
                num_invert = num_invert * 10 + nummedio % 10;
                nummedio = nummedio / 10;

            } while (nummedio > 0);
            Console.WriteLine("\nEl numero ingresado es: " + numero + "\nEl numero invertido es: " + num_invert);
        }
    }
}
