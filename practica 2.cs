
using System;

namespace practica_2
{
	class Program
	{
		public static void Main(string[] args)
		{
		    double precio1,precio2,precio3;
		    double iva = 1.16;		    	
	    	Console.WriteLine("Introduce el precio de los limones");
			float numero1 = float.Parse(Console.ReadLine());
			Console.WriteLine("Introduce el precio de los huevos");
			float numero2 = float.Parse(Console.ReadLine());
			Console.WriteLine("Introduce el precio de las cebollas");
			float numero3 = float.Parse(Console.ReadLine());
			
			
			
			precio1 = numero1*iva;
			precio2 = numero2*iva;
			precio3 = numero3*iva;
			
			Console.WriteLine("El precio de los limones con iva es " +precio1);
			Console.WriteLine("El precio de los huevos con iva es " +precio2);
			Console.WriteLine("El precio de las cebolla con iva es " +precio3);
			Console.WriteLine("El precio total es " +(precio1+precio2+precio3));
			
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}