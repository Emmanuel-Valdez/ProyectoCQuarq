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
			Camisa CCortaComunPremium = new Camisa("Corta", "Comun", "Premium", 150);
			Camisa CCortaMaoStandar = new Camisa("Corta", "Mao", "Standard", 100);
			Camisa CCortaMaoPremium = new Camisa("Corta", "Mao", "Premium", 100);	
			Camisa CLargaMaoStandar = new Camisa("Larga", "Mao", "Standard", 75);
			Camisa CLargaMaoPremium = new Camisa("Larga", "Mao", "Premium", 75);
			Camisa CLargaComunStandard = new Camisa("Larga", "Comun", "Standard", 175);
			Camisa CLargaComunPremium = new Camisa("Larga", "Comun", "Premium", 175);
			Pantalon PChupinStandard = new Pantalon("Chupin", "Standard", 750);
			Pantalon PChupinPremium = new Pantalon("Chupin", "Premium", 750);
			Pantalon PClasicoStandard = new Pantalon("Clasico", "Standard", 250);
			Pantalon PClasicoPremium = new Pantalon("Clasico", "Premium", 250);

			List<Prenda> ListaPedido = new List<Prenda>();
			ListaPedido.Add(CCortaMaoStandar);
			ListaPedido.Add(CCortaMaoPremium);
			ListaPedido.Add(CCortaComunStandard);
			ListaPedido.Add(CCortaComunPremium);
			ListaPedido.Add(CLargaMaoStandar);
			ListaPedido.Add(CLargaMaoPremium);
			ListaPedido.Add(CLargaComunStandard);
			ListaPedido.Add(CLargaComunPremium);
			ListaPedido.Add(PChupinStandard);
			ListaPedido.Add(PChupinPremium);
			ListaPedido.Add(PClasicoStandard);
			ListaPedido.Add(PClasicoPremium);

			return ListaPedido;
		}
		public void TiendaPrueba()
		{
			 T1 = new Tienda("Ukiyo", "Falsa123", PedidoAFabrica());
			 V1 = new Vendedor("Esteban", "Quito", T1.Id); 
			ListaCotizaciones = new List<Cotizacion>();
		}

		public float Cotizar(int idPrenda, int cantidadCotizada,float precioUnitario)
		{
			Cotizacion C1 = V1.CrearCotizacion(idPrenda, cantidadCotizada, precioUnitario, T1.Stock);
			ListaCotizaciones.Add(C1);
			return C1.TotalCotizacion;
			
		}
		
	}
}
