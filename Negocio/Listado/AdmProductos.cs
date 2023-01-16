using Entidades.Entidades.Producto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Listado
{
    public static class AdmProductos
    {
        public static List<Producto> productos = new List<Producto>();
        
        public static List<Producto> Listar()
        {
            return productos;
        }

        //Filtrar por categoria
        public static List<Producto> Listar(string categoria)
        {
            return productos.Where(i => i.Categoria == categoria).ToList();
        }

        //Filtrar por categoria y subcategoria
        public static List<Producto> Listar(string categoria, string subCategoria)
        {
            return productos.Where(i => i.Categoria == categoria && i.Subcategoria == subCategoria).ToList();
        }

        public static Producto ListarDetalle(string nombre)
        {
            return productos.Find(x => x.Nombre == nombre);
        }
    }
}
