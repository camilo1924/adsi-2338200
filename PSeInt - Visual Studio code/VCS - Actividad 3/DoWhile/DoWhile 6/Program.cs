using System;

namespace DoWhile_6
{
    class Program
    {
        static void Main(string[] args)
        {
			//6. Leer por cada alumno de Diseño estructurado de algoritmos su número de control y su calificación en
			//cada una de las 5 unidades de la materia. Al final que escriba el número de control del alumno que
			//obtuvo mayor promedio. Suponga que los alumnos tienen diferentes promedios.

			int opcionContinuar, numControl, numControlMay = 0, numAlumno = 1;
			double nota1, nota2, nota3, nota4, nota5, promedio, promMayor = 0, notaMaxima;
			bool verNumeroControl, verNota1, verNota2, verNota3, verNota4, verNota5;

			do
			{
				Console.WriteLine("\n Ingrese el numero maximo de la calificacion (5-10-100):");
				_ = double.TryParse(Console.ReadLine(), out notaMaxima);
			} while (notaMaxima != 5 && notaMaxima != 10 && notaMaxima != 100);

			do
			{
				do
				{
					Console.WriteLine("\n Ingrese el numero del control del alumno " + numAlumno + " :");
					verNumeroControl = int.TryParse(Console.ReadLine(), out numControl);
				} while (!verNumeroControl);

				do
				{
					Console.WriteLine("Ingrese la nota de la unidad 1 del alumno " + numAlumno + " :");
					verNota1 = double.TryParse(Console.ReadLine(), out nota1);
					if (!verNota1 || nota1 > notaMaxima || nota1 < 0)
					{
						Console.WriteLine("Nota erronea.");
					}
				} while (!verNota1 || nota1 > notaMaxima || nota1 < 0);
				do
				{
					Console.WriteLine("Ingrese la nota de la unidad 1 del alumno " + numAlumno + " :");
					verNota2 = double.TryParse(Console.ReadLine(), out nota2);
					if (!verNota2 || nota2 > notaMaxima || nota2 < 0)
					{
						Console.WriteLine("Nota erronea.");
					}
				} while (!verNota2 || nota2 > notaMaxima || nota2 < 0);
				do
				{
					Console.WriteLine("Ingrese la nota de la unidad 1 del alumno " + numAlumno + " :");
					verNota3 = double.TryParse(Console.ReadLine(), out nota3);
					if (!verNota3 || nota3 > notaMaxima || nota3 < 0)
					{
						Console.WriteLine("Nota erronea.");
					}
				} while (!verNota3 || nota3 > notaMaxima || nota3 < 0);
				do
				{
					Console.WriteLine("Ingrese la nota de la unidad 1 del alumno " + numAlumno + " :");
					verNota4 = double.TryParse(Console.ReadLine(), out nota4);
					if (!verNota4 || nota4 > notaMaxima || nota4 < 0)
					{
						Console.WriteLine("Nota erronea.");
					}
				} while (!verNota4 || nota4 > notaMaxima || nota4 < 0);
				do
				{
					Console.WriteLine("Ingrese la nota de la unidad 1 del alumno " + numAlumno + " :");
					verNota5 = double.TryParse(Console.ReadLine(), out nota5);
					if (!verNota5 || nota5 > notaMaxima || nota5 < 0)
					{
						Console.WriteLine("Nota erronea.");
					}
				} while (!verNota5 || nota5 > notaMaxima || nota5 < 0);

				promedio = (nota1 + nota2 + nota3 + nota4 + nota5) / 5;
				Console.WriteLine("nota promedio del alumno " + numAlumno + ": " + promedio);

				if (promedio > promMayor)
				{
					promMayor = promedio;
					numControlMay = numControl;
				}
				numAlumno++;

				do
				{
					Console.WriteLine("¿Desea ingresar otro alumno? (1.si || 2.no) ");
					_ = int.TryParse(Console.ReadLine(), out opcionContinuar);
				} while (opcionContinuar != 1 && opcionContinuar != 2);
			} while (opcionContinuar == 1);
			Console.WriteLine("\n alumno con promedio mayor");
			Console.WriteLine("\n numero de control: " + numControlMay);
			Console.WriteLine("\n promedio obtenido: " + promMayor);
		}
    }
}
