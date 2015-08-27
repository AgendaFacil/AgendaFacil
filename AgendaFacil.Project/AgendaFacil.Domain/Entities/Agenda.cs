using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaFacil.Domain.Entities
{
	public class Agenda
	{

		public int AgendaID { get; set; }
		public DateTime DataAgendamento { get; set; }
		public Cliente FK_ClienteID { get; set; }
		public Tratamento FK_TratamentoID { get; set; }
	}
}
