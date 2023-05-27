using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
	public class Pantalon:Prenda
	{
		
		private string estilo;

		public string Estilo { get => estilo; set => estilo = value; }

		public Pantalon(string estilo, string calidad, int cantidad)
		{ 
			this.Estilo = estilo;
			this.Calidad = calidad;
			this.Cantidad= cantidad;
			
		}

		public override float PrecioPrenda(float precioVendedor)
		{

			float precioFinal = precioVendedor;
			if (Estilo == "chupin")
				precioFinal *= 0.88f;
			precioFinal=FnCalidad(precioFinal);

			return precioFinal;
		}
	}
}
