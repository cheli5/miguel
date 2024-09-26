using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tienda;

namespace Tienda
{
    class Caja
    {
        // Mostrar la lista de productos y el total del carrito
        public void Cobrar(Carrito carrito)
        {
            decimal total = 0;

            Console.WriteLine("Lista de productos en el carrito:");
            foreach (Producto producto in carrito.Productos)
            {
                Console.WriteLine($"Producto: {producto.Nombre}, Cantidad: {producto.Cantidad}, Precio Unitario: {producto.Precio:C}, Subtotal: {producto.Precio * producto.Cantidad:C}");
                total += producto.Precio * producto.Cantidad;
            }

            Console.WriteLine($"\nTotal del carrito: {total:C}");

            // Iniciar el proceso de pago y cálculo de cambio
            Pagar(total);
        }

        // Método para procesar el pago y calcular el cambio
        public void Pagar(decimal total)
        {
            decimal montoPagado = 0;
            bool pagoCompleto = false;

            while (!pagoCompleto)
            {
                Console.WriteLine($"\nPor favor ingresa el monto con el que vas a pagar (total a pagar: {total:C}): ");
                montoPagado = Convert.ToDecimal(Console.ReadLine());

                if (montoPagado >= total)
                {
                    decimal cambio = montoPagado - total;
                    Console.WriteLine($"\nPago recibido: {montoPagado:C}");
                    Console.WriteLine($"Cambio: {cambio:C}");
                    Console.WriteLine("¡Gracias por tu compra en tiendas el millon!");
                    pagoCompleto = true;
                }
                else
                {
                    Console.WriteLine($"El monto ingresado es insuficiente. Debes pagar al menos {total:C}.");
                }
            }
        }
    }
}