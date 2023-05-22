using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
	internal class Servicios
	{
		private Tienda T1;
		private Vendedor V1;
		public static List<Prenda> PedidoAFabrica()
		{

			Camisa CCortaMaoStandar = new Camisa("Corta", "Mao", "Standard", 100);
			Camisa CCortaMaoPremium = new Camisa("Corta", "Mao", "Premium", 100);
			Camisa CCortaComunStandard = new Camisa("Corta", "Comun", "Standard", 150);
			Camisa CCortaComunPremiun = new Camisa("Corta", "Comun", "Premiun", 150);
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

		public void Cotizar(Cotizacion C1)
		{
			
		}
		 

	}
}
