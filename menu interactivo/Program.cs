using System;

namespace MyNamespace
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("MENU INTERACTIVO");
			Menu();
		}

		static void Menu(){

			int opcion;
			Console.WriteLine("MENÚ");
			Console.WriteLine("1.Calcular Fahrenheit \n2.Calcular Impuestos \n3.Calcular edad \n 4.Salir ");
			opcion = int.Parse(Console.ReadLine());

			elegirOpcion(opcion);



		}

		static void elegirOpcion(int opcion){

			switch (opcion){
				case 1:
					calcularFahrenheit();
					break;
				case 2:
					calcularImpuestos();
					break;
				case 3:
					calcularEdad();
					break;
				case 4:
					Console.WriteLine("Saliendo del programa...");
					break;
			}

		}

		static void calcularFahrenheit(){
			double Celsius;
			double Fahrenheit;

			Console.WriteLine("CONVERTIDOR DE CELSIUS A FAHRENHEIT");
			
			Console.WriteLine("Escriba un numero de grados Celsius");
			Celsius = double.Parse(Console.ReadLine());

			Fahrenheit = (Celsius *9/5) + 32;

			Console.WriteLine($"{Celsius} grados Celsius , equivale a {Fahrenheit} grados Fahrenheit.");

			Console.WriteLine("Presione Enter para regresar al menú");
			Console.ReadLine();
			Menu();

		}

		static void calcularImpuestos(){

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
			Console.WriteLine("Presione Enter para regresar al menú");
			Console.ReadLine();
			Menu();
		}

		static void calcularEdad(){
			
			int year;
			int currentYear = System.DateTime.Now.Year;
			int edad;

			Console.WriteLine("Escriba su año de nacimiento: ");
			year = int.Parse(Console.ReadLine());
			edad = currentYear - year;
			Console.WriteLine($"Su edad son {edad} años.");
			Console.WriteLine("Presione Enter para regresar al menú");
			Console.ReadLine();
			Menu();

		}
	}
}