using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaSalaSenac.Models
{
    public class Reserva
    {
        internal bool ckSeg;
        internal bool ckTer;
        internal bool ckQua;
        internal bool ckQui;
        internal bool ckSex;
        internal bool ckSab;


        public int Id { get; set; }
        public string Sala { get; set; }
        public string Turno { get; set; }
        public DateTime DataInicioAgendamento { get; set; }
        public DateTime DataFinalAgendamento { get; set; }
        public string Responsavel { get; set; }
        public string Finalidade { get; set; }
        public string Conteudo { get; set; }

    }
}
