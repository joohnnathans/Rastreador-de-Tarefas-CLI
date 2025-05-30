using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RastreadorTarefas.TaskTracker.Domain
{
    public class TarefaItem
    {
        public long Id { get; set; }
        public string Descricao { get; set; }
        public Enums.StatusTarefa statusTarefa;
        public DateTime CriadoEm;


        public TarefaItem()
        {
            this.CriadoEm = DateTime.Now;
            this.statusTarefa = Enums.StatusTarefa.Em_andamento;
        }
    }
}
