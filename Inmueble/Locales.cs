using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmueble
{
    class Locales : Inmuebles
    {
        private int cant_ventanas;

        //Getters y Setters:
        public int Ventanas
        {
            get { return cant_ventanas; }
            set { cant_ventanas = value; }
        }

        //Constructor:
        public Locales()
        {
        }

        public Locales(string constr_direccion, int constr_antiguedad, int constr_metros_cuadrados, int constr_cant_ventanas, int constr_precio) : base(constr_direccion, constr_antiguedad, constr_metros_cuadrados, constr_precio)
        {
            cant_ventanas = constr_cant_ventanas;
        }

    }
}
