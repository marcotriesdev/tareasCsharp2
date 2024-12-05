
using System;

namespace clasificarTriangulos
{
	class Program
	{
		static void Main(string[] args)
		{
			float side1;
			float side2;
			float side3;

			Console.WriteLine("CLASIFICACION DE TRIANGULOS");
			Console.WriteLine("Ingresa los 3 lados de tu triángulo");

			side1 = float.Parse(Console.ReadLine());
			side2 = float.Parse(Console.ReadLine());
			side3 = float.Parse(Console.ReadLine());

		//EVALUAR
		if (esTrianguloValido(side1, side2, side3))
		{
			
			string tipo = tipoTriangulo(side1, side2, side3);
			Console.WriteLine($"El triángulo es {tipo}.");
		}
		else
		{
			Console.WriteLine("Las longitudes no forman un triángulo válido.");
		}



		}


	static string tipoTriangulo(double a, double b, double c)
	{
		
		if (a == b && b == c)
		{
			return "equilátero";
		}
		else if (a == b || a == c || b == c)
		{
			return "isósceles";
		}
		else
		{
			return "escaleno";
		}
	}

	static bool esTrianguloValido(double a, double b, double c)
	{
		// Condición de existencia de un triángulo
		return a + b > c && a + c > b && b + c > a;
	}
			
		
	}
}

