using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarritoCompras
{
    class Program
    {
        static void Main(string[] args)
        {
            //Objetos de cada clase:
            Camisas camisa_1 = new Camisas();
            Carrito carrito_1 = new Carrito(camisa_1);

            //Variables:
            int opcion_carrito;
            char opcion_salir;

            //Ciclo que repite hasta que el usurio desee salir del carrito:
            do
            {
                //Muestra el menu:
                carrito_1.Menu();

                //Ingresa una opcion:
                opcion_carrito = int.Parse(Console.ReadLine());

                switch (opcion_carrito)
                {
                    //Agregar camisas:
                    case 1:
                        carrito_1.agregar_camisa();
                    break;

                    //Eliminar camisas:
                    case 2:
                        carrito_1.eliminar_camisa();
                    break;

                    //Salir del carrito:
                    case 3:
                        Console.Clear();
                        Console.WriteLine("¿Esta seguro que desea salir?");
                        Console.WriteLine("|s|- Si");
                        Console.WriteLine("|n|- No");
                        opcion_salir = Console.ReadKey(true).KeyChar;

                        //Comprueba si el usuario ingreso una S, en tal caso el programa termina, y sino sigue
                        if (opcion_salir == 's')
                        {
                            Environment.Exit(0);
                        }
                    break;
                }

                //Verifico si existen descuentos:
                carrito_1.Descuentos();

            } while (opcion_carrito <= 3);


            Console.ReadKey();
        }
    }
}
