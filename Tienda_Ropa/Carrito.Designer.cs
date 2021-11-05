
namespace Tienda_Ropa
{
    partial class Carrito
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
            this.texto_carrito = new System.Windows.Forms.Label();
            this.grupo_tipo_prenda = new System.Windows.Forms.GroupBox();
            this.grupo_tipo_pantalon = new System.Windows.Forms.GroupBox();
            this.seleccion_bermuda = new System.Windows.Forms.RadioButton();
            this.seleccion_pant_normal = new System.Windows.Forms.RadioButton();
            this.grupo_tipo_camisa = new System.Windows.Forms.GroupBox();
            this.seleccion_manga_corta = new System.Windows.Forms.RadioButton();
            this.seleccion_camis_normal = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.seleccion_camisa = new System.Windows.Forms.RadioButton();
            this.seleccion_pantalon = new System.Windows.Forms.RadioButton();
            this.grupo_calidad = new System.Windows.Forms.GroupBox();
            this.seleccion_premium = new System.Windows.Forms.RadioButton();
            this.seleccion_standard = new System.Windows.Forms.RadioButton();
            this.grupo_cantidad = new System.Windows.Forms.GroupBox();
            this.texto_max_min = new System.Windows.Forms.Label();
            this.barra_cantidad = new System.Windows.Forms.TrackBar();
            this.salida_cantidad = new System.Windows.Forms.TextBox();
            this.grupo_precio = new System.Windows.Forms.GroupBox();
            this.entrada_precio = new System.Windows.Forms.TextBox();
            this.seleccion_dolares = new System.Windows.Forms.RadioButton();
            this.seleccion_pesos = new System.Windows.Forms.RadioButton();
            this.boton_calcular = new System.Windows.Forms.Button();
            this.grupo_tipo_prenda.SuspendLayout();
            this.grupo_tipo_pantalon.SuspendLayout();
            this.grupo_tipo_camisa.SuspendLayout();
            this.grupo_calidad.SuspendLayout();
            this.grupo_cantidad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barra_cantidad)).BeginInit();
            this.grupo_precio.SuspendLayout();
            this.SuspendLayout();
            // 
            // texto_carrito
            // 
            this.texto_carrito.AutoSize = true;
            this.texto_carrito.Location = new System.Drawing.Point(12, 9);
            this.texto_carrito.Name = "texto_carrito";
            this.texto_carrito.Size = new System.Drawing.Size(129, 13);
            this.texto_carrito.TabIndex = 0;
            this.texto_carrito.Text = "CARRITO DE COMPRAS";
            // 
            // grupo_tipo_prenda
            // 
            this.grupo_tipo_prenda.Controls.Add(this.grupo_tipo_pantalon);
            this.grupo_tipo_prenda.Controls.Add(this.grupo_tipo_camisa);
            this.grupo_tipo_prenda.Controls.Add(this.groupBox1);
            this.grupo_tipo_prenda.Controls.Add(this.seleccion_camisa);
            this.grupo_tipo_prenda.Controls.Add(this.seleccion_pantalon);
            this.grupo_tipo_prenda.Location = new System.Drawing.Point(15, 38);
            this.grupo_tipo_prenda.Name = "grupo_tipo_prenda";
            this.grupo_tipo_prenda.Size = new System.Drawing.Size(306, 205);
            this.grupo_tipo_prenda.TabIndex = 1;
            this.grupo_tipo_prenda.TabStop = false;
            this.grupo_tipo_prenda.Text = "TIPO";
            // 
            // grupo_tipo_pantalon
            // 
            this.grupo_tipo_pantalon.Controls.Add(this.seleccion_bermuda);
            this.grupo_tipo_pantalon.Controls.Add(this.seleccion_pant_normal);
            this.grupo_tipo_pantalon.Location = new System.Drawing.Point(6, 142);
            this.grupo_tipo_pantalon.Name = "grupo_tipo_pantalon";
            this.grupo_tipo_pantalon.Size = new System.Drawing.Size(294, 34);
            this.grupo_tipo_pantalon.TabIndex = 2;
            this.grupo_tipo_pantalon.TabStop = false;
            // 
            // seleccion_bermuda
            // 
            this.seleccion_bermuda.AutoSize = true;
            this.seleccion_bermuda.Location = new System.Drawing.Point(169, 11);
            this.seleccion_bermuda.Name = "seleccion_bermuda";
            this.seleccion_bermuda.Size = new System.Drawing.Size(67, 17);
            this.seleccion_bermuda.TabIndex = 1;
            this.seleccion_bermuda.TabStop = true;
            this.seleccion_bermuda.Text = "Bermuda";
            this.seleccion_bermuda.UseVisualStyleBackColor = true;
            this.seleccion_bermuda.CheckedChanged += new System.EventHandler(this.seleccion_bermuda_CheckedChanged_1);
            // 
            // seleccion_pant_normal
            // 
            this.seleccion_pant_normal.AutoSize = true;
            this.seleccion_pant_normal.Location = new System.Drawing.Point(43, 11);
            this.seleccion_pant_normal.Name = "seleccion_pant_normal";
            this.seleccion_pant_normal.Size = new System.Drawing.Size(58, 17);
            this.seleccion_pant_normal.TabIndex = 0;
            this.seleccion_pant_normal.TabStop = true;
            this.seleccion_pant_normal.Text = "Normal";
            this.seleccion_pant_normal.UseVisualStyleBackColor = true;
            // 
            // grupo_tipo_camisa
            // 
            this.grupo_tipo_camisa.Controls.Add(this.seleccion_manga_corta);
            this.grupo_tipo_camisa.Controls.Add(this.seleccion_camis_normal);
            this.grupo_tipo_camisa.Location = new System.Drawing.Point(6, 54);
            this.grupo_tipo_camisa.Name = "grupo_tipo_camisa";
            this.grupo_tipo_camisa.Size = new System.Drawing.Size(294, 34);
            this.grupo_tipo_camisa.TabIndex = 2;
            this.grupo_tipo_camisa.TabStop = false;
            // 
            // seleccion_manga_corta
            // 
            this.seleccion_manga_corta.AutoSize = true;
            this.seleccion_manga_corta.Location = new System.Drawing.Point(169, 10);
            this.seleccion_manga_corta.Name = "seleccion_manga_corta";
            this.seleccion_manga_corta.Size = new System.Drawing.Size(86, 17);
            this.seleccion_manga_corta.TabIndex = 5;
            this.seleccion_manga_corta.TabStop = true;
            this.seleccion_manga_corta.Text = "Manga Corta";
            this.seleccion_manga_corta.UseVisualStyleBackColor = true;
            // 
            // seleccion_camis_normal
            // 
            this.seleccion_camis_normal.AutoSize = true;
            this.seleccion_camis_normal.Location = new System.Drawing.Point(43, 10);
            this.seleccion_camis_normal.Name = "seleccion_camis_normal";
            this.seleccion_camis_normal.Size = new System.Drawing.Size(58, 17);
            this.seleccion_camis_normal.TabIndex = 4;
            this.seleccion_camis_normal.TabStop = true;
            this.seleccion_camis_normal.Text = "Normal";
            this.seleccion_camis_normal.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(5, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 10);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // seleccion_camisa
            // 
            this.seleccion_camisa.AutoSize = true;
            this.seleccion_camisa.Location = new System.Drawing.Point(12, 30);
            this.seleccion_camisa.Name = "seleccion_camisa";
            this.seleccion_camisa.Size = new System.Drawing.Size(59, 17);
            this.seleccion_camisa.TabIndex = 0;
            this.seleccion_camisa.TabStop = true;
            this.seleccion_camisa.Text = "Camisa";
            this.seleccion_camisa.UseVisualStyleBackColor = true;
            this.seleccion_camisa.CheckedChanged += new System.EventHandler(this.seleccion_camisa_CheckedChanged_1);
            // 
            // seleccion_pantalon
            // 
            this.seleccion_pantalon.AutoSize = true;
            this.seleccion_pantalon.Location = new System.Drawing.Point(12, 119);
            this.seleccion_pantalon.Name = "seleccion_pantalon";
            this.seleccion_pantalon.Size = new System.Drawing.Size(67, 17);
            this.seleccion_pantalon.TabIndex = 1;
            this.seleccion_pantalon.TabStop = true;
            this.seleccion_pantalon.Text = "Pantalon";
            this.seleccion_pantalon.UseVisualStyleBackColor = true;
            this.seleccion_pantalon.CheckedChanged += new System.EventHandler(this.seleccion_pantalon_CheckedChanged);
            // 
            // grupo_calidad
            // 
            this.grupo_calidad.Controls.Add(this.seleccion_premium);
            this.grupo_calidad.Controls.Add(this.seleccion_standard);
            this.grupo_calidad.Location = new System.Drawing.Point(15, 259);
            this.grupo_calidad.Name = "grupo_calidad";
            this.grupo_calidad.Size = new System.Drawing.Size(306, 52);
            this.grupo_calidad.TabIndex = 2;
            this.grupo_calidad.TabStop = false;
            this.grupo_calidad.Text = "CALIDAD";
            // 
            // seleccion_premium
            // 
            this.seleccion_premium.AutoSize = true;
            this.seleccion_premium.Location = new System.Drawing.Point(175, 19);
            this.seleccion_premium.Name = "seleccion_premium";
            this.seleccion_premium.Size = new System.Drawing.Size(65, 17);
            this.seleccion_premium.TabIndex = 1;
            this.seleccion_premium.TabStop = true;
            this.seleccion_premium.Text = "Premium";
            this.seleccion_premium.UseVisualStyleBackColor = true;
            this.seleccion_premium.CheckedChanged += new System.EventHandler(this.seleccion_premium_CheckedChanged);
            // 
            // seleccion_standard
            // 
            this.seleccion_standard.AutoSize = true;
            this.seleccion_standard.Location = new System.Drawing.Point(49, 19);
            this.seleccion_standard.Name = "seleccion_standard";
            this.seleccion_standard.Size = new System.Drawing.Size(68, 17);
            this.seleccion_standard.TabIndex = 0;
            this.seleccion_standard.TabStop = true;
            this.seleccion_standard.Text = "Standard";
            this.seleccion_standard.UseVisualStyleBackColor = true;
            this.seleccion_standard.CheckedChanged += new System.EventHandler(this.seleccion_standard_CheckedChanged);
            // 
            // grupo_cantidad
            // 
            this.grupo_cantidad.Controls.Add(this.texto_max_min);
            this.grupo_cantidad.Controls.Add(this.barra_cantidad);
            this.grupo_cantidad.Controls.Add(this.salida_cantidad);
            this.grupo_cantidad.Location = new System.Drawing.Point(15, 329);
            this.grupo_cantidad.Name = "grupo_cantidad";
            this.grupo_cantidad.Size = new System.Drawing.Size(306, 104);
            this.grupo_cantidad.TabIndex = 4;
            this.grupo_cantidad.TabStop = false;
            this.grupo_cantidad.Text = "CANTIDAD";
            // 
            // texto_max_min
            // 
            this.texto_max_min.AutoSize = true;
            this.texto_max_min.Location = new System.Drawing.Point(77, 73);
            this.texto_max_min.Name = "texto_max_min";
            this.texto_max_min.Size = new System.Drawing.Size(89, 13);
            this.texto_max_min.TabIndex = 6;
            this.texto_max_min.Text = "(Min: 1 ; Max: 25)";
            // 
            // barra_cantidad
            // 
            this.barra_cantidad.Location = new System.Drawing.Point(6, 19);
            this.barra_cantidad.Maximum = 25;
            this.barra_cantidad.Minimum = 1;
            this.barra_cantidad.Name = "barra_cantidad";
            this.barra_cantidad.Size = new System.Drawing.Size(294, 45);
            this.barra_cantidad.TabIndex = 5;
            this.barra_cantidad.Value = 1;
            this.barra_cantidad.Scroll += new System.EventHandler(this.barra_cantidad_Scroll);
            // 
            // salida_cantidad
            // 
            this.salida_cantidad.Location = new System.Drawing.Point(12, 70);
            this.salida_cantidad.Name = "salida_cantidad";
            this.salida_cantidad.Size = new System.Drawing.Size(59, 20);
            this.salida_cantidad.TabIndex = 4;
            // 
            // grupo_precio
            // 
            this.grupo_precio.Controls.Add(this.entrada_precio);
            this.grupo_precio.Controls.Add(this.seleccion_dolares);
            this.grupo_precio.Controls.Add(this.seleccion_pesos);
            this.grupo_precio.Location = new System.Drawing.Point(15, 450);
            this.grupo_precio.Name = "grupo_precio";
            this.grupo_precio.Size = new System.Drawing.Size(306, 123);
            this.grupo_precio.TabIndex = 5;
            this.grupo_precio.TabStop = false;
            this.grupo_precio.Text = "PRECIO";
            // 
            // entrada_precio
            // 
            this.entrada_precio.Location = new System.Drawing.Point(12, 85);
            this.entrada_precio.Name = "entrada_precio";
            this.entrada_precio.Size = new System.Drawing.Size(176, 20);
            this.entrada_precio.TabIndex = 2;
            this.entrada_precio.TextChanged += new System.EventHandler(this.entrada_precio_TextChanged);
            // 
            // seleccion_dolares
            // 
            this.seleccion_dolares.AutoSize = true;
            this.seleccion_dolares.Location = new System.Drawing.Point(12, 52);
            this.seleccion_dolares.Name = "seleccion_dolares";
            this.seleccion_dolares.Size = new System.Drawing.Size(50, 17);
            this.seleccion_dolares.TabIndex = 1;
            this.seleccion_dolares.TabStop = true;
            this.seleccion_dolares.Text = "Dolar";
            this.seleccion_dolares.UseVisualStyleBackColor = true;
            this.seleccion_dolares.CheckedChanged += new System.EventHandler(this.seleccion_dolares_CheckedChanged);
            // 
            // seleccion_pesos
            // 
            this.seleccion_pesos.AutoSize = true;
            this.seleccion_pesos.Location = new System.Drawing.Point(12, 29);
            this.seleccion_pesos.Name = "seleccion_pesos";
            this.seleccion_pesos.Size = new System.Drawing.Size(54, 17);
            this.seleccion_pesos.TabIndex = 0;
            this.seleccion_pesos.TabStop = true;
            this.seleccion_pesos.Text = "Pesos";
            this.seleccion_pesos.UseVisualStyleBackColor = true;
            this.seleccion_pesos.CheckedChanged += new System.EventHandler(this.seleccion_pesos_CheckedChanged);
            // 
            // boton_calcular
            // 
            this.boton_calcular.Location = new System.Drawing.Point(15, 586);
            this.boton_calcular.Name = "boton_calcular";
            this.boton_calcular.Size = new System.Drawing.Size(306, 46);
            this.boton_calcular.TabIndex = 3;
            this.boton_calcular.Text = "CALCULAR";
            this.boton_calcular.UseVisualStyleBackColor = true;
            this.boton_calcular.Click += new System.EventHandler(this.boton_calcular_Click);
            // 
            // Carrito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 646);
            this.Controls.Add(this.boton_calcular);
            this.Controls.Add(this.grupo_precio);
            this.Controls.Add(this.grupo_cantidad);
            this.Controls.Add(this.grupo_calidad);
            this.Controls.Add(this.grupo_tipo_prenda);
            this.Controls.Add(this.texto_carrito);
            this.Name = "Carrito";
            this.Text = "Carrito";
            this.grupo_tipo_prenda.ResumeLayout(false);
            this.grupo_tipo_prenda.PerformLayout();
            this.grupo_tipo_pantalon.ResumeLayout(false);
            this.grupo_tipo_pantalon.PerformLayout();
            this.grupo_tipo_camisa.ResumeLayout(false);
            this.grupo_tipo_camisa.PerformLayout();
            this.grupo_calidad.ResumeLayout(false);
            this.grupo_calidad.PerformLayout();
            this.grupo_cantidad.ResumeLayout(false);
            this.grupo_cantidad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barra_cantidad)).EndInit();
            this.grupo_precio.ResumeLayout(false);
            this.grupo_precio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label texto_carrito;
        private System.Windows.Forms.GroupBox grupo_tipo_prenda;
        private System.Windows.Forms.RadioButton seleccion_pantalon;
        private System.Windows.Forms.RadioButton seleccion_camisa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grupo_tipo_camisa;
        private System.Windows.Forms.RadioButton seleccion_manga_corta;
        private System.Windows.Forms.RadioButton seleccion_camis_normal;
        private System.Windows.Forms.GroupBox grupo_tipo_pantalon;
        private System.Windows.Forms.RadioButton seleccion_pant_normal;
        private System.Windows.Forms.RadioButton seleccion_bermuda;
        private System.Windows.Forms.GroupBox grupo_calidad;
        private System.Windows.Forms.RadioButton seleccion_premium;
        private System.Windows.Forms.RadioButton seleccion_standard;
        private System.Windows.Forms.GroupBox grupo_cantidad;
        private System.Windows.Forms.TextBox salida_cantidad;
        private System.Windows.Forms.TrackBar barra_cantidad;
        private System.Windows.Forms.Label texto_max_min;
        private System.Windows.Forms.GroupBox grupo_precio;
        private System.Windows.Forms.RadioButton seleccion_dolares;
        private System.Windows.Forms.RadioButton seleccion_pesos;
        private System.Windows.Forms.TextBox entrada_precio;
        private System.Windows.Forms.Button boton_calcular;
    }
}