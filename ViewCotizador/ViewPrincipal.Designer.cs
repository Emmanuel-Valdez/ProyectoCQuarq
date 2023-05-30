using Controller;
namespace ViewCotizador

{
	partial class ViewPrincipal
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			flowLayoutPanel1 = new FlowLayoutPanel();
			panel1 = new Panel();
			labelTitulo = new Label();
			panel2 = new Panel();
			labelDireccionTienda = new Label();
			labelNombreTienda = new Label();
			panel3 = new Panel();
			labelHistorialCotizaciones = new LinkLabel();
			labelDatosVendedor = new Label();
			panel4 = new Panel();
			groupBox4 = new GroupBox();
			label3 = new Label();
			label2 = new Label();
			txtCantidad = new TextBox();
			txtPrecioUnitario = new TextBox();
			groupBox3 = new GroupBox();
			radioPremium = new RadioButton();
			radioStandard = new RadioButton();
			groupBox2 = new GroupBox();
			labelStockPrenda = new Label();
			groupBox1 = new GroupBox();
			cBEstiloChupin = new CheckBox();
			cBCuelloMao = new CheckBox();
			cBMangaCorta = new CheckBox();
			radioPantalon = new RadioButton();
			radioCamisa = new RadioButton();
			panel5 = new Panel();
			labelCotizacion = new Label();
			buttonCotizar = new Button();
			flowLayoutPanel1.SuspendLayout();
			panel1.SuspendLayout();
			panel2.SuspendLayout();
			panel3.SuspendLayout();
			panel4.SuspendLayout();
			groupBox4.SuspendLayout();
			groupBox3.SuspendLayout();
			groupBox2.SuspendLayout();
			groupBox1.SuspendLayout();
			panel5.SuspendLayout();
			SuspendLayout();
			// 
			// flowLayoutPanel1
			// 
			flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
			flowLayoutPanel1.Controls.Add(panel1);
			flowLayoutPanel1.Controls.Add(panel2);
			flowLayoutPanel1.Controls.Add(panel3);
			flowLayoutPanel1.Controls.Add(panel4);
			flowLayoutPanel1.Controls.Add(panel5);
			flowLayoutPanel1.Location = new Point(139, 12);
			flowLayoutPanel1.Name = "flowLayoutPanel1";
			flowLayoutPanel1.Size = new Size(506, 500);
			flowLayoutPanel1.TabIndex = 0;
			// 
			// panel1
			// 
			panel1.BackColor = SystemColors.ActiveCaption;
			panel1.Controls.Add(labelTitulo);
			panel1.Location = new Point(3, 3);
			panel1.Name = "panel1";
			panel1.Size = new Size(499, 73);
			panel1.TabIndex = 0;
			// 
			// labelTitulo
			// 
			labelTitulo.AutoSize = true;
			labelTitulo.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			labelTitulo.Location = new Point(175, 14);
			labelTitulo.Name = "labelTitulo";
			labelTitulo.Size = new Size(163, 24);
			labelTitulo.TabIndex = 0;
			labelTitulo.Text = "Cotizador Express";
			labelTitulo.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// panel2
			// 
			panel2.Controls.Add(labelDireccionTienda);
			panel2.Controls.Add(labelNombreTienda);
			panel2.Location = new Point(3, 82);
			panel2.Name = "panel2";
			panel2.Size = new Size(502, 38);
			panel2.TabIndex = 1;
			// 
			// labelDireccionTienda
			// 
			labelDireccionTienda.AutoSize = true;
			labelDireccionTienda.Location = new Point(407, 14);
			labelDireccionTienda.Name = "labelDireccionTienda";
			labelDireccionTienda.Size = new Size(95, 15);
			labelDireccionTienda.TabIndex = 1;
			labelDireccionTienda.Text = "direccion  tienda";
			labelDireccionTienda.TextAlign = ContentAlignment.MiddleRight;
			// 
			// labelNombreTienda
			// 
			labelNombreTienda.AutoSize = true;
			labelNombreTienda.Location = new Point(3, 14);
			labelNombreTienda.Name = "labelNombreTienda";
			labelNombreTienda.Size = new Size(85, 15);
			labelNombreTienda.TabIndex = 0;
			labelNombreTienda.Text = "nombre tienda";
			// 
			// panel3
			// 
			panel3.Controls.Add(labelHistorialCotizaciones);
			panel3.Controls.Add(labelDatosVendedor);
			panel3.Location = new Point(3, 126);
			panel3.Name = "panel3";
			panel3.Size = new Size(502, 40);
			panel3.TabIndex = 2;
			// 
			// labelHistorialCotizaciones
			// 
			labelHistorialCotizaciones.AutoSize = true;
			labelHistorialCotizaciones.Location = new Point(358, 15);
			labelHistorialCotizaciones.Name = "labelHistorialCotizaciones";
			labelHistorialCotizaciones.Size = new Size(137, 15);
			labelHistorialCotizaciones.TabIndex = 1;
			labelHistorialCotizaciones.TabStop = true;
			labelHistorialCotizaciones.Text = "Historial de Cotizaciones";
			labelHistorialCotizaciones.LinkClicked += labelHistorialCotizaciones_LinkClicked;
			// 
			// labelDatosVendedor
			// 
			labelDatosVendedor.AutoSize = true;
			labelDatosVendedor.Location = new Point(2, 15);
			labelDatosVendedor.Name = "labelDatosVendedor";
			labelDatosVendedor.Size = new Size(108, 15);
			labelDatosVendedor.TabIndex = 0;
			labelDatosVendedor.Text = "datos del vendedor";
			// 
			// panel4
			// 
			panel4.Controls.Add(groupBox4);
			panel4.Controls.Add(groupBox3);
			panel4.Controls.Add(groupBox2);
			panel4.Controls.Add(groupBox1);
			panel4.Location = new Point(3, 172);
			panel4.Name = "panel4";
			panel4.Size = new Size(502, 246);
			panel4.TabIndex = 3;
			// 
			// groupBox4
			// 
			groupBox4.Controls.Add(label3);
			groupBox4.Controls.Add(label2);
			groupBox4.Controls.Add(txtCantidad);
			groupBox4.Controls.Add(txtPrecioUnitario);
			groupBox4.Location = new Point(224, 142);
			groupBox4.Name = "groupBox4";
			groupBox4.Size = new Size(254, 67);
			groupBox4.TabIndex = 3;
			groupBox4.TabStop = false;
			groupBox4.Text = "Precio unitario y cantidad";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(134, 41);
			label3.Name = "label3";
			label3.Size = new Size(55, 15);
			label3.TabIndex = 3;
			label3.Text = "Cantidad";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(1, 41);
			label2.Name = "label2";
			label2.Size = new Size(13, 15);
			label2.TabIndex = 2;
			label2.Text = "$";
			// 
			// txtCantidad
			// 
			txtCantidad.Location = new Point(206, 38);
			txtCantidad.Name = "txtCantidad";
			txtCantidad.Size = new Size(48, 23);
			txtCantidad.TabIndex = 1;
			// 
			// txtPrecioUnitario
			// 
			txtPrecioUnitario.Location = new Point(25, 38);
			txtPrecioUnitario.Name = "txtPrecioUnitario";
			txtPrecioUnitario.Size = new Size(77, 23);
			txtPrecioUnitario.TabIndex = 0;
			// 
			// groupBox3
			// 
			groupBox3.Controls.Add(radioPremium);
			groupBox3.Controls.Add(radioStandard);
			groupBox3.Location = new Point(26, 142);
			groupBox3.Name = "groupBox3";
			groupBox3.Size = new Size(192, 67);
			groupBox3.TabIndex = 2;
			groupBox3.TabStop = false;
			groupBox3.Text = "Calidad de la prenda";
			// 
			// radioPremium
			// 
			radioPremium.AutoSize = true;
			radioPremium.Location = new Point(109, 32);
			radioPremium.Name = "radioPremium";
			radioPremium.Size = new Size(74, 19);
			radioPremium.TabIndex = 1;
			radioPremium.Text = "Premium";
			radioPremium.UseVisualStyleBackColor = true;
			radioPremium.CheckedChanged += radioPremium_CheckedChanged;
			// 
			// radioStandard
			// 
			radioStandard.AutoSize = true;
			radioStandard.Checked = true;
			radioStandard.Location = new Point(0, 32);
			radioStandard.Name = "radioStandard";
			radioStandard.Size = new Size(72, 19);
			radioStandard.TabIndex = 0;
			radioStandard.TabStop = true;
			radioStandard.Text = "Standard";
			radioStandard.UseVisualStyleBackColor = true;
			radioStandard.CheckedChanged += radioStandard_CheckedChanged;
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(labelStockPrenda);
			groupBox2.Location = new Point(21, 89);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(457, 47);
			groupBox2.TabIndex = 1;
			groupBox2.TabStop = false;
			// 
			// labelStockPrenda
			// 
			labelStockPrenda.AutoSize = true;
			labelStockPrenda.Location = new Point(5, 21);
			labelStockPrenda.Name = "labelStockPrenda";
			labelStockPrenda.Size = new Size(192, 15);
			labelStockPrenda.TabIndex = 0;
			labelStockPrenda.Text = "Unidades de stock disponibles: ____";
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(cBEstiloChupin);
			groupBox1.Controls.Add(cBCuelloMao);
			groupBox1.Controls.Add(cBMangaCorta);
			groupBox1.Controls.Add(radioPantalon);
			groupBox1.Controls.Add(radioCamisa);
			groupBox1.Location = new Point(21, 3);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(457, 80);
			groupBox1.TabIndex = 0;
			groupBox1.TabStop = false;
			groupBox1.Text = "Prenda";
			// 
			// cBEstiloChupin
			// 
			cBEstiloChupin.AutoSize = true;
			cBEstiloChupin.Enabled = false;
			cBEstiloChupin.Location = new Point(192, 56);
			cBEstiloChupin.Name = "cBEstiloChupin";
			cBEstiloChupin.Size = new Size(65, 19);
			cBEstiloChupin.TabIndex = 4;
			cBEstiloChupin.Text = "Chupin";
			cBEstiloChupin.UseVisualStyleBackColor = true;
			cBEstiloChupin.CheckedChanged += cBEstiloChupin_CheckedChanged;
			// 
			// cBCuelloMao
			// 
			cBCuelloMao.AutoSize = true;
			cBCuelloMao.Location = new Point(318, 23);
			cBCuelloMao.Name = "cBCuelloMao";
			cBCuelloMao.Size = new Size(87, 19);
			cBCuelloMao.TabIndex = 3;
			cBCuelloMao.Text = "Cuello Mao";
			cBCuelloMao.UseVisualStyleBackColor = true;
			cBCuelloMao.CheckedChanged += cBCuelloMao_CheckedChanged;
			// 
			// cBMangaCorta
			// 
			cBMangaCorta.AutoSize = true;
			cBMangaCorta.Location = new Point(192, 23);
			cBMangaCorta.Name = "cBMangaCorta";
			cBMangaCorta.Size = new Size(95, 19);
			cBMangaCorta.TabIndex = 2;
			cBMangaCorta.Text = "Manga Corta";
			cBMangaCorta.UseVisualStyleBackColor = true;
			cBMangaCorta.CheckedChanged += cBMangaCorta_CheckedChanged;
			// 
			// radioPantalon
			// 
			radioPantalon.AutoSize = true;
			radioPantalon.Location = new Point(20, 55);
			radioPantalon.Name = "radioPantalon";
			radioPantalon.Size = new Size(72, 19);
			radioPantalon.TabIndex = 1;
			radioPantalon.Text = "Pantalon";
			radioPantalon.UseVisualStyleBackColor = true;
			radioPantalon.CheckedChanged += radioPantalon_CheckedChanged;
			// 
			// radioCamisa
			// 
			radioCamisa.AutoSize = true;
			radioCamisa.Checked = true;
			radioCamisa.Location = new Point(20, 22);
			radioCamisa.Name = "radioCamisa";
			radioCamisa.Size = new Size(64, 19);
			radioCamisa.TabIndex = 0;
			radioCamisa.TabStop = true;
			radioCamisa.Text = "Camisa";
			radioCamisa.UseVisualStyleBackColor = true;
			radioCamisa.CheckedChanged += radioCamisa_CheckedChanged;
			// 
			// panel5
			// 
			panel5.Controls.Add(labelCotizacion);
			panel5.Controls.Add(buttonCotizar);
			panel5.Location = new Point(3, 424);
			panel5.Name = "panel5";
			panel5.Size = new Size(478, 62);
			panel5.TabIndex = 4;
			// 
			// labelCotizacion
			// 
			labelCotizacion.AutoSize = true;
			labelCotizacion.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			labelCotizacion.Location = new Point(320, 19);
			labelCotizacion.Name = "labelCotizacion";
			labelCotizacion.Size = new Size(155, 24);
			labelCotizacion.TabIndex = 1;
			labelCotizacion.Text = "$ _____________";
			// 
			// buttonCotizar
			// 
			buttonCotizar.AutoSize = true;
			buttonCotizar.BackColor = SystemColors.ActiveCaption;
			buttonCotizar.Cursor = Cursors.Hand;
			buttonCotizar.FlatStyle = FlatStyle.Popup;
			buttonCotizar.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			buttonCotizar.Location = new Point(62, 14);
			buttonCotizar.Margin = new Padding(10);
			buttonCotizar.Name = "buttonCotizar";
			buttonCotizar.Size = new Size(102, 34);
			buttonCotizar.TabIndex = 0;
			buttonCotizar.Text = "COTIZAR";
			buttonCotizar.UseVisualStyleBackColor = false;
			buttonCotizar.Click += buttonCotizar_Click;
			// 
			// ViewPrincipal
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(885, 524);
			Controls.Add(flowLayoutPanel1);
			Name = "ViewPrincipal";
			Text = "Cotizador";
			Load += ViewPrincipal_Load;
			flowLayoutPanel1.ResumeLayout(false);
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			panel3.ResumeLayout(false);
			panel3.PerformLayout();
			panel4.ResumeLayout(false);
			groupBox4.ResumeLayout(false);
			groupBox4.PerformLayout();
			groupBox3.ResumeLayout(false);
			groupBox3.PerformLayout();
			groupBox2.ResumeLayout(false);
			groupBox2.PerformLayout();
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			panel5.ResumeLayout(false);
			panel5.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private FlowLayoutPanel flowLayoutPanel1;
		private Panel panel1;
		private Panel panel2;
		private Panel panel3;
		private Panel panel4;
		private Label labelTitulo;
		private Panel panel5;
		private Label labelDireccionTienda;
		private Label labelNombreTienda;
		private GroupBox groupBox2;
		private GroupBox groupBox1;
		private LinkLabel labelHistorialCotizaciones;
		private Label labelDatosVendedor;
		private GroupBox groupBox4;
		private GroupBox groupBox3;
		private Label labelStockPrenda;
		private Label labelCotizacion;
		private Button buttonCotizar;
		private RadioButton radioPantalon;
		private RadioButton radioCamisa;
		private CheckBox cBEstiloChupin;
		private Label label3;
		private Label label2;
		private TextBox txtCantidad;
		private TextBox txtPrecioUnitario;
		private RadioButton radioPremium;
		private RadioButton radioStandard;
		private CheckBox cBCuelloMao;
		private CheckBox cBMangaCorta;
	}
}