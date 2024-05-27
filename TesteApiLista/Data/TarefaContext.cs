using Microsoft.EntityFrameworkCore;
using TesteApiLista.Models;

namespace TesteApiLista.Data;

public class TarefaContext(DbContextOptions<TarefaContext> options) : DbContext(options)
{
    public DbSet<Agente> Agentes { get; set; }
    public DbSet<Tarefa> Tarefas { get; set; }
    public DbSet<AgenteTarefa> AgenteTarefas { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AgenteTarefa>()
            .HasKey(at => new { at.AgenteId, at.TarefaId });

        modelBuilder.Entity<AgenteTarefa>()
            .HasOne(at => at.Agente)
            .WithMany(a => a.AgenteTarefas)
            .HasForeignKey(at => at.AgenteId);

        modelBuilder.Entity<AgenteTarefa>()
            .HasOne(at => at.Tarefa)
            .WithMany(t => t.AgenteTarefas)
            .HasForeignKey(at => at.TarefaId);
    }
}
