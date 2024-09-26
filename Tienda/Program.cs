using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carrito carrito = new Carrito();
            bool seguirAgregando = true;

            while (seguirAgregando)
            {
                string nombre = "";
                int cantidad = 0;
                decimal precio = 0;

                Console.WriteLine("Ingresa nombre del producto");
                nombre = Console.ReadLine();
                Console.WriteLine("Ingresa cantidad");
                cantidad = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingresa precio");
                precio = Convert.ToDecimal(Console.ReadLine());

                // Crear instancia del producto y agregarlo al carrito
                Producto prod = new Producto
                {
                    Nombre = nombre,
                    Cantidad = cantidad,
                    Precio = precio
                };
                carrito.AgregarProducto(prod);

                // Preguntar si el usuario quiere agregar otro producto
                Console.WriteLine("¿Quieres agregar otro producto? (s/n)");
                string respuesta = Console.ReadLine().ToLower();
                if (respuesta != "s")
                {
                    seguirAgregando = false;
                }
            }

            Caja caja = new Caja();
            caja.Cobrar(carrito);

            // Mostrar productos del carrito
            carrito.MostrarCarrito();
            Console.ReadLine();
        }
    }
}
