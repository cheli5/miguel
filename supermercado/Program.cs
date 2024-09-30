using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace supermercado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carrito carrito = new Carrito();

            while (true)
            {
                Console.WriteLine("Selecciona el articulo ('6' para terminar):");
                Catalogo.MostrarCatalogo();

                int artID = Convert.ToInt32(Console.ReadLine());

                if (artID == 6)
                {
                    break;
                }

                Articulo articuloSeleccionado = Catalogo.BuscarArticuloPorID(artID);

                if (articuloSeleccionado != null)
                {
                    carrito.AgregarArticulo(articuloSeleccionado);
                    Console.WriteLine($"Articulo '{articuloSeleccionado.Nombre}' agregado al carrito.");
                }
                
                

                
            }
        }
    }
}
