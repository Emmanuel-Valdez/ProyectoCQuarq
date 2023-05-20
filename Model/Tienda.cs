using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
	internal class Tienda
	{
		private int id;
		private string nombre;
		private string direccion;
		private List<Prenda> stock;

		public Tienda( string nombre, string direccion, List<Prenda> stock)
		{
			this.Nombre = nombre;
			this.Direccion = direccion;
			this.Stock = stock;
		}

		public int Id { get => id; set => id = value; }
		public string Nombre { get => nombre; set => nombre = value; }
		public string Direccion { get => direccion; set => direccion = value; }
		public List<Prenda> Stock { get => stock; set => stock = value; }

		

	}
}
