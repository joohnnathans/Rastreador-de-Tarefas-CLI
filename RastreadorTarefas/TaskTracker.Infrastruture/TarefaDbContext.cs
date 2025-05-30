using Microsoft.EntityFrameworkCore;
using RastreadorTarefas.TaskTracker.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RastreadorTarefas.TaskTracker.Infrastruture
{
    public class TarefaDbContext : DbContext
    {
        public DbSet<TarefaItem> Tasks { get; set; }

        public TarefaDbContext(DbContextOptions<TarefaDbContext> options)
            : base(options) { }
    }
}
