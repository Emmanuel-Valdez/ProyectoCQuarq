using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Model;



namespace Controller
{
	public class ControladorVista
	{
		private readonly IViewPrincipal _view;
		Servicios s1 = new Servicios();  

		public ControladorVista(IViewPrincipal view)
		{
			_view = view;
			s1= new Servicios();
		}
		private void IniciarPrograma()
		{
			s1.TiendaPrueba();
		}
		
		private void CrearCotizacion(int idPrenda,int cantidadCotizada, float precioUnitario)
		{
			
			s1.Cotizar(idPrenda, cantidadCotizada, precioUnitario);

			//Console.Write(s1.ListaCotizaciones[cot.Id]);
		}

	}
}
