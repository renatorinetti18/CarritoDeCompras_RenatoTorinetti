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

            int opcion_carrito, cant_camisas = 0, contador = 1;
            float aux = 0,descuento = 0, precio_descuento = 0, precio_unitario = 1000, precio_total = 0;
            char opcion_salir;

            //MENSAJE INICIAL:
            Console.WriteLine("TIENDA ONLINE DE CAMISAS");
            Console.WriteLine("----------------------------------------");

            do
            {
                //MENU:
                Console.WriteLine("Ingrese una de las siguientes opciones: ");
                Console.WriteLine("|1|- Añadir camisa/s al carro de compras");
                Console.WriteLine("|2|- Eliminar camisa/s del carro de compras:");
                Console.WriteLine("|3|- Salir");
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("Carrito:\n");
                Console.WriteLine("Camisas: " + cant_camisas);
                Console.WriteLine("Precio por unidad: " + precio_unitario);
                Console.WriteLine("Descuento: " + descuento * 100 + " %");
                Console.WriteLine("TOTAL sin descuento: " + precio_total);
                Console.WriteLine("TOTAL con descuento: " + precio_descuento + "\n");
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("Opcion: ");
                opcion_carrito = int.Parse(Console.ReadLine());

                switch (opcion_carrito)
                {
                    //AGREGAR CAMISAS:
                    case 1:
                        cant_camisas++;
                        precio_total = precio_unitario * contador;
                        contador++;
                    break;

                    //ELIMINAR CAMISAS:
                    case 2:

                        //Comprueba si existen camisas o no:
                        if (cant_camisas <= 0)
                        {
                            Console.WriteLine("No existen camisas en el carrito de compras");
                        }
                        else
                            cant_camisas--;
                            precio_total -= precio_unitario;

                        //Si el total de descuento es mayor a 0, resta el valor por unidad y devuelve del descuento por unidad
                        if (precio_descuento > 0)
                        {
                            precio_descuento -= precio_unitario;
                            precio_descuento = precio_descuento + 100;
                        }
                            
                    break;

                    //SALIR:
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

                //Descuento 10%:
                if (cant_camisas >= 3 && cant_camisas <=5)
                {
                    precio_total = precio_unitario * cant_camisas;
                    descuento = 0.10f;
                    precio_descuento = precio_total * descuento;
                    precio_descuento = precio_total - precio_descuento;
                }
                else
                    
                    //Descuento del 20%:
                    if (cant_camisas > 5)
                    {
                    precio_total = precio_unitario * cant_camisas;
                    descuento = 0.20f;
                    precio_descuento = precio_total * descuento;
                    precio_descuento = precio_total - precio_descuento;
                }


            } while (opcion_carrito <= 3);


            Console.ReadKey();
        }
    }
}
