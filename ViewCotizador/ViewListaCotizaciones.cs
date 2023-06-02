using Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewCotizador
{
	public partial class ViewListaCotizaciones : Form
	{
		private readonly ControladorListaCotizaciones controller;
		public ViewListaCotizaciones(ControladorListaCotizaciones controller)
		{
			InitializeComponent();
			this.controller = controller;
			ImprimirLista();
		}

		public void ImprimirLista()
		{
			
			for (int i = 0; i < controller.ElementosListaCotizaciones(); i++)
			{
				List<string> lista = controller.EnviarCotizaciones(i);
				dgvHistorialCotizaciones.Rows.Add();
				for (int j = 0; j < 7; j++)
				{
					dgvHistorialCotizaciones.Rows[i].Cells[j].Value= lista[j];
				}
				
			}

			
            
		}
	}
}
