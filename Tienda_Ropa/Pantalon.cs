using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda_Ropa
{
    class Pantalon
    {
        private int precio, cantidad;
        private string calidad;

        int precio_final, aux;

        public int Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        public string Calidad
        {
            get { return calidad; }
            set { calidad = value; }
        }

        public Pantalon()
        {
        }

        public Pantalon (int constr_precio, int constr_cantidad, string constr_calidad)
        {
            precio = constr_precio;
            cantidad = constr_cantidad;
            calidad = constr_calidad;
        }

        public int Precio_Final(int cantidad_x, int precio_x, string calidad_x)
        {
            precio_final = cantidad_x * precio_x;
            if (calidad_x == "Premium")
            {
                aux = (precio_final / 100) * 30;
                precio_final = precio_final + aux;
            }

            return precio_final;
        }

    }
}
