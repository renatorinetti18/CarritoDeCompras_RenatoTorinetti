using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imprimible
{
    class Impresora
    {

        List<Imprimible> cola_impresion = new List<Imprimible>();

        public void imprime_todos()
        {
            Console.WriteLine("Cola de impresion: ");
            for (int i = 0; i < cola_impresion.Count(); i++)
            {
                if (i == 1)
                {
                    Contrato x = new Contrato();
                    x.Imprimible();
                }
                else
                    if (i == 2)
                    {
                    Foto x = new Foto();
                    x.Imprimible();
                    }
                    else
                        {
                            Documento x = new Documento();
                            x.Imprimible();
                        }
            }
        }

        public void agregar_cola(Imprimible X)
        {
            cola_impresion.Add(X);
        }

    }
}
