

using System;
using System.Collections;
using System.Diagnostics.Metrics;

namespace MyNamespace
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("ORDENAMIENTO DE ARRAY");
			int cantidad;
			Console.WriteLine("Cuantos números va a ordenar?:");
			cantidad = int.Parse(Console.ReadLine());

			int[] miArray = new int[cantidad];


			int contador = 0;
			foreach (int numero in miArray){
				
				Console.WriteLine($"{contador}");
				Console.WriteLine("Ingrese número:");
				miArray[contador] = int.Parse(Console.ReadLine());
				contador++;

			}

			for (int i = 0; i < miArray.Length - 1; i++)
			{
				int minIndex = i;

				// Buscar el elemento más pequeño
				for (int j = i + 1; j < miArray.Length; j++)
				{
					if (miArray[j] < miArray[minIndex])
					{
						minIndex = j;
					}
				}

				// Intercambiar los elementos
				int temp = miArray[minIndex];
				miArray[minIndex] = miArray[i];
				miArray[i] = temp;
			}

			Console.WriteLine($"Array ordenado: ");
			Console.WriteLine(string.Join(", ", miArray));
		}
	}
}