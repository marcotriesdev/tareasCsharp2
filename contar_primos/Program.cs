

using System;
using System.Globalization;

namespace contar_primos
{
	class ContarPrimos
	{
		static void Main(string[] args)
		{
			int num1;
			int num2;

			Console.WriteLine("CONTAR NUMEROS PRIMOS EN UN RANGO");

			Console.WriteLine("Ingrese dos numeros, primero el menor, luego el mayor para saber cuantos (y cuales) números primos hay entre ellos:");
			num1 = int.Parse(Console.ReadLine());
			num2 = int.Parse(Console.ReadLine());
			
			for (int i = num1; i < num2+1; i++) {
				Console.WriteLine("Empezó el for");
				if (i % 2 != 0){
					Console.WriteLine($"Es primo: {i}");
				}
			}

			Console.ReadLine();
		}
	}
}