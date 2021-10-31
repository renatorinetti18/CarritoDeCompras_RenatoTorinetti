
namespace Inmueble
{
    partial class Inmobiliaria
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
            this.grupo_inmueble = new System.Windows.Forms.GroupBox();
            this.seleccion_local = new System.Windows.Forms.RadioButton();
            this.seleccion_piso = new System.Windows.Forms.RadioButton();
            this.entrada_ventanas = new System.Windows.Forms.TextBox();
            this.num_ventanas = new System.Windows.Forms.Label();
            this.num_piso = new System.Windows.Forms.Label();
            this.entrada_piso = new System.Windows.Forms.TextBox();
            this.grupo_datos = new System.Windows.Forms.GroupBox();
            this.seleccion_dolar = new System.Windows.Forms.RadioButton();
            this.seleccion_pesos = new System.Windows.Forms.RadioButton();
            this.entrada_precio = new System.Windows.Forms.TextBox();
            this.texto_precio = new System.Windows.Forms.Label();
            this.texto_metros = new System.Windows.Forms.Label();
            this.entrada_superficie = new System.Windows.Forms.TextBox();
            this.texto_superficie = new System.Windows.Forms.Label();
            this.texto_años = new System.Windows.Forms.Label();
            this.entrada_antiguedad = new System.Windows.Forms.TextBox();
            this.texto_antiguedad = new System.Windows.Forms.Label();
            this.entrada_direccion = new System.Windows.Forms.TextBox();
            this.texto_direccion = new System.Windows.Forms.Label();
            this.grupo_precio_final = new System.Windows.Forms.GroupBox();
            this.salida_final = new System.Windows.Forms.TextBox();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.texto_moneda = new System.Windows.Forms.Label();
            this.grupo_inmueble.SuspendLayout();
            this.grupo_datos.SuspendLayout();
            this.grupo_precio_final.SuspendLayout();
            this.SuspendLayout();
            // 
            // grupo_inmueble
            // 
            this.grupo_inmueble.Controls.Add(this.seleccion_local);
            this.grupo_inmueble.Controls.Add(this.seleccion_piso);
            this.grupo_inmueble.Controls.Add(this.entrada_ventanas);
            this.grupo_inmueble.Controls.Add(this.num_ventanas);
            this.grupo_inmueble.Controls.Add(this.num_piso);
            this.grupo_inmueble.Controls.Add(this.entrada_piso);
            this.grupo_inmueble.Location = new System.Drawing.Point(12, 12);
            this.grupo_inmueble.Name = "grupo_inmueble";
            this.grupo_inmueble.Size = new System.Drawing.Size(263, 112);
            this.grupo_inmueble.TabIndex = 0;
            this.grupo_inmueble.TabStop = false;
            this.grupo_inmueble.Text = "INMUEBLE:";
            // 
            // seleccion_local
            // 
            this.seleccion_local.AutoSize = true;
            this.seleccion_local.Location = new System.Drawing.Point(11, 63);
            this.seleccion_local.Name = "seleccion_local";
            this.seleccion_local.Size = new System.Drawing.Size(51, 17);
            this.seleccion_local.TabIndex = 6;
            this.seleccion_local.TabStop = true;
            this.seleccion_local.Text = "Local";
            this.seleccion_local.UseVisualStyleBackColor = true;
            // 
            // seleccion_piso
            // 
            this.seleccion_piso.AutoSize = true;
            this.seleccion_piso.Location = new System.Drawing.Point(11, 29);
            this.seleccion_piso.Name = "seleccion_piso";
            this.seleccion_piso.Size = new System.Drawing.Size(45, 17);
            this.seleccion_piso.TabIndex = 4;
            this.seleccion_piso.TabStop = true;
            this.seleccion_piso.Text = "Piso";
            this.seleccion_piso.UseVisualStyleBackColor = true;
            this.seleccion_piso.CheckedChanged += new System.EventHandler(this.seleccion_piso_CheckedChanged);
            // 
            // entrada_ventanas
            // 
            this.entrada_ventanas.Location = new System.Drawing.Point(198, 58);
            this.entrada_ventanas.Name = "entrada_ventanas";
            this.entrada_ventanas.Size = new System.Drawing.Size(49, 20);
            this.entrada_ventanas.TabIndex = 5;
            // 
            // num_ventanas
            // 
            this.num_ventanas.AutoSize = true;
            this.num_ventanas.Location = new System.Drawing.Point(117, 65);
            this.num_ventanas.Name = "num_ventanas";
            this.num_ventanas.Size = new System.Drawing.Size(75, 13);
            this.num_ventanas.TabIndex = 4;
            this.num_ventanas.Text = "Nro Ventanas:";
            // 
            // num_piso
            // 
            this.num_piso.AutoSize = true;
            this.num_piso.Location = new System.Drawing.Point(117, 31);
            this.num_piso.Name = "num_piso";
            this.num_piso.Size = new System.Drawing.Size(50, 13);
            this.num_piso.TabIndex = 3;
            this.num_piso.Text = "Nro Piso:";
            this.num_piso.Click += new System.EventHandler(this.nro_piso_Click);
            // 
            // entrada_piso
            // 
            this.entrada_piso.Location = new System.Drawing.Point(198, 28);
            this.entrada_piso.Name = "entrada_piso";
            this.entrada_piso.Size = new System.Drawing.Size(49, 20);
            this.entrada_piso.TabIndex = 2;
            this.entrada_piso.TextChanged += new System.EventHandler(this.entrada_piso_TextChanged);
            // 
            // grupo_datos
            // 
            this.grupo_datos.Controls.Add(this.seleccion_dolar);
            this.grupo_datos.Controls.Add(this.seleccion_pesos);
            this.grupo_datos.Controls.Add(this.entrada_precio);
            this.grupo_datos.Controls.Add(this.texto_precio);
            this.grupo_datos.Controls.Add(this.texto_metros);
            this.grupo_datos.Controls.Add(this.entrada_superficie);
            this.grupo_datos.Controls.Add(this.texto_superficie);
            this.grupo_datos.Controls.Add(this.texto_años);
            this.grupo_datos.Controls.Add(this.entrada_antiguedad);
            this.grupo_datos.Controls.Add(this.texto_antiguedad);
            this.grupo_datos.Controls.Add(this.entrada_direccion);
            this.grupo_datos.Controls.Add(this.texto_direccion);
            this.grupo_datos.Location = new System.Drawing.Point(13, 131);
            this.grupo_datos.Name = "grupo_datos";
            this.grupo_datos.Size = new System.Drawing.Size(262, 265);
            this.grupo_datos.TabIndex = 1;
            this.grupo_datos.TabStop = false;
            this.grupo_datos.Text = "DATOS";
            // 
            // seleccion_dolar
            // 
            this.seleccion_dolar.AutoSize = true;
            this.seleccion_dolar.Location = new System.Drawing.Point(10, 227);
            this.seleccion_dolar.Name = "seleccion_dolar";
            this.seleccion_dolar.Size = new System.Drawing.Size(50, 17);
            this.seleccion_dolar.TabIndex = 11;
            this.seleccion_dolar.TabStop = true;
            this.seleccion_dolar.Text = "Dolar";
            this.seleccion_dolar.UseVisualStyleBackColor = true;
            // 
            // seleccion_pesos
            // 
            this.seleccion_pesos.AutoSize = true;
            this.seleccion_pesos.Location = new System.Drawing.Point(10, 204);
            this.seleccion_pesos.Name = "seleccion_pesos";
            this.seleccion_pesos.Size = new System.Drawing.Size(49, 17);
            this.seleccion_pesos.TabIndex = 10;
            this.seleccion_pesos.TabStop = true;
            this.seleccion_pesos.Text = "Peso";
            this.seleccion_pesos.UseVisualStyleBackColor = true;
            // 
            // entrada_precio
            // 
            this.entrada_precio.Location = new System.Drawing.Point(94, 212);
            this.entrada_precio.Name = "entrada_precio";
            this.entrada_precio.Size = new System.Drawing.Size(162, 20);
            this.entrada_precio.TabIndex = 9;
            // 
            // texto_precio
            // 
            this.texto_precio.AutoSize = true;
            this.texto_precio.Location = new System.Drawing.Point(10, 177);
            this.texto_precio.Name = "texto_precio";
            this.texto_precio.Size = new System.Drawing.Size(40, 13);
            this.texto_precio.TabIndex = 8;
            this.texto_precio.Text = "Precio:";
            // 
            // texto_metros
            // 
            this.texto_metros.AutoSize = true;
            this.texto_metros.Location = new System.Drawing.Point(103, 141);
            this.texto_metros.Name = "texto_metros";
            this.texto_metros.Size = new System.Drawing.Size(27, 13);
            this.texto_metros.TabIndex = 7;
            this.texto_metros.Text = "(m2)";
            // 
            // entrada_superficie
            // 
            this.entrada_superficie.Location = new System.Drawing.Point(10, 141);
            this.entrada_superficie.Name = "entrada_superficie";
            this.entrada_superficie.Size = new System.Drawing.Size(86, 20);
            this.entrada_superficie.TabIndex = 6;
            // 
            // texto_superficie
            // 
            this.texto_superficie.AutoSize = true;
            this.texto_superficie.Location = new System.Drawing.Point(7, 125);
            this.texto_superficie.Name = "texto_superficie";
            this.texto_superficie.Size = new System.Drawing.Size(57, 13);
            this.texto_superficie.TabIndex = 5;
            this.texto_superficie.Text = "Superficie:";
            // 
            // texto_años
            // 
            this.texto_años.AutoSize = true;
            this.texto_años.Location = new System.Drawing.Point(102, 90);
            this.texto_años.Name = "texto_años";
            this.texto_años.Size = new System.Drawing.Size(36, 13);
            this.texto_años.TabIndex = 4;
            this.texto_años.Text = "(años)";
            // 
            // entrada_antiguedad
            // 
            this.entrada_antiguedad.Location = new System.Drawing.Point(10, 87);
            this.entrada_antiguedad.Name = "entrada_antiguedad";
            this.entrada_antiguedad.Size = new System.Drawing.Size(86, 20);
            this.entrada_antiguedad.TabIndex = 3;
            // 
            // texto_antiguedad
            // 
            this.texto_antiguedad.AutoSize = true;
            this.texto_antiguedad.Location = new System.Drawing.Point(7, 70);
            this.texto_antiguedad.Name = "texto_antiguedad";
            this.texto_antiguedad.Size = new System.Drawing.Size(64, 13);
            this.texto_antiguedad.TabIndex = 2;
            this.texto_antiguedad.Text = "Antiguedad:";
            // 
            // entrada_direccion
            // 
            this.entrada_direccion.Location = new System.Drawing.Point(10, 37);
            this.entrada_direccion.Name = "entrada_direccion";
            this.entrada_direccion.Size = new System.Drawing.Size(246, 20);
            this.entrada_direccion.TabIndex = 1;
            // 
            // texto_direccion
            // 
            this.texto_direccion.AutoSize = true;
            this.texto_direccion.Location = new System.Drawing.Point(7, 20);
            this.texto_direccion.Name = "texto_direccion";
            this.texto_direccion.Size = new System.Drawing.Size(55, 13);
            this.texto_direccion.TabIndex = 0;
            this.texto_direccion.Text = "Dirección:";
            // 
            // grupo_precio_final
            // 
            this.grupo_precio_final.Controls.Add(this.texto_moneda);
            this.grupo_precio_final.Controls.Add(this.salida_final);
            this.grupo_precio_final.Location = new System.Drawing.Point(12, 454);
            this.grupo_precio_final.Name = "grupo_precio_final";
            this.grupo_precio_final.Size = new System.Drawing.Size(263, 63);
            this.grupo_precio_final.TabIndex = 4;
            this.grupo_precio_final.TabStop = false;
            this.grupo_precio_final.Text = "PRECIO FINAL:";
            // 
            // salida_final
            // 
            this.salida_final.Location = new System.Drawing.Point(11, 28);
            this.salida_final.Name = "salida_final";
            this.salida_final.Size = new System.Drawing.Size(130, 20);
            this.salida_final.TabIndex = 6;
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(13, 402);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(263, 46);
            this.btn_calcular.TabIndex = 5;
            this.btn_calcular.Text = "CALCULAR";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_prueba_Click);
            // 
            // texto_moneda
            // 
            this.texto_moneda.AutoSize = true;
            this.texto_moneda.Location = new System.Drawing.Point(147, 31);
            this.texto_moneda.Name = "texto_moneda";
            this.texto_moneda.Size = new System.Drawing.Size(13, 13);
            this.texto_moneda.TabIndex = 7;
            this.texto_moneda.Text = "$";
            // 
            // Inmobiliaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 527);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.grupo_precio_final);
            this.Controls.Add(this.grupo_datos);
            this.Controls.Add(this.grupo_inmueble);
            this.Name = "Inmobiliaria";
            this.Text = "Inmobiliaria";
            this.grupo_inmueble.ResumeLayout(false);
            this.grupo_inmueble.PerformLayout();
            this.grupo_datos.ResumeLayout(false);
            this.grupo_datos.PerformLayout();
            this.grupo_precio_final.ResumeLayout(false);
            this.grupo_precio_final.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grupo_inmueble;
        private System.Windows.Forms.Label num_piso;
        private System.Windows.Forms.TextBox entrada_piso;
        private System.Windows.Forms.TextBox entrada_ventanas;
        private System.Windows.Forms.Label num_ventanas;
        private System.Windows.Forms.GroupBox grupo_datos;
        private System.Windows.Forms.TextBox entrada_precio;
        private System.Windows.Forms.Label texto_precio;
        private System.Windows.Forms.Label texto_metros;
        private System.Windows.Forms.TextBox entrada_superficie;
        private System.Windows.Forms.Label texto_superficie;
        private System.Windows.Forms.Label texto_años;
        private System.Windows.Forms.TextBox entrada_antiguedad;
        private System.Windows.Forms.Label texto_antiguedad;
        private System.Windows.Forms.TextBox entrada_direccion;
        private System.Windows.Forms.Label texto_direccion;
        private System.Windows.Forms.RadioButton seleccion_piso;
        private System.Windows.Forms.RadioButton seleccion_local;
        private System.Windows.Forms.RadioButton seleccion_dolar;
        private System.Windows.Forms.RadioButton seleccion_pesos;
        private System.Windows.Forms.GroupBox grupo_precio_final;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.TextBox salida_final;
        private System.Windows.Forms.Label texto_moneda;
    }
}