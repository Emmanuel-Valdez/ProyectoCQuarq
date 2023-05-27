using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
	public class Camisa: Prenda
	{
		private string manga;
		private string cuello;

		public string Manga { get => manga; set => manga = value; }
		public string Cuello { get => cuello; set => cuello = value; }

		public Camisa(string manga,string cuello, string calidad, int cantidad)
		{
			this.Manga = manga;
			this.Cuello = cuello;
			this.Calidad = calidad;
			this.Cantidad = cantidad;
		}
		public override float PrecioPrenda(float precioVendedor)
		{
			float precioFinal=precioVendedor;
			if (manga == "corta")
				precioFinal *= 0.9f;

			if(cuello == "mao")
				precioFinal *= 1.03f;
			
			precioFinal = FnCalidad(precioFinal);

			return precioFinal;
		}   
	}
}
