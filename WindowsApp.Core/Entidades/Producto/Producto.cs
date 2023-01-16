using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Entidades.Producto
{
    public class Producto
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public string Proveedor { get; set; }
        public string Categoria { get; set; }
        public string Subcategoria { get; set; }
        public decimal PrecioCosto { get; set; }
        public double Margen { get; set; }
        public double IVA = 0.21;

        public Producto(string nombre, string descripcion, decimal precioCosto, double margen, string proveedor, string categoria, string subcategoria)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            PrecioCosto = precioCosto;
            Margen = margen;            
            Proveedor = proveedor;
            Categoria = categoria;
            Subcategoria = subcategoria;
        }

        public decimal PrecioBruto { get => PrecioCosto + Convert.ToDecimal(Margen); }
        public decimal PrecioVenta { get => PrecioBruto * Convert.ToDecimal(1 + this.IVA); }

        public override string ToString()
        {
            return $"Nombre: {Nombre} | " +
                   $"Descripcion: {Descripcion} | " +
                   $"Proveedor: {Proveedor} | " +
                   $"Categoria: {Categoria} | " +
                   $"Subcategoria: {Subcategoria} | " +
                   $"Precio Costo: {PrecioCosto} | " +
                   $"Margen: {Margen} | " +
                   $"IVA: {IVA * 100}% | " +
                   $"Precio Bruto: {PrecioBruto} | " +
                   $"Precio Venta: {PrecioVenta}";
        }
    }
}
