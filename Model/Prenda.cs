using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
	abstract class Prenda
	{
		private string calidad;
		private int cantidad;
		

		
		protected string Calidad { get => calidad; set => calidad = value; }
		protected int Cantidad { get => cantidad; set => cantidad = value; }

		public abstract float PrecioPrenda(float precioVendedor);
		
	}
}
