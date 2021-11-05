using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda_Ropa
{
    class Manga_corta : Camisa
    {
        int precio_final, aux;

        public Manga_corta()
        {
        }
        public Manga_corta (int constr_precio, int constr_cantidad, string constr_calidad) : base(constr_precio, constr_cantidad, constr_calidad)
        {
        }

        public new int Precio_Final(int cantidad_x, int precio_x, string calidad_x)
        {
            precio_final = cantidad_x * precio_x;
            aux = (precio_final / 100) * 10;
            precio_final = precio_final - aux;

            if (calidad_x == "Premium")
            {
                aux = (precio_final / 100) * 30;
                precio_final = precio_final + aux;
            }

            return precio_final;
        }

    }
}
