using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
	internal class Pantalon:Prenda
	{
		private static int ultimoId=0;
		private string tipo;

		public int Id { get; private set; }
		public string Tipo { get => tipo; set => tipo = value; }
		public Pantalon(string tipo, string calidad, int cantidad)
		{
			this.Tipo = tipo;
			this.Calidad = calidad;
			this.Cantidad= cantidad;
			ultimoId++;
			Id = ultimoId;
		}

		public override float PrecioPrenda(float precioVendedor)
		{

			float precioFinal = precioVendedor;
			if (Tipo == "chupin")
				precioFinal *= 0.88f;
				
			if (Calidad == "premium")
				precioFinal*= 1.3f;
			
			return precioFinal
		}
	}
}
