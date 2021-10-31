using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inmueble
{
    public partial class Inmobiliaria : Form
    {
        Inmuebles inmueble_1 = new Inmuebles();
        Pisos piso_1 = new Pisos();
        Locales local_1 = new Locales();
        int aux, total;

        public Inmobiliaria()
        {
            InitializeComponent();
        }

        //ENTRADAS DE DATOS:
        private void entrada_piso_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(entrada_piso.Text, "  ^ [0-9]"))
            {
                entrada_piso.Text = "";
            }
            
            piso_1.Piso = int.Parse(entrada_piso.Text);
        }

        private void entrada_ventanas_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(entrada_ventanas.Text, "  ^ [0-9]"))
            {
                entrada_ventanas.Text = "";
            }

            local_1.Ventanas = int.Parse(entrada_ventanas.Text);
        }

        //SELECCION DE TIPO DE INMUEBLE:
        private void seleccion_piso_CheckedChanged(object sender, EventArgs e)
        {
            if (seleccion_piso.Checked == true)
            {
                entrada_piso.Enabled = true;
                entrada_ventanas.Text = "";
                entrada_ventanas.Enabled = false;
            }
            else
            {
                entrada_piso.Text = "";
                entrada_piso.Enabled = false;
                entrada_ventanas.Enabled = true;
            }

        }

        //ENTRADAS DE DATOS:
        private void entrada_direccion_TextChanged(object sender, EventArgs e)
        {
            inmueble_1.Direccion = entrada_direccion.Text;
        }

        private void entrada_antiguedad_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(entrada_antiguedad.Text, "  ^ [0-9]"))
            {
                entrada_antiguedad.Text = "";
            }

            inmueble_1.Antiguedad = int.Parse(entrada_antiguedad.Text);
        }

        private void entrada_superficie_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(entrada_superficie.Text, "  ^ [0-9]"))
            {
                entrada_superficie.Text = "";
            }

            inmueble_1.Metros_Cuadrados = int.Parse(entrada_superficie.Text);
        }

        private void entrada_precio_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(entrada_precio.Text, "  ^ [0-9]"))
            {
                entrada_precio.Text = "";
            }

            inmueble_1.Precio = int.Parse(entrada_precio.Text);
        }

        //BOTON CALCULAR:
        private void btn_prueba_Click(object sender, EventArgs e)
        {
            if (seleccion_piso.Checked == true)
            {
                if (inmueble_1.Antiguedad <= 15 && piso_1.Piso < 3)
                {
                    aux = int.Parse(entrada_precio.Text) / 100;
                    inmueble_1.Precio = int.Parse(entrada_precio.Text) - aux;
                    salida_final.Text = inmueble_1.Precio.ToString();
                }
                else
                    if (inmueble_1.Antiguedad <= 15 && piso_1.Piso >= 3)
                    {
                        aux = (int.Parse(entrada_precio.Text) / 100) * 2;
                        inmueble_1.Precio = int.Parse(entrada_precio.Text) + aux;
                        salida_final.Text = inmueble_1.Precio.ToString();
                    }
                    else
                        if (inmueble_1.Antiguedad > 15 && piso_1.Piso <= 3)
                        {
                            aux = (int.Parse(entrada_precio.Text) / 100) * 2;
                            inmueble_1.Precio = int.Parse(entrada_precio.Text) - aux;
                            salida_final.Text = inmueble_1.Precio.ToString();
                        }
                        else
                        {
                            aux = int.Parse(entrada_precio.Text) / 100;
                            inmueble_1.Precio = int.Parse(entrada_precio.Text) + aux;
                            salida_final.Text = inmueble_1.Precio.ToString();
                        }
            }
            //ANTIGUEDAD - LOCAL:
            else
            {
                if (inmueble_1.Antiguedad <= 15 && local_1.Metros_Cuadrados < 50 && local_1.Ventanas < 1)
                {
                    aux = (int.Parse(entrada_precio.Text) / 100) * 3;
                    inmueble_1.Precio = int.Parse(entrada_precio.Text) - aux;
                    salida_final.Text = inmueble_1.Precio.ToString();
                }
                else
                    if (inmueble_1.Antiguedad <= 15 && local_1.Metros_Cuadrados < 50 && local_1.Ventanas > 4)
                    {
                        aux = int.Parse(entrada_precio.Text) / 100;
                        inmueble_1.Precio = int.Parse(entrada_precio.Text) + aux;
                        salida_final.Text = inmueble_1.Precio.ToString();
                    }
                    else
                        if (inmueble_1.Antiguedad <= 15 && local_1.Metros_Cuadrados > 50 && local_1.Ventanas > 4)
                        {
                            aux = (int.Parse(entrada_precio.Text) / 100) * 2;
                            inmueble_1.Precio = int.Parse(entrada_precio.Text) + aux;
                            salida_final.Text = inmueble_1.Precio.ToString();
                        }
                        else
                            if (inmueble_1.Antiguedad > 15 && local_1.Metros_Cuadrados < 50 && local_1.Ventanas < 1)
                            {
                                aux = (int.Parse(entrada_precio.Text) / 100) * 4;
                                inmueble_1.Precio = int.Parse(entrada_precio.Text) - aux;
                                salida_final.Text = inmueble_1.Precio.ToString();
                            }
                            else
                                if (inmueble_1.Antiguedad > 15 && local_1.Metros_Cuadrados > 50 && local_1.Ventanas < 1)
                                {
                                    aux = int.Parse(entrada_precio.Text) / 100;
                                    inmueble_1.Precio = int.Parse(entrada_precio.Text) + aux; ;
                                    salida_final.Text = inmueble_1.Precio.ToString();
                                }
            }
        }

        //LABLES Y TEXTOS: (sin uso)
        private void texto_signo_moneda_Click(object sender, EventArgs e)
        {
        }

        private void nro_piso_Click(object sender, EventArgs e)
        {
        }

        private void seleccion_dolares_CheckedChanged(object sender, EventArgs e)
        {
        }

    }
}
