using Entidades.Entidades.Producto;
using Entidades.Entidades.Persona.Cliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Entidades.Persona.Empresa;

namespace Negocio.Listado
{
    public static class AdmFacturas
    {
        public static void Generar(List<Producto> productos, ClienteIndividuo cliente) { }
        public static void Generar(List<Producto> productos, Empresa cliente) { }
    }
}
