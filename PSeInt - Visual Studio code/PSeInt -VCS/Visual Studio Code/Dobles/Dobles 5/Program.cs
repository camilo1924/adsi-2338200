using System;

namespace Dobles
{
    class Program
    {
        static void Main(string[] args)
        {
            /*5. Un cliente ordena cierta cantidad de brochas de cerda y rodillos; las brochas de cerda tienen un 20% de
           descuento y los rodillos un 15% de descuento. Los datos que se tienen por cada tipo de artículo son: la cantidad 
           pedida y el precio unitario. Además, si se paga de contado todo tiene un descuento del 7%. Elaborar un
           programa en LPP y DFD que calcule y muestre en pantalla el costo total de la orden, tanto para el pago de
           contado como para el caso de pago de crédito. Para el caso de pago de contado el usuario ingresa 1, para pago
           a crédito el usuario ingresa 2.*/

            double brochas, rodillos, descuento_brochas, descuento_rodillos, total_Pago;
            byte Cantidad_brochas, Cantidad_rodillos, Medio_pago;

            brochas = (5000);
            descuento_brochas = brochas - (brochas * 0.20);
            rodillos = (15000);
            descuento_rodillos = rodillos - (rodillos * 0.15);


            Console.WriteLine("Digite la cantidad de brochas que desea comprar, las cuales tienen un 20% de descuento ");
            Cantidad_brochas = byte.Parse(Console.ReadLine());
            Console.WriteLine("Digite la cantidad de rodillos que desea comprar, los cuales tienen un 15% de descuento");
            Cantidad_rodillos = byte.Parse(Console.ReadLine());
            Console.WriteLine("Seleccione el medio de pago con el cual desea cancelar\n 1. Contado / 2. Credito");
            Medio_pago = byte.Parse(Console.ReadLine());

            if (Medio_pago != 1 && Medio_pago != 2)
            {
                Console.WriteLine("Numero no valido, vuelva a intentarlo ");
                Console.WriteLine("Seleccione el medio de pago con el cual desea cancelar\n 1. Contado / 2. Credito");
                Medio_pago = byte.Parse(Console.ReadLine());
            }

            total_Pago = (Cantidad_rodillos * descuento_rodillos) + (Cantidad_brochas * descuento_brochas);

            if (Medio_pago == 1)
            {
                total_Pago = total_Pago - (total_Pago * 0.07);
                Console.WriteLine("Su total a pagar es de " + total_Pago);
            }
            else
            {
                Console.WriteLine("Su total a pagar es de " + total_Pago);
            }

        }
    }
}
