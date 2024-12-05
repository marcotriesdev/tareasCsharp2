

using System;

namespace MyNamespace
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("ROTAR NUMERO EN ARRAY A LA IZQUIERDAD O A LA DERECHA");

			int[] miArray =  {1,1,2,3,1,0,1,1,1};
			moverArray(miArray);

		}	

		static void moverArray(int[] miArray){

			
			Console.WriteLine("ARRAY ACTUAL: ");
			Console.WriteLine("1 2 3 4 5 6 7 8 9  ----  INDICES");
			Console.WriteLine("| | | | | | | | | //");
			Console.WriteLine("| | | | | | | | |/");
			Console.WriteLine(string.Join (",",miArray));

			int currentIndex;
			char currentMove;

			Console.WriteLine("Que elemento quiere mover? \n(indice comenzando de 1, de izquierda a derecha): ");
			currentIndex = int.Parse(Console.ReadLine());
			currentIndex -= 1;

			Console.WriteLine("Hacia donde lo quiere mover? \n(i = izquierda) \n(d = derecha):");
			currentMove = char.Parse(Console.ReadLine());

			if (currentMove == 'i'){
				int numeroElegido = miArray[currentIndex];
				int numeroMover = miArray[currentIndex-1];
				miArray[currentIndex] = numeroMover;
				miArray[currentIndex-1] = numeroElegido;
			}
			else if (currentMove == 'd'){
				int numeroElegido = miArray[currentIndex];
				int numeroMover = miArray[currentIndex-1];
				miArray[currentIndex] = numeroMover;
				miArray[currentIndex+1] = numeroElegido;
			}
			else {
				Console.WriteLine("no se eligió una opción válida, saltando elección");
			}
			
			Console.WriteLine("ARRAY ACTUAL: ");
			Console.WriteLine("1 2 3 4 5 6 7 8 9  ----  INDICES");
			Console.WriteLine("| | | | | | | | | //");
			Console.WriteLine("| | | | | | | | |/");
			Console.WriteLine(string.Join (",",miArray));

			Console.WriteLine("¿Quiere hacerlo otra vez? (Y/N)");	
			char option;
			option = char.Parse(Console.ReadLine());
			if (option == 'y' || option == 'Y'){
				moverArray(miArray);
			}	
			else if (option == 'n' || option == 'N'){
				moverArray(miArray);
			}					
			else {
				Console.WriteLine("ERROR, SALIENDO DEL PROGRAMA");
			}
		}
	}
}