using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volador
{
    class TorreControl
    {

        List<Volador> lista_voladores = new List<Volador>();

        public void vuelen_todos()
        {
            for (int i = 0; i < lista_voladores.Count(); i++)
            {
                if (i == 1)
                {
                    Pato pato_x = new Pato();
                    pato_x.volador();
                }
                else
                    if (i == 2)
                    {
                        Boing747 boing747_x = new Boing747();
                        boing747_x.volador();
                    }
                    else
                    {
                        Superman superman_x = new Superman();
                        superman_x.volador();
                    }

            }
        }

        public void agregar_volador (Volador X)
        {
            lista_voladores.Add(X);
        }

    }
}
