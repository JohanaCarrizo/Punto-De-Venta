using Entidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class ProductoRepositorio
    {
        public List<Producto> listaProductos = new List<Producto>
    {
        new Producto { codigo = 1, nombre = "Laptop Gamer", descripcion = "Laptop con 16GB RAM y tarjeta gráfica dedicada", precio = 1200.50, existencia = 10 },
        new Producto { codigo = 2, nombre = "Mouse Inalámbrico", descripcion = "Mouse óptico ergonómico con receptor USB", precio = 25.99, existencia = 50 },
        new Producto { codigo = 3, nombre = "Teclado Mecánico", descripcion = "Teclado mecánico RGB switch blue", precio = 75.00, existencia = 25 },
        new Producto { codigo = 4, nombre = "Monitor 24 Pulgadas", descripcion = "Monitor Full HD IPS 75Hz", precio = 180.00, existencia = 15 }
    };

        public int ObtenerUltimoCodigo() 
        {
            if (listaProductos == null || !listaProductos.Any())
            {
                return 1; // Si está vacía, empieza en 1
            }

            // Busca el código máximo actual y le suma 1
            return listaProductos.Max(p => p.codigo) + 1;
        }

        // Cambiado a public para que el Servicio pueda usarlo
        public void GuardarProducto(Producto producto)
        {
            listaProductos.Add(producto);
        }

        // Cambiado a public para que el Servicio pueda usarlo
        public Producto BuscarProducto(int codProducto)
        {
            var productoEncontrado = listaProductos.FirstOrDefault(p => p.codigo == codProducto);
            return productoEncontrado;
        }
    }

}
