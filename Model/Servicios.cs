using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
	 public class Servicios
	{
		private Tienda t1;
		private Vendedor v1;
		private List<Cotizacion> listaCotizaciones;

		

		public List<Cotizacion> ListaCotizaciones { get => listaCotizaciones; set => listaCotizaciones = value; }
		public Tienda T1 { get => t1; set => t1 = value; }
		public Vendedor V1 { get => v1; set => v1 = value; }

		

		private static List<Prenda> PedidoAFabrica()
		{
			Camisa CCortaComunStandard = new Camisa("Corta", "Comun", "Standard", 150);
			Camisa CCortaComunPremiun = new Camisa("Corta", "Comun", "Premiun", 150);
			Camisa CCortaMaoStandar = new Camisa("Corta", "Mao", "Standard", 100);
			Camisa CCortaMaoPremium = new Camisa("Corta", "Mao", "Premium", 100);	
			Camisa CLargaMaoStandar = new Camisa("Larga", "Mao", "Standard", 75);
			Camisa CLargaMaoPremium = new Camisa("Larga", "Mao", "Premium", 75);
			Camisa CLargaComunStandard = new Camisa("Larga", "Comun", "Standard", 175);
			Camisa CLargaComunPremiun = new Camisa("Larga", "Comun", "Premiun", 175);
			Pantalon PChupinStandard = new Pantalon("Chupin", "Standard", 750);
			Pantalon PChupinPremiun = new Pantalon("Chupin", "Premiun", 750);
			Pantalon PClasicoStandard = new Pantalon("Clasico", "Standard", 250);
			Pantalon PClasicoPremiun = new Pantalon("Clasico", "Premiun", 250);

			List<Prenda> ListaPedido = new List<Prenda>();
			ListaPedido.Add(CCortaMaoStandar);
			ListaPedido.Add(CCortaMaoPremium);
			ListaPedido.Add(CCortaComunStandard);
			ListaPedido.Add(CCortaComunPremiun);
			ListaPedido.Add(CLargaMaoStandar);
			ListaPedido.Add(CLargaMaoPremium);
			ListaPedido.Add(CLargaComunStandard);
			ListaPedido.Add(CLargaComunPremiun);
			ListaPedido.Add(PChupinStandard);
			ListaPedido.Add(PChupinPremiun);
			ListaPedido.Add(PClasicoStandard);
			ListaPedido.Add(PClasicoPremiun);

			return ListaPedido;
		}
		public void TiendaPrueba()
		{
			 T1 = new Tienda("Ukiyo", "Falsa123", PedidoAFabrica());
			 V1 = new Vendedor("Esteban", "Quito", T1.Id); 
		}

		public List<Cotizacion> Cotizar(int idPrenda, int cantidadCotizada,float precioUnitario)
		{
			Cotizacion C1 = V1.CrearCotizacion(idPrenda, cantidadCotizada, precioUnitario, T1.Stock);
			ListaCotizaciones.Add(C1);
			return ListaCotizaciones;
		}
		
	}
}
