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
		private List<Prenda> lista;

		public Tienda(int id, string nombre, string direccion, List<Prenda> lista)
		{
			this.Id = id;
			this.Nombre = nombre;
			this.Direccion = direccion;
			this.Lista = lista;
		}

		public int Id { get => id; set => id = value; }
		public string Nombre { get => nombre; set => nombre = value; }
		public string Direccion { get => direccion; set => direccion = value; }
		public List<Prenda> Lista { get => lista; set => lista = value; }
	}
}
