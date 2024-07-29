public class Team
{
    public int Id { get; set; }
    public string? teamName { get; set; }
    public int FkIdLeague { get; set; }   // Não suposto estar aqui!
}