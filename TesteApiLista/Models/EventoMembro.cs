namespace TesteApiLista.Models;

public class EventoMembro
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Cellphone { get; set; }
    public string? Description { get; set; }
    public string? Username { get; set; }
    public string? Password { get; set; }
    public bool Manager { get; set; }
    public bool Active { get; set; }
    public int EventoId { get; set; }
    public Evento Evento { get; set; } = new();
}
