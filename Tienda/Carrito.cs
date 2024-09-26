using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tienda;

namespace Tienda
{
    class Carrito
    {
        // Lista de productos en el carrito
        public List<Producto> Productos { get; private set; }

        // Constructor que inicializa la lista de productos
        public Carrito()
        {
            Productos = new List<Producto>();
        }

        // Método para agregar un producto al carrito
        public void AgregarProducto(Producto producto)
        {
            Productos.Add(producto);
        }

        // Método para mostrar los productos del carrito
        public void MostrarCarrito()
        {
            foreach (var producto in Productos)
            {
                Console.WriteLine($"Producto: {producto.Nombre}, Cantidad: {producto.Cantidad}, Precio: {producto.Precio:C}");
            }
        }
    }
}
