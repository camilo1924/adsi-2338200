using System;

namespace Multiples_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1. La empresa comercializadora Solva vende escobas, recogedores y aromatizantes,
              clasifica a sus clientes de acuerdo a la frecuencia de compras con las condiciones
              siguientes:
               Si el cliente es de la categoría 1 se le descuenta el 5%
               Si el cliente es de la categoría 2 se le descuenta el 8%
               Si el cliente de de la categoría 3 se le descuenta el 12%
               Si el cliente es de la categoría 4 se le descuenta el 15%
               Cuando el cliente realiza una compra se generan los siguientes datos:
               Nombre del cliente
               Tipo de cliente
               Cantidad comprada de escobas, recogedores y aromatizantes.
              Los precios de estos elementos son.
              • Escobas. 3000.
              • Recogedores. 2000
              • Aromatizantes. 1000
              Desarrollar un programa en LPP que lea estos datos y calcule y muestre en pantalla:
               Nombre del cliente
               Subtotal a pagar
               Descuento
               Total a pagar.*/

            int Categoria, Cantidad_escobas, Cantidad_aromatizantes, Cantidad_recogedores;
            string Nombre;
            double Escoba, Recogedor, Aromatizante, Sub_Total, descuento, Total_pagar;

            Console.WriteLine("Digite el nombre del cliente");
            Nombre = Console.ReadLine();
            Console.WriteLine("Digite la categoria a la que pertenece \n 1. Categoria 1 \n 2. Categoria 2 \n 3. Categoria 3 \n 4. Categoria 4");
            Categoria = int.Parse(Console.ReadLine());


            while (Categoria != 1 && Categoria != 2 && Categoria != 3 && Categoria != 4)
            {
                Console.WriteLine("valor no valido, intentelo de nuevo");
                Console.WriteLine("Digite la categoria a la que pertenece");
                Console.WriteLine("Digite la categoria a la que pertenece \n 1. Categoria 1 \n 2. Categoria 2 \n 3. Categoria 3 \n 4. Categoria 4");
                Categoria = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Digite la cantidad de escobas que desea comprar");
            bool resp0 = int.TryParse(Console.ReadLine(), out Cantidad_escobas);
            Console.WriteLine("Digite la cantidad de Recogedores que desea comprar");
            bool resp1 = int.TryParse(Console.ReadLine(), out Cantidad_recogedores);
            Console.WriteLine("Digite la cantidad de escobas que desea comprar");
            bool resp2 = int.TryParse(Console.ReadLine(), out Cantidad_aromatizantes);


            Escoba = 3000;
            Recogedor = 2000;
            Aromatizante = 1000;

            switch (Categoria)
            {
                case 1:
                    Sub_Total = (Escoba * Cantidad_escobas) + (Recogedor * Cantidad_recogedores) + (Aromatizante * Cantidad_aromatizantes);
                    descuento = (Sub_Total * 5) / 100;
                    Total_pagar = Sub_Total - descuento;
                    Console.WriteLine("Cliente:       " + Nombre);
                    Console.WriteLine("Sub total:     " + Sub_Total);
                    Console.WriteLine("Descuento:     " + descuento);
                    Console.WriteLine("Total a pagar: " + Total_pagar);
                    break;
                case 2:
                    Sub_Total = (Escoba * Cantidad_escobas) + (Recogedor * Cantidad_recogedores) + (Aromatizante * Cantidad_aromatizantes);
                    descuento = (Sub_Total * 8) / 100;
                    Total_pagar = Sub_Total - descuento;
                    Console.WriteLine("Cliente:       " + Nombre);
                    Console.WriteLine("Sub total:     " + Sub_Total);
                    Console.WriteLine("Descuento:     " + descuento);
                    Console.WriteLine("Total a pagar: " + Total_pagar);
                    break;
                case 3:
                    Sub_Total = (Escoba * Cantidad_escobas) + (Recogedor * Cantidad_recogedores) + (Aromatizante * Cantidad_aromatizantes);
                    descuento = (Sub_Total * 12) / 100;
                    Total_pagar = Sub_Total - descuento;
                    Console.WriteLine("Cliente:       " + Nombre);
                    Console.WriteLine("Sub total:     " + Sub_Total);
                    Console.WriteLine("Descuento:     " + descuento);
                    Console.WriteLine("Total a pagar: " + Total_pagar);
                    break;
                case 4:
                    Sub_Total = (Escoba * Cantidad_escobas) + (Recogedor * Cantidad_recogedores) + (Aromatizante * Cantidad_aromatizantes);
                    descuento = (Sub_Total * 15) / 100;
                    Total_pagar = Sub_Total - descuento;
                    Console.WriteLine("Cliente:       " + Nombre);
                    Console.WriteLine("Sub total:     " + Sub_Total);
                    Console.WriteLine("Descuento:     " + descuento);
                    Console.WriteLine("Total a pagar: " + Total_pagar);
                    break;
                default:
                    Console.WriteLine("La Opcion es incorrecta");
                    break;
            }
        } 
    }
}
