using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmueble
{
    class Pisos : Inmuebles
    {
        private int piso;

        //Getter y Setter:
        public int Piso
        {
            get { return piso; }
            set { piso = value; }
        }

        //Constructor:
        public Pisos()
        {
        }

        public Pisos (string constr_direccion, int constr_antiguedad, int constr_metros_cuadrados, int constr_piso, int constr_precio) : base(constr_direccion, constr_antiguedad, constr_metros_cuadrados, constr_precio)
        {
            piso = constr_piso;
        }

    }
}
