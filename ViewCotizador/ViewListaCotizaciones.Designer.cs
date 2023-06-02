namespace ViewCotizador
{
	partial class ViewListaCotizaciones
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			dgvHistorialCotizaciones = new DataGridView();
			Id = new DataGridViewTextBoxColumn();
			Fecha = new DataGridViewTextBoxColumn();
			IdVendedor = new DataGridViewTextBoxColumn();
			idPrenda = new DataGridViewTextBoxColumn();
			Cantidad = new DataGridViewTextBoxColumn();
			PrecioUnitario = new DataGridViewTextBoxColumn();
			PrecioCotizacion = new DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)dgvHistorialCotizaciones).BeginInit();
			SuspendLayout();
			// 
			// dgvHistorialCotizaciones
			// 
			dgvHistorialCotizaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvHistorialCotizaciones.Columns.AddRange(new DataGridViewColumn[] { Id, Fecha, IdVendedor, idPrenda, Cantidad, PrecioUnitario, PrecioCotizacion });
			dgvHistorialCotizaciones.Location = new Point(-9, 36);
			dgvHistorialCotizaciones.Name = "dgvHistorialCotizaciones";
			dgvHistorialCotizaciones.RowTemplate.Height = 25;
			dgvHistorialCotizaciones.Size = new Size(1007, 422);
			dgvHistorialCotizaciones.TabIndex = 0;
			// 
			// Id
			// 
			Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
			Id.HeaderText = "Id";
			Id.Name = "Id";
			Id.Width = 42;
			// 
			// Fecha
			// 
			Fecha.HeaderText = "Fecha";
			Fecha.Name = "Fecha";
			// 
			// IdVendedor
			// 
			IdVendedor.HeaderText = "idVendedor";
			IdVendedor.Name = "IdVendedor";
			// 
			// idPrenda
			// 
			idPrenda.HeaderText = "idPrenda";
			idPrenda.Name = "idPrenda";
			// 
			// Cantidad
			// 
			Cantidad.HeaderText = "Cantidad";
			Cantidad.Name = "Cantidad";
			// 
			// PrecioUnitario
			// 
			PrecioUnitario.HeaderText = "Precio por unidad";
			PrecioUnitario.Name = "PrecioUnitario";
			// 
			// PrecioCotizacion
			// 
			PrecioCotizacion.HeaderText = "Precio de la cotizacion";
			PrecioCotizacion.Name = "PrecioCotizacion";
			// 
			// ViewListaCotizaciones
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(996, 450);
			Controls.Add(dgvHistorialCotizaciones);
			Name = "ViewListaCotizaciones";
			Text = "Listado de cotizaciones";
			((System.ComponentModel.ISupportInitialize)dgvHistorialCotizaciones).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private DataGridView dgvHistorialCotizaciones;
		private DataGridViewTextBoxColumn Id;
		private DataGridViewTextBoxColumn Fecha;
		private DataGridViewTextBoxColumn IdVendedor;
		private DataGridViewTextBoxColumn idPrenda;
		private DataGridViewTextBoxColumn Cantidad;
		private DataGridViewTextBoxColumn PrecioUnitario;
		private DataGridViewTextBoxColumn PrecioCotizacion;
	}
}