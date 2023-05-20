using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
	internal class Vendedor
	{
		private int id;
		private string nombre;
		private string apellido;
		private int tiendaId;

		public Vendedor(string nombre, string apellido, int tiendaId)
		{
			this.Id = id;
			this.Nombre = nombre;
			this.Apellido = apellido;
			this.TiendaId = tiendaId;
		}

		public int Id { get => id; set => id = value; }
		public string Nombre { get => nombre; set => nombre = value; }
		public string Apellido { get => apellido; set => apellido = value; }
		public int TiendaId { get => tiendaId; set => tiendaId = value; }
	}
}
