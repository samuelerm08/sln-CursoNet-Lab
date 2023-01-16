﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Entidades.Persona.Empresa
{
    public class Empresa
    {
        public Empresa(string nombre, string cUIT, string contacto, string email, string telefono, string direccion)
        {
            Nombre = nombre;
            CUIT = cUIT;
            Contacto = contacto;
            Email = email;
            Telefono = telefono;
            Direccion = direccion;
        }
        public string Nombre { get; set; }
        public string CUIT { get; set; }
        public string Contacto { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }

        public override string ToString()
        {
            return $"Nombre: {Nombre}\n" +
                           $"CUIT: {CUIT}\n" +
                           $"Email: {Email}\n" +
                           $"Numero de telefono: {Telefono}\n" +
                           $"Direccion: {Direccion}\n" +
                           $"Contacto: {Contacto}";
        }
    }
}
