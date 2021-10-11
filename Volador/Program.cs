using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volador
{
    class Program
    {
        static void Main(string[] args)
        {

            Pato pato = new Pato();
            Boing747 boing747 = new Boing747();
            Superman superman = new Superman();
            TorreControl torre_control = new TorreControl();

            torre_control.agregar_volador(pato);
            torre_control.agregar_volador(boing747);
            torre_control.agregar_volador(superman);

            torre_control.vuelen_todos();

            Console.WriteLine("");

            pato.Animales();
            boing747.Avion();
            superman.Super_Heroe();

            Console.ReadKey();
        }
    }
}
