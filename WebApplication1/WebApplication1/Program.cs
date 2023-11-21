/*var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();*/
using System;
using System.Linq;
using System.Collections.Generic;
namespace test {
    class Producto
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public int Precio { get; set; }
    }
    class Program
    {
        static void Main()
        {
            // Crear una lista de productos
            List<Producto> productos = new List<Producto>
        {
            new Producto { ID = 1, Nombre = "Laptop", Precio = 1000 },
            new Producto { ID = 2, Nombre = "Teléfono", Precio = 500 },
            new Producto { ID = 3, Nombre = "Tablet", Precio = 300 },
            new Producto { ID = 4, Nombre = "Mouse", Precio = 20 },
            new Producto { ID = 5, Nombre = "Teclado", Precio = 30 }
        };

            // Consulta 1: Filtrar productos con precio superior a $200
            var productosCaros = from producto in productos
                                 where producto.Precio > 200.0
                                 select producto;

            Console.WriteLine("Productos caros:");
            foreach (var producto in productosCaros)
            {
                Console.WriteLine($"{producto.Nombre}- ${producto.Precio}");
            }

            // Consulta 2: Ordenar productos por nombre
            var productosOrdenadosPorNombre = from producto in productos
                                              orderby producto.Nombre
                                              select producto;

            Console.WriteLine("\nProductos ordenados por nombre:");
            foreach (var producto in productosOrdenadosPorNombre)
            {
                Console.WriteLine($"{producto.Nombre} - ${producto.Precio}");
            }

            // Consulta 3: Calcular el precio total de todos los productos
            int precioTotal = productos.Count();
            Console.WriteLine($"\nPrecio total de todos los productos: ${precioTotal}");
        }
    }
}
