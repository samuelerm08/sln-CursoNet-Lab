using Entidades.Entidades.Persona.Cliente;
using Entidades.Entidades.Persona.Empresa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Listado
{
    public static class AdmClientes
    {
        public static List<ClienteIndividuo> clientesIndividuos = new List<ClienteIndividuo>();
        public static List<Empresa> clientesEmpresas = new List<Empresa>();

        //Metodos Clientes Individuos      
        public static List<ClienteIndividuo> ListarClienteIndividuo()
        {
            return clientesIndividuos;
        }

        //Filtrar por CUIT
        public static ClienteIndividuo ListarClienteIndividuo(string CUIT)
        {               
            return clientesIndividuos.Find(x => x.CUIT == CUIT);
        }

        //Metodos Clientes Empresa
        public static void NuevoClienteEmpresa(ClienteIndividuo c)
        {
            clientesIndividuos.Add(c);
        }

        public static List<Empresa> VerClientesEmpresa()
        {
            return clientesEmpresas;
        }

        //Filtrar por CUIT
        public static Empresa VerClientesEmpresa(string CUIT)
        {
            return clientesEmpresas.Find(x => x.CUIT == CUIT);
        }
    }
}
