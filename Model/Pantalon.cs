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
		
		private string tipo;

		public string Tipo { get => tipo; set => tipo = value; }

		public Pantalon(string tipo, string calidad, int cantidad)
		{ 
			this.Tipo = tipo;
			this.Calidad = calidad;
			this.Cantidad= cantidad;
			
		}

		public override float PrecioPrenda(float precioVendedor)
		{

			float precioFinal = precioVendedor;
			if (Tipo == "chupin")
				precioFinal *= 0.88f;
			precioFinal=FnCalidad(precioFinal);

			return precioFinal;
		}
	}
}
