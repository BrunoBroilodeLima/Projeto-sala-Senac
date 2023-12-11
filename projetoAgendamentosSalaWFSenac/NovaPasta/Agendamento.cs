using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoAgendamentosSalaWFSenac.NovaPasta
{
    internal class Agendamento
    {
        public DateTime Data { get; set; }
        public string Titulo { get; set; }
        public string Detalhes { get; set; }

        public Agendamento(DateTime data, string titulo, string detalhes)
        {
            Data = data;
            Titulo = titulo;
            Detalhes = detalhes;
        }
    }
}
