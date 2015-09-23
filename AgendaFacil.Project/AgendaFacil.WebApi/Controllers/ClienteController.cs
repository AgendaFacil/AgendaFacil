using AgendaFacil.Domain.Entities;
using AgendaFacil.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AgendaFacil.WebApi.Controllers
{
    [RoutePrefix("api/cliente")]
    public class ClienteController : ApiController
    {
        protected ClienteServices _clienteService = new ClienteServices();

        // GET api/cliente
        public IEnumerable<Cliente> Get()
        {
            return _clienteService.GetAllClient();
        }

        // GET api/cliente/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/cliente
        public void Post([FromBody]Cliente obj)
        {
            obj.Ativo = true;
            obj.DataNascimento = DateTime.Now;

            _clienteService.CadastrarCliente(obj);
        }

        // PUT api/cliente/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/cliente/5
        public void Delete(int id)
        {
        }
    }
}
