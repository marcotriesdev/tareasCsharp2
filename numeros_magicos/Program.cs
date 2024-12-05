
using System;
using System.Security.Cryptography;

namespace MyNamespace
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("NUMEROS MÁGICOS");

			Random rand = new Random();
			int intentos = 0;
			int numeroMagico = rand.Next(1,100);
			

			//Console.WriteLine(numeroMagico);
			int respuesta;
			Console.WriteLine("¿Cual es el número?: ");
			respuesta = int.Parse(Console.ReadLine());

			evaluarRespuesta(respuesta,numeroMagico,intentos);

			

		}

		static void evaluarRespuesta(int respuesta,int numero_magico, int intentos){
			intentos++;
			if (respuesta == numero_magico){
				Console.WriteLine($"ADIVINASTE!!! El número mágico es {numero_magico}");
				if (intentos > 1){
				Console.WriteLine($"Lo lograste en {intentos} intentos.");
				}
				else{
					Console.WriteLine($"Eres un adivino. Un solo intento.");
				}
			}
			else if (respuesta < numero_magico) {
				Console.WriteLine("No adivinaste, el número mágico es mayor a tu respuesta, intentalo otra vez");
				Console.WriteLine("¿Cual es el número?: ");
				respuesta = int.Parse(Console.ReadLine());
				evaluarRespuesta(respuesta,numero_magico,intentos);
			
			}
			else if (respuesta > numero_magico){
				Console.WriteLine("No adivinaste, el número mágico es menor a tu respuesta, intentalo otra vez");
				Console.WriteLine("¿Cual es el número?: ");
				respuesta = int.Parse(Console.ReadLine());
				evaluarRespuesta(respuesta,numero_magico,intentos);
			}
		}
	}
}