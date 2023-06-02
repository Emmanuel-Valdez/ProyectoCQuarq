using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Controller
{
	public class ControladorListaCotizaciones
	{
		private Servicios s1;

		public void ObtenerServicios(Servicios s1)
		{
			this.s1 = s1;
		}
		public int ElementosListaCotizaciones()
		{
			return s1.ListaCotizaciones.Count;
		}
		public List<string> EnviarCotizaciones(int n)
		{
			
			List<string> listaParaView = new List<string>();

			listaParaView.Add( s1.ListaCotizaciones[n].Id.ToString());
			listaParaView.Add(s1.ListaCotizaciones[n].Fecha.ToString());

			listaParaView.Add(s1.ListaCotizaciones[n].IdVendedor.ToString());
			listaParaView.Add(s1.ListaCotizaciones[n].PrendaId.ToString());
			listaParaView.Add(s1.ListaCotizaciones[n].Cantidad.ToString());
			listaParaView.Add(s1.ListaCotizaciones[n].PrecioUnitario.ToString());
			listaParaView.Add(s1.ListaCotizaciones[n].TotalCotizacion.ToString());

			return listaParaView;

			




		}



	}
}
