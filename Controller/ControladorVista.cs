using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
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
			IniciarPrograma();
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
		public int obtenerIdPrenda(string clase, string calidad, string cuello, string manga, string estilo)
		{
			foreach (var tipoPrenda in s1.T1.Stock)
			{

				if (tipoPrenda is Pantalon pantalon && clase == "Pantalon" && estilo == pantalon.Estilo && calidad == tipoPrenda.Calidad)
				{
					return tipoPrenda.Id;
				}
				else if (tipoPrenda is Camisa camisa && clase == "Camisa" && calidad == tipoPrenda.Calidad && cuello == camisa.Cuello && manga == camisa.Manga)
				{
					return tipoPrenda.Id;
				}
			}
			return 99;
		}

		public string obtenerStock(int idPrenda)
		{ 
			return s1.T1.Stock[idPrenda].Cantidad.ToString();
		}


	}
}
