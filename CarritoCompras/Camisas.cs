using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarritoCompras
{
    class Camisas
    {
        private int precio_unitario = 1000, cant_camisas;

        //Metodos getter y setters de ambas variables:
        public int precio 
        {
            get {return precio_unitario;} 
        }

        public int cantidad
        {
            get { return cant_camisas; }
            set { cant_camisas = value; }
        }

    }
}
