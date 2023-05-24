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

		}
		public void showText(string text)
		{
			Console.WriteLine(text);
		}
	}
}