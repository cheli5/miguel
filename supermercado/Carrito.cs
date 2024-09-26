using supermercado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace supermercado
{
    class Carrito
    {
        private List<Articulo> articulosEnCarrito = new List<Articulo>();

        public void AgregarArticulo(Articulo articulo)
        {
            articulosEnCarrito.Add(articulo);
        }

        public void MostrarArticulosEnCarrito()
        {
            if (articulosEnCarrito.Count == 0)
            {
                Console.WriteLine("El carrito está vacío.");
            }
            else
            {
                foreach (var articulo in articulosEnCarrito)
                {
                    Console.WriteLine($"ID: {articulo.ID}, Nombre: {articulo.Nombre}, Precio: {articulo.Precio}");
                }
            }
        }
    }
}
