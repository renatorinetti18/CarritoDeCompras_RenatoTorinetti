using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmueble
{
    class Inmuebles
    {
        private String direccion;
        private int metros_cuadrados, antiguedad, precio;

        //Getters y Setters:
        public String Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public int Antiguedad
        {
            get { return antiguedad; }
            set { antiguedad = value; }
        }

        public int Metros_Cuadrados
        {
            get { return metros_cuadrados; }
            set { metros_cuadrados = value; }
        }

        public int Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        //Constructor:
        public Inmuebles()
        {
        }

        public Inmuebles (string constr_direccion, int constr_antiguedad, int constr_metros_cuadrados, int constr_precio) 
        {
            direccion = constr_direccion;
            antiguedad = constr_antiguedad;
            metros_cuadrados = constr_metros_cuadrados;
            precio = constr_precio;
        }


    }
}
