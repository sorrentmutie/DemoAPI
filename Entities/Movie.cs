namespace DemoAPI.Entities;

public class Movie: BaseEntity
{
    public string? Title { get; set; }
    public string? Description { get; set; }
    public bool InTheaters { get; set; }
    public DateTime ReleaseDate { get; set; }
    public HashSet<Comment> Comments { get; set; } = new HashSet<Comment>();
    public HashSet<Genre> Genres { get; set; } = new HashSet<Genre>();
    public HashSet<MovieActor> MoviesActors { get; set; } = new HashSet<MovieActor>();
}
