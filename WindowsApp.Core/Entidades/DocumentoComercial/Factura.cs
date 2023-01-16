using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Entidades.DocumentoComercial
{
    public class Factura : DocumentoComercial
    {
        public Factura(string numero, DateTime fecha, string cliente, string direccion, string condicionIVA, string condicionVenta, string detalle, decimal total, string tipo) : base(numero, fecha, cliente, direccion, condicionIVA, condicionVenta, detalle, total)
        {
            Tipo = tipo;
        }

        public string Tipo { get; set; }

        public override string ToString()
        {
            return $"Numero: {Numero}\n" +
                   $"Fecha: {Fecha:yyyy-MM-dd}\n" +
                   $"Tipo: {Tipo}\n" +
                   $"Detalle: {Detalle}\n" +
                   $"Direccion: {Direccion}\n" +
                   $"Cliente: {Cliente}\n" +
                   $"Condicion IVA: {CondicionIVA}\n" +
                   $"Condicion Venta: {CondicionVenta}\n" +
                   $"Total: {Total}";
        }
    }
}
