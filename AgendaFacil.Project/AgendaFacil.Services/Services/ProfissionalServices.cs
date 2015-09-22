using AgendaFacil.Domain.Entities;
using AgendaFacil.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaFacil.Services.Services
{
    public class ProfissionalServices
    {

        protected RepositoryBase<Profissional> _repositoryBase = new RepositoryBase<Profissional>();

        public void CadastrarProfissional(Profissional obj)
        {
            _repositoryBase.Add(obj);
        }

    }
}
