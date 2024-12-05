

using System;
using System.Diagnostics.Contracts;

namespace Calificaciones
{
	class Program
	{
		static void Main(string[] args)
		{
			int punteo;
			char calificacion;

			Console.WriteLine("CALIFICACIONES");
			Console.WriteLine("Ingrese su calificación obtenida del 1 al 100: ");
			punteo = int.Parse(Console.ReadLine());

			if (punteo <= 20){
				calificacion = 'F';
				Calificar(calificacion);
			}
			else if (punteo > 20 && punteo <= 40){
				calificacion = 'D';
				Calificar(calificacion);
			}
			else if (punteo > 40 && punteo <= 60){
				calificacion = 'C';
				Calificar(calificacion);
			}
			else if (punteo > 60 && punteo <= 80){
				calificacion = 'B';
				Calificar(calificacion);
			}
			else if (punteo > 80 && punteo <= 100){
				calificacion = 'A';
				Calificar(calificacion);
			}


			static void Calificar(char calificacion){

			
			switch (calificacion){
				case 'A':
					Console.WriteLine($"Usted sacó excelente calificación: {calificacion}");
					break;
				case 'B':
					Console.WriteLine($"Su calificación es muy buena: {calificacion}");
					break;
				case 'C':
					Console.WriteLine($"Su calificación es buena: {calificacion}");
					break;
				case 'D':
					Console.WriteLine($"Su calificación es regular: {calificacion}");
					break;
				case 'F':
					Console.WriteLine($"Usted perdió la clase con calificación: {calificacion}");
					break;		
				default:
					Console.WriteLine("No tiene calificación");
					break;								
			}
			}

		}
	}
}