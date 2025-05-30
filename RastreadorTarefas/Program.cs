using RastreadorTarefas.TaskTracker.Domain;

TarefaItem tarefa = new TarefaItem();
TarefaItem tarefa1 = new TarefaItem();

Console.WriteLine($"tarefaid: {tarefa.Id} descricao: {tarefa.Descricao} criada: {tarefa.CriadoEm} status: {tarefa.statusTarefa}");


Console.WriteLine($"tarefaid: {tarefa1.Id} descricao: {tarefa1.Descricao} criada: {tarefa1.CriadoEm} status: {tarefa1.statusTarefa}");