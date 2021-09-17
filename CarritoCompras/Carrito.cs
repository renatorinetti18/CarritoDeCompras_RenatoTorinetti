using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarritoCompras
{
    class Carrito
    {

        private Camisas camisa_1 = new Camisas();

        float descuento = 0, precio_descuento = 0, precio_total = 0;

        //Constructor:
        public Carrito(Camisas X)
        {
            this.camisa_1 = X;
        }

        //Metodo del menu:
        public void Menu()
        {
            Console.WriteLine("TIENDA ONLINE DE CAMISAS");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Ingrese una de las siguientes opciones: ");
            Console.WriteLine("|1|- Añadir camisa/s al carro de compras");
            Console.WriteLine("|2|- Eliminar camisa/s del carro de compras:");
            Console.WriteLine("|3|- Salir");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Carrito:\n");
            Console.WriteLine("Camisas: " + camisa_1.cantidad);
            Console.WriteLine("Precio por unidad: " + camisa_1.precio);
            Console.WriteLine("Descuento: " + descuento * 100 + " %");
            Console.WriteLine("TOTAL sin descuento: " + precio_total);
            Console.WriteLine("TOTAL con descuento: " + precio_descuento + "\n");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Opcion: ");
        }

        //Metodo agregar:
        public void agregar_camisa()
        {
            camisa_1.cantidad++;
            precio_total = camisa_1.precio * camisa_1.cantidad;
        }

        //Metodo eliminar:
        public void eliminar_camisa()
        {
            //Comprueba si existen camisas o no:
            if (camisa_1.cantidad > 0)
            {
                camisa_1.cantidad--;
                precio_total -= camisa_1.precio;
            }
            else
                Console.WriteLine("No existen camisas en el carrito");

            //Si el total de descuento es mayor a 0, resta el valor por unidad y devuelve el descuento por unidad:
            if (precio_descuento > 0)
            {
                precio_descuento -= camisa_1.precio;
                precio_descuento = precio_descuento + 100;
            }


        }

        //Metodo de descuentos:
        public void Descuentos()
        {
            if (camisa_1.cantidad >= 3 && camisa_1.cantidad <= 5)
            {
                precio_total = camisa_1.precio * camisa_1.cantidad;
                descuento = 0.10f;
                precio_descuento = precio_total * descuento;
                precio_descuento = precio_total - precio_descuento;
            }
            else
                //Descuento del 20%:
                if (camisa_1.cantidad > 5)
                {
                    precio_total = camisa_1.precio * camisa_1.cantidad;
                    descuento = 0.20f;
                    precio_descuento = precio_total * descuento;
                    precio_descuento = precio_total - precio_descuento;
                }
        }


    }
}
