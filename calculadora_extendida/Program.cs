using System;

namespace calculadoraExtendida
{
	class Program
	{
		static void Main(string[] args)
		{

			Menu();

			static void Menu(){
			int opcion;
			Console.WriteLine("CALCULADORA MULTIFUNCIONAL");
			Console.WriteLine("Menú:");
			Console.WriteLine("");
			Console.WriteLine(" 1.Suma \n 2.Resta \n 3.Multiplica \n 4.Divide \n 5.Raiz cuadrada \n 6.Potencia \n 7.Salir");
			Console.WriteLine("");
			opcion = int.Parse(Console.ReadLine());

			switch (opcion){
				case 1:
					Console.WriteLine("Ingrese números para sumar: ");
					float num1;
					float num2;					
					num1 = float.Parse(Console.ReadLine());
					num2 = float.Parse(Console.ReadLine());
					Console.WriteLine($"La Suma de {num1} y {num2} es: {Suma(num1,num2)}");
					Console.WriteLine("Presione Enter para regresar al menú");
					Console.ReadLine();
					Menu();
					
					break;
				case 2:		
					Console.WriteLine("Ingrese números para Resta: ");						
					num1 = float.Parse(Console.ReadLine());
					num2 = float.Parse(Console.ReadLine());
					Console.WriteLine($"La Resta de {num1} y {num2} es: {Resta(num1,num2)}");
					Console.WriteLine("Presione Enter para regresar al menú");
					Console.ReadLine();
					Menu();
					break;
				case 3:
					Console.WriteLine("Ingrese números para Multiplicar: ");						
					num1 = float.Parse(Console.ReadLine());
					num2 = float.Parse(Console.ReadLine());
					Console.WriteLine($"La multiplicación de {num1} y {num2} es: {Multiplica(num1,num2)}");	
					Console.WriteLine("Presione Enter para regresar al menú");
					Console.ReadLine();
					Menu();			
					break;
				case 4:
					Console.WriteLine("Ingrese números para Dividir: ");						
					num1 = float.Parse(Console.ReadLine());
					num2 = float.Parse(Console.ReadLine());
					Console.WriteLine($"La división de {num1} y {num2} es: {Divide(num1,num2)}");
					Console.WriteLine("Presione Enter para regresar al menú");
					Console.ReadLine();
					Menu();
					break;

				case 5:
					Console.WriteLine("Ingrese números para Raiz cuadrada: ");						
					num1 = float.Parse(Console.ReadLine());
					Console.WriteLine($"La Raiz cuadrada de {num1} es {Raiz(num1)}");
					Console.WriteLine("Presione Enter para regresar al menú");
					Console.ReadLine();
					Menu();
					break;				
				case 6:
					Console.WriteLine("Ingrese números para Potenciar: ");						
					num1 = float.Parse(Console.ReadLine());
					num2 = float.Parse(Console.ReadLine());
					Console.WriteLine($"La Potencia de {num1} a {num2} es {Potencia(num1,num2)}");
					Console.WriteLine("Presione Enter para regresar al menú");
					Console.ReadLine();
					Menu();
					break;

				case 7:
					Console.WriteLine("Presione Enter para salir");
					Console.ReadLine();
					break;
				
				default:
					Console.WriteLine("Opción no válida, presione enter para volver a ejecutar el programa por favor.");
					Console.ReadLine();
					Menu();
					break;
			}

			}

			
		}

		static float Suma(float num1, float num2){
			return num1 + num2;
		}
		static float Resta(float num1, float num2){
			return num1 - num2;
		}
		static float Multiplica(float num1, float num2){
			return num1 * num2;
		}
		static float Divide(float num1, float num2){
			return num1 + num2;
		}
		static double Raiz(float num1){
			return Math.Sqrt(num1);
		}
		static double Potencia(float num1, float num2){
			return Math.Pow(num1, num2);
		}
	}
}