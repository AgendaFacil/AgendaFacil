using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaFacil.Domain.Entities
{
	public class Tratamento
	{
		public int TratamentoID { get; set; }
		public Funcionario FK_FuncionarioID { get; set; }
		public String Descricao { get; set; }
		public bool Ativo { get; set; }
	}
}
