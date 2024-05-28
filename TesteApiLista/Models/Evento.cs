namespace TesteApiLista.Models;

public class Evento
{
    public int Id { get; set; }
    public DateTime DataInicio { get; set; }
    public DateTime DataFinal { get; set; }
    public string? Descricao { get; set; }
    public List<EventoMembro> Membros { get; set; } = [];
}
