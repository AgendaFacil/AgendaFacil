using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaFacil.Domain.Entities
{
	public class Profissional
	{
		public int ProfissionalID;
		public String Nome { get; set; }
		public String Telefone { get; set; }
		public String Email { get; set; }
		public String Endereco { get; set; }
		public DateTime DataNascimento { get; set; }
		public bool Ativo { get; set; }
	}
}
