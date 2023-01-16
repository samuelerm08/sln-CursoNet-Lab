namespace Entidades.Entidades.Persona.Cliente
{
    public class ClienteIndividuo : Persona
    {
        public ClienteIndividuo(string nombre, string email, string telefono, string direccion, string apellido, string cUIT) : base(nombre, email, telefono, direccion, apellido)
        {
            CUIT = cUIT;
        }
        public string CUIT { get; set; }

        public override string ToString()
        {
            return $"Nombre: {Nombre}\n" +
                   $"Apellido: {Apellido}\n" +
                   $"Email: {Email}\n" +
                   $"Telefono: {Telefono}\n" +
                   $"Direccion: {Direccion}\n" +
                   $"CUIT: {CUIT}"; 
        }
    }
}
