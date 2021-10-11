using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volador
{
    class Superman : SuperHeroe, Volador
    {
        public override void Super_Heroe()
        {
            Console.WriteLine("Soy un super heroe!!!");
        }

        public void volador()
        {
            Console.WriteLine("Estoy volando como un campeón...");
        }




    }
}
