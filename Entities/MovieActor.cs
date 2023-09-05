namespace DemoAPI.Entities;

public class MovieActor: BaseEntity
{
    public int MovieId { get; set; }
    public int ActorId { get; set; }    
    public string? Character { get; set; }
    public int Order { get; set; }
    public Movie? Movie { get; set; }
    public Actor? Actor { get; set; }
}
