using System;

namespace DoWhile_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //3. En la Cámara de Diputados se levanta una encuesta con todos los integrantes con el fin de determinar
            //que porcentaje de los n diputados esta a favor del Tratado de Libre Comercio, que porcentaje esta en
            //contra y que porcentaje se abstiene de opinar.
            //El programa debe preguntar si se desea continuar ingresando datos.

            int CantPerso = 0, cantLComercio = 0, cantContra = 0, cantBlanco = 0, opinion, continuar;
            double porBlanco, porContra, porLComercio;

            do
            {
                do
                {
                    Console.WriteLine("\n¿El integrante esta a favor del tratado de libre comercio? \n1.A favor \n2.En contra \n3.Se abstiene de opinar");
                    _ = int.TryParse(Console.ReadLine(), out opinion);

                } while (opinion < 1 || opinion > 3);

                CantPerso++;

                switch (opinion)
                {
                    case 1:
                        cantLComercio++;
                        break;

                    case 2:
                        cantContra++;
                        break;

                    case 3:
                        cantBlanco++;
                        break;
                }
                Console.WriteLine("\n¿Desea ingresar otra integrante? 1.Si | 0.No");
                _ = int.TryParse(Console.ReadLine(), out continuar);
            } while (continuar == 1);

            porLComercio = cantLComercio * 100 / CantPerso;
            porContra = cantContra * 100 / CantPerso;
            porBlanco = cantBlanco * 100 / CantPerso;

            Console.WriteLine("\nPersonas encuestadas: " + CantPerso);
            Console.WriteLine("\nPersonas A FAVOR del tratado de libre comercio : " + cantLComercio + ", esto equivale al " + porLComercio + "%");
            Console.WriteLine("\nPersonas EN CONTRA del tratado de libre comercio : " + cantContra + ", esto equivale al " + porContra + "%");
            Console.WriteLine("\nPersonas que se abstienen de opinar : " + cantBlanco + ", esto equivale al " + porBlanco + "%\n");
        }
    }
}
