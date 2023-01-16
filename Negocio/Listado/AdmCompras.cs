using Entidades.Entidades.Persona.Vendedor;
using Entidades.Entidades.Producto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Listado
{
    public static class AdmCompras
    {
        public static void Agregar(Producto p, int cantidad)
        {
            AdmProductos.productos.Add(p);
        }
        public static void Modificar(int cantidad) { }        
        public static void Eliminar(string nombre) { }
        public static void Confirmar(Vendedor v) { }
        public static void Cancelar() { }
    }
}
