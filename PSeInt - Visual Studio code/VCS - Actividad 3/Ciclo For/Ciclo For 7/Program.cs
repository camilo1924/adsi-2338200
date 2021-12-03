using System;

namespace Ciclo_For_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Al cerrar un expendio de naranjas, 15 clientes recibirán un 15 % de descuento si compran más de 10
            //kilos.Determinar cuánto pagará cada cliente y cuanto percibirá la tienda por esas compras.

             Console.WriteLine("Digite el valor del Kilo de naranja");

            _ = double.TryParse(Console.ReadLine(), out double valor_kilo);

            double descuento = 0, total = 0, pago = 0, suma_pagos = 0;

            for (int i = 1; i <= 15; i++)
            {
                Console.WriteLine("Digite el numero de kilosde naranja que compro el cliente #" + i);
                _ = double.TryParse(Console.ReadLine(), out double kilos);

                pago = valor_kilo * kilos;

                if (kilos > 10)
                {

                    descuento = pago * 0.15;
                }
                else
                {
                    descuento = 0;
                }



                total = pago - descuento;
                suma_pagos = suma_pagos + total;
                Console.WriteLine("El cliente #" + i + " debe pagar" + total);

            }
            Console.WriteLine("las ganancias de la empresa fueron" + suma_pagos);
        }
    }
}
