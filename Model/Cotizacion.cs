using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
	public class Cotizacion
	{
		
		private DateTime fecha;
		private int idVendedor;
		private int prendaId;
		private int cantidad;
		private float precioUnitario;
		private float totalCotizacion;
		private static int ultimoId = 0;
		

		public Cotizacion(DateTime fecha, int idVendedor, int prendaId, int cantidad, float precioUnitario, float totalCotizacion)
		{
			
			this.fecha = fecha;
			this.idVendedor = idVendedor;
			this.prendaId = prendaId;
			this.cantidad = cantidad;
			this.precioUnitario = precioUnitario;
			this.totalCotizacion = totalCotizacion;
			ultimoId++;
			Id = ultimoId;
			
		}

		public int Id { get; private set; }
		public DateTime Fecha { get => fecha; set => fecha = value; }
		public int IdVendedor { get => idVendedor; set => idVendedor = value; }
		public int PrendaId { get => prendaId; set => prendaId = value; }
		public int Cantidad { get => cantidad; set => cantidad = value; }
		public float PrecioUnitario { get => precioUnitario; set => precioUnitario = value; }
		public float TotalCotizacion { get => totalCotizacion; set => totalCotizacion = value; }


	}
}
