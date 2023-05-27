using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
	public class Tienda
	{
		private static int ultimoId = 0;
		private string nombre;
		private string direccion;
		public List<Prenda> stock;

		public Tienda( string nombre, string direccion, List<Prenda> stock)
		{
			this.Nombre = nombre;
			this.Direccion = direccion;
			this.Stock = stock;
			ultimoId++;
			Id = ultimoId;
		}

		public int Id { get; private set; }
		public string Nombre { get => nombre; set => nombre = value; }
		public string Direccion { get => direccion; set => direccion = value; }
		public List<Prenda> Stock { get => stock; set => stock = value; }

		

	}
}
