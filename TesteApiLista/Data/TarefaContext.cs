using Microsoft.EntityFrameworkCore;
using TesteApiLista.Models;

namespace TesteApiLista.Data;

public class TarefaContext(DbContextOptions<TarefaContext> options) : DbContext(options)
{
    public DbSet<Evento> Eventos { get; set; }
    public DbSet<EventoMembro> Membros { get; set; }
}
