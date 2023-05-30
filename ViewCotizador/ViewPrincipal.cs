using Controller;
namespace ViewCotizador
{
	public partial class ViewPrincipal : Form
	{
		private readonly ControladorVista _controller;
		private int idPrenda;
		private string clase;
		private string calidad;
		private string manga;
		private string cuello;
		private string estilo;

		public ViewPrincipal()
		{
			InitializeComponent();
			_controller = new ControladorVista();
		}
		private void ViewPrincipal_Load(object sender, EventArgs e)
		{

			DeterminarStock();
			labelNombreTienda.Text = _controller.ObtenerNombreTienda();
			labelDatosVendedor.Text = _controller.ObtenerDatosVendedor();
			labelDireccionTienda.Text = _controller.ObtenerDireccionTienda();

		}
		public void showText(string text)
		{
			
		}
		public void DefinirPrenda()
		{
			if (radioCamisa.Checked == true)
			{
				this.clase = "Camisa";
				cBEstiloChupin.Enabled = false;
				cBEstiloChupin.Checked = false;
				cBCuelloMao.Enabled = true;
				cBMangaCorta.Enabled = true;

			}
			else if (radioPantalon.Checked == true)
			{
				this.clase = "Pantalon";
				cBCuelloMao.Enabled = false;
				cBCuelloMao.Checked = false;
				cBMangaCorta.Enabled = false;
				cBMangaCorta.Checked = false;
				cBEstiloChupin.Enabled = true;
			}
			if (cBCuelloMao.Checked)
			{
				this.cuello = "Mao";
			}
			else
			{
				this.cuello = "Comun";
			}
			if (cBMangaCorta.Checked)
			{
				this.manga = "Corta";
			}
			else
			{
				this.manga = "Larga";
			}
			if (cBEstiloChupin.Checked)
			{
				this.estilo = "Chupin";
			}
			else
			{
				this.estilo = "Clasico";
			}
			if (radioPremium.Checked)
			{
				this.calidad = "Premium";
			}
			else if (radioStandard.Checked)
			{
				this.calidad = "Standard";
			}
		}
		public void DeterminarStock()
		{
			DefinirPrenda();
			this.idPrenda = _controller.ObtenerIdPrenda(this.clase, this.calidad, this.cuello, this.manga, this.estilo);
			labelStockPrenda.Text = "Unidades de stock disponibles: " + _controller.ObtenerStock(this.idPrenda);
		}
		#region variaciones en los switchs
		private void cBMangaCorta_CheckedChanged(object sender, EventArgs e)
		{
			DeterminarStock();
		}

		private void cBCuelloMao_CheckedChanged(object sender, EventArgs e)
		{
			DeterminarStock();
		}

		private void radioPantalon_CheckedChanged(object sender, EventArgs e)
		{
			DeterminarStock();
		}

		private void cBEstiloChupin_CheckedChanged(object sender, EventArgs e)
		{
			DeterminarStock();
		}

		private void radioPremium_CheckedChanged(object sender, EventArgs e)
		{
			DeterminarStock();
		}

		private void radioCamisa_CheckedChanged(object sender, EventArgs e)
		{
			DeterminarStock();
		}

		private void radioStandard_CheckedChanged(object sender, EventArgs e)
		{
			DeterminarStock();
		}

		#endregion

		private void buttonCotizar_Click(object sender, EventArgs e)
		{
			try
			{
				if(int.Parse(txtCantidad.Text)>0 & int.Parse(txtCantidad.Text) <= _controller.ObtenerStock(this.idPrenda) & float.Parse(txtPrecioUnitario.Text)>0)
				{
					labelCotizacion.Text = "$ " + _controller.CrearCotizacion(this.idPrenda, int.Parse(txtCantidad.Text), float.Parse(txtPrecioUnitario.Text));
				}
				else
				{
					if (int.Parse(txtCantidad.Text) < 0 || int.Parse(txtCantidad.Text) > _controller.ObtenerStock(this.idPrenda))
					{
						MessageBox.Show("La cantidad cotizada debe ser mayor a 0 y hasta el maximo de unidades disponibles", "Error de cantidad", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					else
					{
						MessageBox.Show("El precio debe ser positvo", "Error de precio unitario", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
			catch (FormatException )
			{

				MessageBox.Show("Ingrese solo numeros", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}