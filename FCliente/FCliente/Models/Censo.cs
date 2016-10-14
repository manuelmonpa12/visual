using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCliente.Models
{
    class Censo
    {
        private List<Cliente> CensoCliente;

        public Censo()
        {
           CensoCliente = new List<Cliente>();
        }     

        public void AdicionarCliente(Cliente Cli)
        {
            CensoCliente.Add(Cli);
        }
        public List<Cliente>ListaCenso
        {
            get
            {
                return CensoCliente;
            }
        }
        public void ActualizarCliente(Cliente clieUpdate)
        {
            foreach (Cliente clie in ListaCenso)
            {
                if (clie.Identificacion == clieUpdate.Identificacion)
                {
                    clie.Nombre = clieUpdate.Nombre;
                    clie.Apellido = clieUpdate.Apellido;
                    return;
                }
            }
            {
                
            }
        }
        public void EliminarCliente(int idClie)
        {
            ListaCenso.RemoveAll(x => x.Identificacion == idClie);
        }

         public Cliente ConsultarCliente(int idClie)
        {
            Cliente objCli = new Cliente();
            foreach(Cliente clie in CensoCliente)
            {
                if(clie.Identificacion==idClie)
                {
                    objCli.Nombre = clie.Nombre;
                    objCli.Apellido = clie.Apellido;
                }
            }
            return objCli;
        }
       
    }
}
