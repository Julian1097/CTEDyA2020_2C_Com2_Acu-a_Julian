using System;

namespace tp2
{
	class PruebaAB
	{
		public static void Main(string[] args)
		{
			ArbolBinario<int> arbolBinarioA = new ArbolBinario<int>(1);

			ArbolBinario<int> hijoIzquierdo=new ArbolBinario<int>(2);
			hijoIzquierdo.agregarHijoIzquierdo(new ArbolBinario<int>(3));
			hijoIzquierdo.agregarHijoDerecho(new ArbolBinario<int>(4));
			
			ArbolBinario<int> hijoDerecho=new ArbolBinario<int>(5);
			hijoDerecho.agregarHijoIzquierdo(new ArbolBinario<int>(6));
			hijoDerecho.agregarHijoDerecho(new ArbolBinario<int>(7));
			
			arbolBinarioA.agregarHijoIzquierdo(hijoIzquierdo);
			arbolBinarioA.agregarHijoDerecho(hijoDerecho);
			Console.WriteLine("PreOrden");
			arbolBinarioA.preorden();
			Console.WriteLine();
			Console.WriteLine("Inorden");
			arbolBinarioA.inorden();
			Console.WriteLine();
			Console.WriteLine("PostOrden");
			arbolBinarioA.postorden();
			Console.WriteLine();
			Console.WriteLine("Por nivel ");
			arbolBinarioA.recorridoPorNiveles();
			Console.WriteLine();
			Console.WriteLine("La cantidade hojas es de = "+arbolBinarioA.contarHojas());
		
			Console.ReadKey(true);
		}
	}
}