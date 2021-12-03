using System;

namespace Simple_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 3. El jefe de un almacén de ropa, pone una promoción en sus trajes por un período de tres días para
            sus clientes, de tal manera que si un cliente ordena un traje se captura el modelo del traje y el
            precio unitario. Si el cliente ordena tres o más trajes se le hace un descuento del 17%, si no se le
            cobra al precio normal. Desarrollar el algoritmo y diagrama de flujo. */

            string modelo;
            double descuento, total_pago, PrecioUnidad;
            byte Cantidad;

            Console.WriteLine("Escriba el modelo del traje que desea comprar ");
            modelo = Console.ReadLine();
            Console.WriteLine(" Escriba el valor o costo unitario del traje que desea comprar ");
            PrecioUnidad = double.Parse(Console.ReadLine());
            Console.WriteLine(" Escriba la cantidad de trajes de este modelo que desea comprar ");
            Cantidad = byte.Parse(Console.ReadLine());

            total_pago = (Cantidad * PrecioUnidad);
            Console.WriteLine(" El total del pago es de: " + total_pago);

            if (Cantidad >= 3)
            {
                descuento = total_pago - (total_pago * 0.17);
                Console.WriteLine(" Con descuento es: " + descuento);
            }
        }
    }
}
