
using System;

namespace Impuestos
{
	class Program
	{
		static void Main(string[] args)
		{
			float ingreso;
			float impuesto;

			float impuestoAlto = 0.15f;
			float impuestoNormal = 0.12f; 


			Console.WriteLine("CALCULADORA DE IMPUESTOS");
			Console.WriteLine("Cuales son sus ingresos anuales: ");
			
			ingreso = float.Parse(Console.ReadLine());

			if (ingreso < 100000){
				impuesto = ingreso * impuestoNormal;
			}
			else {
				impuesto = ingreso * impuestoAlto;
			}

			Console.WriteLine($"Su impuesto es {impuesto}");

			Console.ReadLine();
			
		}
	}
}