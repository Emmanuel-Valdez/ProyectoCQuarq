using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
	public class Vendedor
	{
		
		private string nombre;
		private string apellido;
		private int tiendaId;
		private static int ultimoId = 0;
		

		public Vendedor(string nombre, string apellido, int tiendaId)
		{
			
			this.Nombre = nombre;
			this.Apellido = apellido;
			this.TiendaId = tiendaId;
			ultimoId++;
			Id = ultimoId;
			
		}

		public int Id { get; private set; }
		public string Nombre { get => nombre; set => nombre = value; }
		public string Apellido { get => apellido; set => apellido = value; }
		public int TiendaId { get => tiendaId; set => tiendaId = value; }

		public Cotizacion CrearCotizacion(int idPrenda, int cantidadCotizada, float precioUnitario,List<Prenda> Stock)
		{
			Prenda prendaSeleccionada = Stock[(idPrenda)];
			float precioModificado = prendaSeleccionada.PrecioPrenda(precioUnitario);
			Cotizacion C1 =new Cotizacion(DateTime.Now, Id, idPrenda, cantidadCotizada, precioUnitario, precioModificado*cantidadCotizada );
			return C1;
		}
	}
}
