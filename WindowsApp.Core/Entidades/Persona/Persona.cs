﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Entidades.Persona
{
    public abstract class Persona
    {
        public Persona(string nombre, string email, string telefono, string direccion, string apellido)
        {
            Nombre = nombre;
            Email = email;
            Telefono = telefono;
            Direccion = direccion;
            Apellido = apellido;
        }

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
    }
}
