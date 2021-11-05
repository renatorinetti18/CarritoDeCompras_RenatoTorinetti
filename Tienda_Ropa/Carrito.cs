using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tienda_Ropa
{
    public partial class Carrito : Form
    {

        Camisa camisa_1 = new Camisa();
        Pantalon pantalon_1 = new Pantalon();
        Manga_corta manga_1 = new Manga_corta();
        Bermuda bermuda_1 = new Bermuda();

        public Carrito()
        {
            InitializeComponent();
        }

        private void seleccion_camisa_CheckedChanged_1(object sender, EventArgs e)
        {
            if (seleccion_camisa.Checked == true)
            {
                grupo_tipo_pantalon.Enabled = false;
            }
            else
                grupo_tipo_pantalon.Enabled = true;
        }

        private void seleccion_pantalon_CheckedChanged(object sender, EventArgs e)
        {
            if (seleccion_pantalon.Checked == true)
            {
                grupo_tipo_camisa.Enabled = false;
            }
            else
                grupo_tipo_camisa.Enabled = true;
        }

        private void seleccion_pant_normal_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void seleccion_camis_normal_CheckedChanged(object sender, EventArgs e)
        {
        }
        private void seleccion_manga_corta_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void seleccion_bermuda_CheckedChanged_1(object sender, EventArgs e)
        {
        }

        private void seleccion_premium_CheckedChanged(object sender, EventArgs e)
        {
            if (seleccion_camisa.Checked == true && seleccion_camis_normal.Checked == true)
            {
                camisa_1.Calidad = "Premium";
            }
            else
               if (seleccion_camisa.Checked == true && seleccion_manga_corta.Checked == true)
               {
                   manga_1.Calidad = "Premium";
               }
                else
                   if (seleccion_pantalon.Checked == true && seleccion_pant_normal.Checked == true)
                   {
                       pantalon_1.Calidad = "Premium";
                   }
                    else
                       if (seleccion_pantalon.Checked == true && seleccion_bermuda.Checked == true)
                       {
                           bermuda_1.Calidad = "Premium";
                       }
        }

        private void seleccion_standard_CheckedChanged(object sender, EventArgs e)
        {
            if (seleccion_camisa.Checked == true && seleccion_camis_normal.Checked == true)
            {
                camisa_1.Calidad = "Standard";
            }
            else
                if (seleccion_camisa.Checked == true && seleccion_manga_corta.Checked == true)
                {
                    manga_1.Calidad = "Standard";
                }
                else
                    if (seleccion_pantalon.Checked == true && seleccion_pant_normal.Checked == true)
                    {
                        pantalon_1.Calidad = "Standard";
                    }
                    else
                        if (seleccion_pantalon.Checked == true && seleccion_bermuda.Checked == true)
                        {
                            bermuda_1.Calidad = "Standard";
                        }
        }

        private void barra_cantidad_Scroll(object sender, EventArgs e)
        {
            
            salida_cantidad.Text = barra_cantidad.Value.ToString();
            
            if (seleccion_camisa.Checked == true && seleccion_camis_normal.Checked == true)
            {
                camisa_1.Cantidad = int.Parse(barra_cantidad.Value.ToString());
            }
            else
                manga_1.Cantidad = int.Parse(barra_cantidad.Value.ToString());
            
            if (seleccion_pantalon.Checked == true && seleccion_pant_normal.Checked == true)
            {
               pantalon_1.Cantidad = int.Parse(barra_cantidad.Value.ToString());
            }
            else
               bermuda_1.Cantidad = int.Parse(barra_cantidad.Value.ToString());
        }

        private void seleccion_dolares_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void seleccion_pesos_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void entrada_precio_TextChanged(object sender, EventArgs e)
        {

            if (seleccion_camisa.Checked == true && seleccion_camis_normal.Checked == true)
            {
                camisa_1.Precio = int.Parse(entrada_precio.Text.ToString());
            }
            else
                manga_1.Precio = int.Parse(entrada_precio.Text.ToString());
            
            if (seleccion_pantalon.Checked == true && seleccion_pant_normal.Checked == true)
            {
               pantalon_1.Precio = int.Parse(entrada_precio.Text.ToString());
            }
            else
               bermuda_1.Precio = int.Parse(entrada_precio.Text.ToString());
        }

        private void boton_calcular_Click(object sender, EventArgs e)
        {
            if (seleccion_camisa.Checked == true && seleccion_camis_normal.Checked == true)
            {
                int aux;
                camisa_1.Precio_Final(camisa_1.Cantidad, camisa_1.Precio, camisa_1.Calidad);
                aux = camisa_1.Precio_Final(camisa_1.Cantidad, camisa_1.Precio, camisa_1.Calidad);
                MessageBox.Show("PRECIO FINAL:  $" + aux.ToString());
            }
            else
                if (seleccion_camisa.Checked == true && seleccion_manga_corta.Checked == true)
                {
                    int aux;
                    manga_1.Precio_Final(manga_1.Cantidad, manga_1.Precio, manga_1.Calidad);
                    aux = manga_1.Precio_Final(manga_1.Cantidad, manga_1.Precio, manga_1.Calidad);
                    MessageBox.Show("PRECIO FINAL:  $" + aux.ToString());
            }
                else
                    if (seleccion_pantalon.Checked == true && seleccion_pant_normal.Checked == true)
                    {
                        int aux;
                        pantalon_1.Precio_Final(pantalon_1.Cantidad, pantalon_1.Precio, pantalon_1.Calidad);
                        aux = pantalon_1.Precio_Final(pantalon_1.Cantidad, pantalon_1.Precio, pantalon_1.Calidad);
                        MessageBox.Show("PRECIO FINAL:  $" + aux.ToString());
            }
                    else
                    if (seleccion_pantalon.Checked == true && seleccion_bermuda.Checked == true)
                    {
                        int aux;
                        bermuda_1.Precio_Final(bermuda_1.Cantidad, bermuda_1.Precio, bermuda_1.Calidad);
                        aux = bermuda_1.Precio_Final(bermuda_1.Cantidad, bermuda_1.Precio, bermuda_1.Calidad);
                        MessageBox.Show("PRECIO FINAL:  $" + aux.ToString());
                    }
        }
    }
}
