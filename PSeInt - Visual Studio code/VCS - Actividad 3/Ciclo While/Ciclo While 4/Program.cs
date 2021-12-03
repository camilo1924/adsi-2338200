using System;

namespace dotnet_ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            //4. El Depto. de Seguridad Publica y Transito del D.F. desea saber, de los n autos que entran a la ciudad
            //de México, cuantos entran con calcomanía de cada color. Conociendo el último dígito de la placa de
            //cada automóvil se puede determinar el color de la calcomanía utilizando la sig. relación:

            // DÍGITO       COLOR
            // 1 o 2        amarilla
            // 3 o 4        rosada
            // 5 o 6        roja
            // 7 o 8        verde
            // 9 o 0        azul

            Console.WriteLine("¿Cuantos autos entraron a la ciudad? ");
            _ = int.TryParse(Console.ReadLine(), out int n);
            int contador = 0;
            double amarilla = 0, rosada = 0, roja = 0, verde = 0, azul = 0;

            while (contador < n)
            {
                Console.WriteLine("\nIngrese el ultimo digito del auto ");
                _ = double.TryParse(Console.ReadLine(), out double calcomania);

                if (calcomania == 1 || calcomania == 2)
                {
                    amarilla = amarilla + 1;
                }
                else if (calcomania == 3 || calcomania == 4)
                {
                    rosada = rosada + 1;
                }
                else if (calcomania == 5 || calcomania == 6)
                {
                    roja = roja + 1;
                }
                else if (calcomania == 7 || calcomania == 8)
                {
                    verde = verde + 1;
                }
                else if (calcomania == 9 || calcomania == 0)
                {
                    azul = azul + 1;
                }
                contador++;
            }
            Console.WriteLine("La cantidad de autos con la calcomania amarilla es de " + amarilla);
            Console.WriteLine("La cantidad de autos con la calcomania rosada es de " + rosada);
            Console.WriteLine("La cantidad de autos con la calcomania roja es de " + roja);
            Console.WriteLine("La cantidad de autos con la calcomania verde es de " + amarilla);
            Console.WriteLine("La cantidad de autos con la calcomania azul es de " + azul);
        }

    }
}