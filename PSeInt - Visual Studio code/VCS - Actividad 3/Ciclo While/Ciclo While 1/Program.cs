using System;

namespace dotnet_ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Una compañía de seguros tiene contratados a n vendedores. Cada uno hace tres ventas a la semana.
            //Su política de pagos es que un vendedor recibe un sueldo base, y un 10% extra por comisiones de
            //sus ventas. El gerente de su compañía desea saber cuanto dinero obtendrá en la semana cada
            //vendedor por concepto de comisiones por las tres ventas realizadas, y cuanto tomando en cuenta su
            //sueldo base y sus comisiones.

            Console.WriteLine("¿Cuantos vendedores trabajaron esta semana? ");
            _ = int.TryParse(Console.ReadLine(), out int n);
            Console.WriteLine("\n¿Cual es el sueldo base que maneja la empresa? ");
            _ = double.TryParse(Console.ReadLine(), out double sueldoB);
            int contador = 0, i = 0;
            double comisiones = 0, sueldo_total = 0;


            while (contador <= n)
            {
                for (i = 1; i <= n; i++)
                {
                    Console.WriteLine("\nIngrese el valor de la primer venta del vendedor numero " + i);
                    _ = double.TryParse(Console.ReadLine(), out double venta1);
                    Console.WriteLine("\nIngrese el valor de la segunda venta del vendedor numero " + i);
                    _ = double.TryParse(Console.ReadLine(), out double venta2);
                    Console.WriteLine("\nIngrese el valor de la tercer venta del vendedor numero " + i);
                    _ = double.TryParse(Console.ReadLine(), out double venta3);
                    venta1 = venta1 * 0.10;
                    venta2 = venta2 * 0.10;
                    venta3 = venta3 * 0.10;
                    comisiones = venta1 + venta2 + venta3;
                    sueldo_total = comisiones + sueldoB;
                    Console.WriteLine("\nLas comisiones del vendedor " + i + " son " + comisiones + " y el sueldo total es de " + sueldo_total);
                }
                break;
            }
        }
    }
}