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
		
		Servicios s1 = new Servicios();  

		
			public ControladorVista()
		{
		
			s1= new Servicios();
			IniciarPrograma();
		}
		private void IniciarPrograma()
		{
			s1.TiendaPrueba();
		}
		
		public string CrearCotizacion(int idPrenda,int cantidadCotizada, float precioUnitario)
		{
			
			return s1.Cotizar(idPrenda, cantidadCotizada, precioUnitario).ToString();

			//Console.Write(s1.ListaCotizaciones[cot.Id]);
		}
		public int ObtenerIdPrenda(string clase, string calidad, string cuello, string manga, string estilo)
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

		public int ObtenerStock(int idPrenda)
		{
			return s1.T1.Stock[idPrenda].Cantidad;
		}
		public string ObtenerNombreTienda()
		{
			return s1.T1.Nombre;
		}
		public string ObtenerDatosVendedor()
		{
			return s1.V1.Nombre + " " + s1.V1.Apellido;
		}
		public string ObtenerDireccionTienda()
		{
			return s1.T1.Direccion;
		}

	}
}
