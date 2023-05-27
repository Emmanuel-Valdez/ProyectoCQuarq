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
			textBox2 = new TextBox();
			textBox1 = new TextBox();
			groupBox3 = new GroupBox();
			radioPremiun = new RadioButton();
			radioStandard = new RadioButton();
			groupBox2 = new GroupBox();
			labelStockPrenda = new Label();
			groupBox1 = new GroupBox();
			checkBox3 = new CheckBox();
			checkBox2 = new CheckBox();
			checkBox1 = new CheckBox();
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
			labelDireccionTienda.Location = new Point(379, 14);
			labelDireccionTienda.Name = "labelDireccionTienda";
			labelDireccionTienda.Size = new Size(120, 15);
			labelDireccionTienda.TabIndex = 1;
			labelDireccionTienda.Text = "direccion de la tienda";
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
			groupBox4.Controls.Add(textBox2);
			groupBox4.Controls.Add(textBox1);
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
			// textBox2
			// 
			textBox2.Location = new Point(206, 38);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(48, 23);
			textBox2.TabIndex = 1;
			// 
			// textBox1
			// 
			textBox1.Location = new Point(25, 38);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(77, 23);
			textBox1.TabIndex = 0;
			// 
			// groupBox3
			// 
			groupBox3.Controls.Add(radioPremiun);
			groupBox3.Controls.Add(radioStandard);
			groupBox3.Location = new Point(26, 142);
			groupBox3.Name = "groupBox3";
			groupBox3.Size = new Size(192, 67);
			groupBox3.TabIndex = 2;
			groupBox3.TabStop = false;
			groupBox3.Text = "Calidad de la prenda";
			// 
			// radioPremiun
			// 
			radioPremiun.AutoSize = true;
			radioPremiun.Location = new Point(109, 32);
			radioPremiun.Name = "radioPremiun";
			radioPremiun.Size = new Size(74, 19);
			radioPremiun.TabIndex = 1;
			radioPremiun.Text = "Premium";
			radioPremiun.UseVisualStyleBackColor = true;
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
			groupBox1.Controls.Add(checkBox3);
			groupBox1.Controls.Add(checkBox2);
			groupBox1.Controls.Add(checkBox1);
			groupBox1.Controls.Add(radioPantalon);
			groupBox1.Controls.Add(radioCamisa);
			groupBox1.Location = new Point(21, 3);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(457, 80);
			groupBox1.TabIndex = 0;
			groupBox1.TabStop = false;
			groupBox1.Text = "Prenda";
			// 
			// checkBox3
			// 
			checkBox3.AutoSize = true;
			checkBox3.Enabled = false;
			checkBox3.Location = new Point(192, 56);
			checkBox3.Name = "checkBox3";
			checkBox3.Size = new Size(65, 19);
			checkBox3.TabIndex = 4;
			checkBox3.Text = "Chupin";
			checkBox3.UseVisualStyleBackColor = true;
			// 
			// checkBox2
			// 
			checkBox2.AutoSize = true;
			checkBox2.Location = new Point(318, 23);
			checkBox2.Name = "checkBox2";
			checkBox2.Size = new Size(87, 19);
			checkBox2.TabIndex = 3;
			checkBox2.Text = "Cuello Mao";
			checkBox2.UseVisualStyleBackColor = true;
			// 
			// checkBox1
			// 
			checkBox1.AutoSize = true;
			checkBox1.Location = new Point(192, 23);
			checkBox1.Name = "checkBox1";
			checkBox1.Size = new Size(95, 19);
			checkBox1.TabIndex = 2;
			checkBox1.Text = "Manga Corta";
			checkBox1.UseVisualStyleBackColor = true;
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
			labelCotizacion.Location = new Point(323, 19);
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
		private CheckBox checkBox3;
		private Label label3;
		private Label label2;
		private TextBox textBox2;
		private TextBox textBox1;
		private RadioButton radioPremiun;
		private RadioButton radioStandard;
		private CheckBox checkBox2;
		private CheckBox checkBox1;
	}
}