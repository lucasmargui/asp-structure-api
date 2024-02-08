using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ServicoWebApi.Models;

namespace ServicoWebApi.Controllers
{
    public class ClienteController : ApiController
    {
        Cliente[] clientes = new Cliente[]
        {
            new Cliente() { ID = 1, Nome = "Guinther", EMail = "guintherpauli@gmail.com" },
            new Cliente() { ID = 2, Nome = "Rudolfo", EMail = "rudolfo@teste.com" },
            new Cliente() { ID = 3, Nome = "Wesley", EMail = "Wesley@teste.com" }
        };

        public IEnumerable<Cliente> getClientes()
        {
            return clientes;
        }

        public IHttpActionResult getCliente(int id)
        {
            var cli = clientes.FirstOrDefault((c) => c.ID == id);
            return Ok(cli);
        }
    }

    
}
