using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volador
{
    class Pato : Animal, Volador
    {
        public override void Animales()
        {
            Console.WriteLine("Soy un pato!!!");
        }

        public void volador()
        {
            Console.WriteLine("Estoy volando como un pato... !Cuak¡");
        }

    }
}
