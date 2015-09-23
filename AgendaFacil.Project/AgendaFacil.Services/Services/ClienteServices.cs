using AgendaFacil.Domain.Entities;
using AgendaFacil.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaFacil.Services.Services
{
    public class ClienteServices
    {
        protected RepositoryBase<Cliente> _repositoryBase = new RepositoryBase<Cliente>();

        public void CadastrarCliente(Cliente obj)
        {
            _repositoryBase.Add(obj);
        }

        public IEnumerable<Cliente> GetAllClient()
        {
            return _repositoryBase.GetAll();
        }
    }
}