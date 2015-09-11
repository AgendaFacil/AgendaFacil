using AgendaFacil.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AgendaFacil.WebApi.Controllers
{
	[RoutePrefix("api/tratamento")]
    public class TratamentoController : ApiController
    {
        // GET api/tratamento
        public IEnumerable<Tratamento> Get()
        {
			Tratamento obj = new Tratamento{
				Ativo = false,
			   Descricao = "Tratamento Teste"
			};

			Tratamento obj2 = new Tratamento
			{
				Ativo = true,
				Descricao = "Tratamento Teste"
			};
			List<Tratamento> lstTratamento = new List<Tratamento>();
			lstTratamento.Add(obj);
			lstTratamento.Add(obj2);
			return lstTratamento;
        }

        // GET api/tratamento/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/tratamento
		public string Post([FromBody]string value)
        {
			
			return "POST FEITO";
        }

        // PUT api/tratamento/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/tratamento/5
        public void Delete(int id)
        {
        }
    }
}
