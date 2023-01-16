using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Entidades.Persona.Vendedor
{
    public class Vendedor : Persona
    {
        public Vendedor(string nombre, string email, string telefono, string direccion, string apellido, string dNI) : base(nombre, email, telefono, direccion, apellido)
        {
            DNI = dNI;
        }
        public string DNI { get; set; }

        public override string ToString()
        {
            return $"Nombre: {Nombre}\n" +
                            $"Apellido: {Apellido}\n" +
                            $"Email: {Email}\n" +
                            $"Numero de telefono: {Telefono}\n" +
                            $"Direccion: {Direccion}\n" +
                            $"DNI: {DNI}"; 
        }
    }
}
