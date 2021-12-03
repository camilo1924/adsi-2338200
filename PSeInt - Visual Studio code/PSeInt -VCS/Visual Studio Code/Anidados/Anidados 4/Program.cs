using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*4. En un montallantas se ha establecido una promoción de las llantas marca “Ponchadas”, dicha promoción
          consiste en lo siguiente:
          Si se compran menos de cinco llantas el precio es de $90000 cada una, de $80000 si se compran de cinco a 10
          y de $70000 si se compran más de 10. Obtener la cantidad de dinero que una persona tiene que pagar por cada
          una de las llantas que compra y la que tiene que pagar por el total de la compra*/

            double TotPag;
            byte Cantidad;

            Console.WriteLine("Digite el numero de llantas Ponchadas que desea comprar");
            Cantidad = byte.Parse(Console.ReadLine());

            if (Cantidad == 5)
            {
                TotPag = Cantidad * 9000;
                Console.WriteLine("El total a pagar es de " + TotPag);
            }
            else if (Cantidad > 5 || Cantidad < 10)
            {
                TotPag = Cantidad * 80000;
                Console.WriteLine("El total a pagar es de " + TotPag);
            }
            else if (Cantidad > 10)
            {
                TotPag = Cantidad * 7000;
                Console.WriteLine("El total a pagar es de " + TotPag);
            }
        
        }   
    }    
}
