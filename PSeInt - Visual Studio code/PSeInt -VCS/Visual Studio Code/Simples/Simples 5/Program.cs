using System;

namespace Simples_5
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 5.Calcular el total que una persona debe pagar en un almacén, si el precio de cada llanta es de $ 80000
           si se compran menos de 5 llantas y de $ 70000 si se compran 5 o más. */

            byte cantidad;
            double PrecioUnidad, total_pago;

            Console.WriteLine(" Digite el numero de llantas que desea comprar ");
            cantidad = byte.Parse(Console.ReadLine());

            PrecioUnidad = (80000);

            if (cantidad >= 5)
            {
                PrecioUnidad = (70000);
            }
            total_pago = PrecioUnidad * cantidad;

            Console.WriteLine(" Su total a pagar es de " + total_pago);
        }
    }
}
