using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Entidades.DocumentoComercial
{
    public class Remito : DocumentoComercial
    {
        public Remito(string numero, DateTime fecha, string cliente, string direccion, string condicionIVA, string condicionVenta, string detalle, decimal total, DateTime fechaEntrega) : base(numero, fecha, cliente, direccion, condicionIVA, condicionVenta, detalle, total)
        {
            FechaEntrega = fechaEntrega;
        }

        public DateTime FechaEntrega { get; set; }

        public override string ToString()
        {
            return $"Numero: {Numero}\n" +
                   $"Fecha: {Fecha:yyyy-MM-dd}\n" +
                   $"Fecha Entrega: {FechaEntrega:yyyy-MM-dd}\n" +
                   $"Detalle: {Detalle}\n" +
                   $"Direccion: {Direccion}\n" +
                   $"Cliente: {Cliente}\n" +
                   $"Condicion IVA: {CondicionIVA}\n" +
                   $"Condicion Venta: {CondicionVenta}\n" +
                   $"Total: {Total}"; 
        }
    }
}
