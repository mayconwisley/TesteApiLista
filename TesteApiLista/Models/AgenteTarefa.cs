namespace TesteApiLista.Models;

public class AgenteTarefa
{
    public int AgenteId { get; set; }
    public Agente? Agente { get; set; }
    public int TarefaId { get; set; }
    public Tarefa? Tarefa { get; set; }
}
