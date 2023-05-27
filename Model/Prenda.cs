using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
	public abstract class Prenda
	{

		private string calidad;
		private int cantidad;
		private static int ultimoId = 0;
		public int Id { get; private set; }
		

		public Prenda()
		{
			Id = ultimoId;
			ultimoId++;
			
		}
		public string Calidad { get => calidad; set => calidad = value; }
		public int Cantidad { get => cantidad; set => cantidad = value; }

		public abstract float PrecioPrenda(float precioVendedor);
		public float FnCalidad(float precio) 
		{
			if (Calidad == "premium")
				precio *= 1.3f;
			return precio;
		}
	}
}
