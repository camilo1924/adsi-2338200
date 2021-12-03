using System;

namespace Simples_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //*1.El jefe del personal de operación de la industria de aceitera Móvil desea calcular el sueldo neto de sus
            //empleados bajo las siguientes normas, solicitar el nombre del empleado, número de horas trabajadas
            //y la cuota por hora trabajada, para calcular el sueldo neto del empleado, se le otorga un incentivo del
            //5% si el empleado trabajó más de 40 horas. Desarrollar
            //el algoritmo y diagrama de flujo.

            string nombre;
            byte horas_trabajadas;
            double valor_hora, total_pago, horas_extra;

            Console.WriteLine("Escriba nombre del empleado: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Escriba el número de horas trabajadas esta semana: ");
            horas_trabajadas = byte.Parse(Console.ReadLine());
            Console.WriteLine("Digite el valor de cada hora de trabajo: ");
            valor_hora = double.Parse(Console.ReadLine());

            total_pago = (horas_trabajadas * valor_hora);

            if (horas_trabajadas > 40)

            {
                horas_extra = (horas_trabajadas - 40) * (total_pago * 0.05);
                total_pago = horas_extra + (40 * valor_hora);

                Console.WriteLine("El empleado es " + nombre + "El sueldo total del trabajor es: " + total_pago);
            }
        }
    }
}
