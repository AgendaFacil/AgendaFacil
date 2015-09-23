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
	[RoutePrefix("api/profissional")]
    public class ProfissionalController : ApiController
    {
        protected ProfissionalServices _profissionalService = new ProfissionalServices();

        // GET api/profissional
        public IEnumerable<Profissional> Get()
        {
			return _profissionalService.getProfissionais();
        }

        // GET api/profissional/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/profissional
        public void Post([FromBody]Profissional obj)
        {
            obj.Ativo = true;
            obj.DataNascimento = DateTime.Now;
            

			_profissionalService.CadastrarProfissional(obj);
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
