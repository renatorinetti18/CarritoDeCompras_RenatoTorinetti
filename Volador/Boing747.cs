using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volador
{
    class Boing747 : Aviones, Volador
    {
        public override void Avion()
        {
            Console.WriteLine("Soy un avión!!!");
        }

        public void volador()
        {
            Console.WriteLine("Estoy volando como un avión...");
        }
    }
}
