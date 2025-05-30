using RastreadorTarefas.TaskTracker.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RastreadorTarefas.TaskTracker.Application
{
    interface ITaskRepository
    {
        Task AddAsync(TarefaItem tarefa);
        Task<IEnumerable<TarefaItem>> GetAllAsync();
        Task UpdateAsync(TarefaItem tarefa);
        Task DeleteAsync(TarefaItem tarefa);
        Task DeleteAll();

    }
}
