
using System;

namespace fibonacci
{
	class Fibonacci
	{
		static void Main(string[] args)
		{
			int limite;
			Console.WriteLine("FIBONACCI");
			Console.WriteLine("Ingrese un número para generar hasta ese numero la serie fibonacci:");

			limite = int.Parse(Console.ReadLine());

			Console.WriteLine("Secuencia Fibonacci: ");
			int num1 = 0;
			int num2 = 1;
			Console.WriteLine($"{num1}");
			Console.WriteLine($"{num2}");

			for (int i = 3; i <= limite; i++){

				int next = num1 + num2;
				Console.WriteLine($"{next}");
				num1 = num2;
				num2 = next;

			}
			
		}
	}
}

