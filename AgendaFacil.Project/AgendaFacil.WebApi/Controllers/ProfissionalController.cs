using AgendaFacil.Domain.Entities;
using AgendaFacil.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AgendaFacil.WebApi.Controllers
{
	[RoutePrefix("api/profissional")]
    public class ProfissionalController : ApiController
    {
		//ProfissionalService _profissionalService;

        // GET api/profissional
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/profissional/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/profissional
        public void Post([FromBody]Funcionario funcionario)
        {
			//_profissionalService.CadastrarProfissional();
        }

        // PUT api/profissional/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/profissional/5
        public void Delete(int id)
        {
        }
    }
}
