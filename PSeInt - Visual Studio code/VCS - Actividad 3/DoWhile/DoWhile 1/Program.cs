using System;

namespace DoWhile_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. En un supermercado una ama de casa pone en su carrito los artículos que va tomando de los
            //estantes. La señora quiere asegurarse de que el cajero le cobre bien lo que ella ha comprado, por lo
            //que cada vez que toma un articulo anota su precio junto con la cantidad de artículos iguales que ha
            //tomado y determina cuanto dinero gastara en ese articulo; a esto le suma lo que ira gastando en los
            //demás artículos, hasta que decide que ya tomo todo lo que necesitaba. Ayúdale a esta señora a
            //obtener el total de sus compras.

            char opcion;
            double total_arts = 0, cant, valor;
            do
            {
                Console.WriteLine("\nIngrese nombre del articulo");
                string nom_art = Console.ReadLine();
                Console.WriteLine("\nIngrese cantidad del articulo");
                _ = double.TryParse(Console.ReadLine(), out cant);
                Console.WriteLine("\nIngrese el valor del articulo");
                _ = double.TryParse(Console.ReadLine(), out valor);
                double precio_total_art = valor * cant;
                Console.WriteLine("\nEl total del articulo " + nom_art + " es: " + precio_total_art);
                total_arts += precio_total_art;

                Console.WriteLine("\nDesea ingresar mas articulos Si (S) | No (N)");
                _ = char.TryParse(Console.ReadLine(), out opcion);
            } while (opcion == 'S');
            Console.WriteLine("\nEl total de la compra es de: " + total_arts);
        }
    }
}
