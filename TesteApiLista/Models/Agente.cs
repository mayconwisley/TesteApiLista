﻿namespace TesteApiLista.Models;

public class Agente
{
    public int Id { get; set; }
    public string? Nome { get; set; }
    public List<AgenteTarefa>? AgenteTarefas { get; set; }
}
