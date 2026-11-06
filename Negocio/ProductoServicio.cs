using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ProductoServicio
    {
        public static Producto producto = new Producto();
        public static ProductoRepositorio repositorio = new ProductoRepositorio();
        
        public bool GuardarProducto(string nombre, string descripcion, double precio, int existencia) 
        {
            int ultimoCodigo = repositorio.ObtenerUltimoCodigo();

            Producto nuevoProducto = new Producto
            {
                codigo = ultimoCodigo,
                nombre = nombre,
                descripcion = descripcion,
                precio = precio,
                existencia = existencia
            };

            repositorio.GuardarProducto(nuevoProducto);
            return true;
        }

        public List<Producto> listarProductos() 
        {
            return repositorio.listaProductos;
        }
    }
}
