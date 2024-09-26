using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace supermercado
{
    internal class Catalogo
    {
        private static List<Articulo> Inventario { get; set; }
        private static void LlenarCatalogo()
        {
            Inventario = new List<Articulo>
            {
                new Articulo {Nombre = "Jabon", Precio=18.9f ,ID=1},
                 new Articulo {Nombre="Mayonesa", Precio=45.13f , ID=2 },
                 new Articulo {Nombre="Tomate", Precio=49.00f, ID=3 },
                 new Articulo {Nombre="Carne", Precio=98f, ID=4 },
                 new Articulo {Nombre="Huevos",Precio=65f, ID=5 },
            };
        }

        public static void MostrarCatalogo() 
        {
            LlenarCatalogo();
            foreach (Articulo art in Inventario)
            {
                Console.Write($"{art.ID} - {art.Nombre} - {art.Precio}\n");
            }
        }
          
        public static Articulo BuscarArticuloPorID(int artID)
        {
            return Inventario.Find(articulo => articulo.ID.Equals(artID));

        }

        
    }
}
