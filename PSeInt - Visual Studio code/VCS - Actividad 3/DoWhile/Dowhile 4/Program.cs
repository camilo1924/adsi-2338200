using System;

namespace Dowhile_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //4. Un censador recopila ciertos datos aplicando encuestas para el último Censo Nacional de Población
            //y Vivienda. Desea obtener de todas las personas que alcance a encuestar en un día, que porcentaje
            //tiene estudios de primaria, secundaria, carrera técnica, estudios profesionales y estudios de
            //posgrado.
            //El programa debe preguntar si se desea continuar ingresando datos.

            double porPrimaria, porSecundaria, porTecnica, porProfesional, porPosgrado;
            int CantPersonas = 0, CantPrimaria = 0, CantSecundaria = 0, CantTecnica = 0, CantProfesional = 0, CantPosgrado = 0, nivel, seguir;

            do
            {
                do
                {
                    Console.WriteLine("\n¿Cual es el nivel de estudio de la persona encuestada? \n1.Primaria \n2.Secundaria \n3.Carrera Tecnica \n4.Profesional \n5.Posgrado");
                    _ = int.TryParse(Console.ReadLine(), out nivel);

                } while (nivel < 1 || nivel > 5);

                CantPersonas++;

                switch (nivel)
                {
                    case 1:
                        CantPrimaria++;
                        break;

                    case 2:
                        CantSecundaria++;
                        break;

                    case 3:
                        CantTecnica++;
                        break;

                    case 4:
                        CantProfesional++;
                        break;

                    case 5:
                        CantPosgrado++;
                        break;
                }
                Console.WriteLine("\n¿Desea ingresar otra persona? 1.Si | 0.No");
                _ = int.TryParse(Console.ReadLine(), out seguir);
            } while (seguir == 1);

            porPrimaria = CantPrimaria * 100 / CantPersonas;
            porSecundaria = CantSecundaria * 100 / CantPersonas;
            porTecnica = CantTecnica * 100 / CantPersonas;
            porProfesional = CantProfesional * 100 / CantPersonas;
            porPosgrado = CantPosgrado * 100 / CantPersonas;

            Console.WriteLine("\nPersonas encuestadas: " + CantPersonas);
            Console.WriteLine("\nPersonas con estudios en primaria : " + CantPrimaria + ", esto equivale al " + porPrimaria + "%");
            Console.WriteLine("\nPersonas con estudios en secundaria : " + CantSecundaria + ", esto equivale al " + porSecundaria + "%");
            Console.WriteLine("\nPersonas con estudios en carrera tecnica : " + CantTecnica + ", esto equivale al " + porTecnica + "%");
            Console.WriteLine("\nPersonas con estudios profesionales : " + CantProfesional + ", esto equivale al " + porProfesional + "%");
            Console.WriteLine("\nPersonas con estudios en posgrado : " + CantPosgrado + ", esto equivale al " + porPosgrado + "%\n");
        }
    }
}
