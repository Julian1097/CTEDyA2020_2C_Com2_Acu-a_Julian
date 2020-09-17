using System;
using System.Collections;

namespace tp2
{
	public class ArbolBinario<T>
	{
		
	
		private T dato;
		private ArbolBinario<T> hijoIzquierdo;
		private ArbolBinario<T> hijoDerecho;
	
		
		public ArbolBinario(T dato) {
			this.dato = dato;
		}
	
		public T getDatoRaiz() {
			return this.dato;
		}
	
		public ArbolBinario<T> getHijoIzquierdo() {
			return this.hijoIzquierdo;
		}
	
		public ArbolBinario<T> getHijoDerecho() {
			return this.hijoDerecho;
		}
	
		public void agregarHijoIzquierdo(ArbolBinario<T> hijo) {
			this.hijoIzquierdo=hijo;
		}
	
		public void agregarHijoDerecho(ArbolBinario<T> hijo) {
			this.hijoDerecho=hijo;
		}
	
		public void eliminarHijoIzquierdo() {
			this.hijoIzquierdo=null;
		}
	
		public void eliminarHijoDerecho() {
			this.hijoDerecho=null;
		}
	
		public bool esHoja() {
			return this.hijoIzquierdo==null && this.hijoDerecho==null;
		}
		
		public void inorden()
		{
			if(getHijoIzquierdo()!=null)
			{
				getHijoIzquierdo().inorden();
			}
			Console.Write(this.getDatoRaiz()+"  ");
			if(getHijoDerecho()!=null)
			{
				getHijoDerecho().inorden();
			}
		}
		
		public void preorden() {
			if(getDatoRaiz()!=null)
			{
				Console.Write(this.getDatoRaiz()+"  ");
				if(hijoIzquierdo!=null)
				{
					hijoIzquierdo.preorden();
				}
				if(hijoDerecho!=null)
				{
					hijoDerecho.preorden();
				}
			}
		}
		
		public void postorden()
		{
			
				if(hijoIzquierdo!=null)
				{
					hijoIzquierdo.postorden();
				}
				if(hijoDerecho!=null)
				{
					hijoDerecho.postorden();
				}
				Console.Write(getDatoRaiz()+"  ");
			
		}
		
		public void recorridoPorNiveles() {
			Cola<ArbolBinario<T>> C= new Cola<ArbolBinario<T>>();
			ArbolBinario<T> arbolAux;
			
			C.encolar(this);// Encolamos el arbol completo
			
			while(!C.esVacia())
			{
				arbolAux=C.desencolar();
				
				
				Console.Write(arbolAux.getDatoRaiz()+"  ");//puede ser tambien dato o getdatoraiz()
				
				if(arbolAux.getHijoIzquierdo()!=null)
				{
					C.encolar(arbolAux.getHijoIzquierdo());
				}
				if(arbolAux.getHijoDerecho()!=null)
				{
					C.encolar(arbolAux.getHijoDerecho());
				}
			}
		}
		public static int A=0;
		
		public int contarHojas() {
			
			if(hijoIzquierdo!=null)
				{
				if(hijoIzquierdo.esHoja())
				{
					A++;
				}
				
					hijoIzquierdo.contarHojas();
					
				}
				if(hijoDerecho!=null)
				{
					
					if(hijoDerecho.esHoja())
				{
						A++;
				}
					hijoDerecho.contarHojas();
				}
				
			
				
				return A;
		}
		
		public void recorridoEntreNiveles(int n,int m) {
		}
	}
}

