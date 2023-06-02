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
			ultimoId++;
			Id = ultimoId;
			
			
		}
		public string Calidad { get => calidad; set => calidad = value; }
		public int Cantidad { get => cantidad; set => cantidad = value; }

		public abstract float PrecioPrenda(float precioVendedor);
		public float FnCalidad(float precio) 
		{
			if (Calidad == "Premium")
				precio *= 1.3f;
			return precio;
		}
	}
}
