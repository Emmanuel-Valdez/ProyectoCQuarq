using Controller;
namespace ViewCotizador
{
	public partial class ViewPrincipal : Form, IViewPrincipal
	{
		private readonly ControladorVista _controller;

		public ViewPrincipal()
		{
			InitializeComponent();
			_controller = new ControladorVista(this);
		}
		private void ViewPrincipal_Load(object sender, EventArgs e)
		{
			int idPrenda = _controller.obtenerIdPrenda("Camisa", "Standard", "Comun", "Corta", "");
			labelStockPrenda.Text = "Unidades de stock disponibles: " + _controller.obtenerStock(idPrenda);
			labelTitulo.Text += idPrenda.ToString();
		}
		public void showText(string text)
		{
			//Console.WriteLine(text);
		}

	}
}