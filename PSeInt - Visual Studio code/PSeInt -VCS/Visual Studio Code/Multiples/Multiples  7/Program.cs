using System;

namespace Multiples__7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*7. El costo de las llamadas internacionales depende de la zona geográfica en la que se encuentre el país destino,
             y del número de minutos hablados.
             En la siguiente tabla se presenta el costo por minuto por zona. A cada uno se le ha asociado una clave.
             Construya la solución para calcular e imprimir el costo de una llamada dada la clave y la duración de la llamada.

             Clave        Zona                  Precio         Precio/minuto(del 4 en adelante)

             12           América del Norte     200            150                               
             15           América Central       220            180                              
             18           América del Sur       450            350                               
             19           Europa                350            270                               
             23           Asia                  600            460                                   
             25           África                600            460                              
             29           Oceanía               500            390                             

              */
            double PreMin, Zona, CostTot, numero;
            int MinHab;
            string NameCase;

            Console.WriteLine("Digite la extensión de la zona del mundo a la que quiere llamar \n 12. América del Norte \n 15. América Central \n 18. América del Sur \n 19. Europa \n 23. Asia \n 25. África \n 29. Oceanía");
            Zona = double.Parse(Console.ReadLine());

            while (Zona != 12 && Zona != 15 && Zona != 18 && Zona != 19 && Zona != 23 && Zona != 25 && Zona != 29)
            {
                Console.WriteLine("Digite la extensión de la zona del mundo a la que quiere llamar \n 12. América del Norte \n 15. América Central \n 18. América del Sur \n 19. Europa \n 23. Asia \n 25. África \n 29. Oceanía");
                Zona = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("Digite el numero al cual desea llamar");
            numero = double.Parse(Console.ReadLine());

            Console.WriteLine("llamando al " + Zona + "-" + numero);
            Console.WriteLine("Digite el numero de minutos que habló");
            MinHab = int.Parse(Console.ReadLine());

            CostTot = 0;
            NameCase = "";
            switch (Zona)
            {
                case 12:
                    NameCase = "America del Norte";
                    PreMin = 200;
                    CostTot = PreMin * MinHab;
                    if (MinHab > 4)
                    {
                        CostTot = ((MinHab - 4) * 150) + (4 * PreMin);
                    }


                    break;
                case 15:
                    NameCase = "America Central";
                    PreMin = 220;
                    CostTot = PreMin * MinHab;
                    CostTot = PreMin * MinHab;
                    if (MinHab > 4)
                    {
                        CostTot = ((MinHab - 4) * 180) + (4 * PreMin);
                    }

                    break;
                case 18:
                    NameCase = "America del Sur";
                    PreMin = 450;
                    CostTot = PreMin * MinHab;
                    if (MinHab > 4)
                    {
                        CostTot = ((MinHab - 4) * 350) + (4 * PreMin);
                    }

                    break;
                case 19:
                    NameCase = "Europa";
                    PreMin = 350;
                    CostTot = PreMin * MinHab;
                    if (MinHab > 4)
                    {
                        CostTot = ((MinHab - 4) * 270) + (4 * PreMin);
                    }

                    break;
                case 23:
                    NameCase = "Asia";
                    PreMin = 600;
                    CostTot = PreMin * MinHab;
                    if (MinHab > 4)
                    {
                        CostTot = ((MinHab - 4) * 460) + (4 * PreMin);
                    }

                    break;
                case 25:
                    NameCase = "África";
                    PreMin = 600;
                    CostTot = PreMin * MinHab;
                    if (MinHab > 4)
                    {
                        CostTot = ((MinHab - 4) * 460) + (4 * PreMin);
                    }

                    break;
                case 29:
                    NameCase = "Ocenía";
                    PreMin = 500;
                    CostTot = PreMin * MinHab;
                    if (MinHab > 4)
                    {
                        CostTot = ((MinHab - 4) * 390) + (4 * PreMin);
                    }

                    break;
                default:
                    Console.WriteLine("Syntax ERROR");
                    break;
            }
            Console.WriteLine("Llamada a " + NameCase);
            Console.WriteLine("Numero llamadó [" + numero + "]");
            Console.WriteLine("Costo total de la llamada " + CostTot);
        }
    }
}
