using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imprimible
{
    class Program
    {
        static void Main(string[] args)
        {

            Contrato contrato_x = new Contrato();
            Foto foto_x = new Foto();
            Documento documento_x = new Documento();
            Impresora impresora_x = new Impresora();

            impresora_x.agregar_cola(contrato_x);
            impresora_x.agregar_cola(foto_x);
            impresora_x.agregar_cola(documento_x);

            impresora_x.imprime_todos();

            Console.ReadKey();

        }
    }
}
